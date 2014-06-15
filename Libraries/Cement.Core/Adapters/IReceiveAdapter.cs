﻿using Cement.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cement.Adapters
{
    public interface IReceiveAdapter : IObserver<IMessage>
    {
        IMessage Receive();
    }
}
