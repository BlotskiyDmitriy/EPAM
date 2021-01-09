﻿using ATS.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models.Controllers.Contracts
{
    internal interface IPort
    {
        PortState GetPortState();

        event EventHandler<ITerminal> OutGoingCall;
        event EventHandler InComingCall;
        event EventHandler Answer;
        event EventHandler Drop;
    }
}