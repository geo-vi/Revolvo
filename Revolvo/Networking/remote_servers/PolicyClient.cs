using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DotNetty.Transport.Bootstrapping;
using DotNetty.Transport.Channels;
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
        private PolicyServer Server;

        public PolicyClient(PolicyServer server)
        {
            Server = server;
        }

        public async void Connect()
        {
            //TODO: Connect
            var ip = StorageManager.GetIP();
            var bootstrap = new Bootstrap();
            IChannel bootstrapChannel = await bootstrap.ConnectAsync(ip, Defaults.DEFAULT_POLICY_PORT);

        }


    }
}
