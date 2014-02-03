﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cement.ServiceModel.Channels
{
    public class WaitForFileResult
    {
        public WaitForFileResult(bool timedOut)
        {
            TimedOut = timedOut;
        }
        public bool TimedOut { get; private set; }        
    }
}