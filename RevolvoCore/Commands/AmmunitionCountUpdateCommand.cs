using System.Collections.Generic;

namespace RevolvoCore.Commands
{
    class AmmunitionCountUpdateCommand
    {
        public const short ID = 7158;

        public static Command write(List<AmmunitionCountModule> ammunitionItems)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(ammunitionItems.Count);
            foreach (var item in ammunitionItems)
            {
                cmd.AddBytes(item.write());
            }
            return new Command(cmd.ToByteArray(), false);
        }
    }
}