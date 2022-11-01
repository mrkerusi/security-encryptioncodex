using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;
using System.IO;
using System.Collections;

namespace EncryptionCodex.HashingSample
{
    class SHAhash
    {

        /// <summary>
        /// This is a group of Hashing function that can be used, MD5 Hash is obselete but can still be used to to generate as key
        /// SHA512 is the Strongest Hashed among the SHA Hash. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        
        public static string SHA512Hash(string input)
        {
            SHA512 alg = SHA512.Create();
            byte[] hashdata512 = alg.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashdata512.Length; i++)
            {
                sb.Append(hashdata512[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static string SHA256Hash(string input)
        {
            SHA256 alg = SHA256.Create();
            byte[] hashdata256 = alg.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashdata256.Length; i++)
            {
                sb.Append(hashdata256[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public static string SHA1Hash(string input)
        {
            HashAlgorithm algorithm = SHA1.Create();
            byte[] hashdata = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashdata.Length; i++)
            {
                sb.Append(hashdata[i].ToString("X2"));
            }
            return sb.ToString();
        }

        
    }
}
