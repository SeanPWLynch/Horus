using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UserClientService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ClientSideService : IClientSideService
    {
        public string GetHostName()
        {
            return Environment.MachineName;
        }

        public HorusShared.ComputerObjects.Computer GetComputer()
        {
            HorusShared.ComputerObjects.Computer ThisComputer = new HorusShared.ComputerObjects.Computer();
            return ThisComputer;
        }

        public bool Ping()
        {
            return true;
        }
    }
}
