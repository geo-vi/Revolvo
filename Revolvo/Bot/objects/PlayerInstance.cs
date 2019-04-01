using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Bot.controllers;
using Revolvo.Main;
using RevolvoCore.Commands;
using RevolvoCore.Commands.requests;

namespace Revolvo.Bot.objects
{
    class PlayerInstance : Character
    {
        /// <summary>
        /// Owner's instance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="position"></param>

        public PlayerInstance(int id, string name, Vector position, int speed) : base(id, name, position, speed)
        {
        }

        public void Move(Vector newPos)
        {
            MainController.Instance.Session.TryRedirectToGameClient(MoveRequest.write(Position.X, Position.Y, newPos.X, newPos.Y).Bytes);
            MovementController.Move(this, newPos);
        }
    }
}
