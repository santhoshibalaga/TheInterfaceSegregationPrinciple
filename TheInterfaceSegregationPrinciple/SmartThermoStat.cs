using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * 
 * Filename    = SmartThermoStat.cs
 *
 * Author      = B. Santhoshi Kumari
 *
 * Product     = Interface Segregation Principle
 * 
 * Project     = Smart Home Devices
 *
 * Description = Implements a Smart Thermostat with temperature adjustment and 
 *               scheduling capabilities.
 * 
 *****************************************************************************/

namespace TheInterfaceSegregationPrinciple
{
    /// <summary>
    /// Represents a Smart Thermostat with temperature adjustment and scheduling capabilities.
    /// </summary>
    public class SmartThermoStat : ITemperatureAdjustable, ISchedulable
    {
        public void SetTemperature()
        {
            Console.WriteLine("The temperature is now set...");
        }

        public void SetSchedule()
        {
            Console.WriteLine("The schedule is now set...");
        }
    }
}
