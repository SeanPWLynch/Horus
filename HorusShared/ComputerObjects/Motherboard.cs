using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HorusShared.ComputerObjects
{
    public class Motherboard : Hardware
    {
        public string SystemModel = "unknown";

        public Motherboard()
        {
            try
            {

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");

                ManagementObjectCollection searchList = searcher.Get();

                foreach (ManagementObject mo in searchList)
                {
                    this.Manufacturer = mo["manufacturer"].ToString().Trim();
                    this.Model = mo["product"].ToString().Trim();
                    this.id = mo["SerialNumber"].ToString().Trim().Replace(",", null).Trim();
                }

                searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_ComputerSystem");

                searchList = searcher.Get();

                foreach (ManagementObject mo in searchList)
                {
                    this.SystemModel = mo["model"].ToString().Trim();
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
