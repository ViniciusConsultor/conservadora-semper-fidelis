﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaConservadora.CondominioWeb {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CondominioWeb.CondominioWebSoap")]
    public interface CondominioWebSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RetornaLista", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(condominio[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityKeyMember[]))]
        condominio[] RetornaLista(string acesso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RetornaItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(condominio[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityKeyMember[]))]
        SistemaConservadora.CondominioWeb.condominio RetornaItem(int id, string acesso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SalvaCondominio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(condominio[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityKeyMember[]))]
        bool SalvaCondominio(SistemaConservadora.CondominioWeb.condominio condominio, string acesso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AdicionaCondominio", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(condominio[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityKeyMember[]))]
        bool AdicionaCondominio(SistemaConservadora.CondominioWeb.condominio condominio, string acesso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Apagar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(condominio[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityKeyMember[]))]
        bool Apagar(int id, string acesso);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class condominio : EntityObject {
        
        private int idcondominiosField;
        
        private string nomeField;
        
        private string enderecoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int idcondominios {
            get {
                return this.idcondominiosField;
            }
            set {
                this.idcondominiosField = value;
                this.RaisePropertyChanged("idcondominios");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
                this.RaisePropertyChanged("nome");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string endereco {
            get {
                return this.enderecoField;
            }
            set {
                this.enderecoField = value;
                this.RaisePropertyChanged("endereco");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(condominio))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class EntityObject : StructuralObject {
        
        private EntityKey entityKeyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public EntityKey EntityKey {
            get {
                return this.entityKeyField;
            }
            set {
                this.entityKeyField = value;
                this.RaisePropertyChanged("EntityKey");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EntityKey : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string entitySetNameField;
        
        private string entityContainerNameField;
        
        private EntityKeyMember[] entityKeyValuesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string EntitySetName {
            get {
                return this.entitySetNameField;
            }
            set {
                this.entitySetNameField = value;
                this.RaisePropertyChanged("EntitySetName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string EntityContainerName {
            get {
                return this.entityContainerNameField;
            }
            set {
                this.entityContainerNameField = value;
                this.RaisePropertyChanged("EntityContainerName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public EntityKeyMember[] EntityKeyValues {
            get {
                return this.entityKeyValuesField;
            }
            set {
                this.entityKeyValuesField = value;
                this.RaisePropertyChanged("EntityKeyValues");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EntityKeyMember : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string keyField;
        
        private object valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
                this.RaisePropertyChanged("Key");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public object Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(condominio))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.225")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class StructuralObject : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CondominioWebSoapChannel : SistemaConservadora.CondominioWeb.CondominioWebSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CondominioWebSoapClient : System.ServiceModel.ClientBase<SistemaConservadora.CondominioWeb.CondominioWebSoap>, SistemaConservadora.CondominioWeb.CondominioWebSoap {
        
        public CondominioWebSoapClient() {
        }
        
        public CondominioWebSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CondominioWebSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CondominioWebSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CondominioWebSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public condominio[] RetornaLista(string acesso) {
            return base.Channel.RetornaLista(acesso);
        }
        
        public SistemaConservadora.CondominioWeb.condominio RetornaItem(int id, string acesso) {
            return base.Channel.RetornaItem(id, acesso);
        }
        
        public bool SalvaCondominio(SistemaConservadora.CondominioWeb.condominio condominio, string acesso) {
            return base.Channel.SalvaCondominio(condominio, acesso);
        }
        
        public bool AdicionaCondominio(SistemaConservadora.CondominioWeb.condominio condominio, string acesso) {
            return base.Channel.AdicionaCondominio(condominio, acesso);
        }
        
        public bool Apagar(int id, string acesso) {
            return base.Channel.Apagar(id, acesso);
        }
    }
}
