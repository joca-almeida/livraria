﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Autor", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Web.ServiceReference1.Livro))]
    public partial class Autor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeAutorField;
        
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
        public string NomeAutor {
            get {
                return this.NomeAutorField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeAutorField, value) != true)) {
                    this.NomeAutorField = value;
                    this.RaisePropertyChanged("NomeAutor");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Livro", Namespace="http://schemas.datacontract.org/2004/07/Models")]
    [System.SerializableAttribute()]
    public partial class Livro : Web.ServiceReference1.Autor {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CdLivroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SinopseLivroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TituloLivroField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CdLivro {
            get {
                return this.CdLivroField;
            }
            set {
                if ((this.CdLivroField.Equals(value) != true)) {
                    this.CdLivroField = value;
                    this.RaisePropertyChanged("CdLivro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SinopseLivro {
            get {
                return this.SinopseLivroField;
            }
            set {
                if ((object.ReferenceEquals(this.SinopseLivroField, value) != true)) {
                    this.SinopseLivroField = value;
                    this.RaisePropertyChanged("SinopseLivro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TituloLivro {
            get {
                return this.TituloLivroField;
            }
            set {
                if ((object.ReferenceEquals(this.TituloLivroField, value) != true)) {
                    this.TituloLivroField = value;
                    this.RaisePropertyChanged("TituloLivro");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        Web.ServiceReference1.CompositeType GetDataUsingDataContract(Web.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Web.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Web.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CadastrarLivro", ReplyAction="http://tempuri.org/IService/CadastrarLivroResponse")]
        void CadastrarLivro(Web.ServiceReference1.Livro objLivro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CadastrarLivro", ReplyAction="http://tempuri.org/IService/CadastrarLivroResponse")]
        System.Threading.Tasks.Task CadastrarLivroAsync(Web.ServiceReference1.Livro objLivro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ListarLivros", ReplyAction="http://tempuri.org/IService/ListarLivrosResponse")]
        Web.ServiceReference1.Livro[] ListarLivros();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ListarLivros", ReplyAction="http://tempuri.org/IService/ListarLivrosResponse")]
        System.Threading.Tasks.Task<Web.ServiceReference1.Livro[]> ListarLivrosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ExcluirLivro", ReplyAction="http://tempuri.org/IService/ExcluirLivroResponse")]
        void ExcluirLivro(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ExcluirLivro", ReplyAction="http://tempuri.org/IService/ExcluirLivroResponse")]
        System.Threading.Tasks.Task ExcluirLivroAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/BuscarLivro", ReplyAction="http://tempuri.org/IService/BuscarLivroResponse")]
        Web.ServiceReference1.Livro BuscarLivro(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/BuscarLivro", ReplyAction="http://tempuri.org/IService/BuscarLivroResponse")]
        System.Threading.Tasks.Task<Web.ServiceReference1.Livro> BuscarLivroAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AtualizarLivro", ReplyAction="http://tempuri.org/IService/AtualizarLivroResponse")]
        void AtualizarLivro(Web.ServiceReference1.Livro l);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/AtualizarLivro", ReplyAction="http://tempuri.org/IService/AtualizarLivroResponse")]
        System.Threading.Tasks.Task AtualizarLivroAsync(Web.ServiceReference1.Livro l);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Web.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Web.ServiceReference1.IService>, Web.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public Web.ServiceReference1.CompositeType GetDataUsingDataContract(Web.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Web.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public void CadastrarLivro(Web.ServiceReference1.Livro objLivro) {
            base.Channel.CadastrarLivro(objLivro);
        }
        
        public System.Threading.Tasks.Task CadastrarLivroAsync(Web.ServiceReference1.Livro objLivro) {
            return base.Channel.CadastrarLivroAsync(objLivro);
        }
        
        public Web.ServiceReference1.Livro[] ListarLivros() {
            return base.Channel.ListarLivros();
        }
        
        public System.Threading.Tasks.Task<Web.ServiceReference1.Livro[]> ListarLivrosAsync() {
            return base.Channel.ListarLivrosAsync();
        }
        
        public void ExcluirLivro(int codigo) {
            base.Channel.ExcluirLivro(codigo);
        }
        
        public System.Threading.Tasks.Task ExcluirLivroAsync(int codigo) {
            return base.Channel.ExcluirLivroAsync(codigo);
        }
        
        public Web.ServiceReference1.Livro BuscarLivro(int codigo) {
            return base.Channel.BuscarLivro(codigo);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceReference1.Livro> BuscarLivroAsync(int codigo) {
            return base.Channel.BuscarLivroAsync(codigo);
        }
        
        public void AtualizarLivro(Web.ServiceReference1.Livro l) {
            base.Channel.AtualizarLivro(l);
        }
        
        public System.Threading.Tasks.Task AtualizarLivroAsync(Web.ServiceReference1.Livro l) {
            return base.Channel.AtualizarLivroAsync(l);
        }
    }
}
