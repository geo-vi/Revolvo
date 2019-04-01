namespace RevolvoCore.Commands.requests
{
    class LabUpdateItemRequest
    {
        public const short ID = 5583;

        public LabItemModule itemToUpdate;
        public OreCountModule updateWith;

        public LabUpdateItemRequest()
        {
            itemToUpdate = new LabItemModule(-1);
            updateWith = new OreCountModule(new OreTypeModule(-1), -1);
        }
        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            itemToUpdate.read(parser);
            updateWith.read(parser);
        }
    }
}
