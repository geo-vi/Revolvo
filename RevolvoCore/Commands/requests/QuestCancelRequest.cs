namespace RevolvoCore.Commands.requests
{
    class QuestCancelRequest
    {
        public const short ID = 21584;

        public int questId;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            questId = parser.readInt();
        }
    }
}
