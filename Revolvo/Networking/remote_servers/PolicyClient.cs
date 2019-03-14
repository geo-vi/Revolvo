using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Bot.managers;
using Revolvo.Bot.netty;
using Revolvo.Main;
using Revolvo.Main.global_objects;
using Revolvo.Networking.local_servers;
using RevolvoCore.Networking;

namespace Revolvo.Networking.remote_servers
{
    class PolicyClient
    {
        public XSocket XSocket { get; }

        public event EventHandler<EventArgs> Connected;

        private PolicyServer Server;

        public PolicyClient(PolicyServer server)
        {
            var ip = StorageManager.GetIP();
            XSocket = new XSocket(ip, Defaults.DEFAULT_POLICY_PORT);
            XSocket.OnReceive += XSocket_OnReceive;
            XSocket.ConnectionClosedEvent += XSocket_ConnectionClosedEvent;
            Server = server;
        }

        public void Connect()
        {
            XSocket.Connect();
            XSocket.Read(true);
        }

        private void XSocket_ConnectionClosedEvent(object sender, EventArgs e)
        {

        }

        private void XSocket_OnReceive(object sender, EventArgs e)
        {
            var args = (StringArgs)e;
            var packet = args.Packet;
            Server.XSocket.Write(packet);
            Server.XSocket.Close();
            
        }
    }
}
