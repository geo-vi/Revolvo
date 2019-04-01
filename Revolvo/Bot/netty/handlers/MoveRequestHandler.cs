using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Bot.controllers;
using Revolvo.Bot.objects;
using Revolvo.Main;
using RevolvoCore.Commands.requests;

namespace Revolvo.Bot.netty.handlers
{
    class MoveRequestHandler : IHandler
    {
        public void execute(byte[] bytes)
        {
            var request = new MoveRequest();
            request.readCommand(bytes);
            var player = MainController.Instance.Player;
            MovementController.Move(player, new Vector(request.targetX, request.targetY));
        }
    }
}
