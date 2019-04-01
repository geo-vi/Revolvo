using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Main;
using Revolvo.Networking.remote_servers;
using RevolvoCore.Commands;
using RevolvoCore.Commands.requests;

namespace Revolvo.Bot.netty.handlers
{
    class VersionHandler : IHandler
    {
        public void execute(byte[] bytes)
        {
            var request = new VersionRequest();
            request.readCommand(bytes);
            var userId = request.playerId;
            var sessionId = request.sessionId;

            MainController.Instance.UserId = userId;
            MainController.Instance.SessionId = sessionId;

            var client = new GameClient();
            MainController.Instance.Session.GameClient = client;
            //client.XSocket.OnConnected += delegate
            //{
            //    MainController.Instance.Session.TryRedirectToGameClient(bytes);
            //};
            //client.Connect();

        }
    }
}
