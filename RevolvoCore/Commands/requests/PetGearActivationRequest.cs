namespace RevolvoCore.Commands.requests
{
    class PetGearActivationRequest
    {
        public const short ID = 6873;

        public PetGearTypeModule gearTypeToActivate;
        public int optParam;

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            parser.readShort(); // command id
            //parser.readShort(); // lenght
            gearTypeToActivate = new PetGearTypeModule(parser.readShort());
            optParam = parser.readInt();
        }
    }
}
