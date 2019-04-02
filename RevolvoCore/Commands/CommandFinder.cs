using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvoCore.Commands
{
    public class CommandFinder
    {
        private static readonly Dictionary<int, object> Commands = new Dictionary<int, object>
        {
             { UserKeyBindingsUpdate.ID, new UserKeyBindingsUpdate() },
             { AddOreCommand.ID, new AddOreCommand() },
             { LegacyModule.ID, new LegacyModule() },
        };

        public static string Find(int id)
        {
            if (Commands.ContainsKey(id))
            {
                var cmd = Commands[id];
                //cmd.Execute();
                //TODO: execute and dictionary
                return cmd.GetType().Name;
            }
            return "";
        }
    }
}
