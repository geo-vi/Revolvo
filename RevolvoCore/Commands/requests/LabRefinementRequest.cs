namespace RevolvoCore.Commands.requests
{
    class LabRefinementRequest
    {
        public const short ID = 6752;

        public OreCountModule toProduce;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            toProduce = new OreCountModule(null,0);
            toProduce.read(parser);
        }
    }
}
