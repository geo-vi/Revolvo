namespace RevolvoCore.Commands
{
    class PetHitpointsUpdateCommand
    {
        public const short ID = 27483;

        public static Command write(int hitpointsNow, int hitpointsMax, bool useRepairGear)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(hitpointsNow);
            cmd.Integer(hitpointsMax);
            cmd.Boolean(useRepairGear);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
