﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mywebsite.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://proj/", ConfigurationName="ServiceReference1.ServerSend")]
    public interface ServerSend {
        
        // CODEGEN: Generating message contract since element name return from namespace  is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://proj/ServerSend/updateTableRequest", ReplyAction="http://proj/ServerSend/updateTableResponse")]
        mywebsite.ServiceReference1.updateTableResponse updateTable(mywebsite.ServiceReference1.updateTableRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateTableRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateTable", Namespace="http://proj/", Order=0)]
        public mywebsite.ServiceReference1.updateTableRequestBody Body;
        
        public updateTableRequest() {
        }
        
        public updateTableRequest(mywebsite.ServiceReference1.updateTableRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class updateTableRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int arg0;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public double arg1;
        
        public updateTableRequestBody() {
        }
        
        public updateTableRequestBody(int arg0, double arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateTableResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateTableResponse", Namespace="http://proj/", Order=0)]
        public mywebsite.ServiceReference1.updateTableResponseBody Body;
        
        public updateTableResponse() {
        }
        
        public updateTableResponse(mywebsite.ServiceReference1.updateTableResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class updateTableResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public updateTableResponseBody() {
        }
        
        public updateTableResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServerSendChannel : mywebsite.ServiceReference1.ServerSend, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServerSendClient : System.ServiceModel.ClientBase<mywebsite.ServiceReference1.ServerSend>, mywebsite.ServiceReference1.ServerSend {
        
        public ServerSendClient() {
        }
        
        public ServerSendClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServerSendClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerSendClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServerSendClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        mywebsite.ServiceReference1.updateTableResponse mywebsite.ServiceReference1.ServerSend.updateTable(mywebsite.ServiceReference1.updateTableRequest request) {
            return base.Channel.updateTable(request);
        }
        
        public string updateTable(int arg0, double arg1) {
            mywebsite.ServiceReference1.updateTableRequest inValue = new mywebsite.ServiceReference1.updateTableRequest();
            inValue.Body = new mywebsite.ServiceReference1.updateTableRequestBody();
            inValue.Body.arg0 = arg0;
            inValue.Body.arg1 = arg1;
            mywebsite.ServiceReference1.updateTableResponse retVal = ((mywebsite.ServiceReference1.ServerSend)(this)).updateTable(inValue);
            return retVal.Body.@return;
        }
    }
}