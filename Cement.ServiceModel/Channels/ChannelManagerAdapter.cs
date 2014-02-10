﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;

namespace Cement.ServiceModel.Channels
{
    public class ChannelManagerAdapter : IChannelManager
    {
        private ChannelManagerBase channelManager;

        public ChannelManagerAdapter(ChannelManagerBase channelManager)
        {
            this.channelManager = channelManager;
        }
    }
}
