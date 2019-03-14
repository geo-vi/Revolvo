using RevolvoCore.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevolvoCore.Encryption
{
    public class Pandora
    {
        private static NetBigInteger ENC_BASE_GENERATOR = new NetBigInteger("9d199fb7785e1616f60c8f717ca46f7c088bdb8986095380499fdfa93a1268020a3164427f5c27c2b9df41676063a43e140f57ae2acd207fdf5f48d44b4bca1a", 16);
        private static NetBigInteger ENC_PRIME_MODULUS = new NetBigInteger("d1bca8f2c1c71815111fe07923018747084ab8d546ea5d3a06671a814726898380acfd81a3843221ce68939ce90c8d665e762398ac86058b5860bf4623ce9417", 16);

        public Wrapper Wrapper;

        public RC4 EncodeAlgorithm = new RC4();
        public RC4 DecodeAlgorithm = new RC4();

        private NetBigInteger privateKey;

        // VARIABLES
        private bool stageOneActive = false;
        private bool rc4Active = false;

        //public byte[] GenerateObfuscationCallback()
        //{
        //    var _loc5_ = 0;
        //    var _loc6_ = "";
        //    var _loc1_ = "";
        //    var _loc2_ = 0;
        //    while (_loc2_ < 128)
        //    {
        //        _loc5_ = (int)(MathF.random() * 256);
        //        _loc6_ = Convert.ToString(_loc5_, 16);
        //        if (_loc6_.Length == 1)
        //        {
        //            _loc6_ = "0" + _loc6_;
        //        }
        //        _loc1_ = _loc1_ + _loc6_;
        //        _loc2_++;
        //    }
        //    this.privateKey = new NetBigInteger(_loc1_, 16);
        //    var _loc3_ = ENC_BASE_GENERATOR.ModPow(privateKey, ENC_PRIME_MODULUS);
        //    var loc3Bytes = _loc3_.ToByteArray();
        //    Console.WriteLine("Generated key, L:" + loc3Bytes.Length);
        //    return loc3Bytes;
        //}

        public byte[] GenerateObfuscationCallback()
        {
            var finalizedString = "";
            for (int i = 0; i < 128; i++)
            {
                var randomNum = Convert.ToInt32(MathF.random() * 256);
                var randomizedString = Convert.ToString(randomNum, 16);
                if (randomizedString.Length == 1)
                    randomizedString = "0" + randomizedString;
                finalizedString = finalizedString + randomizedString;
            }
            Console.WriteLine(finalizedString);
            // Output 0: a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1a1
            // Output 1: b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7b7
            // Output 2: dededededededededededededededededededededededededededededededededededededededededededededededededededededededededededededededededede3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a3a
            privateKey = new NetBigInteger(finalizedString, 16);
            var generatedKey = ENC_BASE_GENERATOR.ModPow(privateKey, ENC_PRIME_MODULUS);
            var bytes = generatedKey.ToByteArray();
            Console.WriteLine("Generated key, L:" + bytes.Length);
            return bytes;
        }

        public void InitiateObfuscation(byte[] key)
        {
            Wrapper = new Wrapper(key);
            stageOneActive = true;
        }

        public void InitiateHandshake()
        {
            throw new NotImplementedException();
        }

        public byte[] Encode(byte[] decoded)
        {
            byte[] returningBytes = decoded;
            if (stageOneActive)
                returningBytes = Wrapper.Encode(decoded);

            return returningBytes;
        }

        public byte[] Decode(byte[] decoded)
        {
            byte[] returningBytes = Wrapper.Decode(decoded);
            return returningBytes;
        }
    }
}
