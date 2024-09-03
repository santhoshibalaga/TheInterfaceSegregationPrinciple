using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/******************************************************************************
 * 
 * Filename    = ITemperatureAdjustable.cs
 *
 * Author      = B. Santhoshi Kumari
 *
 * Product     = Interface Segregation Principle
 * 
 * Project     = Smart Home Devices
 *
 * Description = Defines the ITemperatureAdjustable interface for adjusting temperature.
 * 
 *****************************************************************************/

namespace TheInterfaceSegregationPrinciple
{
    /// <summary>
    /// Interface representing temperature adjustment capability.
    /// </summary>
    internal interface ITemperatureAdjustable
    {
        /// <summary>
        /// Sets the temperature.
        /// </summary>
        void SetTemperature();
    }
}

