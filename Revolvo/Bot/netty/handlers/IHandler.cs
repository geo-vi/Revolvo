using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Bot.netty.handlers
{
    interface IHandler
    {
        /// <summary>
        /// Executing the handler
        /// -> param1 GameSession //TODO//
        /// -> param2 bytes received
        /// </summary>
        /// <param name="bytes"></param>
        void execute(byte[] bytes);
    }
}
