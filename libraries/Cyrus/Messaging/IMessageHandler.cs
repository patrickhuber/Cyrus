﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cyrus.Messaging
{
    public interface IMessageHandler
    {
        Task HandleAsync(IMessageReader message);
        void Handle(IMessageReader message);
    }
}
