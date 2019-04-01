using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Bot.netty;
using Revolvo.Main.global_objects;
using Revolvo.Networking.remote_servers;
using RevolvoCore.Networking;

namespace Revolvo.Networking.local_servers
{
    class GameServer
    {
        public XSocket XSocket { get; private set; }

        public GameServer()
        {
            var xSocket = new XSocket(Defaults.DEFAULT_GAME_PORT);
            xSocket.OnAccept += XSocket_OnAccept;
            xSocket.Listen();
        }

        private void XSocket_OnAccept(object sender, XSocketArgs e)
        {
            XSocket = e.XSocket;
            Console.WriteLine("Connection received [" + e.XSocket.IpEndPoint.Port + "]");
            XSocket.OnReceive += XSocket_OnReceive;
            XSocket.ConnectionClosedEvent += delegate { Console.WriteLine("closed?"); };
            XSocket.Read();
            Console.WriteLine("Ready GameServer");
        }

        private void XSocket_OnReceive(object sender, EventArgs e)
        {
            var args = (ByteArrayArgs)e;
            Packet.Handler.HandleGameServerBytes(args.ByteArray);
        }
    }
}
