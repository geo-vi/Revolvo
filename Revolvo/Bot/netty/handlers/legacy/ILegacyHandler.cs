using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Bot.netty.handlers.legacy
{
    interface ILegacyHandler
    {
        void execute(string[] packet);
    }
}
