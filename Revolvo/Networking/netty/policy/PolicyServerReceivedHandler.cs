using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetty.Transport.Channels;

namespace Revolvo.Networking.netty.policy
{
    class PolicyServerReceivedHandler : SimpleChannelInboundHandler<string>
    {
        protected override void ChannelRead0(IChannelHandlerContext ctx, string msg)
        {
            throw new NotImplementedException();
        }
    }
}
