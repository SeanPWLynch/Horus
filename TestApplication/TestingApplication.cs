using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.AdminClient;
using TestApplication.UserClient;

namespace TestApplication
{
    class TestingApplication
    {
        static void Main(string[] args)
        {
            try
            {
                //Test connection To Server Admin Service, expected return is server name
                ServerAdminServiceClient admin = new ServerAdminServiceClient();

                //Test connection To Client Service, expected return is server name
                ServerClientServiceClient client = new ServerClientServiceClient();
               
                

                Console.WriteLine(admin.GetHostName());

                Console.WriteLine(client.GetHostName());

                client.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
        }
    }
