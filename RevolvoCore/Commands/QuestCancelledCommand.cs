namespace RevolvoCore.Commands
{
    class QuestCancelledCommand
    {
        public const short ID = 17478;
        public static Command write(int id)
        {
            var cmd = new ByteArray(ID);
            cmd.Integer(id);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
