namespace RevolvoCore.Commands
{
    class ClanMemberMapInfoCommand
    {
        public const short ID = 22387;

        public static Command write(int userId, int mapId)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(userId);
            cmd.Integer(mapId);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
