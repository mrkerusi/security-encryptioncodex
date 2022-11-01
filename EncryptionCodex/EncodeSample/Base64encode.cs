using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionCodex.EncodeSample
{
    class Base64
    {
        /// <summary>
        /// This is the encoding Sourcecode, to change strings but still can be decode to get the real strings
        /// </summary>
        /// <param name="plaintext"></param>
        /// <returns></returns>
        
        public static string Base64Encode(string plaintext)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plaintext);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
