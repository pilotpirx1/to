using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleService
{
    class ComputerModel
    {
        public void SaveData(string CompName, string CounterName, double value)
        {
            Console.WriteLine("Computer: {0} reporting {1} = {2:F2}", CompName, CounterName, value);

            ServicePointManager.ServerCertificateValidationCallback +=
                CustomXertificateValidation;

            ServiceReference.MonitorServiceClient cln = new ServiceReference.MonitorServiceClient();
            cln.AddData(DateTime.Now.Year, 
                        DateTime.Now.Month, 
                        DateTime.Now.Day, 
                        DateTime.Now.Hour, 
                        DateTime.Now.Minute, 
                        DateTime.Now.Second, 
                        CompName, 
                        CounterName, 
                        (float)value);
        }

        private static bool CustomXertificateValidation(object sender, X509Certificate cert,
            X509Chain chain, SslPolicyErrors error)
        {
            var certificate = (X509Certificate2)cert;

            // Inspect the server certficiate here to validate 
            // that you are dealing with the correct server.
            // If so return true, if not return false.
            return true;
        }

    }
}
