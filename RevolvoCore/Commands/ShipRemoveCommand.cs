namespace RevolvoCore.Commands
{
    class ShipRemoveCommand
    {
        public const short ID = 29006;

        public static Command write(int userId)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(userId);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
