﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_OOD.Services
{
    public interface IMobilePhone
    {
        void Call(string contact);
        void RecieveCall(string contact);
    }
}
