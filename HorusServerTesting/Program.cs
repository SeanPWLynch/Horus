using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorusServerTesting.ClientServerSide;
using HorusServerTesting.AdminServerSide;
using System.Threading;

namespace HorusServerTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            s_ClientHost ClientHost = new s_ClientHost();

            Thread t_ClientHost = new Thread(ClientHost.StartServce);
            t_ClientHost.Start();

            try
            {
                ServerClientServiceClient client = new ServerClientServiceClient();
                ServerAdminServiceClient a_client = new ServerAdminServiceClient();

                client.Endpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://localhost:13000/ServerClientService/ServerClientService");
                a_client.Endpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://localhost:12000/ServerAdminService/ServerAdminService");
                

                client.Open();
                client.HandShake(Environment.MachineName);

                a_client.Open();

                Console.WriteLine(a_client.GetClients().Count());
                

                Console.ReadLine();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
