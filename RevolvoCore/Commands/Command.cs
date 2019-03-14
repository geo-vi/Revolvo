using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvoCore.Commands
{
    public class Command
    {
        public event EventHandler Received;

        public void Execute()
        {
            Received.Invoke(this, EventArgs.Empty);
        }
    }
}
