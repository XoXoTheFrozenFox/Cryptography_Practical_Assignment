using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;

namespace Cryptography_Assignment
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public void getStyle()
        {
            label1.Font = new Font(label1.Font, FontStyle.Underline);
            label2.Font = new Font(label2.Font, FontStyle.Underline);
            label3.Font = new Font(label2.Font, FontStyle.Underline);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Size = this.ClientSize;
            txtPath.ReadOnly = true;
            this.Focus();
            txtPath.ForeColor = Color.Lime;
            txtPath.BorderStyle = BorderStyle.FixedSingle;
            txtPath.Font = new Font(txtPath.Font, FontStyle.Bold);
            txtKey.ForeColor = Color.Lime;
            txtKey.BorderStyle = BorderStyle.FixedSingle;
            txtKey.Font = new Font(txtPath.Font, FontStyle.Bold);
            btnCaesarEncrypt.Font = new Font(btnCaesarEncrypt.Font, FontStyle.Bold);
            btnCaesarDecrypt.Font = new Font(btnCaesarDecrypt.Font, FontStyle.Bold);
            btnVernamEncrypt.Font = new Font(btnVernamEncrypt.Font, FontStyle.Bold);
            btnVernamDecrypt.Font = new Font(btnVernamDecrypt.Font, FontStyle.Bold);
            btnRSAEncrypt.Font = new Font(btnRSAEncrypt.Font, FontStyle.Bold);
            btnRSADecrypt.Font = new Font(btnRSADecrypt.Font, FontStyle.Bold);
            btnVignereEncrypt.Font = new Font(btnVignereEncrypt.Font, FontStyle.Bold);
            btnVignereDecrypt.Font = new Font(btnVignereDecrypt.Font, FontStyle.Bold);
            btnSpecialEncrypt.Font = new Font(btnSpecialEncrypt.Font, FontStyle.Bold);
            btnSpecialDecrypt.Font = new Font(btnSpecialDecrypt.Font, FontStyle.Bold);
            btnExit.Font = new Font(btnExit.Font, FontStyle.Bold);
            txtPath.BackColor = Color.Gray;
            txtKey.BackColor = Color.Gray;
            btnCaesarEncrypt.BackColor = Color.Gray; // Set background color to gray
            btnCaesarDecrypt.BackColor = Color.Gray; // Set background color to gray
            btnRSAEncrypt.BackColor = Color.Gray; // Set background color to gray
            btnRSADecrypt.BackColor = Color.Gray; // Set background color to gray
            btnSpecialEncrypt.BackColor = Color.Gray; // Set background color to gray
            btnSpecialDecrypt.BackColor = Color.Gray; // Set background color to gray
            btnVignereEncrypt.BackColor = Color.Gray;
            btnVignereDecrypt.BackColor = Color.Gray;
            btnVernamEncrypt.BackColor = Color.Gray;
            btnVernamDecrypt.BackColor = Color.Gray;
            btnExit.BackColor = Color.Gray;
            this.BackColor = Color.Black;
            gbCaesar.ForeColor = Color.Lime; // Assuming NeonGreen is defined as Color.Lime
            gbRSA.ForeColor = Color.Lime; // Assuming NeonGreen is defined as Color.Lime
            gbVernam.ForeColor = Color.Lime; // Assuming NeonGreen is defined as Color.Lime
            gbVignere.ForeColor = Color.Lime; // Assuming NeonGreen is defined as Color.Lime
            gbSpecial.ForeColor = Color.Lime; // Assuming NeonGreen is defined as Color.Lime
            label1.ForeColor = Color.Lime; // Assuming NeonGreen is defined as Color.Lime
            label2.ForeColor = Color.Lime; // Assuming NeonGreen is defined as Color.Lime
            label3.ForeColor = Color.Lime; // Assuming NeonGreen is defined as Color.Lime
            btnExit.ForeColor = Color.Lime;
            RemoveButtonBorder(btnCaesarEncrypt);
            RemoveButtonBorder(btnCaesarDecrypt);
            RemoveButtonBorder(btnRSAEncrypt);
            RemoveButtonBorder(btnRSADecrypt);
            RemoveButtonBorder(btnSpecialEncrypt);
            RemoveButtonBorder(btnSpecialDecrypt);
            RemoveButtonBorder(btnVignereEncrypt);
            RemoveButtonBorder(btnVignereDecrypt);
            RemoveButtonBorder(btnVernamEncrypt);
            RemoveButtonBorder(btnVernamDecrypt);
            RemoveButtonBorder(btnExit);
            pictureBox1.SendToBack();
        }
        private void RemoveButtonBorder(System.Windows.Forms.Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

        public String getPath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "All files (*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return "";
        }
        //RSA 1
        public class RSAEncryption
        {
            private static RSAParameters publicKey;
            private static RSAParameters privateKey;

            public static void GenerateRSAKeys()
            {
                using (var rsa = new RSACryptoServiceProvider(2048))
                {
                    publicKey = rsa.ExportParameters(false);
                    privateKey = rsa.ExportParameters(true);
                }
            }

            public static byte[] EncryptRSA(byte[] data)
            {
                using (var rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(publicKey);
                    return rsa.Encrypt(data, RSAEncryptionPadding.Pkcs1);
                }
            }

            public static byte[] DecryptRSA(byte[] data, RSAParameters privateKey)
            {
                using (var rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(privateKey);

                    int blockSize = rsa.KeySize / 8; // Block size for RSA decryption

                    // Create a MemoryStream to store the decrypted data
                    using (MemoryStream decryptedStream = new MemoryStream())
                    {
                        int bytesRead = 0;
                        int offset = 0;

                        // Decrypt each block separately
                        while (offset < data.Length)
                        {
                            byte[] blockToDecrypt = new byte[blockSize];
                            bytesRead = Math.Min(blockSize, data.Length - offset);
                            Array.Copy(data, offset, blockToDecrypt, 0, bytesRead);

                            // Decrypt the block and write it to the MemoryStream
                            byte[] decryptedBlock = rsa.Decrypt(blockToDecrypt, RSAEncryptionPadding.Pkcs1);
                            decryptedStream.Write(decryptedBlock, 0, decryptedBlock.Length);

                            offset += bytesRead;
                        }

                        // Return the decrypted data as a byte array
                        return decryptedStream.ToArray();
                    }
                }
            }

            public static void EncryptFileRSA(string inputFile, string outputFile)
            {
                GenerateRSAKeys(); // Generate RSA keys before encryption

                byte[] dataToEncrypt = File.ReadAllBytes(inputFile);
                List<byte[]> encryptedBlocks = new List<byte[]>();

                int blockSize = (publicKey.Modulus.Length / 8) - 11; // Calculate the maximum block size for RSA encryption

                // Encrypt each block separately
                for (int i = 0; i < dataToEncrypt.Length; i += blockSize)
                {
                    int remainingBytes = Math.Min(blockSize, dataToEncrypt.Length - i);
                    byte[] blockToEncrypt = new byte[remainingBytes];
                    Array.Copy(dataToEncrypt, i, blockToEncrypt, 0, remainingBytes);

                    byte[] encryptedBlock = EncryptRSA(blockToEncrypt);
                    encryptedBlocks.Add(encryptedBlock);
                }

                // Concatenate all encrypted blocks
                byte[] encryptedData = encryptedBlocks.SelectMany(x => x).ToArray();
                File.WriteAllBytes(outputFile, encryptedData);
            }

            public static void DecryptFileRSA(string inputFile, string outputFile)
            {
                byte[] dataToDecrypt = File.ReadAllBytes(inputFile);
                byte[] decryptedData = DecryptRSA(dataToDecrypt, privateKey);
                File.WriteAllBytes(outputFile, decryptedData);
            }

        }

        private string GetDownloadsFolderPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\";
        }

        private void btnRSAEncrypt_Click(object sender, EventArgs e)
        {
            string inputFile = getPath();
            txtPath.Text = inputFile;
            txtPath.Text = inputFile;
            string encryptedFile = GetDownloadsFolderPath() + "RSAEncrypted.bin"; // Save to Downloads folder
            RSAEncryption.EncryptFileRSA(inputFile, encryptedFile);
            MessageBox.Show("File encrypted using RSA successfully.");
        }

        private void btnRSADecrypt_Click(object sender, EventArgs e)
        {
            string encryptedFile = getPath();
            txtPath.Text = encryptedFile;
            string decryptedFile = GetDownloadsFolderPath() + "RSADecrypted.bin"; // Save to Downloads folder
            RSAEncryption.DecryptFileRSA(encryptedFile, decryptedFile);
            MessageBox.Show("File decrypted using RSA successfully.");
        }
        //Caesar 2
        private static byte CaesarCipher(byte inputByte, int key, bool encrypt)
        {
            if (encrypt)
            {
                // Encryption: Shift the byte value by the key
                return (byte)((inputByte + key) % 256);
            }
            else
            {
                // Decryption: Shift the byte value backwards by the key
                return (byte)((inputByte - key + 256) % 256);
            }
        }

        // Function to encrypt or decrypt a binary file using the Caesar cipher
        public static void EncryptDecryptBinaryFile(string inputFile, string outputFile, int key, bool encrypt)
        {
            // Open the input binary file for reading
            using (FileStream inputStream = new FileStream(inputFile, FileMode.Open))
            {
                // Create a new binary writer to write to the output file
                using (BinaryWriter outputFileWriter = new BinaryWriter(File.Open(outputFile, FileMode.Create)))
                {
                    // Read and process each byte in the input file
                    int byteRead;
                    while ((byteRead = inputStream.ReadByte()) != -1)
                    {
                        // Encrypt or decrypt the byte using the Caesar cipher
                        byte processedByte = CaesarCipher((byte)byteRead, key, encrypt);

                        // Write the processed byte to the output file
                        outputFileWriter.Write(processedByte);
                    }
                }
            }

            Console.WriteLine(encrypt ? "File encrypted successfully." : "File decrypted successfully.");
        }
        //3 Vignere
        public static void VigenereEncryptBinaryFile(string inputFile, string outputFile, string key)
        {
            // Read all bytes from the input file
            byte[] dataToEncrypt = File.ReadAllBytes(inputFile);
            byte[] encryptedData = new byte[dataToEncrypt.Length];

            // Perform Vigenere encryption
            for (int i = 0; i < dataToEncrypt.Length; i++)
            {
                // Apply the Vigenere cipher algorithm
                encryptedData[i] = (byte)(dataToEncrypt[i] + key[i % key.Length]);
            }

            // Write the encrypted data to the output file
            File.WriteAllBytes(outputFile, encryptedData);
            MessageBox.Show("File encrypted using Vigenere cipher successfully.");
        }

        public static void VigenereDecryptBinaryFile(string inputFile, string outputFile, string key)
        {
            // Read all bytes from the input file
            byte[] dataToDecrypt = File.ReadAllBytes(inputFile);
            byte[] decryptedData = new byte[dataToDecrypt.Length];

            // Perform Vigenere decryption
            for (int i = 0; i < dataToDecrypt.Length; i++)
            {
                // Apply the Vigenere cipher algorithm
                decryptedData[i] = (byte)(dataToDecrypt[i] - key[i % key.Length]);
            }

            // Write the decrypted data to the output file
            File.WriteAllBytes(outputFile, decryptedData);
            MessageBox.Show("File decrypted using Vigenere cipher successfully.");
        }
        public static void VernamEncryptBinaryFile(string inputFile, string outputFile, string key)
        {
            // Read all bytes from the input file
            byte[] dataToEncrypt = File.ReadAllBytes(inputFile);
            byte[] encryptedData = new byte[dataToEncrypt.Length];

            // Perform Vernam encryption
            for (int i = 0; i < dataToEncrypt.Length; i++)
            {
                // Apply the Vernam cipher algorithm
                encryptedData[i] = (byte)(dataToEncrypt[i] ^ key[i % key.Length]);
            }

            // Write the encrypted data to the output file
            File.WriteAllBytes(outputFile, encryptedData);
            MessageBox.Show("File encrypted using Vernam cipher successfully.");
        }
        //4 Vernam
        public static void VernamDecryptBinaryFile(string inputFile, string outputFile, string key)
        {
            // Read all bytes from the input file
            byte[] dataToDecrypt = File.ReadAllBytes(inputFile);
            byte[] decryptedData = new byte[dataToDecrypt.Length];

            // Perform Vernam decryption (same as encryption because it's symmetric)
            for (int i = 0; i < dataToDecrypt.Length; i++)
            {
                // Apply the Vernam cipher algorithm
                decryptedData[i] = (byte)(dataToDecrypt[i] ^ key[i % key.Length]);
            }

            // Write the decrypted data to the output file
            File.WriteAllBytes(outputFile, decryptedData);
            MessageBox.Show("File decrypted using Vernam cipher successfully.");
        }
        private void btnCaesarEncrypt_Click(object sender, EventArgs e)
        {
            string inputFile = getPath();
            string outputFile = GetDownloadsFolderPath() + "CaesarEncrypted.bin"; // Save to Downloads folder
            int key;
            if (!int.TryParse(txtKey.Text, out key))
            {
                MessageBox.Show("This is not a valid integer key for the caesar cipher.");
                return; // Exit the method if parsing fails
            }
            else
            {
                EncryptDecryptBinaryFile(inputFile, outputFile, key, true);
                MessageBox.Show("File encrypted using Caesar cipher successfully.");
            }
        }

        private void btnCaesarDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedFile = getPath();
            string decryptedFile = GetDownloadsFolderPath() + "CaesarDecrypted.bin"; // Save to Downloads folder
            int key;
            if (!int.TryParse(txtKey.Text, out key))
            {
                MessageBox.Show("This is not a valid integer key for the caesar cipher.");
                return; // Exit the method if parsing fails
            }
            else
            {
                EncryptDecryptBinaryFile(encryptedFile, decryptedFile, key, false);
                MessageBox.Show("File decrypted using Caesar cipher successfully.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getStyle();
        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Width; 
            pictureBox1.Height = this.Height;
        }

        private void frmMain_ResizeBegin(object sender, EventArgs e)
        {
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVignereEncrypt_Click(object sender, EventArgs e)
        {
            string inputFile = getPath();
            string outputFile = GetDownloadsFolderPath() + "VigenereEncrypted.bin"; // Save to Downloads folder
            string key = txtKey.Text;
            if (txtKey.Text.Length == 0)
            {
                MessageBox.Show("Please enter a string key.");
            }
            else
            {
                VigenereEncryptBinaryFile(inputFile, outputFile, key);
            }
        }

        private void btnVignereDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedFile = getPath();
            string decryptedFile = GetDownloadsFolderPath() + "VigenereDecrypted.bin"; // Save to Downloads folder
            string key = txtKey.Text;
            if(txtKey.Text.Length == 0)
            {
                MessageBox.Show("Please enter a string key.");
            }
            else
            {
                VigenereDecryptBinaryFile(encryptedFile, decryptedFile, key);
            }
        }

        private void btnVernamEncrypt_Click(object sender, EventArgs e)
        {
            string inputFile = getPath();
            string outputFile = GetDownloadsFolderPath() + "VernamEncrypted.bin"; // Save to Downloads folder
            string key = txtKey.Text;
            if (txtKey.Text.Length == 0)
            {
                MessageBox.Show("Please enter a string key.");
            }
            else
            {
                VernamEncryptBinaryFile(inputFile, outputFile, key);
            }
        }

        private void btnVernamDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedFile = getPath();
            string decryptedFile = GetDownloadsFolderPath() + "VernamDecrypted.bin"; // Save to Downloads folder
            string key = txtKey.Text;
            if (txtKey.Text.Length == 0)
            {
                MessageBox.Show("Please enter a string key.");
            }
            else
            {
                VernamDecryptBinaryFile(encryptedFile, decryptedFile, key);
            }
            
        }
    }
}
