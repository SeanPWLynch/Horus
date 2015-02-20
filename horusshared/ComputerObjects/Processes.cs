using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics; 


namespace HorusShared.ComputerObjects
{
    

    public class Processes
    {
        private Process[] RunningProcesses;

        public Processes()
        {
            RunningProcesses = System.Diagnostics.Process.GetProcesses();
        }

        private void UpdateProcesses()
        {
            RunningProcesses = System.Diagnostics.Process.GetProcesses();
        }

        private void StartProcess(string ProcessName)
        {
            System.Diagnostics.Process.Start(ProcessName);
        }

        private void EndProcess(string ProcessName)
        {
            Process[] ToKill = Process.GetProcessesByName(ProcessName);
                foreach (Process proc in ToKill)
                {
                    proc.Kill();
                    proc.WaitForExit();
                }
        }
    }

}
