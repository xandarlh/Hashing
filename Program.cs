using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Hashing
{
    class Program
    {
        //generates random key
        static byte[] key = Hmac.GenerateKey();

        //takes input and which hashing method to use
        static void Input(int input, byte[] message)
        {
            switch (input)
            {
                case 1:
                    string sha1 = Convert.ToBase64String(Hash.ComputeHashSha1(message));
                    Console.WriteLine(sha1);
                    break;
                case 2:
                    string sha256 = Convert.ToBase64String(Hash.ComputeHashSha256(message));
                    Console.WriteLine(sha256);
                    break;
                case 3:
                    string sha512 = Convert.ToBase64String(Hash.ComputeHashSha512(message));
                    Console.WriteLine(sha512);
                    break;
                case 4:
                    string md5 = Convert.ToBase64String(Hash.ComputeHashMd5(message));
                    Console.WriteLine(md5);
                    break;
                case 5:
                    string hsha1 = Convert.ToBase64String(Hmac.ComputeHmacsha1(message, key));
                    Console.WriteLine(hsha1);
                    break;
                case 6:
                    string hsha256 = Convert.ToBase64String(Hmac.ComputeHmacsha256(message, key));
                    Console.WriteLine(hsha256);
                    break;
                case 7:
                    string hsha512 = Convert.ToBase64String(Hmac.ComputeHmacsha512(message, key));
                    Console.WriteLine(hsha512);
                    break;
                case 8:
                    string hmd5 = Convert.ToBase64String(Hmac.ComputeHmacmd5(message, key));
                    Console.WriteLine(hmd5);
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            List<string> hashings = new List<string>() { "Sha1", "Sha256", "Sha512", "Md5", "HMAC Sha1", "HMAC Sha256", "HMAC Sha512", "HMAC Md5" };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hmac key: {0}", Convert.ToBase64String(key) + "\nEnter message:");
                byte[] message = Encoding.UTF8.GetBytes(Console.ReadLine());
                for (int i = 0; i < hashings.Count; i++)
                {
                    Console.WriteLine("{0}: {1}", i + 1, hashings[i]);
                }
                Input(int.Parse(Console.ReadLine()), message);
                Console.ReadLine();
            }
        }
    }
}
