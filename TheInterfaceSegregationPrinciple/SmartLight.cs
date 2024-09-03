using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterfaceSegregationPrinciple
{
    public class SmartLight:ISwitchable,IBrightnessAdjustable
    {
        public void TurnOn()
        {
            Console.WriteLine("the light is turned on...");
        }
        public void TurnOff() { Console.WriteLine("the light is turned off...."); }

        public void AdjustBrightness()
        {
            Console.WriteLine("brightness of light is adjusted....");
        }
    }
}
