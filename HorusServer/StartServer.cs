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
            try
            {
            Console.WriteLine("Server Starting...");
            //Create Server
            HorusServer Server = new HorusServer();


            //Start The Server Service
new Thread(() => 
{
    Thread.CurrentThread.IsBackground = true;
    Server.StartAdmin();
}).Start();
            

            //Start The Client Service
new Thread(() =>
{
    Thread.CurrentThread.IsBackground = true;
    Server.StartClient();
}).Start();
            
            

            //Start Looking For Clients
new Thread(() =>
{
    Thread.CurrentThread.IsBackground = true;
    Server.CheckForClients();
}).Start();

            Console.WriteLine("Server Live");

            Console.ReadLine();
        }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
