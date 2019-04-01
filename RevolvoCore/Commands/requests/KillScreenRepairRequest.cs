namespace RevolvoCore.Commands.requests
{
    class KillScreenRepairRequest
    {
        public const short ID = 3303;

        public KillScreenOptionTypeModule selection;

        public void readCommand(byte[] bytes)
        {
            var p = new ByteParser(bytes);
            p.readShort();
            selection = new KillScreenOptionTypeModule(p.readShort());
        }
    }
}
