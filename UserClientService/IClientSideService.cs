using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UserClientService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ClientSideService" in both code and config file together.
    [ServiceContract]
    public interface IClientSideService
    {
        
        [OperationContract]
        string GetHostName();

        [OperationContract]
        Computer GetComputer(Computer composite);

        [OperationContract]
        void Ping();
        
    }

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "UserClientService.ContractType".
    [DataContract]
    public class Computer
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

