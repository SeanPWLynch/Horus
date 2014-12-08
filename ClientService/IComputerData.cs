using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Diagnostics;

namespace SeanLynch.YearFourProject.ProofOfConcept.WCFPOC
{
    
    [ServiceContract]
    public interface IComputerData
    {
        [OperationContract]
        string GetComputerData();

        [OperationContract]
        ClientComputer GetComputer();

        [OperationContract]
        void StartProcess(string ProcessName);

        [OperationContract]
        void SetCPUUsage(ClientComputer clientComputer);


    }

    public class ClientComputer
    {
        public string ComputerName;
        public string[] RunningProcesses;
        public float CPUUsage;

        public ClientComputer()
        {
            this.ComputerName = Dns.GetHostName();
            this.RunningProcesses = new string[Process.GetProcesses().Length];
            int i = 0;
            foreach(var process in Process.GetProcesses())
            {
                RunningProcesses[i] = process.ProcessName.ToString();
                i++;
            }

            
        }

        public string GetComputerData()
        {
            return this.ComputerName;
        }

        public void SetCPUUsage()
        {
            var cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            cpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000); // wait a second to get a valid reading
            var cpuusage = cpuCounter.NextValue();
            this.CPUUsage = cpuusage;

        }
    }
}
