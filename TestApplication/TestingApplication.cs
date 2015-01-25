using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.AdminClient;

namespace TestApplication
{
    class TestingApplication
    {
        static void Main(string[] args)
        {
            try
            {
                //Test connection To Server Admin Service, expected return is server name
                ServerAdminServiceClient client = new ServerAdminServiceClient();

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
