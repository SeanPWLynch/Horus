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
            //Step 1: Create an instance of the WCF proxy.
            ComputerDataClient client = new ComputerDataClient();

            Console.WriteLine(client.GetComputer().ComputerName);
            
            client.Close();

            Console.ReadLine();
        }
    }
}
