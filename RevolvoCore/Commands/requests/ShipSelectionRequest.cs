namespace RevolvoCore.Commands.requests
{
    class ShipSelectionRequest
    {
        public const short ID = 1666;

        public int targetId { get; set; }
        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            targetId = parser.readInt();
        }
    }
}
