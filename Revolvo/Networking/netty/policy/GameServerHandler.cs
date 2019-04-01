using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetty.Transport.Channels;
using DotNetty.Transport.Channels.Sockets;

namespace Revolvo.Networking.netty.policy
{
    class GameServerHandler : SimpleChannelInboundHandler<DatagramPacket>
    {
        protected override void ChannelRead0(IChannelHandlerContext ctx, DatagramPacket packet)
        {
            Console.WriteLine($"Server Received => {packet}");
        }
    }
}
