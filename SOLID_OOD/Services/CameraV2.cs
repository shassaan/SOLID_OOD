using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OOD.Services
{
    public class CameraV2 : ICamera
    {
        private readonly int Pixels = 12;
        public void CapturePicture()
        {
            Console.WriteLine($"Captured picture with {Pixels} pixels.");
        }
    }
}
