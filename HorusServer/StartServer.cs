using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApplicationServer
{
    class StartServer
    {
        static void Main(string[] args)
        {
            //Create Server
            HorusServer Server = new HorusServer();


            //Start The Server Service
            Server.StartAdmin();

            //Start The Client Service
            Server.StartClient();

            //Start Looking For Clients
            Thread t_CheckForClients = new Thread(Server.CheckForClients);
            t_CheckForClients.Start();

            Console.WriteLine("Server Live");



            Console.ReadLine();

        }
    }
}
