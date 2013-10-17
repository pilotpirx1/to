using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WSDLGeneration
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "http://MonitorDB.agh.edu.pl")]
    public interface IMonitorService
    {
        [OperationContract]
        void AddData(int year, int month, int day, int hour, int min, float sec, string computer, string counter, float value);
    }
}
