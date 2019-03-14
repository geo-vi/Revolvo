namespace RevolvoCore.Commands.requests
{
    class WindowSettingsRequest
    {
        public const short ID = 19710;

        public int clientResolutionId = 0;
      
        public string windowSettings = "";
      
        public string resizableWindows = "";
      
        public int minimapScale = 0;
      
        public string mainmenuPosition = "";
      
        public string slotmenuPosition = "";
      
        public string slotMenuOrder = "";
      
        public string slotmenuPremiumPosition = "";
      
        public string slotMenuPremiumOrder = "";
      
        public string barStatus = "";

        public void readCommand(byte[] bytes)
        {
            var parser = new ByteParser(bytes);
            clientResolutionId = parser.readShort();
            windowSettings = parser.readUTF();
            resizableWindows = parser.readUTF();
            minimapScale = parser.readInt();
            mainmenuPosition = parser.readUTF();
            slotmenuPosition = parser.readUTF();
            slotMenuOrder = parser.readUTF();
            slotmenuPremiumPosition = parser.readUTF();
            slotMenuPremiumOrder = parser.readUTF();
            barStatus = parser.readUTF();
        }
    }
}
