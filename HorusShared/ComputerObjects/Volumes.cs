using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HorusShared.ComputerObjects
{
    public class Volumes : Hardware
    {
        public Volumes[] drives;
        public string driveLetter = "none";
        public string osDrive = "none";
        public string fileSystem = "none";
        public long driveCap = 0;
        public long freeSpace = 0;
        public string volUsage = "none";
        public string volRead = "0";
        public string volWrite = "0";
        public static long totalFreeSpace = 0;

        public Volumes()
        {
            int counter = 0;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Volume");

            ManagementObjectCollection searchList = searcher.Get();

            this.drives = new Volumes[searcher.Get().Count];

            foreach (ManagementObject mo in searchList)
            {
                try
                {
                    try
                    {
                        this.drives[counter] = new Volumes(mo["driveletter"].ToString().Trim() + @"\");
                    }
                    catch (System.Exception ex)
                    {
                        this.drives[counter] = new Volumes("Not Applicable");
                    }

                    try
                    {
                        this.drives[counter].osDrive = mo["bootvolume"].ToString().Trim();
                    }
                    catch (System.Exception ex)
                    {
                        this.drives[counter].osDrive = "Not Applicable";
                    }

                    try
                    {
                        this.drives[counter].fileSystem = mo["filesystem"].ToString().Trim();
                    }
                    catch (System.Exception ex)
                    {
                        this.drives[counter].fileSystem = "Not Applicable";
                    }

                    try
                    {
                        this.drives[counter].driveCap = long.Parse(mo["capacity"].ToString().Trim()) / 1073741824;
                    }
                    catch (System.Exception ex)
                    {
                        this.drives[counter].driveCap = 0;
                    }

                    try
                    {
                        this.drives[counter].freeSpace = long.Parse(mo["freespace"].ToString().Trim()) / 1073741824;
                        totalFreeSpace += this.drives[counter].freeSpace;
                    }
                    catch (System.Exception ex)
                    {
                        this.drives[counter].freeSpace = 0;
                    }

                    try
                    {
                        this.drives[counter].id = mo["DeviceID"].ToString().Trim().Replace(@"\", "").Replace("?", "").Replace("Volume", "").Replace("{", "").Replace("}", "").Replace("-", "").Trim();
                    }
                    catch (System.Exception ex)
                    {
                        this.drives[counter].id = "Not Applicable";
                    }

                    try
                    {
                        this.drives[counter].Manufacturer = "Not Applicable";
                    }
                    catch (System.Exception ex)
                    {
                        this.drives[counter].Manufacturer = "Not Applicable";
                    }

                    try
                    {
                        this.drives[counter].Model = "Not Applicable";
                    }
                    catch (System.Exception ex)
                    {
                        this.drives[counter].Model = "Not Applicable";
                    }
                    counter++;
                }
                catch (System.Exception ex)
                {

                }

            }
            try
            {
                //Temp code, need to modify query to get for each disk
                foreach (Volumes vol in this.drives)
                {
                    searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PerfFormattedData_PerfDisk_LogicalDisk");
                    searchList = searcher.Get();

                    foreach (ManagementObject mo1 in searchList)
                    {
                        vol.volRead = long.Parse(mo1["DiskReadBytesPersec"].ToString().Trim()) / 1024 + "KB/s";
                        vol.volWrite = long.Parse(mo1["DiskWriteBytesPersec"].ToString().Trim()) / 1024 + "KB/s";
                    }
                }
            }
            catch (Exception e)
            {

            }



        }

        public Volumes(string driveLetter)
        {
            this.driveLetter = driveLetter;
        }

    }
}
