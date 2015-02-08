﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ApplicationServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ServerAdminService : IServerAdminService
    {
        public string GetHostName()
        {
            return Environment.MachineName;
        }

        public List<string> GetClients()
        {
            HorusServer hs = new HorusServer();
            return hs.GetConnectedClients();
        }

        public Computer GetComputer(Computer computer)
        {
            if (computer == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (computer.BoolValue)
            {
                computer.StringValue += "Suffix";
            }
            return computer;
        }
    }
}