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

        public User User;

        public void Init()
        {
            // Proxy to decrypt DO https
            _proxy = new XProxy(true);
            _proxy.ProxyFilters.Add(new MapsFilter());
            _proxy.ProxyFilters.Add(new InternalMapFilter());
            _proxy.Start();

            // Gets the client connection
            Task.Run(new Action(InitiateConnection));
        }

        private void InitiateConnection()
        {
            // Wait for MapId
            while (StorageManager.Spacemaps.Count != MapId || MapId == 0) { }

            // Init Policy protocol and game server
            var server = new Main.global_objects.IServer(StorageManager.Spacemaps[MapId].IP, Defaults.POLICY_PORT, true);
            server.Connected += (s, e) => User = new User(new Main.global_objects.IClient(Defaults.POLICY_PORT, true), server);
            server.Connect();
        }

        public void CloseProxy()
        {
            if (_proxy != null)
                _proxy.Stop();
        }
    }
}
