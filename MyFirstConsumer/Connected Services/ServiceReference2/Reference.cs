﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstConsumer.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMyName", ReplyAction="http://tempuri.org/IService1/GetMyNameResponse")]
        string GetMyName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMyName", ReplyAction="http://tempuri.org/IService1/GetMyNameResponse")]
        System.Threading.Tasks.Task<string> GetMyNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMyEmail", ReplyAction="http://tempuri.org/IService1/GetMyEmailResponse")]
        string GetMyEmail();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMyEmail", ReplyAction="http://tempuri.org/IService1/GetMyEmailResponse")]
        System.Threading.Tasks.Task<string> GetMyEmailAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MyFirstConsumer.ServiceReference2.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MyFirstConsumer.ServiceReference2.IService1>, MyFirstConsumer.ServiceReference2.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMyName() {
            return base.Channel.GetMyName();
        }
        
        public System.Threading.Tasks.Task<string> GetMyNameAsync() {
            return base.Channel.GetMyNameAsync();
        }
        
        public string GetMyEmail() {
            return base.Channel.GetMyEmail();
        }
        
        public System.Threading.Tasks.Task<string> GetMyEmailAsync() {
            return base.Channel.GetMyEmailAsync();
        }
    }
}
