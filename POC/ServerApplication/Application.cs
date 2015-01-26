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
                ComputerDataClient Client = new ComputerDataClient();

                Console.WriteLine(Client.GetComputer().ComputerName);

                Console.WriteLine("Type Name of Process To Start");

                Client.StartProcess("calc.exe");

                Console.WriteLine("Running Processes \n");

                foreach(string Process in Client.GetComputer().RunningProcesses)
                {
                    Console.WriteLine(Process + Environment.NewLine);
                }

                Console.WriteLine(Client.GetClientCPUUsage());


                Client.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
