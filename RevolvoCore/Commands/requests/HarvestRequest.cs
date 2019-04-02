namespace RevolvoCore.Commands.requests
{
    class HarvestRequest
    {
        public const short ID = 27140;

        public string itemHash;

        public void readCommand(byte[] bytes)
        {
            var parse = new ByteParser(bytes);
            itemHash = parse.readUTF();
        }
    }
}
