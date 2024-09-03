/******************************************************************************
 * 
 * Filename    = Program.cs
 *
 * Author      = B. Santhoshi Kumari
 *
 * Product     = Interface Segregation Principle
 * 
 * Project     = Smart Home Devices
 *
 * Description = Entry point of the application demonstrating the use of various
 *               smart devices implementing the Interface Segregation Principle.
 * 
 *****************************************************************************/

using System;

namespace TheInterfaceSegregationPrinciple
{
    /// <summary>
    /// Entry point for the Smart Home Devices application.
    /// Demonstrates interaction with various smart devices.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartLight smartLight = new SmartLight();
            SmartThermoStat smartThermostat = new SmartThermoStat();
            SmartCamera smartCamera = new SmartCamera();
            SmartHomeAssistant smartHomeAssistant = new SmartHomeAssistant();

            string? input = Console.ReadLine();

            if (input == "smartlight")
            {
                Console.WriteLine("1 to turn on ------ 0 to turn off the smart light");
                string? input1 = Console.ReadLine();
                if (input1 == "1")
                {
                    smartLight.TurnOn();
                }
                else
                {
                    smartLight.TurnOff();
                }
            }
            else if (input == "smartThermostat")
            {
                Console.WriteLine("1 to set the temperature ---- 2 to schedule ---- 0 for both");
                string? input1 = Console.ReadLine();
                if (input1 == "1")
                {
                    smartThermostat.SetTemperature();
                }
                else if (input1 == "2")
                {
                    smartThermostat.SetSchedule();
                }
                else
                {
                    smartThermostat.SetTemperature();
                    smartThermostat.SetSchedule();
                }
            }

            smartCamera.DetectMotion();
            smartCamera.RecordVideo();
        }
    }
}
