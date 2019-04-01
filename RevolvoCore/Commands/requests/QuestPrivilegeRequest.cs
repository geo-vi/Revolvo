namespace RevolvoCore.Commands.requests
{
    class QuestPrivilegeRequest
    {
        public const short ID = 29007;

        public int questId;
        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            questId = parser.readInt();
        }
    }
}
