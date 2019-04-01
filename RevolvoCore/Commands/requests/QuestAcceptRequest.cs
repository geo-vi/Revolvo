namespace RevolvoCore.Commands.requests
{
    class QuestAcceptRequest
    {
        public const short ID = 8886;

        public int questId;
        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            questId = parser.readInt();
        }
    }
}
