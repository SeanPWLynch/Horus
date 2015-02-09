using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorusAdmin.Horus;

namespace HorusAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Starting Testing");

                Console.WriteLine("Available Clients");

                ServerAdminServiceClient AdminClient = new ServerAdminServiceClient();

                AdminClient.Open();

                string[] onlineClients = AdminClient.GetClients();

                Console.WriteLine(onlineClients[0]);

                Console.WriteLine(AdminClient.GetHostName(onlineClients[0]));

                Console.WriteLine(AdminClient.GetComputer(onlineClients[0]).CPUName);
                

                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
