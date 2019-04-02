namespace RevolvoCore.Commands
{
    class AbilityStartCommand
    {
        public const short ID = 25358;

        public static Command write(int selectedAbilityId, int activatorId, bool noStopCommand)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(selectedAbilityId);
            cmd.Integer(activatorId);
            cmd.Boolean(noStopCommand);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
