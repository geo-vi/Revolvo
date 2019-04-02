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
        private bool PacketStream { get; set; }

        public event EventHandler<EventArgs> Connected;

        public IServer(string ip, int port, bool packetStream = false)
        {
            XSocket = new XSocket(ip, port);
            PacketStream = packetStream;
            XSocket.OnReceive += XSocket_OnReceive;
            XSocket.ConnectionClosedEvent += XSocket_ConnectionClosedEvent;
            XSocket.OnConnected += XSocket_ConnectionOnConnected;
        }

        public void Connect()
        {
            XSocket.Connect();
            Connected?.Invoke(this, EventArgs.Empty);
            XSocket.Read(PacketStream);
        }

        private void XSocket_ConnectionOnConnected(object sender, EventArgs e)
        {
            Console.WriteLine("Connected to the server.");
            if (PacketStream)
            {
                XSocket.Write("<policy-file-request/>");
            }
            MainController.Instance.User = new User(this);
        }

        private void XSocket_ConnectionClosedEvent(object sender, EventArgs e)
        {
            Console.WriteLine("IServer: Disconnected from server");
        }

        private void XSocket_OnReceive(object sender, EventArgs e)
        {
            if (PacketStream)
            {
                Packet.Handler.HandlePolicyServer(((StringArgs)e).Packet);
            } else
            {
                Packet.Handler.HandleServerCommand(((ByteArrayArgs)e).ByteArray);
            }
        }
    }
}
