using Microsoft.Extensions.DependencyInjection;
using SOLID_OOD.Services;
using System;

namespace SOLID_OOD
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.RegisterServices();

            var mobilePhone = services.BuildServiceProvider()
                .GetService<IMobilePhone>();

            mobilePhone.Call("Hassaan");
            mobilePhone.RecieveCall("Hassaan");
            mobilePhone.CapturePicture();

            
            Console.ReadLine();
        }
    }
}
