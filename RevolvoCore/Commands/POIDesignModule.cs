namespace RevolvoCore.Commands
{
    class POIDesignModule
    {
        public const short ID = 15058;

        public short designValue = 0;

        public POIDesignModule(short designValue)
        {
            this.designValue = designValue;
        }

        public byte[] write()
        {
            var cmd = new ByteArray(ID);
            cmd.Short(designValue);
            return cmd.Message.ToArray();
        }
    }
}