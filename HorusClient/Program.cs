using HorusClient.HorusServerClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HorusClient
{

    class Program
    {
        static void Main(string[] args)
        {
            HorusComputer thisComputer = new HorusComputer();
            
            s_ClientHost ClientHost = new s_ClientHost();
            


            Thread t_ClientHost = new Thread(ClientHost.StartServce);
            t_ClientHost.Start();

            try
            {
                ServerClientServiceClient client = new ServerClientServiceClient();

                client.Endpoint.Address = new System.ServiceModel.EndpointAddress("net.tcp://"+Properties.Settings.Default.HorusServerAddress+":13000/ServerClientService/ServerClientService");

                client.Open();
                client.HandShake(Environment.MachineName);

                Console.WriteLine("Connected To Server On: " + Properties.Settings.Default.HorusServerAddress);

                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
