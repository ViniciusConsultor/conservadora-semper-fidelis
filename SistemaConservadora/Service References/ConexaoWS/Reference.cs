﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaConservadora.ConexaoWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConexaoWS.ConexaoWSSoap")]
    public interface ConexaoWSSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Conectar", ReplyAction="*")]
        void Conectar();
        
        // CODEGEN: Generating message contract since element name testeResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/teste", ReplyAction="*")]
        SistemaConservadora.ConexaoWS.testeResponse teste(SistemaConservadora.ConexaoWS.testeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class testeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="teste", Namespace="http://tempuri.org/", Order=0)]
        public SistemaConservadora.ConexaoWS.testeRequestBody Body;
        
        public testeRequest() {
        }
        
        public testeRequest(SistemaConservadora.ConexaoWS.testeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class testeRequestBody {
        
        public testeRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class testeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="testeResponse", Namespace="http://tempuri.org/", Order=0)]
        public SistemaConservadora.ConexaoWS.testeResponseBody Body;
        
        public testeResponse() {
        }
        
        public testeResponse(SistemaConservadora.ConexaoWS.testeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class testeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string testeResult;
        
        public testeResponseBody() {
        }
        
        public testeResponseBody(string testeResult) {
            this.testeResult = testeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ConexaoWSSoapChannel : SistemaConservadora.ConexaoWS.ConexaoWSSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConexaoWSSoapClient : System.ServiceModel.ClientBase<SistemaConservadora.ConexaoWS.ConexaoWSSoap>, SistemaConservadora.ConexaoWS.ConexaoWSSoap {
        
        public ConexaoWSSoapClient() {
        }
        
        public ConexaoWSSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConexaoWSSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConexaoWSSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConexaoWSSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Conectar() {
            base.Channel.Conectar();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SistemaConservadora.ConexaoWS.testeResponse SistemaConservadora.ConexaoWS.ConexaoWSSoap.teste(SistemaConservadora.ConexaoWS.testeRequest request) {
            return base.Channel.teste(request);
        }
        
        public string teste() {
            SistemaConservadora.ConexaoWS.testeRequest inValue = new SistemaConservadora.ConexaoWS.testeRequest();
            inValue.Body = new SistemaConservadora.ConexaoWS.testeRequestBody();
            SistemaConservadora.ConexaoWS.testeResponse retVal = ((SistemaConservadora.ConexaoWS.ConexaoWSSoap)(this)).teste(inValue);
            return retVal.Body.testeResult;
        }
    }
}
