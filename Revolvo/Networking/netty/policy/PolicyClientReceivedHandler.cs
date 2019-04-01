using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetty.Transport.Channels;
using Revolvo.Networking.local_servers;

namespace Revolvo.Networking.netty.policy
{
    class PolicyClientReceivedHandler : SimpleChannelInboundHandler<string>
    {
        private PolicyServer _server;

        public PolicyClientReceivedHandler(PolicyServer server)
        {
            _server = server;
        }

        protected override async void ChannelRead0(IChannelHandlerContext ctx, string msg)
        {
            await _server.Write(msg);
            await _server.Close();
            await ctx.CloseAsync();
        }
    }
}
