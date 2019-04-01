namespace RevolvoCore.Commands
{
    class PetShieldUpdateCommand
    {
        public const short ID = 8653;

        public static Command write(int petShieldNow, int petShieldMax)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(petShieldNow);
            cmd.Integer(petShieldMax);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
