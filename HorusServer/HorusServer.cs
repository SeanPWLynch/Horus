using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;



namespace HorusServer
{
    public class HorusServer
    {
        List<ConnectedClient> connectedClients = new List<ConnectedClient>();
        public HorusServer()
        {
            
        }

        public void ClientHandShake(string clientName)
        {
            ConnectedClient newClient = new ConnectedClient(clientName);
            connectedClients.Add(newClient);
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



            }
            catch (Exception ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                ClientHost.Abort();
            }

            

           
        }

        private void ClientConnecting(object sender, EventArgs e)
        {
            Console.WriteLine("something");
            Console.WriteLine(e.ToString());
        }
    }
}
