using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;



// Jade Encryption - Main.cs
// Version 1.1.1
// Copyright © 2026 Jesso (Jessica Amy) All Rights Reserved
// Website: https://jessicaamy.com
// Contact: contact@jessicaamy.com
//
// After years of abandonment, I decided to revive my first project
// and give it a proper update.
//
// This release is a small maintenance fix:
// - Updated project name and website references
// - Removed old Bitcoin-related code
// - General cleanup; stable and ready to use
//
// A major rewrite (v2.0) is in development.
// Felicis will consume an unreasonable amount of ham during the process.


namespace JadeEncryption
{
  
    public partial class Main : Form
    {


        // for drag and drop support

        // for temporary storage and checking, saves up time :D

        List<String> files = new List<String>();

        void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        // this deals with listviews

        void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData("FileDrop", false);

            try
            {

                // now loop though all files and add it to the ListView


                for (int i = 0; i <= s.Length - 1; i++)
                {

                    if (Directory.Exists(s[i]))
                    {

                        List<string> list = FileHelper.GetFilesRecursive(s[i]);
                        foreach (string path in list)
                        {


                            // this peice of code extracts the icon
                            // and than adds it to the listbox :D

                            // we doo a little check to see if the file exists but first we check if it is greater than 1

                            // we quickly check if the file exists
                            if (files.Contains(path.ToString()))
                            {
                                MessageBox.Show(path.ToString() + " already exists");
                            }
                            else
                            {
                                Icon iconForFile = SystemIcons.WinLogo;
                                ListViewItem item = new ListViewItem(path.ToString());
                                item.ImageIndex = 1;
                                iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(path.ToString());
                                imageList1.Images.Add(path.ToString(), iconForFile);
                                item.ImageKey = path.ToString();
                                item.Text = path.ToString();

                                files.Add(path.ToString());

                                // now to update the file count

                                ToolStripStatusLabel3.Text = ListView1.Items.Count.ToString();


                                ListView1.BeginUpdate();

                                if (path.EndsWith(".aes"))
                                {
                                    ListView1.Items.Add(item).SubItems.Add("Yes");
                                }
                                else
                                {
                                    ListView1.Items.Add(item).SubItems.Add("No");
                                }

                                ListView1.EndUpdate();
                            }
                        }
                    }


                    else
                    {

                        // must be a file, owell we will import it, yay... lets extract the files.

                        if (files.Contains(s[i].ToString()))
                        {
                            MessageBox.Show(s[i].ToString() + " already exists");
                        }
                        else
                        {

                            Icon iconForFile = SystemIcons.WinLogo;
                            ListViewItem item = new ListViewItem(s[i].ToString());
                            item.ImageIndex = 1;
                            iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(s[i].ToString());
                            imageList1.Images.Add(s[i].ToString(), iconForFile);
                            item.ImageKey = s[i].ToString();
                            item.Text = s[i].ToString();

                            files.Add(s[i].ToString());

                            // now to update the file count

                            ToolStripStatusLabel3.Text = ListView1.Items.Count.ToString();


                            ListView1.BeginUpdate();

                            if (s[i].EndsWith(".aes"))
                            {
                                ListView1.Items.Add(item).SubItems.Add("Yes");
                            }
                            else
                            {
                                ListView1.Items.Add(item).SubItems.Add("No");
                            }

                            ListView1.EndUpdate();
                        }
                    }
                    ToolStripStatusLabel3.Text = ListView1.Items.Count.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }




        private async void encrypt_files()
        {

            // handles crashes, we need this.. for now

            try
            {

                if (ListView1.Items.Count > 0)
                {
                    password passform = new password();

                    if (passform.ShowDialog(this) == DialogResult.OK)
                    {


                        int total_files = ListView1.Items.Count;
                        int files = 0;
                        foreach (ListViewItem item in ListView1.Items)
                        {
                            if (!item.Text.ToString().EndsWith("aes"))
                            {
                                Label6.Text = Path.GetFileName(item.Text.ToString());

                                // we have to setup cryptofunctions

                                CryptoFunctions encryption = new CryptoFunctions();
                                encryption.setFile(item.Text.ToString());
                                encryption.setPass(passform.MaskedTextBox1.Text.ToString());
                                //encryption.init_progressbar(ProgressBar1);


                                await Task.Run(() =>
                                {
                                    encryption.encrypt(ProgressBar1);
                                });




                                files = files + 1;

                                //File.Delete(item.Text.ToString());


                                ProgressBar2.Value = (int)(files / ListView1.Items.Count) * 100;



                            }

                        }



                        // loop though listview and remove anything amd update everything

                        foreach (ListViewItem item in ListView1.Items)
                        {
                            for (int i = 0; i < ListView1.Items.Count; i++)
                            {
                                // checks if the filename in the list box doesn't edit with .aes
                                if (!ListView1.Items[i].Text.EndsWith("aes"))
                                {
                                    // okay passed the check, lets add .encrypt to the filename
                                    // also delete the original file
                                    string filename = ListView1.Items[i].Text.ToString();
                                    File.Delete(filename);

                                    ListView1.BeginUpdate();

                                    ListView1.Items.RemoveAt(i);
                                    //  laod icon and add it to the list view;
                                    Icon iconForFile = SystemIcons.WinLogo;
                                    ListViewItem item_fixed = new ListViewItem(filename + ".aes", 1);
                                    item_fixed.ImageIndex = 1;
                                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(filename + ".aes");


                                    imageList1.Images.Add(filename + ".aes", iconForFile);
                                    item_fixed.ImageKey = filename + ".aes";
                                    item_fixed.Text = filename + ".aes".ToString();
                                    ListView1.Items.Add(item_fixed).SubItems.Add("Yes");
                                    ListView1.EndUpdate();



                                }
                            }
                        }

                        MessageBox.Show("Encryption Successful");



                        // reset the progress barss

                        ProgressBar1.Value = 0;
                        ProgressBar2.Value = 0;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // this is a global function for decrypting files

        private async void decrypt_files()
        {
            try
            {
                if (ListView1.Items.Count > 0)
                {
                    password passform = new password();
                    if (passform.ShowDialog(this) == DialogResult.OK)
                    {


                        int total_files = ListView1.Items.Count;
                        int files = 0;
                        foreach (ListViewItem item in ListView1.Items)
                        {
                            if (item.Text.ToString().EndsWith("aes"))
                            {
                                Label6.Text = Path.GetFileName(item.Text.ToString());
                                // we have to setup the crypto functions

                                CryptoFunctions encryption = new CryptoFunctions();

                                encryption.setFile(item.Text.ToString());
                                encryption.setPass(passform.MaskedTextBox1.Text.ToString());
                                encryption.init_progressbar(ProgressBar1);
                                await Task.Run(() =>
                                {
                                    encryption.decrypt(ProgressBar1);
                                });
                                files = files + 1;

                                File.Delete(item.Text.ToString());

                                ProgressBar2.Value = (int)(files / ListView1.Items.Count) * 100;


                            }

                        }



                        // loop though listview and remove anything amd update everything

                        foreach (ListViewItem item in ListView1.Items)
                        {
                            for (int i = 0; i < ListView1.Items.Count; i++)
                            {
                                // checks if the filename in the list box doesn't edit with .aes
                                if (ListView1.Items[i].Text.EndsWith("aes"))
                                {
                                    // okay passed the check, lets add .encrypt to the filename
                                    // also delete the original file
                                    string filename = ListView1.Items[i].Text.ToString();
                                    File.Delete(filename);

                                    ListView1.BeginUpdate();



                                    ListView1.Items.RemoveAt(i);
                                    //  laod icon and add it to the list view;
                                    Icon iconForFile = SystemIcons.WinLogo;
                                    ListViewItem item_fixed = new ListViewItem(filename.Replace(".aes", ""), 1);
                                    item_fixed.ImageIndex = 1;
                                    iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(filename.Replace(".aes", ""));


                                    imageList1.Images.Add(filename.Replace(".aes", ""), iconForFile);
                                    item_fixed.ImageKey = filename.Replace(".aes", "");
                                    item_fixed.Text = filename.Replace(".aes", "").ToString();
                                    ListView1.Items.Add(item_fixed).SubItems.Add("No");
                                    ListView1.EndUpdate();



                                }
                            }
                        }

                        MessageBox.Show("Decryption Successful");
                        // reset the progress barss

                        ProgressBar1.Value = 0;
                        ProgressBar2.Value = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Main()
        {
            InitializeComponent();
            

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            About about = new About();
            if(about.ShowDialog() == DialogResult.OK)
            {
                // obviously do nothing.
            }
        }

        


        private void Main_Load(object sender, EventArgs e)
        {
            ListView1.AllowDrop = true;
            ListView1.DragDrop += new DragEventHandler(listView1_DragDrop);
            ListView1.DragEnter += new DragEventHandler(listView1_DragEnter);
            ListView1.Columns[0].Width = (int)ListView1.ClientRectangle.Width - (int)ListView1.Columns[1].Width;
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            encrypt_files();
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            decrypt_files();
        }

        private void ResizeListView(object sender, EventArgs e)
        {
            // simple resize :D
            ListView1.Columns[0].Width = (int)ListView1.ClientRectangle.Width - (int)ListView1.Columns[1].Width;
        }

        private void clear_list()
        {
            ListView1.Items.Clear();
            ToolStripStatusLabel3.Text = "0";
            files.Clear();

        }

        // this removes a item from list

        public void remove_list()
        {
            try
            {
                for (int i = 0; i < ListView1.Items.Count; i++)
                {
                    if (ListView1.Items[i].Selected)
                    {
                        ListView1.Items.RemoveAt(i);
                    }

                    // now update the list count

                    files.RemoveAt(i);

                    ToolStripStatusLabel3.Text = ListView1.Items.Count.ToString();
                }
            }catch(Exception list)
            {
                // do nothing
            }


        }

        private void EncryptFiles_Click(object sender, EventArgs e)
        {
            encrypt_files();
        }

        private void DecryptFiles_Click(object sender, EventArgs e)
        {
            decrypt_files();
        }

        private void RemoveFromList_Click(object sender, EventArgs e)
        {
            remove_list();
        }

        private void ClearList_Click(object sender, EventArgs e)
        {
            clear_list();
        }

        private void About_Click(object sender, EventArgs e)
        {
            About about = new JadeEncryption.About();
            about.Show();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            remove_list();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            clear_list();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length >= 0 && TextBox1.Text != "")
            {
                CryptoFunctions crypto = new CryptoFunctions();
                crypto.setPass(TextBox1.Text.ToString());
                string text = crypto.AES_String_Encrypt(RichTextBox1.Text.ToString());
                // we replace the contents of the string lol;
                RichTextBox1.Text = text;
            }
            else
            {
                MessageBox.Show("Please enter a password!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Length >= 0 && TextBox1.Text != "")
            {
                CryptoFunctions crypto = new CryptoFunctions();
                crypto.setPass(TextBox1.Text.ToString());
                string text = crypto.AES_String_Decrypt(RichTextBox1.Text.ToString());
                // we replace the contents of the string lol;
                RichTextBox1.Text = text;
            }
            else
            {
                MessageBox.Show("Please enter a password!");
            }
        }



        private void ToolStripStatusLabel6_Click(object sender, EventArgs e)
        {
            Process.Start("https://jessicaamy.com");
        }



        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://jessicaamy.com");
        }

        private void Buy_Click(object sender, EventArgs e)
        {
        }

        private void ListView1_Resize(object sender, EventArgs e)
        {
            // simple resize :D
            ListView1.Columns[0].Width = (int)ListView1.ClientRectangle.Width - (int)ListView1.Columns[1].Width;
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Process.Start("https://jessicaamy.com");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void removeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListView1.Items.RemoveAt(ListView1.SelectedIndices[0]);
                ToolStripStatusLabel3.Text = ListView1.Items.Count.ToString();


            }
            catch (Exception ex)
            {
            }
        }

        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clear_list();
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
