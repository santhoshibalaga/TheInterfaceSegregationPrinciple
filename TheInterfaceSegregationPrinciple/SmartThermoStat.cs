using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterfaceSegregationPrinciple
{
    public class SmartThermoStat:ITemperatureAdjustable,ISchedulable
    {
        public void SetTemperature()
        {
            Console.WriteLine("the temperature is now set...");
        }

        public void SetSchedule()
        {
            Console.WriteLine("the schedule is now set...");
        }
    }
}
