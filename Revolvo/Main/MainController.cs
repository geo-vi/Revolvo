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

        public int MapId { get; set; }
        public string SessionId { get; set; }
        public int UserId { get; set; }

        public User User;

        public void Init()
        {
            // Gets the client connection
            Task.Run(new Action(InitiateConnection));
        }

        private void InitiateConnection()
        {
            // Init Policy protocol and game server
            var server = new Main.global_objects.IServer(Defaults.HOST_IP, Defaults.POLICY_PORT, true);
            server.Connect();
        }
    }
}
