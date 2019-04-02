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

        public static byte[] write(int playerId, string sessionId)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(playerId);
            cmd.UTF(sessionId);
            return cmd.ToByteArray();
        }
    }
}