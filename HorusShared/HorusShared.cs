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

        public static ComputerObjects.Computer GetComputer(string targetHost)
        {

            return hs.GetComputer(targetHost);
        }

        public static void StartRemoteProcess(string ProcessName, string TargetHost)
        {
            hs.StartRemoteProcess(TargetHost, ProcessName);
        }

        public static void EndRemoteProcess(string ProcessName, string TargetHost)
        {
            hs.EndRemoteProcess(TargetHost, ProcessName);
        }

        public static void StartRemoteService(string ServiceName, string TargetHost)
        {
            hs.StartRemoteProcess(TargetHost, ServiceName);
        }

        public static void EndRemoteService(string ServiceName, string TargetHost)
        {
            hs.EndRemoteProcess(TargetHost, ServiceName);
        }
        
    }
}
