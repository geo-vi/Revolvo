namespace RevolvoCore.Commands
{
    class PetIsDestroyedCommand
    {
        public const short ID = 3328;

        public static Command write()
        {
            var cmd = new ByteArray(ID);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
