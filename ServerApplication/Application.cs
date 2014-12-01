using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerApplication.ClientService;

namespace SeanLynch.YearFourProject.ProofOfConcept.WCFPOC
{
    class Application
    {
        static void Main(string[] args)
        {
            try
            {
                ComputerDataClient client = new ComputerDataClient();

                Console.WriteLine(client.GetComputer().ComputerName);

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
