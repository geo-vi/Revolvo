using Revolvo.Bot.managers;
using Revolvo.Bot.netty;
using RevolvoCore.Networking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Main.global_objects
{
    internal class IServer
    {
        public XSocket XSocket { get; }
        private bool PacketStream { get; }

        public event EventHandler<EventArgs> Connected;

        public IServer(string ip, int port, bool packetStream = false)
        {
            XSocket = new XSocket(ip, port);
            PacketStream = packetStream;
            XSocket.OnReceive += XSocket_OnReceive;
            XSocket.ConnectionClosedEvent += XSocket_ConnectionClosedEvent;
        }

        public void Connect()
        {
            XSocket.Connect();
            Connected?.Invoke(this, EventArgs.Empty);
            Console.WriteLine("Connected to server");
            XSocket.Read(PacketStream);
        }

        private void XSocket_ConnectionClosedEvent(object sender, EventArgs e)
        {
           
        }

        private void XSocket_OnReceive(object sender, EventArgs e)
        {
            if (PacketStream)
                Packet.Handler.HandlePolicyServer(((StringArgs)e).Packet);
            else
                Packet.Handler.HandleServerCommand(((ByteArrayArgs)e).ByteArray);
        }
    }
}
