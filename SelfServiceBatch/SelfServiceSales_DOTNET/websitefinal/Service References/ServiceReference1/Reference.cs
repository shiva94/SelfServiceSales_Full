﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace websitefinal.ServiceReference1 {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://proj/")]
    public partial class ClassNotFoundException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private stackTraceElement[] exceptionField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("stackTrace", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public stackTraceElement[] exception {
            get {
                return this.exceptionField;
            }
            set {
                this.exceptionField = value;
                this.RaisePropertyChanged("exception");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://proj/")]
    public partial class stackTraceElement : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(exception))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(sqlException))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://proj/")]
    public partial class throwable : object, System.ComponentModel.INotifyPropertyChanged {
        
        private stackTraceElement[] stackTraceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("stackTrace", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true, Order=0)]
        public stackTraceElement[] stackTrace {
            get {
                return this.stackTraceField;
            }
            set {
                this.stackTraceField = value;
                this.RaisePropertyChanged("stackTrace");
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(sqlException))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://proj/")]
    public partial class exception : throwable {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://proj/")]
    public partial class sqlException : exception {
        
        private sqlException nextExceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public sqlException nextException {
            get {
                return this.nextExceptionField;
            }
            set {
                this.nextExceptionField = value;
                this.RaisePropertyChanged("nextException");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://proj/")]
    public partial class SQLException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string sQLStateField;
        
        private int errorCodeField;
        
        private string messageField;
        
        private sqlException nextExceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string SQLState {
            get {
                return this.sQLStateField;
            }
            set {
                this.sQLStateField = value;
                this.RaisePropertyChanged("SQLState");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int errorCode {
            get {
                return this.errorCodeField;
            }
            set {
                this.errorCodeField = value;
                this.RaisePropertyChanged("errorCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public sqlException nextException {
            get {
                return this.nextExceptionField;
            }
            set {
                this.nextExceptionField = value;
                this.RaisePropertyChanged("nextException");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://proj/", ConfigurationName="ServiceReference1.ServerSend")]
    public interface ServerSend {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://proj/ServerSend/updateTableRequest", ReplyAction="http://proj/ServerSend/updateTableResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(websitefinal.ServiceReference1.ClassNotFoundException), Action="http://proj/ServerSend/updateTable/Fault/ClassNotFoundException", Name="ClassNotFoundException")]
        [System.ServiceModel.FaultContractAttribute(typeof(websitefinal.ServiceReference1.SQLException), Action="http://proj/ServerSend/updateTable/Fault/SQLException", Name="SQLException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        websitefinal.ServiceReference1.updateTableResponse updateTable(websitefinal.ServiceReference1.updateTableRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateTable", WrapperNamespace="http://proj/", IsWrapped=true)]
    public partial class updateTableRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://proj/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://proj/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double arg1;
        
        public updateTableRequest() {
        }
        
        public updateTableRequest(int arg0, double arg1) {
            this.arg0 = arg0;
            this.arg1 = arg1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="updateTableResponse", WrapperNamespace="http://proj/", IsWrapped=true)]
    public partial class updateTableResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://proj/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public updateTableResponse() {
        }
        
        public updateTableResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServerSendChannel : websitefinal.ServiceReference1.ServerSend, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServerSendClient : System.ServiceModel.ClientBase<websitefinal.ServiceReference1.ServerSend>, websitefinal.ServiceReference1.ServerSend {
        
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
        websitefinal.ServiceReference1.updateTableResponse websitefinal.ServiceReference1.ServerSend.updateTable(websitefinal.ServiceReference1.updateTableRequest request) {
            return base.Channel.updateTable(request);
        }
        
        public string updateTable(int arg0, double arg1) {
            websitefinal.ServiceReference1.updateTableRequest inValue = new websitefinal.ServiceReference1.updateTableRequest();
            inValue.arg0 = arg0;
            inValue.arg1 = arg1;
            websitefinal.ServiceReference1.updateTableResponse retVal = ((websitefinal.ServiceReference1.ServerSend)(this)).updateTable(inValue);
            return retVal.@return;
        }
    }
}