using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * 
 * Filename    = ISwitchable.cs
 *
 * Author      = B. Santhoshi Kumari
 *
 * Product     = Interface Segregation Principle
 * 
 * Project     = Smart Home Devices
 *
 * Description = Defines the ISwitchable interface for switching devices on or off.
 * 
 *****************************************************************************/

namespace TheInterfaceSegregationPrinciple
{
    /// <summary>
    /// Interface representing the ability to switch a device on or off.
    /// </summary>
    public interface ISwitchable
    {
        /// <summary>
        /// Turns the device on.
        /// </summary>
        void TurnOn();

        /// <summary>
        /// Turns the device off.
        /// </summary>
        void TurnOff();
    }
}

