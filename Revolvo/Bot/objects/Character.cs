using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Bot.objects
{
    class Character
    {
        public int Id { get; }

        public string Name { get; set; }

        public Vector Position { get; set; }
        public bool Moving { get; set; }
        public Vector OldPosition { get; set; }
        public Vector Destination { get; set; }
        public Vector Direction { get; set; }
        public DateTime MovementStartTime { get; set; }
        public int MovementTime { get; set; }

        public int Speed { get; set; }

        public Character(int id, string name, Vector position, int speed)
        {
            Id = id;
            Name = name;
            Position = position;
            Speed = speed;
        }
        
    }
}
