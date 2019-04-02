namespace RevolvoCore.Commands.requests
{
    class AbilityLaunchRequest
    {
        public const short ID = 26418;

        public int selectedAbilityId;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            selectedAbilityId = parser.readInt();
        }
    }
}
