using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvoCore.Commands
{
    public class KeepAlive
    {
        public const short ID = 5959;

        public static byte[] write()
        {
            var cmd = new ByteArray(ID);
            return cmd.ToByteArray();
        }
    }
}
