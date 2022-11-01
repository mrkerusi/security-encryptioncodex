using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace EncryptionCodex
{
    public partial class EncryptionCodex : Form
    {
        //string in and out
        string textin;
        string textout;
        
        public EncryptionCodex()
        {
            InitializeComponent();
        }

        private void EncodeBase64_Click(object sender, EventArgs e)
        {
            textin = stringin.Text;
            //stringout.Text = CryptoEngine.Base64Encode(textin);
            stringout.Text = EncodeSample.Base64.Base64Encode(textin);
        }

        private void DecodeBase64_Click(object sender, EventArgs e)
        {
            textin = stringin.Text;
            //stringout.Text = CryptoEngine.Base64Decode(textin);
            stringout.Text = EncodeSample.Base64.Base64Decode(textin);
        }

        private void reverse_Click(object sender, EventArgs e)
        {
            textin = stringin.Text;
            stringout.Text = new string(textin.ToCharArray().Reverse().ToArray());
        }

        private void DES3_Encrypt_Click(object sender, EventArgs e)
        {
            if (DES3Key.Text != "")
            {
                textin = stringin.Text;
                //stringout.Text = CryptoEngine.Encrypt3DES(textin, true, DES3Key.Text);
                stringout.Text = Encryptionsample.DESencryption.Encrypt3DES(textin, true, DES3Key.Text);
            }
            else
                MessageBox.Show("3DES Key Cannot be Null!");
        }

        private void DES3_Decrypt_Click(object sender, EventArgs e)
        {
            if (DES3Key.Text != "")
            {
                textin = stringin.Text;
                //stringout.Text = CryptoEngine.Decrypt3DES(textin, true, DES3Key.Text);
                stringout.Text = Encryptionsample.DESencryption.Decrypt3DES(textin, true, DES3Key.Text);
            }
            else
                MessageBox.Show("3DES Key Cannot be Null!");
        }

        private void AESEncrypt_Click(object sender, EventArgs e)
        {
            if (!(AESKey.Text == ""))
            {
                textin = stringin.Text;
                //stringout.Text = CryptoEngine.EncryptAES128(textin, AESKey.Text);
                stringout.Text = Encryptionsample.AESencryption.EncryptAES128(textin, AESKey.Text);
            }
            else
                MessageBox.Show("AES Key Cannot be Null!");
        }

        private void AESDecrypt_Click(object sender, EventArgs e)
        {

            if (!(AESKey.Text == ""))
            {
                textin = stringin.Text;
                //stringout.Text = CryptoEngine.DecryptAES128(textin, AESKey.Text);
                stringout.Text = Encryptionsample.AESencryption.DecryptAES128(textin, AESKey.Text);
            }
            else
                MessageBox.Show("AES Key Cannot be Null!");
        }

        private void MD5Hash_Click(object sender, System.EventArgs e)
        {
            textin = stringin.Text;
            //stringout.Text = CryptoEngine.MD5Hash(textin);
            stringout.Text = HashingSample.MD5hash.MD5Hash(textin);
        }

        private void SHA1Hash_Click(object sender, System.EventArgs e)
        {
            textin = stringin.Text;
            //stringout.Text = CryptoEngine.SHA1Hash(textin);
            stringout.Text = HashingSample.SHAhash.SHA1Hash(textin);
        }

        private void SHA256Hash_Click(object sender, System.EventArgs e)
        {
            textin = stringin.Text;
            //stringout.Text = CryptoEngine.SHA256Hash(textin);
            stringout.Text = HashingSample.SHAhash.SHA256Hash(textin);
        }

        private void SHA512Hash_Click(object sender, System.EventArgs e)
        {
            textin = stringin.Text;
            //stringout.Text = CryptoEngine.SHA512Hash(textin);
            stringout.Text = HashingSample.SHAhash.SHA512Hash(textin);
        }

        private void MoveString_Click(object sender, System.EventArgs e)
        {
            textout = stringout.Text;
            stringout.Clear();
            stringin.Text = textout;
        }

        private void AES256Encrypt_Click(object sender, System.EventArgs e)
        {
            if (!(AESKey.Text == ""))
            {
                textin = stringin.Text;
                //stringout.Text = CryptoEngine.EncryptTextAES256(textin, AESKey.Text);
                stringout.Text = Encryptionsample.AESencryption.EncryptTextAES256(textin, AESKey.Text);
            }
            else
                MessageBox.Show("AES Key Cannot be Null!");
        }

        private void AES256Decrypt_Click(object sender, System.EventArgs e)
        {
            if (!(AESKey.Text == ""))
            {
                textin = stringin.Text;
                //stringout.Text = CryptoEngine.DecryptTextAES256(textin, AESKey.Text);
                stringout.Text = Encryptionsample.AESencryption.DecryptTextAES256(textin, AESKey.Text);
            }
            else
                MessageBox.Show("AES Key Cannot be Null!");
        }

        private void DESEncrypt_Click(object sender, System.EventArgs e)
        {
            if (!(DES3Key.Text == ""))
            {
                if ((DES3Key.Text.Length == 8))
                {
                    textin = stringin.Text;
                    //stringout.Text = CryptoEngine.DESEncrypt(textin, DES3Key.Text);
                    stringout.Text = Encryptionsample.DESencryption.DESEncrypt(textin, DES3Key.Text);
                }
                else
                    MessageBox.Show("DES Key Has to be exactly 64-bits/8-bytes = 8 Character");
            }
            else
                MessageBox.Show("AES Key Cannot be Null!");
        }

        private void DESDecrypt_Click(object sender, System.EventArgs e)
        {
            if (!(DES3Key.Text == ""))
            {
                if ((DES3Key.Text.Length == 8))
                {
                    textin = stringin.Text;
                    //stringout.Text = CryptoEngine.DESDecrypt(textin, DES3Key.Text);
                    stringout.Text = Encryptionsample.DESencryption.DESDecrypt(textin, DES3Key.Text);
                }
                else
                    MessageBox.Show("DES Key Has to be exactly 64-bits/8-bytes = 8 Character");
            }
            else
                MessageBox.Show("AES Key Cannot be Null!");
            
        }

        private void RandomStringGeneratorAES_Click(object sender, EventArgs e)
        {
            //AESKey.Text = CryptoEngine.GetRandomString();
            AESKey.Text = RandomCharGenerator.RandomString.GetRandomString();
        }

        private void RandomStringGeneratorDES3_Click(object sender, EventArgs e)
        {
            //DES3Key.Text = CryptoEngine.GetRandomString();
            DES3Key.Text = RandomCharGenerator.RandomString.GetRandomString();
        }

        private void PRNGAES_Click(object sender, EventArgs e)
        {
            //AESKey.Text = CryptoEngine.PRNG();
            AESKey.Text = RandomCharGenerator.PRandomNumberGenerator.PRNG();
        }

        private void PRNGDES3_Click(object sender, EventArgs e)
        {
            //DES3Key.Text = CryptoEngine.PRNG();
            DES3Key.Text = RandomCharGenerator.PRandomNumberGenerator.PRNG();
        }

        private void RSAEncrypt_Click(object sender, EventArgs e)
        {
            textin = stringin.Text;
            //stringout.Text = CryptoEngine.EncryptRSAString(textin);
            stringout.Text = Encryptionsample.RSAencryption.EncryptRSAString(textin, textBoxPb.Text.ToString());
            //stringout.Text = Encryptionsample.RSAencryption.EncryptRSA(textin, textBoxPb.Text.ToString());
        }

        private void RSADecrypt_Click(object sender, EventArgs e)
        {
            textin = stringin.Text;
            //stringout.Text = CryptoEngine.DecryptRSAString(textin);
            stringout.Text = Encryptionsample.RSAencryption.DecryptRSAString(textin, textBoxPv.Text.ToString());
            //stringout.Text = Encryptionsample.RSAencryption.DecryptRSA(textin, textBoxPv.Text.ToString()); 
        }

        private void PublicPrivateKeyGenerator_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024); // Generate a new 2048 bit RSA key

            string publicOnlyKeyXML = rsa.ToXmlString(false);
            string PrivateKeyXML = rsa.ToXmlString(true);

            textBoxPb.Text = publicOnlyKeyXML;
            textBoxPv.Text = PrivateKeyXML;

            if (PrivateKeyXML == publicOnlyKeyXML)
            {
                MessageBox.Show("Public and Private is the Same");
            }
            else
            {
                MessageBox.Show("Public and Private is Not the Same!");
                RSAe.Enabled = true;
                RSAd.Enabled = true;
            }
            
        }

        private void EncryptionCodex_Load(object sender, EventArgs e)
        {
            RSAe.Enabled = false;
            RSAd.Enabled = false;
        }

    }
}
