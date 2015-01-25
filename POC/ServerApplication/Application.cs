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

                Console.WriteLine("Type Name of Process To Start");

                client.StartProcess("calc.exe");

                Console.WriteLine("Running Processes \n");

                foreach(string Process in client.GetComputer().RunningProcesses)
                {
                    Console.WriteLine(Process + Environment.NewLine);
                }

                Console.WriteLine(client.GetClientCPUUsage());


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
