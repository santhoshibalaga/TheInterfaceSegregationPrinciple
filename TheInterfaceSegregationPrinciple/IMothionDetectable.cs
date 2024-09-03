using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/******************************************************************************
 * 
 * Filename    = IMothionDetectable.cs
 *
 * Author      = B. Santhoshi Kumari
 *
 * Product     = Interface Segregation Principle
 * 
 * Project     = Smart Home Devices
 *
 * Description = Defines the IMothionDetectable interface for detecting motion.
 * 
 *****************************************************************************/

namespace TheInterfaceSegregationPrinciple
{
    /// <summary>
    /// Interface representing motion detection capability.
    /// </summary>
    internal interface IMothionDetectable
    {
        /// <summary>
        /// Detects motion.
        /// </summary>
        void DetectMotion();
    }
}

