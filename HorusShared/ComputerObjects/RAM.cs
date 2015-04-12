using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HorusShared.ComputerObjects
{
    public class RAM : Hardware
    {

        public long totalRAM = 0;
        public RAM[] installedRAM;
        public int numModules = 0;
        public int moduleNumber = 0;
        public string speed = "none";
        public long moduleSize = 0;
        public long freeRAM = 0;

        public RAM()
        {
            int counter = 0;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");

            ManagementObjectCollection searchList = searcher.Get();


            this.numModules = searcher.Get().Count;
            this.installedRAM = new RAM[numModules];

            foreach (ManagementObject mo in searchList)
            {
                installedRAM[counter] = new RAM(counter);
                try
                {
                    installedRAM[counter].Manufacturer = mo["manufacturer"].ToString().Trim();
                }
                catch (Exception e)
                {
                    installedRAM[counter].Manufacturer = "unknown";
                }

                try
                {
                    installedRAM[counter].Model = mo["partnumber"].ToString().Trim();
                }
                catch (Exception e)
                {
                    installedRAM[counter].Model = "Unknown";
                }

                try
                {
                    installedRAM[counter].id = mo["serialnumber"].ToString().Trim();
                }
                catch (Exception e)
                {
                    installedRAM[counter].id = "Unknown";
                }

                try
                {
                    installedRAM[counter].speed = mo["speed"].ToString().Trim() + "MHz";
                }
                catch (Exception e)
                {
                    installedRAM[counter].speed = "none";
                }

                try
                {
                    installedRAM[counter].moduleSize = long.Parse(mo["capacity"].ToString().Trim()) / 1048576;
                }
                catch (Exception e)
                {
                    installedRAM[counter].moduleSize = 0;
                }
                counter++;
            }

            
            try
            {
                searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");

                searchList = searcher.Get();

                foreach (ManagementObject mo in searchList)
                {
                    this.freeRAM = long.Parse(mo["FreePhysicalMemory"].ToString().Trim()) / 1024;
                }
            }
            catch(Exception e)
            {
                this.freeRAM = 0;
            }

            try
            {
                for (int i = 0; i < this.installedRAM.Count(); i++)
                {
                    this.totalRAM += this.installedRAM[i].moduleSize;
                }
            }
            catch (Exception e)
            {

            }
        }

        public RAM(int moduleNumber)
        {
            this.moduleNumber = moduleNumber;
        }

    }
}
