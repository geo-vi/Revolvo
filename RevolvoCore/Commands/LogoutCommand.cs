namespace RevolvoCore.Commands
{
    class LogoutCommand
    {
        public const short ID = 4743;

        public static Command write(short command)
        {
            var cmd = new ByteArray(ID);
            cmd.Short(command);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
