﻿using Cement.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cement.Channels
{
    public interface IOutputChannel : IChannel
    {
        void Send(IMessage message);
    }
}
