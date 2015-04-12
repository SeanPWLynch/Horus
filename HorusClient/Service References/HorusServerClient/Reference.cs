﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HorusClient.HorusServerClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HorusServerClient.IServerClientService")]
    public interface IServerClientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerClientService/GetHostName", ReplyAction="http://tempuri.org/IServerClientService/GetHostNameResponse")]
        string GetHostName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerClientService/GetHostName", ReplyAction="http://tempuri.org/IServerClientService/GetHostNameResponse")]
        System.Threading.Tasks.Task<string> GetHostNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerClientService/HandShake", ReplyAction="http://tempuri.org/IServerClientService/HandShakeResponse")]
        void HandShake(string hostName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerClientService/HandShake", ReplyAction="http://tempuri.org/IServerClientService/HandShakeResponse")]
        System.Threading.Tasks.Task HandShakeAsync(string hostName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerClientService/RecieveComputer", ReplyAction="http://tempuri.org/IServerClientService/RecieveComputerResponse")]
        void RecieveComputer(HorusShared.ComputerObjects.Computer System);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerClientService/RecieveComputer", ReplyAction="http://tempuri.org/IServerClientService/RecieveComputerResponse")]
        System.Threading.Tasks.Task RecieveComputerAsync(HorusShared.ComputerObjects.Computer System);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerClientService/GetComputer", ReplyAction="http://tempuri.org/IServerClientService/GetComputerResponse")]
        HorusShared.ComputerObjects.Computer GetComputer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerClientService/GetComputer", ReplyAction="http://tempuri.org/IServerClientService/GetComputerResponse")]
        System.Threading.Tasks.Task<HorusShared.ComputerObjects.Computer> GetComputerAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServerClientServiceChannel : HorusClient.HorusServerClient.IServerClientService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServerClientServiceClient : System.ServiceModel.ClientBase<HorusClient.HorusServerClient.IServerClientService>, HorusClient.HorusServerClient.IServerClientService {
        
        public ServerClientServiceClient() {
        }
        
        public ServerClientServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServerClientServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerClientServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerClientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetHostName() {
            return base.Channel.GetHostName();
        }
        
        public System.Threading.Tasks.Task<string> GetHostNameAsync() {
            return base.Channel.GetHostNameAsync();
        }
        
        public void HandShake(string hostName) {
            base.Channel.HandShake(hostName);
        }
        
        public System.Threading.Tasks.Task HandShakeAsync(string hostName) {
            return base.Channel.HandShakeAsync(hostName);
        }
        
        public void RecieveComputer(HorusShared.ComputerObjects.Computer System) {
            base.Channel.RecieveComputer(System);
        }
        
        public System.Threading.Tasks.Task RecieveComputerAsync(HorusShared.ComputerObjects.Computer System) {
            return base.Channel.RecieveComputerAsync(System);
        }
        
        public HorusShared.ComputerObjects.Computer GetComputer() {
            return base.Channel.GetComputer();
        }
        
        public System.Threading.Tasks.Task<HorusShared.ComputerObjects.Computer> GetComputerAsync() {
            return base.Channel.GetComputerAsync();
        }
    }
}
