namespace RevolvoCore.Commands.requests
{
    class EquipModuleRequest
    {
        public const short ID = 25418;

        public int battleStationId;
        public int itemId;
        public int slotId;
        public bool replace;

        public void readCommand(byte[] bytes)
        {
            var cmd = new ByteParser(bytes);
            battleStationId = cmd.readInt();
            itemId = cmd.readInt();
            slotId = cmd.readInt();
            replace = cmd.readBool();
        }
    }
}
