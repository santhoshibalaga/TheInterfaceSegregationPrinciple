using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * 
 * Filename    = IVideoRecordable.cs
 *
 * Author      = B. Santhoshi Kumari
 *
 * Product     = Interface Segregation Principle
 * 
 * Project     = Smart Home Devices
 *
 * Description = Defines the IVideoRecordable interface for recording video.
 * 
 *****************************************************************************/

namespace TheInterfaceSegregationPrinciple
{
    /// <summary>
    /// Interface representing video recording capability.
    /// </summary>
    internal interface IVideoRecordable
    {
        /// <summary>
        /// Records video.
        /// </summary>
        void RecordVideo();
    }
}
