namespace RevolvoCore.Commands
{
    public class MoveCommand
    {
        public const short ID = 20502;

        public int userId;
        public int x;
        public int y;
        public int timeToTarget;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            userId = parser.readInt();
            x = parser.readInt();
            y = parser.readInt();
            timeToTarget = parser.readInt();
        }

        public static Command write(int userId, int x, int y, int timeToTarget)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(userId);
            cmd.Integer(x);
            cmd.Integer(y);
            cmd.Integer(timeToTarget);
            return new Command(cmd.ToByteArray(), false);
        }

    }
}
