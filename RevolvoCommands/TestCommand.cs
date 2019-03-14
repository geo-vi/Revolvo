using RevolvoCore;
using System;

namespace Revolvo.Bot.netty.commands
{
    class TestCommand : IExternal
    {
        public TestCommand() : base(0)
        {

        }

        public override byte[] write()
        {
            throw new NotImplementedException();
        }

        public override void readCommand(byte[] bytes)
        {
            throw new NotImplementedException();
        }
    }
}
