using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Networking.local_servers;
using Revolvo.Networking.remote_servers;
using Revolvo.Utils;
using RevolvoCore.Commands;

namespace Revolvo.Networking
{
    class UserSession
    {
        public GameServer GameServer;
        public GameClient GameClient;

        public bool Connection => GetConnection();

        public void TryRedirectToGameClient(byte[] bytes)
        {
            if (GameClient?.XSocket == null)
            {
                Console.WriteLine("Failed [GameClient]");
            }

            GameClient?.XSocket?.Write(bytes);
        }

        public void TryRedirectToGameServer(byte[] bytes)
        {
            if (GameServer?.XSocket == null)
            {
                Console.WriteLine("Failed [GameServer]");
                return;
            }

            GameServer?.XSocket?.Write(bytes);
        }

        private bool GetConnection()
        {
            var gameServerConnected = false;
            if (GameServer?.XSocket != null)
            {
                gameServerConnected = GameServer.XSocket.Connected;
            }

            var gameClientConnected = false;
            if (GameClient?.XSocket != null)
            {
                gameClientConnected = GameClient.XSocket.Connected;
            }

            return gameClientConnected && gameServerConnected;
        }
    }
}
