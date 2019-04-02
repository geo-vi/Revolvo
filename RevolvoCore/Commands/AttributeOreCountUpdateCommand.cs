﻿using System.Collections.Generic;

namespace RevolvoCore.Commands
{
    class AttributeOreCountUpdateCommand
    {
        public const short ID = 10112;

        public static Command write(List<OreCountModule> ores)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(ores.Count);
            foreach (var ore in ores)
                cmd.AddBytes(ore.write());
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
