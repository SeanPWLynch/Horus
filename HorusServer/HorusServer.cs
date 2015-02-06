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
        List<ConnectedClient> connectedClients = new List<ConnectedClient>();
        ServiceHost AdminHost;
        ServiceHost ClientHost;

        public HorusServer()
        {
            
        }

        public void StartAdmin()
        {
            Uri AdminAddress = new Uri("net.tcp://localhost:12000/ServerAdminService/");
            ServiceHost AdminHost = new ServiceHost(typeof(ServerAdminService.ServerAdminService), AdminAddress);
            try
            {
                AdminHost.AddServiceEndpoint(typeof(ServerAdminService.IServerAdminService), new NetTcpBinding(SecurityMode.None), "ServerAdminService");
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
                    if(connectedClients.Contains(new ConnectedClient(clientName.name)))
                    {
                        ClientSideServiceClient checkClient = new ClientSideServiceClient();
                        checkClient.Endpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://"+clientName.name+":15000/ServerClientService/ServerClientService");
                        try
                        {
                            checkClient.Ping();
                        }
                        catch(Exception e)
                        {
                            for(int i = 0; i < connectedClients.Count; i++)
                            {
                                if(connectedClients[i].GetClientName()==clientName.name)
                                {
                                    connectedClients.RemoveAt(i);
                                }
                            }
                        }
                    }
                    else
                    {
                        //Check if client is online
                        //ToDo(write method to check this)
                        connectedClients.Add(new ConnectedClient(clientName.name));
                        Console.WriteLine("Client: " + clientName.name + " Added To Connected Client List");
                    }
                    
                }

                



                Thread.Sleep(10000);
            }

            Console.WriteLine("Client Service Must Be Closed?");
        }

    }
}
