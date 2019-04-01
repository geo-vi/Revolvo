namespace RevolvoCore.Commands.requests
{
    class HellstormSelectRocketRequest
    {
        public const short ID = 7133;

        public AmmunitionTypeModule rocketType;
        public void readCommand(byte[] bytes)
        {
            var p = new ByteParser(bytes);
            p.readShort();
            rocketType = new AmmunitionTypeModule(p.readShort());
        }
    }
}
