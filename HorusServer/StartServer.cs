using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HorusServer
{
    class StartServer
    {
        static void Main(string[] args)
        {
            HorusServer Server = new HorusServer();

            Server.StartAdmin();

            Server.StartClient();

            Thread t_CheckForClients = new Thread(Server.CheckForClients);
            t_CheckForClients.Start();

            Console.WriteLine("Server Live");



            Console.ReadLine();

        }
    }
}
