namespace RevolvoCore.Commands
{
    class QuestCompletedCommand
    {
        public const short ID = 4127;

        public static Command write(int id, int rating)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(id);
            cmd.Integer(rating);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
