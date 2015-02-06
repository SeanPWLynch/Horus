﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestApplication.UserClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Computer", Namespace="http://schemas.datacontract.org/2004/07/ServerClientService")]
    [System.SerializableAttribute()]
    public partial class Computer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserClient.IServerClientService")]
    public interface IServerClientService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerClientService/GetHostName", ReplyAction="http://tempuri.org/IServerClientService/GetHostNameResponse")]
        string GetHostName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerClientService/GetHostName", ReplyAction="http://tempuri.org/IServerClientService/GetHostNameResponse")]
        System.Threading.Tasks.Task<string> GetHostNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerClientService/GetComputer", ReplyAction="http://tempuri.org/IServerClientService/GetComputerResponse")]
        TestApplication.UserClient.Computer GetComputer(TestApplication.UserClient.Computer composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServerClientService/GetComputer", ReplyAction="http://tempuri.org/IServerClientService/GetComputerResponse")]
        System.Threading.Tasks.Task<TestApplication.UserClient.Computer> GetComputerAsync(TestApplication.UserClient.Computer composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServerClientServiceChannel : TestApplication.UserClient.IServerClientService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServerClientServiceClient : System.ServiceModel.ClientBase<TestApplication.UserClient.IServerClientService>, TestApplication.UserClient.IServerClientService {
        
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
        
        public TestApplication.UserClient.Computer GetComputer(TestApplication.UserClient.Computer composite) {
            return base.Channel.GetComputer(composite);
        }
        
        public System.Threading.Tasks.Task<TestApplication.UserClient.Computer> GetComputerAsync(TestApplication.UserClient.Computer composite) {
            return base.Channel.GetComputerAsync(composite);
        }
    }
}