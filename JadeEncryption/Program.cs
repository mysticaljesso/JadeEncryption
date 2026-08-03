using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JadeEncryption
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists("SharpAESCrypt.dll")){
                Application.Run(new Main());
            }else
            {
                MessageBox.Show("Encryption Library Missing", "Missing DLL", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
