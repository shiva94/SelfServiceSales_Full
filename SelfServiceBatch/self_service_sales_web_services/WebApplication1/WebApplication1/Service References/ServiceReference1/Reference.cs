﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dao.com/", ConfigurationName="ServiceReference1.CustDao1")]
    public interface CustDao1 {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://dao.com/CustDao1/getCustOrdersRequest", ReplyAction="http://dao.com/CustDao1/getCustOrdersResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        WebApplication1.ServiceReference1.getCustOrdersResponse getCustOrders(WebApplication1.ServiceReference1.getCustOrdersRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://dao.com/")]
    public partial class custOrders : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int customerIDField;
        
        private int orderIdField;
        
        private string orderStatusField;
        
        private string orderTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int customerID {
            get {
                return this.customerIDField;
            }
            set {
                this.customerIDField = value;
                this.RaisePropertyChanged("customerID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int orderId {
            get {
                return this.orderIdField;
            }
            set {
                this.orderIdField = value;
                this.RaisePropertyChanged("orderId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string orderStatus {
            get {
                return this.orderStatusField;
            }
            set {
                this.orderStatusField = value;
                this.RaisePropertyChanged("orderStatus");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public string orderType {
            get {
                return this.orderTypeField;
            }
            set {
                this.orderTypeField = value;
                this.RaisePropertyChanged("orderType");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCustOrders", WrapperNamespace="http://dao.com/", IsWrapped=true)]
    public partial class getCustOrdersRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dao.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int arg0;
        
        public getCustOrdersRequest() {
        }
        
        public getCustOrdersRequest(int arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCustOrdersResponse", WrapperNamespace="http://dao.com/", IsWrapped=true)]
    public partial class getCustOrdersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://dao.com/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public WebApplication1.ServiceReference1.custOrders @return;
        
        public getCustOrdersResponse() {
        }
        
        public getCustOrdersResponse(WebApplication1.ServiceReference1.custOrders @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CustDao1Channel : WebApplication1.ServiceReference1.CustDao1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CustDao1Client : System.ServiceModel.ClientBase<WebApplication1.ServiceReference1.CustDao1>, WebApplication1.ServiceReference1.CustDao1 {
        
        public CustDao1Client() {
        }
        
        public CustDao1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CustDao1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustDao1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CustDao1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication1.ServiceReference1.getCustOrdersResponse WebApplication1.ServiceReference1.CustDao1.getCustOrders(WebApplication1.ServiceReference1.getCustOrdersRequest request) {
            return base.Channel.getCustOrders(request);
        }
        
        public WebApplication1.ServiceReference1.custOrders getCustOrders(int arg0) {
            WebApplication1.ServiceReference1.getCustOrdersRequest inValue = new WebApplication1.ServiceReference1.getCustOrdersRequest();
            inValue.arg0 = arg0;
            WebApplication1.ServiceReference1.getCustOrdersResponse retVal = ((WebApplication1.ServiceReference1.CustDao1)(this)).getCustOrders(inValue);
            return retVal.@return;
        }
    }
}
