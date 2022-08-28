﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Technologique_Website.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/userRegister", ReplyAction="http://tempuri.org/IService1/userRegisterResponse")]
        bool userRegister(string userName, string userSurname, string userEmail, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/userRegister", ReplyAction="http://tempuri.org/IService1/userRegisterResponse")]
        System.Threading.Tasks.Task<bool> userRegisterAsync(string userName, string userSurname, string userEmail, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/userLogin", ReplyAction="http://tempuri.org/IService1/userLoginResponse")]
        int userLogin(string userEmail, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/userLogin", ReplyAction="http://tempuri.org/IService1/userLoginResponse")]
        System.Threading.Tasks.Task<int> userLoginAsync(string userEmail, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Technologique_Website.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Technologique_Website.ServiceReference1.IService1>, Technologique_Website.ServiceReference1.IService1 {
        
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
        
        public bool userRegister(string userName, string userSurname, string userEmail, string password) {
            return base.Channel.userRegister(userName, userSurname, userEmail, password);
        }
        
        public System.Threading.Tasks.Task<bool> userRegisterAsync(string userName, string userSurname, string userEmail, string password) {
            return base.Channel.userRegisterAsync(userName, userSurname, userEmail, password);
        }
        
        public int userLogin(string userEmail, string password) {
            return base.Channel.userLogin(userEmail, password);
        }
        
        public System.Threading.Tasks.Task<int> userLoginAsync(string userEmail, string password) {
            return base.Channel.userLoginAsync(userEmail, password);
        }
    }
}