using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Hashing
{
    public class Hmac
    {
        private const int KeySize = 32;

        public static byte[] GenerateKey()
        {
            using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[KeySize];
                randomNumberGenerator.GetBytes(randomNumber);

                return randomNumber;
            }
        }

        public static byte[] ComputeHmacsha256(byte[] input, byte[] key)
        {
            using (var hmac = new HMACSHA256(key))
            {
                return hmac.ComputeHash(input);
            }
        }

        public static byte[] ComputeHmacsha1(byte[] input, byte[] key)
        {
            using (var hmac = new HMACSHA1(key))
            {
                return hmac.ComputeHash(input);
            }
        }

        public static byte[] ComputeHmacsha512(byte[] input, byte[] key)
        {
            using (var hmac = new HMACSHA512(key))
            {
                return hmac.ComputeHash(input);
            }
        }

        public static byte[] ComputeHmacmd5(byte[] input, byte[] key)
        {
            using (var hmac = new HMACMD5(key))
            {
                return hmac.ComputeHash(input);
            }
        }
    }
}
