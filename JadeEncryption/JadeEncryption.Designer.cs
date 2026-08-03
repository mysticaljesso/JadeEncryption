namespace JadeEncryption
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Sidebar = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProgressBar2 = new System.Windows.Forms.ProgressBar();
            this.Label3 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.Label4 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Encrypt = new System.Windows.Forms.ToolStripButton();
            this.Decrypt = new System.Windows.Forms.ToolStripButton();
            this.Remove = new System.Windows.Forms.ToolStripButton();
            this.Clear = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.Report = new System.Windows.Forms.ToolStripButton();
            this.Tab = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Encrypted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.String = new System.Windows.Forms.TabPage();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Encryption = new System.Windows.Forms.ToolStripMenuItem();
            this.EncryptFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.DecryptFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveFromList = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearList = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.Tab.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.String.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sidebar.BackColor = System.Drawing.SystemColors.Control;
            this.Sidebar.Controls.Add(this.Label5);
            this.Sidebar.Controls.Add(this.Label6);
            this.Sidebar.Controls.Add(this.PictureBox1);
            this.Sidebar.Controls.Add(this.ProgressBar2);
            this.Sidebar.Controls.Add(this.Label3);
            this.Sidebar.Controls.Add(this.ProgressBar1);
            this.Sidebar.Controls.Add(this.Label4);
            this.Sidebar.Location = new System.Drawing.Point(711, 95);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(159, 513);
            this.Sidebar.TabIndex = 18;
            this.Sidebar.TabStop = false;
            this.Sidebar.Text = "Jade Encryption Progress";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(7, 220);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(63, 13);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Current File:";
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.Location = new System.Drawing.Point(7, 240);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(148, 263);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "IDLE";
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::JadeEncryption.Properties.Resources.progress_bar;
            this.PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.InitialImage")));
            this.PictureBox1.Location = new System.Drawing.Point(7, 20);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(146, 109);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // ProgressBar2
            // 
            this.ProgressBar2.Location = new System.Drawing.Point(7, 190);
            this.ProgressBar2.Name = "ProgressBar2";
            this.ProgressBar2.Size = new System.Drawing.Size(146, 23);
            this.ProgressBar2.TabIndex = 8;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(4, 174);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(78, 13);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Total Progress:";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.ProgressBar1.Location = new System.Drawing.Point(7, 148);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(146, 23);
            this.ProgressBar1.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(4, 132);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(70, 13);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "File Progress:";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton6,
            this.ToolStripSeparator2,
            this.Encrypt,
            this.Decrypt,
            this.Remove,
            this.Clear,
            this.ToolStripSeparator1,
            this.AboutButton,
            this.Report});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(882, 54);
            this.ToolStrip1.TabIndex = 17;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripButton6
            // 
            this.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton6.Image")));
            this.ToolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton6.Name = "ToolStripButton6";
            this.ToolStripButton6.Size = new System.Drawing.Size(272, 51);
            this.ToolStripButton6.Text = "ToolStripButton6";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // Encrypt
            // 
            this.Encrypt.Image = ((System.Drawing.Image)(resources.GetObject("Encrypt.Image")));
            this.Encrypt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Encrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(51, 51);
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Image = ((System.Drawing.Image)(resources.GetObject("Decrypt.Image")));
            this.Decrypt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Decrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(52, 51);
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Remove
            // 
            this.Remove.Image = ((System.Drawing.Image)(resources.GetObject("Remove.Image")));
            this.Remove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(54, 51);
            this.Remove.Text = "Remove";
            this.Remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Clear
            // 
            this.Clear.Image = ((System.Drawing.Image)(resources.GetObject("Clear.Image")));
            this.Clear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(59, 51);
            this.Clear.Text = "Clear List";
            this.Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // AboutButton
            // 
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(44, 51);
            this.AboutButton.Text = "About";
            this.AboutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Report
            // 
            this.Report.Image = ((System.Drawing.Image)(resources.GetObject("Report.Image")));
            this.Report.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Report.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(70, 51);
            this.Report.Text = "Report Bug";
            this.Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            // 
            // Tab
            // 
            this.Tab.AllowDrop = true;
            this.Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab.Controls.Add(this.TabPage1);
            this.Tab.Controls.Add(this.String);
            this.Tab.Location = new System.Drawing.Point(0, 81);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(705, 528);
            this.Tab.TabIndex = 16;
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.Transparent;
            this.TabPage1.Controls.Add(this.ListView1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(697, 502);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "File Encryption";
            // 
            // ListView1
            // 
            this.ListView1.AllowDrop = true;
            this.ListView1.AutoArrange = false;
            this.ListView1.BackgroundImageTiled = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader5,
            this.Encrypted});
            this.ListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(3, 3);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(691, 496);
            this.ListView1.SmallImageList = this.imageList1;
            this.ListView1.TabIndex = 3;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.Resize += new System.EventHandler(this.ListView1_Resize);
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Tag = "1";
            this.ColumnHeader5.Text = "File Name";
            this.ColumnHeader5.Width = 650;
            // 
            // Encrypted
            // 
            this.Encrypted.Tag = "2";
            this.Encrypted.Text = "Encrypted";
            this.Encrypted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Encrypted.Width = 70;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // String
            // 
            this.String.BackColor = System.Drawing.Color.Transparent;
            this.String.Controls.Add(this.Label1);
            this.String.Controls.Add(this.Label7);
            this.String.Controls.Add(this.TextBox1);
            this.String.Controls.Add(this.RichTextBox1);
            this.String.Controls.Add(this.Button1);
            this.String.Controls.Add(this.Button3);
            this.String.Location = new System.Drawing.Point(4, 22);
            this.String.Name = "String";
            this.String.Padding = new System.Windows.Forms.Padding(3);
            this.String.Size = new System.Drawing.Size(697, 502);
            this.String.TabIndex = 1;
            this.String.Text = "Text Encryption";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(2, 478);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 13);
            this.Label1.TabIndex = 19;
            this.Label1.Text = "Password:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(3, 3);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(219, 13);
            this.Label7.TabIndex = 15;
            this.Label7.Text = "Text to encrypt (or encrypted text to decrypt):";
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.Location = new System.Drawing.Point(59, 475);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '*';
            this.TextBox1.Size = new System.Drawing.Size(465, 20);
            this.TextBox1.TabIndex = 18;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBox1.Location = new System.Drawing.Point(6, 19);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.Size = new System.Drawing.Size(685, 449);
            this.RichTextBox1.TabIndex = 14;
            this.RichTextBox1.Text = "";
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.Location = new System.Drawing.Point(611, 473);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "Decrypt";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button3
            // 
            this.Button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button3.Location = new System.Drawing.Point(530, 473);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 16;
            this.Button3.Text = "Encrypt";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.clearListToolStripMenuItem,
            this.removeFileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.addFileToolStripMenuItem.Text = "Add File";
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.clearListToolStripMenuItem.Text = "Clear List";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // removeFileToolStripMenuItem
            // 
            this.removeFileToolStripMenuItem.Name = "removeFileToolStripMenuItem";
            this.removeFileToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.removeFileToolStripMenuItem.Text = "Remove File";
            this.removeFileToolStripMenuItem.Click += new System.EventHandler(this.removeFileToolStripMenuItem_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel6,
            this.ToolStripStatusLabel4,
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel5,
            this.ToolStripStatusLabel2,
            this.ToolStripStatusLabel3});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 612);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(882, 22);
            this.StatusStrip1.TabIndex = 14;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel6
            // 
            this.ToolStripStatusLabel6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ToolStripStatusLabel6.IsLink = true;
            this.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6";
            this.ToolStripStatusLabel6.Size = new System.Drawing.Size(121, 17);
            this.ToolStripStatusLabel6.Text = "www.jessicaamy.com";
            this.ToolStripStatusLabel6.Click += new System.EventHandler(this.ToolStripStatusLabel6_Click);
            // 
            // ToolStripStatusLabel4
            // 
            this.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4";
            this.ToolStripStatusLabel4.Size = new System.Drawing.Size(243, 17);
            this.ToolStripStatusLabel4.Spring = true;
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(170, 17);
            this.ToolStripStatusLabel1.Text = "Jade Encryption © Jessica Amy";
            this.ToolStripStatusLabel1.Click += new System.EventHandler(this.ToolStripStatusLabel1_Click);
            // 
            // ToolStripStatusLabel5
            // 
            this.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5";
            this.ToolStripStatusLabel5.Size = new System.Drawing.Size(243, 17);
            this.ToolStripStatusLabel5.Spring = true;
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(33, 17);
            this.ToolStripStatusLabel2.Text = "Files:";
            this.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(13, 17);
            this.ToolStripStatusLabel3.Text = "0";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Encryption,
            this.OptionToolStripMenuItem,
            this.Help});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(882, 24);
            this.MenuStrip1.TabIndex = 15;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // Encryption
            // 
            this.Encryption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EncryptFiles,
            this.DecryptFiles});
            this.Encryption.Name = "Encryption";
            this.Encryption.Size = new System.Drawing.Size(76, 20);
            this.Encryption.Text = "Encryption";
            // 
            // EncryptFiles
            // 
            this.EncryptFiles.Image = global::JadeEncryption.Properties.Resources.locked_padlock__1_;
            this.EncryptFiles.Name = "EncryptFiles";
            this.EncryptFiles.Size = new System.Drawing.Size(154, 22);
            this.EncryptFiles.Text = "Encrypt all files";
            this.EncryptFiles.Click += new System.EventHandler(this.EncryptFiles_Click);
            // 
            // DecryptFiles
            // 
            this.DecryptFiles.Image = global::JadeEncryption.Properties.Resources.padlock;
            this.DecryptFiles.Name = "DecryptFiles";
            this.DecryptFiles.Size = new System.Drawing.Size(154, 22);
            this.DecryptFiles.Text = "Decrypt all files";
            this.DecryptFiles.Click += new System.EventHandler(this.DecryptFiles_Click);
            // 
            // OptionToolStripMenuItem
            // 
            this.OptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveFromList,
            this.ClearList});
            this.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem";
            this.OptionToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.OptionToolStripMenuItem.Text = "Remove";
            // 
            // RemoveFromList
            // 
            this.RemoveFromList.Image = global::JadeEncryption.Properties.Resources.remove_symbol;
            this.RemoveFromList.Name = "RemoveFromList";
            this.RemoveFromList.Size = new System.Drawing.Size(164, 22);
            this.RemoveFromList.Text = "Remove from list";
            this.RemoveFromList.Click += new System.EventHandler(this.RemoveFromList_Click);
            // 
            // ClearList
            // 
            this.ClearList.Image = global::JadeEncryption.Properties.Resources.rubbish_bin;
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(164, 22);
            this.ClearList.Text = "Clear list";
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(44, 20);
            this.Help.Text = "Help";
            // 
            // About
            // 
            this.About.Image = global::JadeEncryption.Properties.Resources.information_button;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(107, 22);
            this.About.Text = "About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 634);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Jade Encryption";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.String.ResumeLayout(false);
            this.String.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox Sidebar;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.PictureBox PictureBox1;
        public System.Windows.Forms.ProgressBar ProgressBar2;
        internal System.Windows.Forms.Label Label3;
        public System.Windows.Forms.ProgressBar ProgressBar1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripLabel ToolStripButton6;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton Encrypt;
        internal System.Windows.Forms.ToolStripButton Decrypt;
        internal System.Windows.Forms.ToolStripButton Remove;
        internal System.Windows.Forms.ToolStripButton Clear;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton AboutButton;
        internal System.Windows.Forms.TabControl Tab;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.ColumnHeader ColumnHeader5;
        internal System.Windows.Forms.ColumnHeader Encrypted;
        private System.Windows.Forms.TabPage String;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel6;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel4;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel5;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem Encryption;
        internal System.Windows.Forms.ToolStripMenuItem EncryptFiles;
        internal System.Windows.Forms.ToolStripMenuItem DecryptFiles;
        internal System.Windows.Forms.ToolStripMenuItem OptionToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RemoveFromList;
        internal System.Windows.Forms.ToolStripMenuItem ClearList;
        internal System.Windows.Forms.ToolStripMenuItem Help;
        internal System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.ToolStripButton Report;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFileToolStripMenuItem;
    }
}

