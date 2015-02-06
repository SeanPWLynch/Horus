using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Diagnostics;

namespace SeanLynch.YearFourProject.ProofOfConcept.WCFPOC
{
    public class AdminService : IComputerData
    {
        AdminComputer AdminComputer = new AdminComputer();
        
        public string GetComputerData()
        {
            Console.WriteLine(AdminComputer.GetComputerData());
            return AdminComputer.GetComputerData();
        }

        public AdminComputer GetComputer()
        {
            return AdminComputer;
        }

        public void StartProcess(string ProcessName)
        {
            Process.Start(ProcessName);
        }

        public int GetAdminCPUUsage()
        {
            AdminComputer.SetCPUUsage();
            return AdminComputer.CPUUsage;
        }
    }
}
