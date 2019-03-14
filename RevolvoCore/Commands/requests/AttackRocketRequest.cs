namespace RevolvoCore.Commands.requests
{
    public class AttackRocketRequest
    {
        public const short ID = 16203;

        public int targetId;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            targetId = parser.readInt();
        }
    }
}