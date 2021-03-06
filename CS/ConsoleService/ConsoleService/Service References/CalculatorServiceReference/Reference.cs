﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleService.CalculatorServiceReference {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://calculator.jaxws.axis2.apache.org")]
    public partial class AddNumbersException : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://calculator.jaxws.axis2.apache.org", ConfigurationName="CalculatorServiceReference.CalculatorServicePortType")]
    public interface CalculatorServicePortType {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://calculator.jaxws.axis2.apache.org/add", ReplyAction="http://calculator.jaxws.axis2.apache.org/addResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ConsoleService.CalculatorServiceReference.AddNumbersException), Action="http://calculator.jaxws.axis2.apache.org/addFault", Name="AddNumbersException")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        int add(int value1, int value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://calculator.jaxws.axis2.apache.org/add", ReplyAction="http://calculator.jaxws.axis2.apache.org/addResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<int> addAsync(int value1, int value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://calculator.jaxws.axis2.apache.org/Calculator/getTicketRequest", ReplyAction="http://calculator.jaxws.axis2.apache.org/Calculator/getTicketResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ConsoleService.CalculatorServiceReference.EndpointReferenceType getTicket();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://calculator.jaxws.axis2.apache.org/Calculator/getTicketRequest", ReplyAction="http://calculator.jaxws.axis2.apache.org/Calculator/getTicketResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        System.Threading.Tasks.Task<ConsoleService.CalculatorServiceReference.EndpointReferenceType> getTicketAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2005/08/addressing")]
    public partial class EndpointReferenceType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private AttributedURIType addressField;
        
        private ReferenceParametersType referenceParametersField;
        
        private MetadataType metadataField;
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AttributedURIType Address {
            get {
                return this.addressField;
            }
            set {
                this.addressField = value;
                this.RaisePropertyChanged("Address");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceParametersType ReferenceParameters {
            get {
                return this.referenceParametersField;
            }
            set {
                this.referenceParametersField = value;
                this.RaisePropertyChanged("ReferenceParameters");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public MetadataType Metadata {
            get {
                return this.metadataField;
            }
            set {
                this.metadataField = value;
                this.RaisePropertyChanged("Metadata");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=3)]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2005/08/addressing")]
    public partial class AttributedURIType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="anyURI")]
        public string Value {
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2005/08/addressing")]
    public partial class ReferenceParametersType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2005/08/addressing")]
    public partial class MetadataType : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
                this.RaisePropertyChanged("Any");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    public interface CalculatorServicePortTypeChannel : ConsoleService.CalculatorServiceReference.CalculatorServicePortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServicePortTypeClient : System.ServiceModel.ClientBase<ConsoleService.CalculatorServiceReference.CalculatorServicePortType>, ConsoleService.CalculatorServiceReference.CalculatorServicePortType {
        
        public CalculatorServicePortTypeClient() {
        }
        
        public CalculatorServicePortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServicePortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServicePortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServicePortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int add(int value1, int value2) {
            return base.Channel.add(value1, value2);
        }
        
        public System.Threading.Tasks.Task<int> addAsync(int value1, int value2) {
            return base.Channel.addAsync(value1, value2);
        }
        
        public ConsoleService.CalculatorServiceReference.EndpointReferenceType getTicket() {
            return base.Channel.getTicket();
        }
        
        public System.Threading.Tasks.Task<ConsoleService.CalculatorServiceReference.EndpointReferenceType> getTicketAsync() {
            return base.Channel.getTicketAsync();
        }
    }
}
