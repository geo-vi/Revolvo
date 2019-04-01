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
    class PolicyServer
    {
        public XSocket XSocket { get; private set; }

        public PolicyServer()
        {
            var xSocket = new XSocket(Defaults.DEFAULT_POLICY_PORT);

            xSocket.OnAccept += XSocket_OnAccept;
            xSocket.Listen();
        }

        private void XSocket_OnAccept(object sender, XSocketArgs e)
        {
            XSocket = e.XSocket;
            Console.WriteLine("Connection received [" + e.XSocket.IpEndPoint.Port + "]");
            XSocket.OnReceive += XSocket_OnReceive;
            XSocket.Read(true);
        }

        private void XSocket_OnReceive(object sender, EventArgs e)
        {
            var args = (StringArgs) e;
            var packet = args.Packet;
            Console.WriteLine(packet);
            // that's the main.swf sending policy request
            // now we must redirect that to the hosted server on univ3rse.com
            // so here should come connect.
            var policyClient = new PolicyClient(this);
            policyClient.XSocket.OnConnected += delegate (object o, EventArgs eventArgs) {
                policyClient.XSocket.Write(packet);
            };
            policyClient.Connect();
        }
    }
}
