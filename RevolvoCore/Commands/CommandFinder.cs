using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvoCore.Commands
{
    public class CommandFinder
    {
        private static readonly Dictionary<int, Command> Commands = new Dictionary<int, Command>
        {
            {ShipInitializationCommand.ID, new ShipInitializationCommand() }
        };

        public static string Find(int id)
        {
            if (Commands.ContainsKey(id))
            {
                var cmd = Commands[id];
                cmd.Execute();
                return cmd.GetType().Name;
            }
            return "";
        }
    }
}
