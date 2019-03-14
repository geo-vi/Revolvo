namespace RevolvoCore.Commands
{
    class POIReadyCommand
    {
        public const short ID = 6588;

        public static byte[] write()
        {
            var cmd = new ByteArray(ID);
            return cmd.ToByteArray();
        }
    }
}