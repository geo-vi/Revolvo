namespace RevolvoCore.Commands
{
    class QuestPrivilegeCommand
    {
        public const short ID = 31002;

        public static Command write(int questId)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(questId);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
