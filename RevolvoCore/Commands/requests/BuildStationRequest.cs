namespace RevolvoCore.Commands.requests
{
    class BuildStationRequest
    {
        public const short ID = 14010;

        public int battleStationId;
        public int buildTimeInMinutes;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            battleStationId = parser.readInt();
            buildTimeInMinutes = parser.readInt();
        }
    }
}
