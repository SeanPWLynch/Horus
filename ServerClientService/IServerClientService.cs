﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServerClientService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServerClientService
    {
        [OperationContract]
        string GetHostName();

        [OperationContract]
        void HandShake(string hostName);

        [OperationContract]
        void RecieveComputer(HorusShared.ComputerObjects.Computer System);

        [OperationContract]
        HorusShared.ComputerObjects.Computer GetComputer();
    }
}
