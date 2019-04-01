namespace RevolvoCore.Commands
{
    class ClanMemberOnlineInfoCommand
    {
        public const short ID = 19442;

        public static Command write(int userId, bool online)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(userId);
            cmd.Boolean(online);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
