using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SeanLynch.YearFourProject.ProofOfConcept.WCFPOC
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IComputerData
    {
        [OperationContract]
        string GetComputerData();

        [OperationContract]
        ClientComputer GetComputer();
    }

    public class ClientComputer
    {
        public string ComputerName;

        public ClientComputer()
        {
            this.ComputerName = Dns.GetHostName();
        }

        public string GetComputerData()
        {
            return this.ComputerName;
        }
    }
}
