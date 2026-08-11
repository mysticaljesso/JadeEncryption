using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

// 12/08/2026 - 5:42AM

// The last final version of Jade Encryption 1.1.2 Its going to be called Jade Encryption Classic until final launch

// This is the main encryption functions, this is where the magic happens

// I replaced SimpleCrypt with JadeEncryption in the file header small change but makes it a final special fix

namespace JadeEncryption
{

    // These are the functions for encryption xD

    public class CryptoFunctions
    {
        private string password;
        private string filename;
        private double percentage;
        ProgressBar progress;





        public void init_progressbar(ProgressBar progress)
        {
            this.progress = progress;
        }

        public void update_progressbar(double value)
        {
            if (progress != null)
            {
                progress.Value = (int)value;
            }
        }



        private static object lockObject = new object();

        // we need a invoker, to change control windows from inside the thread.




        public void encrypt(ProgressBar progress)
        {
            // we do this to handle any errors

            try
            {


                lock (lockObject)
                {

                    SharpAESCrypt.SharpAESCrypt.Extension_CreatedByIdentifier = "JadeEncryption";
                    using (FileStream output = new FileStream(@filename + ".aes", FileMode.Create, FileAccess.ReadWrite))
                    {
                        SharpAESCrypt.SharpAESCrypt aesStream = new SharpAESCrypt.SharpAESCrypt(password, output, SharpAESCrypt.OperationMode.Encrypt);
                        // now we set the extension information

                        byte[] buffer = new byte[1024 * 4];

                        using (FileStream input = new FileStream(@filename, FileMode.Open, FileAccess.Read))
                        {

                            long fileLength = input.Length;
                            long totalBytes = 0;
                            int currentBlockSize = 0;

                            while ((currentBlockSize = input.Read(buffer, 0, buffer.Length)) != 0)
                            {
                                totalBytes += currentBlockSize;
                                percentage = (double)totalBytes * 100.0 / fileLength;
                                //update_progressbar(percentage);

                                MethodInvoker method = new MethodInvoker(() => progress.Value = (int)percentage);
                                progress.Invoke(method);


                                //progress.ProgressBar1.value

                                aesStream.Write(buffer, 0, currentBlockSize);
                            }

                            aesStream.FlushFinalBlock();

                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // return true if done




        }


        public void decrypt(ProgressBar progress)
        {

            // now we use try catch, in the event something bad happens <3

            try
            {



                lock (lockObject)
                {
                    SharpAESCrypt.SharpAESCrypt.Extension_CreatedByIdentifier = "JadeEncryption";

                    using (FileStream output = new FileStream(@filename.Replace(".aes", ""), FileMode.OpenOrCreate, FileAccess.ReadWrite))
                    {



                        byte[] buffer = new byte[1024 * 4];

                        Stream input = new FileStream(@filename, FileMode.Open, FileAccess.Read);
                        SharpAESCrypt.SharpAESCrypt aesStream = new SharpAESCrypt.SharpAESCrypt(password, input, SharpAESCrypt.OperationMode.Decrypt);
                        long fileLength = input.Length;
                        long totalBytes = 0;
                        int currentBlockSize = 0;



                        while ((currentBlockSize = aesStream.Read(buffer, 0, buffer.Length)) != 0)
                        {
                            totalBytes += currentBlockSize;
                            percentage = (double)totalBytes * 100.0 / fileLength;
                            MethodInvoker method = new MethodInvoker(() => progress.Value = (int)percentage);
                            progress.Invoke(method);
                            output.Write(buffer, 0, currentBlockSize);
                        }

                        input.Close();

                    }

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public void setFile(string filename)
        {
            this.filename = filename;
        }

        public void setPass(string password)
        {
            this.password = password;
        }


        public string AES_String_Encrypt(string input)
        {
            System.Security.Cryptography.RijndaelManaged AES = new System.Security.Cryptography.RijndaelManaged();
            System.Security.Cryptography.MD5CryptoServiceProvider Hash_AES = new System.Security.Cryptography.MD5CryptoServiceProvider();
            string encrypted = "";
            try
            {
                byte[] hash = new byte[32];
                byte[] temp = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = System.Security.Cryptography.CipherMode.ECB;
                System.Security.Cryptography.ICryptoTransform AESEncrypter = AES.CreateEncryptor();
                byte[] Buffer = System.Text.ASCIIEncoding.ASCII.GetBytes(input);
                encrypted = Convert.ToBase64String(AESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length));
                return encrypted;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }

        public string AES_String_Decrypt(string input)
        {
            System.Security.Cryptography.RijndaelManaged AES = new System.Security.Cryptography.RijndaelManaged();
            System.Security.Cryptography.MD5CryptoServiceProvider Hash_AES = new System.Security.Cryptography.MD5CryptoServiceProvider();
            string decrypted = "";
            try
            {
                byte[] hash = new byte[32];
                byte[] temp = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password));
                Array.Copy(temp, 0, hash, 0, 16);
                Array.Copy(temp, 0, hash, 15, 16);
                AES.Key = hash;
                AES.Mode = System.Security.Cryptography.CipherMode.ECB;
                System.Security.Cryptography.ICryptoTransform AESDecrypter = AES.CreateDecryptor();
                byte[] Buffer = Convert.FromBase64String(input);
                decrypted = System.Text.ASCIIEncoding.ASCII.GetString(AESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length));
                return decrypted;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }


    }
}
