using System;

namespace RevolvoCore.Commands
{
    public class LegacyModule
    {
        public const short ID = 29052;

        public event EventHandler Received;

        public string message;
        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            message = parser.readUTF();
        }

        public static byte[] write(string message)
        {
            var cmd = new ByteArray(ID);
            cmd.UTF(message);
            return cmd.ToByteArray();
        }
    }
}
