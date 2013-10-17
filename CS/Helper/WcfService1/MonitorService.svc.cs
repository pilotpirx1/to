using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WSDLGeneration;

namespace WcfService1
{
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(Namespace="http://MonitorDB.agh.edu.pl")]
    public class MonitorService : IMonitorService
    {
        public void AddData(int year, int month, int day, int hour, int min, float sec, string computer, string counter, float value)
        {
            throw new NotImplementedException();
        }
    }
}
