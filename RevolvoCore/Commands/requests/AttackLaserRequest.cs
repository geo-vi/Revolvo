namespace RevolvoCore.Commands.requests
{
    public class AttackLaserRequest
    {
        public const short ID = 29918;

        public int targetId = 0;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            targetId = parser.readInt();
        }
    }
}