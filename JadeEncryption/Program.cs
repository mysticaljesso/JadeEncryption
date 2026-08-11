using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Jade Encryption 1.1.2 — Final Classic Release
// ---------------------------------------------------------------
// This marks the final update to the original Jade Encryption codebase,
// first created in 2016. The legacy version now runs correctly under MSIX,
// with proper DLL path resolution and stable packaging.
//
// The long-standing issue where SharpAESCrypt.dll could not be located
// when deployed (due to MSIX sandboxing and working directory changes)
// has been fully resolved in this release.
//
// Classic Jade Encryption is now complete.
// Version 2.0 will be a brand new codebase, rebuilt from the ground up,
// and announced only when ready.
//
// Yes I am dropping obvious hints into my codebase there will be a version 2.0 and it will be the best damn thing you can imagine.

// © Jessica Amy, 2026 — Final release of Jade Encryption final version 1.1.2, the classic version of Jade Encryption. All rights reserved.
// Felicis Approved 2026

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
            string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SharpAESCrypt.dll");

            if (File.Exists(dllPath))
            {
                Application.Run(new Main());
            }
            else
            {
                MessageBox.Show("Encryption Library Missing", "Missing DLL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}