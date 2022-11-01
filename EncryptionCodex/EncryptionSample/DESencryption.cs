using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Configuration;
using System.IO;
using System.Collections;

namespace EncryptionCodex.Encryptionsample
{
    class DESencryption
    {
        static byte[] DESbytes = ASCIIEncoding.ASCII.GetBytes("12345678");
        /// <summary>
        /// The is encryption for DES, DES require exactly 8 character as key to decrypt. while 3DES is triple of DES bit requirement.
        /// 3DES in this sourcecode us MD5 to hash the key
        /// </summary>
        /// <param name="toEncrypt"></param>
        /// <param name="useHashing"></param>
        /// <param name="keyhere"></param>
        /// <returns></returns>

        /* public static string DESEncrypt(string originalString, string keyhere)
       {
           //System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
           //Get your key from config file to open the lock!
           //string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));

           //string key = SourceCodeKey;
           if (String.IsNullOrEmpty(originalString))
           {
               throw new ArgumentNullException
                      ("The string which needs to be encrypted can not be null.");
           }
           DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
           MemoryStream memoryStream = new MemoryStream();
           CryptoStream cryptoStream = new CryptoStream(memoryStream,cryptoProvider.CreateEncryptor(DESbytes, DESbytes), CryptoStreamMode.Write);
           StreamWriter writer = new StreamWriter(cryptoStream);
           writer.Write(originalString);
           writer.Flush();
           cryptoStream.FlushFinalBlock();
           writer.Flush();
           return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
       }*/

        /* public static string DESDecrypt(string cryptedString,string keyhere)
         {
             //System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
             //Get your key from config file to open the lock!
             //string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));

             //string key = SourceCodeKey;
             if (String.IsNullOrEmpty(cryptedString))
             {
                 throw new ArgumentNullException
                    ("The string which needs to be decrypted can not be null.");
             }
             DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
             MemoryStream memoryStream = new MemoryStream
             (Convert.FromBase64String(cryptedString));
             CryptoStream cryptoStream = new CryptoStream(memoryStream,cryptoProvider.CreateDecryptor(DESbytes, DESbytes), CryptoStreamMode.Read);
             StreamReader reader = new StreamReader(cryptoStream);
             return reader.ReadToEnd();
         }*/

        public static string DESEncrypt(string toEncrypt, string key)
        {
            //byte[] keyArray = DESbytes;
            byte[] keyArray = ASCIIEncoding.ASCII.GetBytes(key);
            byte[] toEncryptArray = ASCIIEncoding.ASCII.GetBytes(toEncrypt);

            DESCryptoServiceProvider tdes = new DESCryptoServiceProvider();
            //tdes.Key = DESbytes;
            tdes.Key = keyArray;
            tdes.IV = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string DESDecrypt(string toDecrypt, string key)
        {
            //byte[] keyArray = DESbytes;
            byte[] keyArray = ASCIIEncoding.ASCII.GetBytes(key);
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            DESCryptoServiceProvider tdes = new DESCryptoServiceProvider();
            //tdes.Key = DESbytes;
            tdes.Key = keyArray;
            tdes.IV = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            tdes.Clear();
            return ASCIIEncoding.ASCII.GetString(resultArray);
        }

        public static string Encrypt3DES(string toEncrypt, bool useHashing, string keyhere)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            //System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
            // Get the key from config file
            //string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));
            //System.Windows.Forms.MessageBox.Show(key);
            string key = keyhere;
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
            {
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            }
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }// use MD5 to hash password

        public static string Decrypt3DES(string cipherString, bool useHashing, string keyhere)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(cipherString);

            //System.Configuration.AppSettingsReader settingsReader = new AppSettingsReader();
            //Get your key from config file to open the lock!
            //string key = (string)settingsReader.GetValue("SecurityKey", typeof(String));
            string key = keyhere;
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            else
            {
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            }
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            tdes.Clear();
            return UTF8Encoding.UTF8.GetString(resultArray);
        }//use MD5 to has password
    }
}
