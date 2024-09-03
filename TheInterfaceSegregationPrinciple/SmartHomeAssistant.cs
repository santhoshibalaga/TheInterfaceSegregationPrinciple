using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * 
 * Filename    = SmartHomeAssistant.cs
 *
 * Author      = B. Santhoshi Kumari
 *
 * Product     = Interface Segregation Principle
 * 
 * Project     = Smart Home Devices
 *
 * Description = Implements a Smart Home Assistant with multiple capabilities 
 *               including switching, brightness adjustment, temperature control, 
 *               scheduling, motion detection, and video recording.
 * 
 *****************************************************************************/

namespace TheInterfaceSegregationPrinciple
{
    /// <summary>
    /// Represents a Smart Home Assistant with various smart capabilities.
    /// </summary>
    public class SmartHomeAssistant : ISwitchable, IBrightnessAdjustable, ITemperatureAdjustable, ISchedulable, IMothionDetectable, IVideoRecordable
    {
        public void TurnOn()
        {
            Console.WriteLine("Smart Home Assistant is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Smart Home Assistant is turned off.");
        }

        public void AdjustBrightness()
        {
            Console.WriteLine("Smart Home Assistant display brightness adjusted.");
        }

        public void SetTemperature()
        {
            Console.WriteLine("Smart Home Assistant set the temperature.");
        }

        public void SetSchedule()
        {
            Console.WriteLine("Smart Home Assistant schedule set.");
        }

        public void DetectMotion()
        {
            Console.WriteLine("Smart Home Assistant detected motion.");
        }

        public void RecordVideo()
        {
            Console.WriteLine("Smart Home Assistant is recording video.");
        }
    }
}
