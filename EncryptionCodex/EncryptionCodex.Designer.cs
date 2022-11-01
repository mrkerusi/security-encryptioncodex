namespace EncryptionCodex
{
    partial class EncryptionCodex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stringin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button19 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.AESKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.DES3Key = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.reverse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RSAe = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.stringout = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.RSAd = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPv = new System.Windows.Forms.TextBox();
            this.textBoxPb = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // stringin
            // 
            this.stringin.Location = new System.Drawing.Point(22, 49);
            this.stringin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stringin.Multiline = true;
            this.stringin.Name = "stringin";
            this.stringin.Size = new System.Drawing.Size(314, 136);
            this.stringin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text Input Here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text Encrypted/Decrypted:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.AESKey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(363, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(369, 168);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt/Encode";
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(186, 31);
            this.button19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(174, 35);
            this.button19.TabIndex = 14;
            this.button19.Text = "Get PRNG";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.PRNGAES_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(186, 75);
            this.button16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(174, 35);
            this.button16.TabIndex = 13;
            this.button16.Text = "Get Random String";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.RandomStringGeneratorAES_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(32, 75);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(146, 35);
            this.button10.TabIndex = 12;
            this.button10.Text = "AES256";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.AES256Encrypt_Click);
            // 
            // AESKey
            // 
            this.AESKey.Location = new System.Drawing.Point(87, 120);
            this.AESKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AESKey.Name = "AESKey";
            this.AESKey.Size = new System.Drawing.Size(222, 26);
            this.AESKey.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Key :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 31);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "AES128";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AESEncrypt_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(32, 29);
            this.button15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(146, 35);
            this.button15.TabIndex = 13;
            this.button15.Text = "DES";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.DESEncrypt_Click);
            // 
            // DES3Key
            // 
            this.DES3Key.Location = new System.Drawing.Point(87, 112);
            this.DES3Key.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DES3Key.Name = "DES3Key";
            this.DES3Key.Size = new System.Drawing.Size(222, 26);
            this.DES3Key.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Key :";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(32, 69);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 35);
            this.button5.TabIndex = 3;
            this.button5.Text = "3DES";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.DES3_Encrypt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "EnBase64";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.EncodeBase64_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(208, 29);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 35);
            this.button8.TabIndex = 5;
            this.button8.Text = "SHA1";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.SHA1Hash_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(38, 29);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 35);
            this.button7.TabIndex = 4;
            this.button7.Text = "MD5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.MD5Hash_Click);
            // 
            // reverse
            // 
            this.reverse.Location = new System.Drawing.Point(135, 446);
            this.reverse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reverse.Name = "reverse";
            this.reverse.Size = new System.Drawing.Size(96, 60);
            this.reverse.TabIndex = 1;
            this.reverse.Text = "Reverse String";
            this.reverse.UseVisualStyleBackColor = true;
            this.reverse.Click += new System.EventHandler(this.reverse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button18);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(741, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(382, 131);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decrypt/Decode";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(206, 75);
            this.button18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(160, 35);
            this.button18.TabIndex = 6;
            this.button18.Text = "DES";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.DESDecrypt_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(38, 75);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(160, 35);
            this.button9.TabIndex = 5;
            this.button9.Text = "AES256";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.AES256Decrypt_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(206, 29);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 35);
            this.button6.TabIndex = 4;
            this.button6.Text = "3DES";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.DES3_Decrypt_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 31);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "AES128";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.AESDecrypt_Click);
            // 
            // RSAe
            // 
            this.RSAe.Location = new System.Drawing.Point(36, 40);
            this.RSAe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RSAe.Name = "RSAe";
            this.RSAe.Size = new System.Drawing.Size(160, 35);
            this.RSAe.TabIndex = 7;
            this.RSAe.Text = "RSAe";
            this.RSAe.UseVisualStyleBackColor = true;
            this.RSAe.Click += new System.EventHandler(this.RSAEncrypt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 29);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "DeBase64";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.DecodeBase64_Click);
            // 
            // stringout
            // 
            this.stringout.Location = new System.Drawing.Point(18, 237);
            this.stringout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stringout.Multiline = true;
            this.stringout.Name = "stringout";
            this.stringout.Size = new System.Drawing.Size(319, 173);
            this.stringout.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button13);
            this.groupBox3.Controls.Add(this.button12);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Location = new System.Drawing.Point(739, 161);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(382, 133);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hashing";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(40, 76);
            this.button13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(160, 35);
            this.button13.TabIndex = 8;
            this.button13.Text = "SHA256";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.SHA256Hash_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(208, 76);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(160, 35);
            this.button12.TabIndex = 7;
            this.button12.Text = "SHA512";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.SHA512Hash_Click);
            // 
            // RSAd
            // 
            this.RSAd.Location = new System.Drawing.Point(206, 40);
            this.RSAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RSAd.Name = "RSAd";
            this.RSAd.Size = new System.Drawing.Size(160, 35);
            this.RSAd.TabIndex = 9;
            this.RSAd.Text = "RSAd";
            this.RSAd.UseVisualStyleBackColor = true;
            this.RSAd.Click += new System.EventHandler(this.RSADecrypt_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(18, 446);
            this.button14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(108, 60);
            this.button14.TabIndex = 8;
            this.button14.Text = "Move to Input";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.MoveString_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(240, 446);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(99, 60);
            this.button11.TabIndex = 9;
            this.button11.Text = "Clear";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.DES3Key);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(363, 203);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(369, 158);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DES Encryption";
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(186, 29);
            this.button20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(174, 35);
            this.button20.TabIndex = 15;
            this.button20.Text = "Get PRNG";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.PRNGDES3_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(186, 69);
            this.button17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(174, 34);
            this.button17.TabIndex = 14;
            this.button17.Text = "Get Random String";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.RandomStringGeneratorDES3_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Location = new System.Drawing.Point(363, 371);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(369, 88);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Encoding";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 469);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Note: Everything is compiled inside CrytoEngine.cs";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 491);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Content can be update for future";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.textBoxPv);
            this.groupBox6.Controls.Add(this.textBoxPb);
            this.groupBox6.Controls.Add(this.button23);
            this.groupBox6.Controls.Add(this.RSAd);
            this.groupBox6.Controls.Add(this.RSAe);
            this.groupBox6.Location = new System.Drawing.Point(739, 306);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(382, 207);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "RSA Implementation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Private:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Public:";
            // 
            // textBoxPv
            // 
            this.textBoxPv.Location = new System.Drawing.Point(98, 163);
            this.textBoxPv.Name = "textBoxPv";
            this.textBoxPv.ReadOnly = true;
            this.textBoxPv.Size = new System.Drawing.Size(268, 26);
            this.textBoxPv.TabIndex = 13;
            // 
            // textBoxPb
            // 
            this.textBoxPb.Location = new System.Drawing.Point(98, 128);
            this.textBoxPb.Name = "textBoxPb";
            this.textBoxPb.ReadOnly = true;
            this.textBoxPb.Size = new System.Drawing.Size(268, 26);
            this.textBoxPb.TabIndex = 12;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(38, 85);
            this.button23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(328, 35);
            this.button23.TabIndex = 10;
            this.button23.Text = "RSAwKeyE/RSAwKeyD";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.PublicPrivateKeyGenerator_Click);
            // 
            // EncryptionCodex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 525);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.stringout);
            this.Controls.Add(this.reverse);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stringin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EncryptionCodex";
            this.Text = "EncryptionCodex";
            this.Load += new System.EventHandler(this.EncryptionCodex_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox stringin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox stringout;
        private System.Windows.Forms.Button reverse;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox DES3Key;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AESKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button RSAe;
        private System.Windows.Forms.Button RSAd;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPv;
        private System.Windows.Forms.TextBox textBoxPb;
    }
}

