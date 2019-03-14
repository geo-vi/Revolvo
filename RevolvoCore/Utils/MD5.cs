using System;
using System.IO;

namespace RevolvoCore.Utils
{
    public class MD5
    {
        public static string Get(string path)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-","").ToLower();
                }
            }

        }
    }
}
