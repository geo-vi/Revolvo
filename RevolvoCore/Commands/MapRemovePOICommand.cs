namespace RevolvoCore.Commands
{
    class MapRemovePOICommand
    {
        public const short ID = 7044;

        public static Command write(string poiId)
        {
            var cmd = new ByteArray(ID);
            cmd.UTF(poiId);
            return new Command(cmd.ToByteArray(), false);
        }
    }
}
