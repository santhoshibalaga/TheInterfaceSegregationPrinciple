using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterfaceSegregationPrinciple
{
    public class SmartCamera:IMothionDetectable,IVideoRecordable
    {
        public void DetectMotion()
        {
            Console.WriteLine("the motion was detected...");
        }

        public void RecordVideo()
        {
            Console.WriteLine("the video is being recorded...");
        }
    }
}
