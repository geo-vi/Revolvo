namespace RevolvoCore.Commands.requests
{
    public class KeepAliveRequest
    {
        public const short ID = 4512;

        public static byte[] write()
        {
            var p = new ByteArray(ID);
            return p.ToByteArray();
        }
    }
}
