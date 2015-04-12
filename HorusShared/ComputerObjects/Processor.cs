using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HorusShared.ComputerObjects
{
    public class Processor : Hardware
    {
        public int numPhysicalCores = 0;
        public int numLogicalCores = 0;
        public string cpuUsage = "none";
        public int processes = 0;
        public int threads = 0;

        public Processor()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            ManagementObjectCollection searchList = searcher.Get();

            foreach (ManagementObject mo in searchList)
            {
                this.Model = mo["name"].ToString().Trim();
                this.Manufacturer = mo["Manufacturer"].ToString().Trim();
                this.id = mo["ProcessorId"].ToString().Trim();

                //Remember to create an XP version
                this.numPhysicalCores = int.Parse(mo["NumberOfCores"].ToString());
                this.numLogicalCores = int.Parse(mo["NumberOfLogicalProcessors"].ToString());

            }

            searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PerfFormattedData_PerfOS_System");
            
            searchList = searcher.Get();

            try
            {

                foreach (ManagementObject mo in searchList)
                {
                    this.processes = int.Parse(mo["Processes"].ToString().Trim());
                    this.threads = int.Parse(mo["Threads"].ToString().Trim());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " something broke");
            }

            try
            {
                searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PerfFormattedData_Counters_ProcessorInformation WHERE Name = '_Total'");

                searchList = searcher.Get();

                foreach (ManagementObject mo in searchList)
                {
                    this.cpuUsage = ((long)100 - long.Parse(mo["PercentIdleTime"].ToString())).ToString().Trim() + '%';
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }

        public void SetCPUUsage()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PerfFormattedData_Counters_ProcessorInformation WHERE Name = '_Total'");

                ManagementObjectCollection searchList = searcher.Get();

                foreach (ManagementObject mo in searchList)
                {
                    this.cpuUsage = ((long)100 - long.Parse(mo["PercentIdleTime"].ToString())).ToString().Trim() + '%';
                }
            }
            catch (ManagementException e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }
    }
}
