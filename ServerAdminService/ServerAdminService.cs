using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
//using HorusShared;

namespace ServerAdminService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServerAdminService : IServerAdminService
    {
        public List<string> GetClients()
        {
            throw new NotImplementedException();
            //return HorusShared.HorusShared.GetClients();
        }

        public string GetHostName(string targetMachine)
        {
            throw new NotImplementedException();
            //return HorusShared.HorusShared.GetHostName(targetMachine);
        }
        
    }
}
