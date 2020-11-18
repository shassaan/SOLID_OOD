using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OOD.Services
{
    public class CallService : ICallService
    {
        public void Call(string contact)
        {
            Console.WriteLine($"Calling.. {contact}");
        }

        public void RecieveCall(string contact)
        {
            Console.WriteLine($"Recieved call of {contact}");
        }
    }
}
