namespace Cryptography_Assignment
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.gbRSA = new System.Windows.Forms.GroupBox();
            this.btnRSADecrypt = new System.Windows.Forms.Button();
            this.btnRSAEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCaesar = new System.Windows.Forms.GroupBox();
            this.btnCaesarDecrypt = new System.Windows.Forms.Button();
            this.btnCaesarEncrypt = new System.Windows.Forms.Button();
            this.gbVignere = new System.Windows.Forms.GroupBox();
            this.btnVignereDecrypt = new System.Windows.Forms.Button();
            this.btnVignereEncrypt = new System.Windows.Forms.Button();
            this.gbVernam = new System.Windows.Forms.GroupBox();
            this.btnVernamDecrypt = new System.Windows.Forms.Button();
            this.btnVernamEncrypt = new System.Windows.Forms.Button();
            this.gbSpecial = new System.Windows.Forms.GroupBox();
            this.btnSpecialDecrypt = new System.Windows.Forms.Button();
            this.btnSpecialEncrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbRSA.SuspendLayout();
            this.gbCaesar.SuspendLayout();
            this.gbVignere.SuspendLayout();
            this.gbVernam.SuspendLayout();
            this.gbSpecial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 33);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(612, 20);
            this.txtPath.TabIndex = 1;
            // 
            // gbRSA
            // 
            this.gbRSA.Controls.Add(this.btnRSADecrypt);
            this.gbRSA.Controls.Add(this.btnRSAEncrypt);
            this.gbRSA.Location = new System.Drawing.Point(12, 116);
            this.gbRSA.Name = "gbRSA";
            this.gbRSA.Size = new System.Drawing.Size(200, 83);
            this.gbRSA.TabIndex = 2;
            this.gbRSA.TabStop = false;
            this.gbRSA.Text = "RSA";
            // 
            // btnRSADecrypt
            // 
            this.btnRSADecrypt.Location = new System.Drawing.Point(6, 48);
            this.btnRSADecrypt.Name = "btnRSADecrypt";
            this.btnRSADecrypt.Size = new System.Drawing.Size(188, 23);
            this.btnRSADecrypt.TabIndex = 4;
            this.btnRSADecrypt.Text = "Decrypt";
            this.btnRSADecrypt.UseVisualStyleBackColor = true;
            this.btnRSADecrypt.Click += new System.EventHandler(this.btnRSADecrypt_Click);
            // 
            // btnRSAEncrypt
            // 
            this.btnRSAEncrypt.Location = new System.Drawing.Point(6, 19);
            this.btnRSAEncrypt.Name = "btnRSAEncrypt";
            this.btnRSAEncrypt.Size = new System.Drawing.Size(188, 23);
            this.btnRSAEncrypt.TabIndex = 3;
            this.btnRSAEncrypt.Text = "Encrypt";
            this.btnRSAEncrypt.UseVisualStyleBackColor = true;
            this.btnRSAEncrypt.Click += new System.EventHandler(this.btnRSAEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File path (Don\'t need to enter anything into this field):";
            // 
            // gbCaesar
            // 
            this.gbCaesar.Controls.Add(this.btnCaesarDecrypt);
            this.gbCaesar.Controls.Add(this.btnCaesarEncrypt);
            this.gbCaesar.Location = new System.Drawing.Point(218, 116);
            this.gbCaesar.Name = "gbCaesar";
            this.gbCaesar.Size = new System.Drawing.Size(200, 83);
            this.gbCaesar.TabIndex = 5;
            this.gbCaesar.TabStop = false;
            this.gbCaesar.Text = "Caesar";
            // 
            // btnCaesarDecrypt
            // 
            this.btnCaesarDecrypt.Location = new System.Drawing.Point(6, 48);
            this.btnCaesarDecrypt.Name = "btnCaesarDecrypt";
            this.btnCaesarDecrypt.Size = new System.Drawing.Size(188, 23);
            this.btnCaesarDecrypt.TabIndex = 4;
            this.btnCaesarDecrypt.Text = "Decrypt";
            this.btnCaesarDecrypt.UseVisualStyleBackColor = true;
            this.btnCaesarDecrypt.Click += new System.EventHandler(this.btnCaesarDecrypt_Click);
            // 
            // btnCaesarEncrypt
            // 
            this.btnCaesarEncrypt.Location = new System.Drawing.Point(6, 19);
            this.btnCaesarEncrypt.Name = "btnCaesarEncrypt";
            this.btnCaesarEncrypt.Size = new System.Drawing.Size(188, 23);
            this.btnCaesarEncrypt.TabIndex = 3;
            this.btnCaesarEncrypt.Text = "Encrypt";
            this.btnCaesarEncrypt.UseVisualStyleBackColor = true;
            this.btnCaesarEncrypt.Click += new System.EventHandler(this.btnCaesarEncrypt_Click);
            // 
            // gbVignere
            // 
            this.gbVignere.Controls.Add(this.btnVignereDecrypt);
            this.gbVignere.Controls.Add(this.btnVignereEncrypt);
            this.gbVignere.Location = new System.Drawing.Point(424, 116);
            this.gbVignere.Name = "gbVignere";
            this.gbVignere.Size = new System.Drawing.Size(200, 83);
            this.gbVignere.TabIndex = 6;
            this.gbVignere.TabStop = false;
            this.gbVignere.Text = "Vignere";
            // 
            // btnVignereDecrypt
            // 
            this.btnVignereDecrypt.Location = new System.Drawing.Point(6, 48);
            this.btnVignereDecrypt.Name = "btnVignereDecrypt";
            this.btnVignereDecrypt.Size = new System.Drawing.Size(188, 23);
            this.btnVignereDecrypt.TabIndex = 4;
            this.btnVignereDecrypt.Text = "Decrypt";
            this.btnVignereDecrypt.UseVisualStyleBackColor = true;
            this.btnVignereDecrypt.Click += new System.EventHandler(this.btnVignereDecrypt_Click);
            // 
            // btnVignereEncrypt
            // 
            this.btnVignereEncrypt.Location = new System.Drawing.Point(6, 19);
            this.btnVignereEncrypt.Name = "btnVignereEncrypt";
            this.btnVignereEncrypt.Size = new System.Drawing.Size(188, 23);
            this.btnVignereEncrypt.TabIndex = 3;
            this.btnVignereEncrypt.Text = "Encrypt";
            this.btnVignereEncrypt.UseVisualStyleBackColor = true;
            this.btnVignereEncrypt.Click += new System.EventHandler(this.btnVignereEncrypt_Click);
            // 
            // gbVernam
            // 
            this.gbVernam.Controls.Add(this.btnVernamDecrypt);
            this.gbVernam.Controls.Add(this.btnVernamEncrypt);
            this.gbVernam.Location = new System.Drawing.Point(12, 205);
            this.gbVernam.Name = "gbVernam";
            this.gbVernam.Size = new System.Drawing.Size(200, 83);
            this.gbVernam.TabIndex = 7;
            this.gbVernam.TabStop = false;
            this.gbVernam.Text = "Vernam";
            // 
            // btnVernamDecrypt
            // 
            this.btnVernamDecrypt.Location = new System.Drawing.Point(6, 48);
            this.btnVernamDecrypt.Name = "btnVernamDecrypt";
            this.btnVernamDecrypt.Size = new System.Drawing.Size(188, 23);
            this.btnVernamDecrypt.TabIndex = 4;
            this.btnVernamDecrypt.Text = "Decrypt";
            this.btnVernamDecrypt.UseVisualStyleBackColor = true;
            this.btnVernamDecrypt.Click += new System.EventHandler(this.btnVernamDecrypt_Click);
            // 
            // btnVernamEncrypt
            // 
            this.btnVernamEncrypt.Location = new System.Drawing.Point(6, 19);
            this.btnVernamEncrypt.Name = "btnVernamEncrypt";
            this.btnVernamEncrypt.Size = new System.Drawing.Size(188, 23);
            this.btnVernamEncrypt.TabIndex = 3;
            this.btnVernamEncrypt.Text = "Encrypt";
            this.btnVernamEncrypt.UseVisualStyleBackColor = true;
            this.btnVernamEncrypt.Click += new System.EventHandler(this.btnVernamEncrypt_Click);
            // 
            // gbSpecial
            // 
            this.gbSpecial.Controls.Add(this.btnSpecialDecrypt);
            this.gbSpecial.Controls.Add(this.btnSpecialEncrypt);
            this.gbSpecial.Location = new System.Drawing.Point(218, 205);
            this.gbSpecial.Name = "gbSpecial";
            this.gbSpecial.Size = new System.Drawing.Size(200, 83);
            this.gbSpecial.TabIndex = 8;
            this.gbSpecial.TabStop = false;
            this.gbSpecial.Text = "Special";
            // 
            // btnSpecialDecrypt
            // 
            this.btnSpecialDecrypt.Location = new System.Drawing.Point(6, 48);
            this.btnSpecialDecrypt.Name = "btnSpecialDecrypt";
            this.btnSpecialDecrypt.Size = new System.Drawing.Size(188, 23);
            this.btnSpecialDecrypt.TabIndex = 4;
            this.btnSpecialDecrypt.Text = "Decrypt";
            this.btnSpecialDecrypt.UseVisualStyleBackColor = true;
            // 
            // btnSpecialEncrypt
            // 
            this.btnSpecialEncrypt.Location = new System.Drawing.Point(6, 19);
            this.btnSpecialEncrypt.Name = "btnSpecialEncrypt";
            this.btnSpecialEncrypt.Size = new System.Drawing.Size(188, 23);
            this.btnSpecialEncrypt.TabIndex = 3;
            this.btnSpecialEncrypt.Text = "Encrypt";
            this.btnSpecialEncrypt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose cryptography algorithm:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cryptography_Assignment.Properties.Resources._6scI;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 14);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(424, 210);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 77);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 77);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(612, 20);
            this.txtKey.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter the key you would like to use for algorithm that require them:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 299);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbSpecial);
            this.Controls.Add(this.gbVernam);
            this.Controls.Add(this.gbVignere);
            this.Controls.Add(this.gbCaesar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbRSA);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Encrypt & decrypt algorithms:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.frmMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.frmMain_ResizeEnd);
            this.gbRSA.ResumeLayout(false);
            this.gbCaesar.ResumeLayout(false);
            this.gbVignere.ResumeLayout(false);
            this.gbVernam.ResumeLayout(false);
            this.gbSpecial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox gbRSA;
        private System.Windows.Forms.Button btnRSADecrypt;
        private System.Windows.Forms.Button btnRSAEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCaesar;
        private System.Windows.Forms.Button btnCaesarDecrypt;
        private System.Windows.Forms.Button btnCaesarEncrypt;
        private System.Windows.Forms.GroupBox gbVignere;
        private System.Windows.Forms.Button btnVignereDecrypt;
        private System.Windows.Forms.Button btnVignereEncrypt;
        private System.Windows.Forms.GroupBox gbVernam;
        private System.Windows.Forms.Button btnVernamDecrypt;
        private System.Windows.Forms.Button btnVernamEncrypt;
        private System.Windows.Forms.GroupBox gbSpecial;
        private System.Windows.Forms.Button btnSpecialDecrypt;
        private System.Windows.Forms.Button btnSpecialEncrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
    }
}

