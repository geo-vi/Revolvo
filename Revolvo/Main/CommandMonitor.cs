using Revolvo.Main.global_commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Main
{
    class CommandMonitor
    {
        public static Dictionary<string, Command> Commands = new Dictionary<string, Command>();

        public static void Add()
        {
            Commands.Add("test", new Test());
            Commands.Add("togglelog", new ToggleLog());
        }

        public static void Handle(string txt)
        {
            var packet = txt.Replace("/", "");
            if (packet.Contains(" "))
            {
                var splitted = packet.Split(' ');
                if (Commands.ContainsKey(splitted[0]))
                    Commands[splitted[0]].Execute(splitted);
            }
            else if (Commands.ContainsKey(packet))
                Commands[packet].Execute();
            else Console.WriteLine("ERROR: Command doesn't exist");
        }
    }
}
