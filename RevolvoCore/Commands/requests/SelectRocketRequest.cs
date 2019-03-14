namespace RevolvoCore.Commands.requests
{
    class SelectRocketRequest
    {
        public const short ID = 15849;

        public short type = 0;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            parser.readShort();
            type = parser.readShort();
        }
    }
}
