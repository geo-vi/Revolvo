namespace RevolvoCore.Commands.requests
{
    class ShipWarpRequest
    {
        public const short ID = 1450;

        public int shipType;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            shipType = parser.readInt();
        }
    }
}
