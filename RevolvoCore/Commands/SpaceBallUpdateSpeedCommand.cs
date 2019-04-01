namespace RevolvoCore.Commands
{
    class SpaceBallUpdateSpeedCommand
    {
        public const short ID = 23110;

        public static Command write(int factionId, int speed)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(factionId);
            cmd.Integer(speed);
            return new Command(cmd.ToByteArray(),false);
        }
    }
}
