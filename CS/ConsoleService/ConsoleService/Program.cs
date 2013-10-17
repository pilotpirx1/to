using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleService
{
    class Program
    {
        static void SendData(string CompName, string CounterName, double value)
        {
            Console.WriteLine("Computer: {0} reporting {1} = {2:F2}", CompName, CounterName, value);
            //todo:
            ServiceReference.MonitorServiceClient cln = new ServiceReference.MonitorServiceClient();
            cln.AddData(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, CompName, CounterName, (float)value);
        }
        static void Main(string[] args)
        {
            PerformanceCounter  myCounter = new PerformanceCounter("Processor", @"% Processor Time", @"_Total");
            while (true)
            {
                SendData(Environment.MachineName, "Processor Total", myCounter.NextValue());
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
