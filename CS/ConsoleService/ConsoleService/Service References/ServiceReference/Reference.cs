﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleService.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://MonitorDB.agh.edu.pl", ConfigurationName="ServiceReference.IMonitorService")]
    public interface IMonitorService {
        
        // CODEGEN: Generating message contract since element name computer from namespace http://MonitorDB.agh.edu.pl is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://MonitorDB.agh.edu.pl/IMonitorService/AddData", ReplyAction="http://MonitorDB.agh.edu.pl/IMonitorService/AddDataResponse")]
        ConsoleService.ServiceReference.AddDataResponse AddData(ConsoleService.ServiceReference.AddData request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://MonitorDB.agh.edu.pl/IMonitorService/AddData", ReplyAction="http://MonitorDB.agh.edu.pl/IMonitorService/AddDataResponse")]
        System.Threading.Tasks.Task<ConsoleService.ServiceReference.AddDataResponse> AddDataAsync(ConsoleService.ServiceReference.AddData request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddData {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddData", Namespace="http://MonitorDB.agh.edu.pl", Order=0)]
        public ConsoleService.ServiceReference.AddDataBody Body;
        
        public AddData() {
        }
        
        public AddData(ConsoleService.ServiceReference.AddDataBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://MonitorDB.agh.edu.pl")]
    public partial class AddDataBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int year;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int month;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int day;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int hour;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int min;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public float sec;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string computer;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string counter;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public float value;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string verify;
        
        public AddDataBody() {
        }
        
        public AddDataBody(int year, int month, int day, int hour, int min, float sec, string computer, string counter, float value, string verify) {
            this.year = year;
            this.month = month;
            this.day = day;
            this.hour = hour;
            this.min = min;
            this.sec = sec;
            this.computer = computer;
            this.counter = counter;
            this.value = value;
            this.verify = verify;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddDataResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddDataResponse", Namespace="http://MonitorDB.agh.edu.pl", Order=0)]
        public ConsoleService.ServiceReference.AddDataResponseBody Body;
        
        public AddDataResponse() {
        }
        
        public AddDataResponse(ConsoleService.ServiceReference.AddDataResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddDataResponseBody {
        
        public AddDataResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMonitorServiceChannel : ConsoleService.ServiceReference.IMonitorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MonitorServiceClient : System.ServiceModel.ClientBase<ConsoleService.ServiceReference.IMonitorService>, ConsoleService.ServiceReference.IMonitorService {
        
        public MonitorServiceClient() {
        }
        
        public MonitorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MonitorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MonitorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MonitorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleService.ServiceReference.AddDataResponse ConsoleService.ServiceReference.IMonitorService.AddData(ConsoleService.ServiceReference.AddData request) {
            return base.Channel.AddData(request);
        }
        
        public void AddData(int year, int month, int day, int hour, int min, float sec, string computer, string counter, float value, string verify) {
            ConsoleService.ServiceReference.AddData inValue = new ConsoleService.ServiceReference.AddData();
            inValue.Body = new ConsoleService.ServiceReference.AddDataBody();
            inValue.Body.year = year;
            inValue.Body.month = month;
            inValue.Body.day = day;
            inValue.Body.hour = hour;
            inValue.Body.min = min;
            inValue.Body.sec = sec;
            inValue.Body.computer = computer;
            inValue.Body.counter = counter;
            inValue.Body.value = value;
            inValue.Body.verify = verify;
            ConsoleService.ServiceReference.AddDataResponse retVal = ((ConsoleService.ServiceReference.IMonitorService)(this)).AddData(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleService.ServiceReference.AddDataResponse> ConsoleService.ServiceReference.IMonitorService.AddDataAsync(ConsoleService.ServiceReference.AddData request) {
            return base.Channel.AddDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleService.ServiceReference.AddDataResponse> AddDataAsync(int year, int month, int day, int hour, int min, float sec, string computer, string counter, float value, string verify) {
            ConsoleService.ServiceReference.AddData inValue = new ConsoleService.ServiceReference.AddData();
            inValue.Body = new ConsoleService.ServiceReference.AddDataBody();
            inValue.Body.year = year;
            inValue.Body.month = month;
            inValue.Body.day = day;
            inValue.Body.hour = hour;
            inValue.Body.min = min;
            inValue.Body.sec = sec;
            inValue.Body.computer = computer;
            inValue.Body.counter = counter;
            inValue.Body.value = value;
            inValue.Body.verify = verify;
            return ((ConsoleService.ServiceReference.IMonitorService)(this)).AddDataAsync(inValue);
        }
    }
}
