﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CertifyMe.Client.UserServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DmBaseOfUseruL7agKBo", Namespace="http://schemas.datacontract.org/2004/07/CertifyMe.Data")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CertifyMe.Client.UserServiceReference.User))]
    public partial class DmBaseOfUseruL7agKBo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
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
        public System.DateTime CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/CertifyMe.Data")]
    [System.SerializableAttribute()]
    public partial class User : CertifyMe.Client.UserServiceReference.DmBaseOfUseruL7agKBo {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInfo", Namespace="http://schemas.datacontract.org/2004/07/CertifyMe.Service.DataContracts")]
    [System.SerializableAttribute()]
    public partial class UserInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LoginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
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
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Login {
            get {
                return this.LoginField;
            }
            set {
                if ((object.ReferenceEquals(this.LoginField, value) != true)) {
                    this.LoginField = value;
                    this.RaisePropertyChanged("Login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UserServiceReference.IUserService")]
    public interface IUserService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_User_UserInfo/GetById", ReplyAction="http://tempuri.org/IServiceOf_User_UserInfo/GetByIdResponse")]
        CertifyMe.Client.UserServiceReference.User GetById(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_User_UserInfo/GetById", ReplyAction="http://tempuri.org/IServiceOf_User_UserInfo/GetByIdResponse")]
        System.Threading.Tasks.Task<CertifyMe.Client.UserServiceReference.User> GetByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_User_UserInfo/Add", ReplyAction="http://tempuri.org/IServiceOf_User_UserInfo/AddResponse")]
        System.Guid Add(CertifyMe.Client.UserServiceReference.UserInfo item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_User_UserInfo/Add", ReplyAction="http://tempuri.org/IServiceOf_User_UserInfo/AddResponse")]
        System.Threading.Tasks.Task<System.Guid> AddAsync(CertifyMe.Client.UserServiceReference.UserInfo item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_User_UserInfo/RemoveById", ReplyAction="http://tempuri.org/IServiceOf_User_UserInfo/RemoveByIdResponse")]
        bool RemoveById(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_User_UserInfo/RemoveById", ReplyAction="http://tempuri.org/IServiceOf_User_UserInfo/RemoveByIdResponse")]
        System.Threading.Tasks.Task<bool> RemoveByIdAsync(System.Guid id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_User_UserInfo/Update", ReplyAction="http://tempuri.org/IServiceOf_User_UserInfo/UpdateResponse")]
        bool Update(CertifyMe.Client.UserServiceReference.User item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_User_UserInfo/Update", ReplyAction="http://tempuri.org/IServiceOf_User_UserInfo/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(CertifyMe.Client.UserServiceReference.User item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_User_UserInfo/GetAll", ReplyAction="http://tempuri.org/IServiceOf_User_UserInfo/GetAllResponse")]
        CertifyMe.Client.UserServiceReference.User[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceOf_User_UserInfo/GetAll", ReplyAction="http://tempuri.org/IServiceOf_User_UserInfo/GetAllResponse")]
        System.Threading.Tasks.Task<CertifyMe.Client.UserServiceReference.User[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserByCredentials", ReplyAction="http://tempuri.org/IUserService/GetUserByCredentialsResponse")]
        System.Guid GetUserByCredentials(string login, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUserByCredentials", ReplyAction="http://tempuri.org/IUserService/GetUserByCredentialsResponse")]
        System.Threading.Tasks.Task<System.Guid> GetUserByCredentialsAsync(string login, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUserServiceChannel : CertifyMe.Client.UserServiceReference.IUserService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<CertifyMe.Client.UserServiceReference.IUserService>, CertifyMe.Client.UserServiceReference.IUserService {
        
        public UserServiceClient() {
        }
        
        public UserServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CertifyMe.Client.UserServiceReference.User GetById(System.Guid id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<CertifyMe.Client.UserServiceReference.User> GetByIdAsync(System.Guid id) {
            return base.Channel.GetByIdAsync(id);
        }
        
        public System.Guid Add(CertifyMe.Client.UserServiceReference.UserInfo item) {
            return base.Channel.Add(item);
        }
        
        public System.Threading.Tasks.Task<System.Guid> AddAsync(CertifyMe.Client.UserServiceReference.UserInfo item) {
            return base.Channel.AddAsync(item);
        }
        
        public bool RemoveById(System.Guid id) {
            return base.Channel.RemoveById(id);
        }
        
        public System.Threading.Tasks.Task<bool> RemoveByIdAsync(System.Guid id) {
            return base.Channel.RemoveByIdAsync(id);
        }
        
        public bool Update(CertifyMe.Client.UserServiceReference.User item) {
            return base.Channel.Update(item);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(CertifyMe.Client.UserServiceReference.User item) {
            return base.Channel.UpdateAsync(item);
        }
        
        public CertifyMe.Client.UserServiceReference.User[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<CertifyMe.Client.UserServiceReference.User[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public System.Guid GetUserByCredentials(string login, string password) {
            return base.Channel.GetUserByCredentials(login, password);
        }
        
        public System.Threading.Tasks.Task<System.Guid> GetUserByCredentialsAsync(string login, string password) {
            return base.Channel.GetUserByCredentialsAsync(login, password);
        }
    }
}
