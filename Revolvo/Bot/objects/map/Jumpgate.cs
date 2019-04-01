using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Bot.objects.map
{
    public class Jumpgate
    {
        public int Id;

        public Vector Position;

        public int DestinationMapId;

        public Jumpgate(int id, Vector position, int destinationMap)
        {
            Id = id;
            Position = position;
            DestinationMapId = destinationMap;
        }
    }
}
