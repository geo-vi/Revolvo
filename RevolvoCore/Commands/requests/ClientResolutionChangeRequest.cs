namespace RevolvoCore.Commands.requests
{
    class ClientResolutionChangeRequest
    {
        public const short ID = 23816;

        public int resolutionId;
        public int width;
        public int height;

        public void readCommand(byte[] bytes)
        {
            var cmd = new ByteParser(bytes);
            cmd.readShort();
            resolutionId = cmd.readInt();
            width = cmd.readInt();
            height = cmd.readInt();
        }
    }
}
