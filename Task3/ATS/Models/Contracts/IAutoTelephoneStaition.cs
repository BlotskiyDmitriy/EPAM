﻿using ATS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models.Controllers.Contracts
{
    internal interface IAutoTelephoneStaition
    {
        PortController GetPorts();
    }
}