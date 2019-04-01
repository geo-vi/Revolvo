using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.ProxyFilters;
using RevolvoCore.Networking;
using Revolvo.Main.global_objects;
using Revolvo.Bot.managers;
using RevolvoCore.Encryption;
using System.Threading;
using Revolvo.Bot.netty;
using Revolvo.Bot.netty.packet;
using Revolvo.Bot.objects;
using Revolvo.Networking;
using Revolvo.Networking.local_servers;

namespace Revolvo.Main
{
    /// <summary>
    /// Main controller of the application.
    /// </summary>
    internal sealed class MainController
    {
        /// <summary>
        /// Ultra singleton pattern.
        /// I prefer it over static methods.
        /// </summary>
        public static MainController Instance { get; } = new MainController();

        /// <summary>
        /// Main proxy. Used to replace maps.php mainly
        /// </summary>
        private XProxy _proxy;

        public int MapId { get; set; }
        public string SessionId { get; set; }
        public int UserId { get; set; }

        public UserSession Session = new UserSession();

        public PlayerInstance Player;

        public void Init()
        {
            Packet.Handler = new Handler();
            // Proxy to decrypt DO https
            _proxy = new XProxy(true);
            //_proxy.ProxyFilters.Add(new MainFilter()); for uberorbit only
            _proxy.ProxyFilters.Add(new MapsFilter());
            _proxy.ProxyFilters.Add(new InternalMapFilter());
            _proxy.Start();

            // Gets the client connection
            Task.Run(new Action(InitiateConnection));
            //GetClientConnection();
        }

        private void InitiateConnection()
        {
            new PolicyServer();
            //while (StorageManager.Spacemaps.Count != MapId || MapId == 0) {  }
            //var server = new Main.global_objects.IServer(StorageManager.Spacemaps[MapId].IP, 843, true);
            //server.Connected += (s, e) => User = new User(new Main.global_objects.IClient(843, true), server);
            //server.Connect();
        }

        private void GetClientConnection()
        {
            var policyServer = new XSocket(843);
            policyServer.OnAccept += (sender, args) =>
            {
                Console.WriteLine("Connection received!");
                var policyConnection = args.XSocket;
                policyConnection.OnReceive += (o, eventArgs) =>
                {
                    var p = ((StringArgs) eventArgs).Packet;
                    Console.WriteLine("Received: " + p);
                };
                policyConnection.Read(true);
            };
            policyServer.Listen();
        }

        public void CloseProxy()
        {
            if (_proxy != null)
                _proxy.Stop();
        }
    }
}
