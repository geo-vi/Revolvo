using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Bot.objects;
using Revolvo.Main;
using RevolvoCore.Commands;

namespace Revolvo.Bot.netty.handlers
{
    class ShipInitializationHandler : IHandler
    {
        public void execute(byte[] bytes)
        {
            var request = new ShipInitializationCommand();
            request.readCommand(bytes);

            Console.WriteLine("Received ShipInit");

            MainController.Instance.Player = new PlayerInstance(request.userId, request.userName, new Vector(request.x, request.y), request.speed);
            MainController.Instance.Session.TryRedirectToGameServer(bytes);
        }
    }
}
