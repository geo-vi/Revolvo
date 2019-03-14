namespace RevolvoCore.Commands.requests
{
    class CollectBoxRequest
    {
        public const short ID = 29347;

        public string itemHash { get; set; }

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            itemHash = parser.readUTF();
        }
    }
}
