namespace RevolvoCore.Commands.requests
{
    class QuestInfoRequest
    {
        public const short ID = 28545;

        public int questId;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            questId = parser.readInt();
        }
    }
}
