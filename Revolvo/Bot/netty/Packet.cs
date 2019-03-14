using Revolvo.Bot.netty.packet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Bot.netty
{
    class Packet
    {
        public static Builder Builder = new Builder();

        public static Handler Handler = new Handler();
    }
}
