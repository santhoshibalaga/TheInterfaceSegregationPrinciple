using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * 
 * Filename    = IBrightnessAdjustable.cs
 *
 * Author      = B. Santhoshi Kumari
 *
 * Product     = Interface Segregation Principle
 * 
 * Project     = Smart Home Devices
 *
 * Description = Defines the IBrightnessAdjustable interface for adjusting brightness.
 * 
 *****************************************************************************/

namespace TheInterfaceSegregationPrinciple
{
    /// <summary>
    /// Interface representing brightness adjustment capability.
    /// </summary>
    public interface IBrightnessAdjustable
    {
        /// <summary>
        /// Adjusts the brightness.
        /// </summary>
        void AdjustBrightness();
    }
}

