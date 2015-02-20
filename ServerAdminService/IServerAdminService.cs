using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HorusShared;

namespace ServerAdminService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServerAdminService
    {
        [OperationContract]
        List<string> GetClients();

        [OperationContract]
        void StartRemoteProcess(string ProcessName, string targetMachine);

        [OperationContract]
        string GetHostName(string targetMachine);

        [OperationContract] 
        HorusShared.ComputerObjects.Computer GetComputer(string targetMachine);
        
        
    }
}
