﻿namespace RevolvoCore.Commands
{
    class ShipWarpCompletedCommand
    {
        public const short ID = 5630;

        public static Command write()
        {
            var cmd = new ByteArray(ID);
            return new Command(cmd.ToByteArray(), false);
        }

    }
}
