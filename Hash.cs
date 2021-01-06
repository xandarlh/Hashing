using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Hashing
{
    public class Hash
    {
        public static byte[] ComputeHashSha1(byte[] input)
        {
            using (var sha1 = SHA1.Create())
            {
                return sha1.ComputeHash(input);
            }
        }

        public static byte[] ComputeHashSha256(byte[] input)
        {
            using (var sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(input);
            }
        }

        public static byte[] ComputeHashSha512(byte[] input)
        {
            using (var sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(input);
            }
        }

        public static byte[] ComputeHashMd5(byte[] input)
        {
            using (var md5 = MD5.Create())
            {
                return md5.ComputeHash(input);
            }
        }
    }
}
