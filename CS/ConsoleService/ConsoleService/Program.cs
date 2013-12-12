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
        
        static void Main(string[] args)
        {
            PerformanceCounter  myCounter = new PerformanceCounter("Processor", @"% Processor Time", @"_Total");
            ComputerModel model = new ComputerModel();

            while (true)
            {
                model.SaveData(Environment.MachineName, "Processor Total", myCounter.NextValue());
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
