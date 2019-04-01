using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revolvo.Bot.objects;
using Revolvo.Main;
using Revolvo.Networking.remote_servers;
using RevolvoCore.Commands;

namespace Revolvo.Bot.controllers
{
    class MovementController
    {
        // TODO: Send local movement sent with MoveHero Command in order to *remove* lag
        public static void Move(Character character, Vector destination)
        {
            //Gets the movement time
            character.MovementTime = GetTime(character, destination);

            //Gets the system time when the movement starts
            character.MovementStartTime = DateTime.Now;
            character.Moving = true;

            MainController.Instance.Session.TryRedirectToGameServer(MoveCommand.write(character.Id, destination.X, destination.Y,
                character.MovementTime).Bytes);

        }

        public static int GetTime(Character character, Vector destination)
        {
            try
            {
                //Sets the position before the movement
                character.OldPosition = ActualPosition(character);

                //And the destination position
                var destinationPosition = destination;
                character.Destination = destinationPosition;

                //Same with the direction, will be used to calculate the position
                character.Direction = new Vector(destinationPosition.X - character.OldPosition.X, destinationPosition.Y - character.OldPosition.Y);

                var distance = destinationPosition.DistanceTo(character.OldPosition);

                var time = Math.Round(distance / character.Speed * 1000);

                return (int)time;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return -1;
        }

        public static Vector ActualPosition(Character character)
        {
            Vector actualPosition;

            if (character.Moving)
            {
                var timeElapsed = (DateTime.Now - character.MovementStartTime).TotalMilliseconds;

                //if the character continues moving
                if (timeElapsed < character.MovementTime)
                {
                    //maths time, it returns the actual position while flying
                    actualPosition = new Vector((int)Math.Round(character.OldPosition.X + (character.Direction.X * (timeElapsed / character.MovementTime))),
                            (int)Math.Round(character.OldPosition.Y + (character.Direction.Y * (timeElapsed / character.MovementTime))));
                }
                else
                {
                    //the character should be on the destination position
                    character.Moving = false;
                    actualPosition = character.Destination;
                }
            }
            else
            {
                //the character is not moving
                actualPosition = character.Position;
            }

            //updates the actual position into the character
            character.Position = actualPosition;


            /*
             *  TODO: FIXING A BUG WHERE IT VISUALLY TELEPORTS PLAYER / PLAYER BECOMES INVSIBILE
             */
            return actualPosition;
        }
    }
}
