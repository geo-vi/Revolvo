namespace RevolvoCore.Commands.requests
{
    class DroneFormationChangeRequest
    {
        public const short ID = 22456;

        public int selectedFormationId;

        public void readCommand(byte[] bytes)
        {
            var cmd = new ByteParser(bytes);
            selectedFormationId = cmd.readInt();
        }
    }
}
