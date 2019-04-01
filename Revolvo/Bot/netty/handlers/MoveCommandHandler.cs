using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Bot.managers;
using Revolvo.Bot.objects;
using Revolvo.Main;
using RevolvoCore.Commands;

namespace Revolvo.Bot.netty.handlers
{
    class MoveCommandHandler : IHandler
    {
        public void execute(byte[] bytes)
        {
            var request = new MoveCommand();
            request.readCommand(bytes);
            if (request.userId == MainController.Instance.UserId)
            {
                var p = MainController.Instance.Player;
                p.Position = new Vector(request.x, request.y);
                p.MovementTime = request.timeToTarget;
            }
            else
            {
                //todo....
            }
            MainController.Instance.Session.TryRedirectToGameServer(bytes);
        }
    }
}
