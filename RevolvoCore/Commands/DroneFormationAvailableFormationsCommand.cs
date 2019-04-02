using System.Collections.Generic;

namespace RevolvoCore.Commands
{
    class DroneFormationAvailableFormationsCommand
    {
        public const short ID = 4479;

        public static Command write(List<int> availableFormations)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(availableFormations.Count);
            foreach (var formation in availableFormations)
            {
                cmd.Integer(formation);
            }
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
