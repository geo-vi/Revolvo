using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolvo.Main.global_commands
{
    class ToggleLog : Command
    {
        public ToggleLog() : base("togglelog", "Toggles logging directly on the UI", false) { }

        public override void Execute(string[] args = null)
        {
            Properties.Visuals.SHOWING_LOG = !Properties.Visuals.SHOWING_LOG;
        }
    }
}
