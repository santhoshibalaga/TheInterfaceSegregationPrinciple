using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * 
 * Filename    = SmartLight.cs
 *
 * Author      = B. Santhoshi Kumari
 *
 * Product     = Interface Segregation Principle
 * 
 * Project     = Smart Home Devices
 *
 * Description = Implements a Smart Light with switching and brightness adjustment
 *               capabilities.
 * 
 *****************************************************************************/

namespace TheInterfaceSegregationPrinciple
{
    /// <summary>
    /// Represents a Smart Light with switching and brightness adjustment capabilities.
    /// </summary>
    public class SmartLight : ISwitchable, IBrightnessAdjustable
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is turned on...");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is turned off...");
        }

        public void AdjustBrightness()
        {
            Console.WriteLine("Brightness of the light is adjusted...");
        }
    }
}
