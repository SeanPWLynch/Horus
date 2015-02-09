using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace HorusShared.ComputerObjects
{
    public class Computer
    {
        public string HostName;
        public string UserName;
        public string CPUName;
        public string CPUMan;
        public int CPUNumPhysicalCores;
        public int CPUNumLogicalCores;
        public string CPUID;
        public TimeSpan SystemUpTime;

        public Computer()
        {
            GetHostName();
            GetuserName();
            GetCPUInformation();
        }

        public void GetHostName()
        {
            this.HostName = Environment.MachineName;
        }

        public void GetuserName()
        {
            this.UserName = Environment.UserName;
        }

        public void GetCPUInformation()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");

            ManagementObjectCollection searchList = searcher.Get();

            foreach (ManagementObject mo in searchList)
            {
                this.CPUName = mo["name"].ToString().Trim();
                this.CPUMan = mo["Manufacturer"].ToString().Trim();
                this.CPUID = mo["ProcessorId"].ToString().Trim();

                this.CPUNumPhysicalCores = int.Parse(mo["NumberOfCores"].ToString());
                this.CPUNumLogicalCores = int.Parse(mo["NumberOfLogicalProcessors"].ToString());

            }

            searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PerfFormattedData_PerfOS_System");

            searchList = searcher.Get();

            try
            {
                ManagementObject mo = new ManagementObject(@"\\.\root\cimv2:Win32_OperatingSystem=@");
                DateTime lastBootUp = ManagementDateTimeConverter.ToDateTime(mo["LastBootUpTime"].ToString());
                this.SystemUpTime = (DateTime.Now.ToUniversalTime() - lastBootUp.ToUniversalTime());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " something broke");
            }

        }
        
    }
}
