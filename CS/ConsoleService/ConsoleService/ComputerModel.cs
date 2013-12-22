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

        private static String user = "wsuser";
        private static String pass = "wsuser";
        
        public void SaveData(string CompName, string CounterName, double value)
        {
            Console.WriteLine("Computer: {0} reporting {1} = {2:F2}", CompName, CounterName, value);

            ServicePointManager.ServerCertificateValidationCallback +=
                CertificateValidationCallBack;

            ServiceReference.MonitorServiceClient cln = new ServiceReference.MonitorServiceClient();
            cln.AddData(DateTime.Now.Year, 
                        DateTime.Now.Month, 
                        DateTime.Now.Day, 
                        DateTime.Now.Hour, 
                        DateTime.Now.Minute, 
                        DateTime.Now.Second, 
                        CompName, 
                        CounterName, 
                        (float)value,
                        getVerifySCode());
            //Console.WriteLine("{0}-{1}-{2} {3}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour);
        }


        public static String getVerifySCode()
        {
            String code = user+"|"+pass;
            return code;
        }

        public static bool CertificateValidationCallBack(
            object sender,
            X509Certificate cert,
            X509Chain chain, 
            SslPolicyErrors sslPolicyErrors)
        {
            var certificate = (X509Certificate2)cert;
            
            //clientCert = new X509Certificate2(AUTHEN_CERT_FILE);
            //X509Certificate2 cert2 = new X509Certificate2("C:\\Workplace\\project\\to\\cert\\serverself.crt");

            // If the certificate is a valid, signed certificate, return true.
            if (sslPolicyErrors == System.Net.Security.SslPolicyErrors.None)
            {
                Console.WriteLine("The certificate is a valid, signed certificate, return true.");
                return true;
            }

            // If there are errors in the certificate chain, look at each error to determine the cause.
            if ((sslPolicyErrors & System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors) != 0)
            {
                if (chain != null && chain.ChainStatus != null)
                {
                    foreach (System.Security.Cryptography.X509Certificates.X509ChainStatus status in chain.ChainStatus)
                    {
                        if ((certificate.Subject == certificate.Issuer) &&
                           (status.Status == System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.UntrustedRoot))
                        {
                            // Self-signed certificates with an untrusted root are valid. 
                            Console.WriteLine("Self-signed certificates with an untrusted root are valid.");
                            continue;
                        }
                        else
                        {
                            if (status.Status != System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
                            {
                                // If there are any other errors in the certificate chain, the certificate is invalid,
                                // so the method returns false.
                                Console.WriteLine("If there are any other errors in the certificate chain, the certificate is invalid, so the method returns false.");
                                return false;
                            }
                        }
                    }
                }

                // When processing reaches this line, the only errors in the certificate chain are 
                // untrusted root errors for self-signed certificates. These certificates are valid
                // for default Exchange server installations, so return true.
                Console.WriteLine("When processing reaches this line, the only errors in the certificate chain are untrusted root errors for self-signed certificates.");

                if (!certificate.Subject.Contains("CN=agh.edu.pl"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                // In all other cases, return false.
                Console.WriteLine("In all other cases, return false.");
                return false;
            }
        }

    }
}
