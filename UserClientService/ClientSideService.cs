﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UserClientService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ClientSideService : IClientSideService
    {

        public void StartProcess(string ProcessName)
        {
            HorusShared.ComputerObjects.Computer ThisComputer = new HorusShared.ComputerObjects.Computer();
            ThisComputer.RunningProcesses.StartProcess(ProcessName);
        }

        public void EndProcess(string ProcessName)
        {
            HorusShared.ComputerObjects.Computer ThisComputer = new HorusShared.ComputerObjects.Computer();
            ThisComputer.RunningProcesses.EndProcess(ProcessName);
        }

        public void StartService(string ServiceName)
        {
            HorusShared.ComputerObjects.Computer ThisComputer = new HorusShared.ComputerObjects.Computer();
            ThisComputer.RunningServices.StartService(ServiceName);
        }

        public void EndService(string ServiceName)
        {
            HorusShared.ComputerObjects.Computer ThisComputer = new HorusShared.ComputerObjects.Computer();
            ThisComputer.RunningServices.StopService(ServiceName);
        }

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
