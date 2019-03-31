using Revolvo.Bot.netty;
using RevolvoCore.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Main.global_objects
{
    internal class IClient
    {
        public XSocket XSocket { get; private set; }
        private bool PacketStream { get; }
        public IClient(int port, bool packetStream = false)
        {
            var xSocket = new XSocket(port);
            PacketStream = packetStream;
            xSocket.OnAccept += XSocket_OnAccept;
            xSocket.Listen();
        }

        private void XSocket_OnAccept(object sender, XSocketArgs e)
        {
            XSocket = e.XSocket;
            Console.WriteLine("IClient: Connection received [" + e.XSocket.IpEndPoint.Port + "]");
            XSocket.OnReceive += XSocket_OnReceive;
            XSocket.Read(PacketStream);
        }

        private void XSocket_OnReceive(object sender, EventArgs e)
        {
            if (PacketStream)
                Packet.Handler.HandlePolicyClient(((StringArgs)e).Packet);
            else
                Packet.Handler.HandleClientCommand(((ByteArrayArgs)e).ByteArray);
        }
    }
}
