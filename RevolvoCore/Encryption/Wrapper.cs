using RevolvoCore.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvoCore.Encryption
{
    public class Wrapper
    {
        public RC4 Encoder { get; private set; }

        protected bool Activated = false;

        public Wrapper(byte[] key)
        {
            Encoder = new RC4(key);
            Console.WriteLine("Wrapped up and ready to go.");
        }

        public byte[] Encode(byte[] bytes)
        {
            return Encoder.Encrypt(bytes);
        }

        public byte[] Decode(byte[] bytes)
        {
            return Encoder.Decrypt(bytes);
        }
    }
}
