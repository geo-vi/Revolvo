namespace RevolvoCore.Commands.requests
{
    public class VersionRequest
    {
        public const short ID = 666;

        public int playerId;
        public string sessionId;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            playerId = parser.readInt();
            sessionId = parser.readUTF();
        }
    }
}
