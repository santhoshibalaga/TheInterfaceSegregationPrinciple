using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/******************************************************************************
 * 
 * Filename    = SmartCamera.cs
 *
 * Author      = B. Santhoshi Kumari
 *
 * Product     = Interface Segregation Principle
 * 
 * Project     = Smart Home Devices
 *
 * Description = Implements a Smart Camera with motion detection and video recording
 *               capabilities.
 * 
 *****************************************************************************/

namespace TheInterfaceSegregationPrinciple
{
    /// <summary>
    /// Represents a Smart Camera with motion detection and video recording capabilities.
    /// </summary>
    public class SmartCamera : IMothionDetectable, IVideoRecordable
    {
        /// <summary>
        /// Detects motion using the Smart Camera.
        /// </summary>
        public void DetectMotion()
        {
            Console.WriteLine("The motion was detected...");
        }

        /// <summary>
        /// Records video using the Smart Camera.
        /// </summary>
        public void RecordVideo()
        {
            Console.WriteLine("The video is being recorded...");
        }
    }
}
