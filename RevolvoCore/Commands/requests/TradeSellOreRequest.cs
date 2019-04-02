namespace RevolvoCore.Commands.requests
{
    class TradeSellOreRequest
    {
        public const short ID = 26473;
        public OreCountModule toSell;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            toSell = new OreCountModule(null, 0);
            toSell.read(parser);
        }
    }
}
