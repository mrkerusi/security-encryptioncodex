using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Configuration;
using System.IO;
using System.Collections;

namespace EncryptionCodex.RandomCharGenerator
{
    class PRandomNumberGenerator
    {
        private static RNGCryptoServiceProvider randomnumber = new RNGCryptoServiceProvider();//this is to generate random number can be used to generate salt

        public static string PRNG()
        {
            using (randomnumber)
            {
                byte[] data = new byte[10];

                for (int i = 0; i < 15; i++)
                {
                    randomnumber.GetBytes(data);
                    int value = BitConverter.ToInt32(data, 0);
                    return value.ToString("X2").Replace("-", "");
                }
            } return null;
        }//Generate random number

    }
}
