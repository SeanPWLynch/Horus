using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace HorusShared.ComputerObjects
{
    public class NIC : Hardware
    {
        public long KBytesIn = 0; //Current MBytes Per Second In
        public long KBytesOut = 0; //Current MBytes Per Second Out
        public long KBytesTotal = 0; //Current MBytes Per Second Total
        public NIC[] NICS;


        public NIC()
        {

            int counter = 0;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PerfFormattedData_Tcpip_NetworkInterface");

            this.NICS = new NIC[searcher.Get().Count];

            ManagementObjectCollection searchList = searcher.Get();

            foreach (ManagementObject mo in searchList)
            {
                this.NICS[counter] = new NIC(mo["Name"].ToString().Trim());
                try
                {
                    this.NICS[counter].Manufacturer = mo["Name"].ToString().Split(' ')[0];
                }
                catch (Exception ex)
                {
                    this.NICS[counter].Manufacturer = mo["Name"].ToString().Trim();
                }
                try
                {
                    this.NICS[counter].id = mo["Name"].ToString().Split(' ')[1];
                }
                catch (Exception ex)
                {
                    this.NICS[counter].id = mo["Name"].ToString().Trim();
                }
                this.NICS[counter].KBytesIn = long.Parse(mo["BytesReceivedPersec"].ToString().Trim()) / 1024;
                this.NICS[counter].KBytesOut = long.Parse(mo["BytesSentPersec"].ToString().Trim()) / 1024;
                this.NICS[counter].KBytesTotal = long.Parse(mo["BytesTotalPersec"].ToString().Trim()) / 1024;
                counter++;
            }
            //this.SetBandwidth();
        }

        public NIC(string name)
        {
            this.Model = name;
        }
    }
}
