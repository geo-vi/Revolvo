namespace RevolvoCore.Commands.requests
{
    public class MoveRequest
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

        public static Command write(int positionX, int positionY, int targetX,int targetY)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(positionX);
            cmd.Integer(targetY);
            cmd.Integer(targetX);
            cmd.Integer(positionY);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
