using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HorusShared.ComputerObjects
{
    public class DisplayAdapters : Hardware
    {
        public DisplayAdapters[] myDevices;
        public int deviceNum = 0;
        public long deviceMem = 0;


        public DisplayAdapters()
        {
            int counter = 0;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");

            ManagementObjectCollection searchList = searcher.Get();

            this.myDevices = new DisplayAdapters[searcher.Get().Count];

            try
            {

                foreach (ManagementObject mo in searchList)
                {
                    myDevices[counter] = new DisplayAdapters(counter);
                    try
                    {
                        myDevices[counter].Manufacturer = mo["AdapterCompatibility"].ToString().Trim();
                    }
                    catch (Exception e)
                    {
                        myDevices[counter].Manufacturer = "Unknown";
                    }
                    try
                    {
                        myDevices[counter].Model = mo["name"].ToString().Trim();
                    }
                    catch (Exception e)
                    {
                        myDevices[counter].Model = "Unknown";
                    }
                    try
                    {
                        myDevices[counter].id = mo["deviceid"].ToString().Trim();
                    }
                    catch
                    {
                        myDevices[counter].id = "Unknown";
                    }
                    try
                    {
                        myDevices[counter].deviceMem = long.Parse(mo["adapterram"].ToString().Trim()) / 1048576;
                    }
                    catch
                    {
                        myDevices[counter].deviceMem = 0;
                    }
                    
                    counter++;

                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DisplayAdapters(int deviceNum)
        {
            this.deviceNum = deviceNum++;
        }
    }
}
