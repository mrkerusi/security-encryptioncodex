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
    class RandomString
    {
        public static string GetRandomString()
        {
            string path = Path.GetRandomFileName();
            path = path.Replace(".", ""); // Remove period.
            return path;
        }//Generate random Strings 11 character
    }
}
