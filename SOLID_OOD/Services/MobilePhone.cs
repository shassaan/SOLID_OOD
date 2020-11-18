using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OOD.Services
{
    public class MobilePhone : IMobilePhone
    {
        private readonly ICallService callService;
        private readonly ICamera camera;
        public MobilePhone(ICallService callService,ICamera camera)
        {
            this.callService = callService;
            this.camera = camera;
        }
        public void Call(string contact)
        {
            callService.Call(contact);
        }

        public void RecieveCall(string contact)
        {
            callService.RecieveCall(contact);
        }

        public void CapturePicture()
        {
            camera.CapturePicture();
        }
    }
}
