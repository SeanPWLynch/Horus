using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.AdminAdmin;

namespace TestApplication
{
    class TestingApplication
    {
        static void Main(string[] args)
        {
            try
            {
                //Test connection To Server Admin Service, expected return is server name
                ServerAdminServiceAdmin Admin = new ServerAdminServiceAdmin();
                

                Console.WriteLine(Admin.GetHostName());

                Admin.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
        }
    }
