using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Threading;
using HorusServer.RemoteUserService;

namespace ApplicationServer
{
    public class HorusServer
    {
        static List<string> connectedClients = new List<string>();
        ServiceHost AdminHost;
        ServiceHost ClientHost;


        public HorusServer()
        {
            
        }

        public List<string> GetConnectedClients()
        {
            return connectedClients;
        }

        public void StartAdmin()
        {
            Uri AdminAddress = new Uri("net.tcp://localhost:12000/ServerAdminService/");
            ServiceHost AdminHost = new ServiceHost(typeof(ApplicationServer.ServerAdminService), AdminAddress);
            try
            {
                AdminHost.AddServiceEndpoint(typeof(ApplicationServer.IServerAdminService), new NetTcpBinding(SecurityMode.None), "ServerAdminService");
                ServiceMetadataBehavior AdminMetaBehaviour = new ServiceMetadataBehavior();
                AdminHost.Description.Behaviors.Add(AdminMetaBehaviour);
                AdminHost.Open();
                this.AdminHost = AdminHost;
                Console.WriteLine("Admin: " + AdminHost.BaseAddresses[0]);
            }
            catch (Exception ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                AdminHost.Abort();
            }
        }


        public void StartClient()
        {
            Uri ClientAddress = new Uri("net.tcp://localhost:13000/ServerClientService/");
            ServiceHost ClientHost = new ServiceHost(typeof(ServerClientService.ServerClientService), ClientAddress);
            
            try
            {
                ClientHost.AddServiceEndpoint(typeof(ServerClientService.IServerClientService), new NetTcpBinding(SecurityMode.None), "ServerClientService");
                ServiceMetadataBehavior ClientMetaBehaviour = new ServiceMetadataBehavior();
                ClientHost.Description.Behaviors.Add(ClientMetaBehaviour);
                ClientHost.Open();
                Console.WriteLine("Client: " + ClientHost.BaseAddresses[0]);
                this.ClientHost = ClientHost;


            }
            catch (Exception ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                ClientHost.Abort();
            }

        }


        public void CheckForClients()
        {
            //Delay method start to ensure all services are ready
            Thread.Sleep(10000);

            //While The Client Is Running
            while(this.ClientHost.State.ToString()=="Opened")
            {
                //Check Mongo For Client Names
                var connectionString = "mongodb://localhost";
                var client = new MongoClient(connectionString);
                var server = client.GetServer();
                var database = server.GetDatabase("horus");
                var collection = database.GetCollection<ServerClientService.ServerClientService.Client>("Clients");
                var res = collection.FindAll();
                foreach(var clientName in res)
                {
                    //Check if client exists in currently recognised online clients
                    if(connectedClients.Contains(clientName.name))
                    {
                        Console.WriteLine("Client: " + clientName.name + " Found In Connected Clients, Checking If Still Online");
                        ClientSideServiceClient checkClient = new ClientSideServiceClient();
                        checkClient.Endpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://" + clientName.name + ":15000/UserClientService/UserClientService");
                        try
                        {
                            if (checkClient.Ping() == true)
                            {
                                Console.WriteLine("Client: " + clientName.name + " Still Online");
                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Client: " + clientName.name + " Changed to offline");
                            for(int i = 0; i < connectedClients.Count; i++)
                            {
                                if(connectedClients[i] == clientName.name)
                                {
                                    connectedClients.RemoveAt(i);
                                    Console.WriteLine("Client: " + clientName.name + " Removed From Connected Clients");
                                }
                            }
                        }
                    }
                    else
                    {
                        //Check if client is online
                        ClientSideServiceClient checkClient = new ClientSideServiceClient();
                        checkClient.Endpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://" + clientName.name + ":15000/UserClientService/UserClientService");
                        try
                        {
                            if (checkClient.Ping() == true)
                            {
                                Console.WriteLine("Client: " + clientName.name + " Online");
                                Console.WriteLine("Adding To Connected Clients");
                                connectedClients.Add(clientName.name);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Client: " + clientName.name + " Offline");
                        } 
                    }
                    
                }
                Thread.Sleep(10000);
            }

        }

    }
}
