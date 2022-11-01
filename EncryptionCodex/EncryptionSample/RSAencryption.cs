using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Configuration;
using System.IO;
using System.Collections;

namespace EncryptionCodex.Encryptionsample
{
    class RSAencryption
    {
        /// <summary>
        /// Here you can set salt, Key, and even random number from the RNGCryptoServiceProvider. 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string RSAData = "<RSAKeyValue><Modulus>6tvDxJL6o2OOcoBk1iihifA4a65R8YEaV8xWUiPZBWnNGhB8S6z4E8XWS4XHpqMh9+VCj+C6fjTWDBjIuw1PXj6IvaokPTRe3zatuXeIa6qkvBr9x/aHq0mHcyNQm6A8sCsXSgfDgRDaiwInrxovWUmSAxcnm1dGTvhkPAc54f0=</Modulus><Exponent>AQAB</Exponent><P>90rLi7cM4cxuyatDcZ1y2039YsZZ/+qOARXzqPZlCf/u103xmlqXQ9xEW4cSk1CQ7hjxvqnqWodP0NUetqfn0w==</P><Q>8yDi7Y+2Kg7te0WVwJN/ith75/54EgcTPP4/EiVwj+nQe2z4CDfdI+WoK4IwfOUUu4cg47Ndsym05l9wpnE87w==</Q><DP>uh9zX67gZTpm0Ca01lh40BK8+ZDswC8bvjl1cOAyX/pfG3GwvEoeu5aXZIQfOP1Ud8ASgzyEBKr/KeCeA0AQvQ==</DP><DQ>aVUBG5zcdgI7nuF5zJHaeuPpYowbpuvLyOv5lToFN0Q8H40JND5Hn2q63gasTR/OSKR1elDWMm3KQthsbJ+4nw==</DQ><InverseQ>iv0K0cPCDT7goJLs2IuSSO734qLdr68Mhz3vdzvTj5MgsGdfTyOVN/fsQTkA29PH2zglkxVta7P3Sm0frWR7YA==</InverseQ><D>LQ2TdHYtloJWpSh0L5EDzA5FBIMgPQ/jGcydEozF6P/u1H0tGudHf6OIBFzZe+H3djKInkkh/WvtU8y9VQSsoK2SFYPuOKzk7Y2qCevDaAP3pKGFC8aZ8btYlJZo6UP1TTZ0IhnHWwJlMqGzqE4RlJ+uLc55sZiABwqSNrE8LpE=</D></RSAKeyValue>";

        private static int dwKeySize = 1024;

        //public RSA(string RSAXMLData, int KeySize)
        //{
        //    RSAData = RSAXMLData;
        //    dwKeySize = KeySize;
        //}

        public static string EncryptRSAString(string inputString, string Key)
        {
            // TODO: Add Proper Exception Handlers
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
            rsaCryptoServiceProvider.FromXmlString(Key);
            int keySize = dwKeySize / 8;
            byte[] bytes = Encoding.UTF32.GetBytes(inputString);
            // The hash function in use by the .NET RSACryptoServiceProvider here is SHA1
            // int maxLength = ( keySize ) - 2 - ( 2 * SHA1.Create().ComputeHash( rawBytes ).Length );
            int maxLength = keySize - 42;
            int dataLength = bytes.Length;
            int iterations = dataLength / maxLength;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i <= iterations; i++)
            {
                byte[] tempBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength : dataLength - maxLength * i];
                Buffer.BlockCopy(bytes, maxLength * i, tempBytes, 0, tempBytes.Length);
                byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt(tempBytes, true);
                // Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
                // If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
                // Comment out the next line and the corresponding one in the DecryptString function.
                Array.Reverse(encryptedBytes);
                // Why convert to base 64?
                // Because it is the largest power-of-two base printable using only ASCII characters
                stringBuilder.Append(Convert.ToBase64String(encryptedBytes));
            }
            return stringBuilder.ToString();
        }

        public static string DecryptRSAString(string inputString, string key)
        {
            // TODO: Add Proper Exception Handlers

                RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(dwKeySize);
                rsaCryptoServiceProvider.FromXmlString(key);
                int base64BlockSize = ((dwKeySize / 8) % 3 != 0) ? (((dwKeySize / 8) / 3) * 4) + 4 : ((dwKeySize / 8) / 3) * 4;
                int iterations = inputString.Length / base64BlockSize;
                ArrayList arrayList = new ArrayList();
                for (int i = 0; i < iterations; i++)
                {
                    byte[] encryptedBytes = Convert.FromBase64String(inputString.Substring(base64BlockSize * i, base64BlockSize));
                    // Be aware the RSACryptoServiceProvider reverses the order of encrypted bytes after encryption and before decryption.
                    // If you do not require compatibility with Microsoft Cryptographic API (CAPI) and/or other vendors.
                    // Comment out the next line and the corresponding one in the EncryptString function.
                    Array.Reverse(encryptedBytes);
                    arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(encryptedBytes, true));
                }
                return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
          
        }

        //public void Dispose()
        //{
        //    RSAData = string.Empty;
        //    dwKeySize = 0;
        //}

        /*public static void AssignNewKey()
        {
            RSA rsa = new RSACryptoServiceProvider(2048); // Generate a new 2048 bit RSA key

            string publicPrivateKeyXML = rsa.ToXmlString(true);
            string publicOnlyKeyXML = rsa.ToXmlString(false);
            // do stuff with keys...
        }*/

        public static string EncryptRSA(string text, string key)
        {
            RSACryptoServiceProvider rsaEncrypt = new RSACryptoServiceProvider();
            rsaEncrypt.FromXmlString(key);
            byte[] data = Encoding.UTF8.GetBytes(text);
            byte[] cipherdata = rsaEncrypt.Encrypt(data, false);
            string EData = Convert.ToBase64String(cipherdata);

            return EData;
        }

        public static string DecryptRSA(string text, string key)
        {
            RSACryptoServiceProvider rsaDecrypt = new RSACryptoServiceProvider();
            rsaDecrypt.FromXmlString(key);
            byte[] data = Encoding.UTF8.GetBytes(text);
            byte[] plaindata = rsaDecrypt.Decrypt(data, false);
            string DData = Encoding.UTF8.GetString(plaindata);

            return DData;
        }
    }       
}
