using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterfaceSegregationPrinciple
{
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
            Console.WriteLine("Smart Home Assistant display brightness adjusted to level");
        }

        public void SetTemperature()
        {
            Console.WriteLine("Smart Home Assistant set the temperature to degrees.");
        }

        public void SetSchedule()
        {
            Console.WriteLine("Smart Home Assistant schedule set ");
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
