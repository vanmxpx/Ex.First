﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MainClient.Service {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Service.IMainService")]
    public interface IMainService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/Summ", ReplyAction="http://tempuri.org/IMainService/SummResponse")]
        int Summ(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/IsConnected", ReplyAction="http://tempuri.org/IMainService/IsConnectedResponse")]
        bool IsConnected();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetHuman", ReplyAction="http://tempuri.org/IMainService/GetHumanResponse")]
        DomainModel.Human GetHuman(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetCar", ReplyAction="http://tempuri.org/IMainService/GetCarResponse")]
        DomainModel.Car GetCar();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMainServiceChannel : MainClient.Service.IMainService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MainServiceClient : System.ServiceModel.ClientBase<MainClient.Service.IMainService>, MainClient.Service.IMainService {
        
        public MainServiceClient() {
        }
        
        public MainServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MainServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Summ(int a, int b) {
            return base.Channel.Summ(a, b);
        }
        
        public bool IsConnected() {
            return base.Channel.IsConnected();
        }
        
        public DomainModel.Human GetHuman(int Id) {
            return base.Channel.GetHuman(Id);
        }
        
        public DomainModel.Car GetCar() {
            return base.Channel.GetCar();
        }
    }
}