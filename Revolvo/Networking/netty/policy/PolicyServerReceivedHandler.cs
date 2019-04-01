using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetty.Transport.Channels;
using Revolvo.Networking.local_servers;
using Revolvo.Networking.remote_servers;

namespace Revolvo.Networking.netty.policy
{
    class PolicyServerReceivedHandler : SimpleChannelInboundHandler<string>
    {
        private PolicyServer _server;

        public PolicyServerReceivedHandler(PolicyServer server)
        {
            _server = server;
        }

        protected override async void ChannelRead0(IChannelHandlerContext ctx, string msg)
        {
            var policyClient = new PolicyClient(_server);
            var connect = policyClient.Connect();
            Task.WaitAll(connect);
            await policyClient.Write(msg);
        }
    }
}
