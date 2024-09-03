using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * 
 * Filename    = ISchedulable.cs
 *
 * Author      = B. Santhoshi Kumari
 *
 * Product     = Interface Segregation Principle
 * 
 * Project     = Smart Home Devices
 *
 * Description = Defines the ISchedulable interface for setting schedules.
 * 
 *****************************************************************************/

namespace TheInterfaceSegregationPrinciple
{
    /// <summary>
    /// Interface representing scheduling capability.
    /// </summary>
    internal interface ISchedulable
    {
        /// <summary>
        /// Sets a schedule.
        /// </summary>
        void SetSchedule();
    }
}
