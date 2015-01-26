using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerApplication.AdminService;

namespace SeanLynch.YearFourProject.ProofOfConcept.WCFPOC
{
    class Application
    {
        static void Main(string[] args)
        {
            try
            {
                ComputerDataAdmin Admin = new ComputerDataAdmin();

                Console.WriteLine(Admin.GetComputer().ComputerName);

                Console.WriteLine("Type Name of Process To Start");

                Admin.StartProcess("calc.exe");

                Console.WriteLine("Running Processes \n");

                foreach(string Process in Admin.GetComputer().RunningProcesses)
                {
                    Console.WriteLine(Process + Environment.NewLine);
                }

                Console.WriteLine(Admin.GetAdminCPUUsage());


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
