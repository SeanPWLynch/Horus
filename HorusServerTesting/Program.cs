using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorusServerTesting.ClientServerSide;

namespace HorusServerTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ServerClientServiceClient client = new ServerClientServiceClient();

                //client.Endpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://localhost:13000/ServerClientService/ServerClientService");

                client.Open();

                client.HandShake(Environment.MachineName);

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
