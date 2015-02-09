using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorusShared
{
    public class HorusShared
    {
        public static ApplicationServer.HorusServer hs = new ApplicationServer.HorusServer();

        public static List<string> GetClients()
        {
            return hs.GetConnectedClients();
        }

        public static string GetHostName(string targetHost)
        {
            return hs.GetHostName(targetHost);
        }


    }
}
