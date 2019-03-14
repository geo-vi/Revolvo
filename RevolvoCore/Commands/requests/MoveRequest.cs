namespace RevolvoCore.Commands.requests
{
    class MoveRequest
    {
        public const short ID = 6417;

        public int positionX;
        public int targetY;
        public int targetX;
        public int positionY;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            this.positionX = parser.readInt();
            this.targetY = parser.readInt();
            this.targetX = parser.readInt();
            this.positionY = parser.readInt();

        }
    }
}
