using Microsoft.Extensions.DependencyInjection;
using SOLID_OOD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OOD
{
    public static class ExtensionMethods
    {
        public static void RegisterServices(this ServiceCollection services)
        {
            services.AddScoped<ICallService, CallService>();
            services.AddScoped<IMobilePhone,MobilePhone>();
        }
    }
}
