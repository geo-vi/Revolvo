using System.Collections.Generic;

namespace RevolvoCore.Commands
{
    class AbilityStatusFullCommand
    {
        public const short ID = 24975;

        public static Command write(List<AbilityStatusSingleCommand> abilities)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(abilities.Count);
            foreach (var ability in abilities)
                cmd.AddBytes(ability.write());
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
