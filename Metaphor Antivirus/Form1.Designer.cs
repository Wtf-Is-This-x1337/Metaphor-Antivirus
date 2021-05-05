﻿
namespace Metaphor_Antivirus
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.OptionsBtn = new ns1.BunifuFlatButton();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Label();
            this.ScanBtn = new ns1.BunifuFlatButton();
            this.ToolsBtn = new ns1.BunifuFlatButton();
            this.DashboardBtn = new ns1.BunifuFlatButton();
            this.IconImage = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ComputerNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.VersionLbl = new System.Windows.Forms.Label();
            this.OSLbl = new System.Windows.Forms.Label();
            this.ComputerName = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.TextVersion = new System.Windows.Forms.Label();
            this.OS = new System.Windows.Forms.Label();
            this.BitOsLbl = new System.Windows.Forms.Label();
            this.OsBit = new System.Windows.Forms.Label();
            this.BitProcessLbl = new System.Windows.Forms.Label();
            this.ProcessBit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OsPlatform = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.processesBtn = new ns1.BunifuFlatButton();
            this.usageBtn = new ns1.BunifuFlatButton();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconImage)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Metaphor Antivirus";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.LeftPanel.Controls.Add(this.OptionsBtn);
            this.LeftPanel.Controls.Add(this.UpdateBtn);
            this.LeftPanel.Controls.Add(this.Version);
            this.LeftPanel.Controls.Add(this.ScanBtn);
            this.LeftPanel.Controls.Add(this.ToolsBtn);
            this.LeftPanel.Controls.Add(this.DashboardBtn);
            this.LeftPanel.Controls.Add(this.IconImage);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 43);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(209, 493);
            this.LeftPanel.TabIndex = 3;
            // 
            // OptionsBtn
            // 
            this.OptionsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.OptionsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OptionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptionsBtn.BorderRadius = 0;
            this.OptionsBtn.ButtonText = "Options";
            this.OptionsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.OptionsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.OptionsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("OptionsBtn.Iconimage")));
            this.OptionsBtn.Iconimage_right = null;
            this.OptionsBtn.Iconimage_right_Selected = null;
            this.OptionsBtn.Iconimage_Selected = null;
            this.OptionsBtn.IconMarginLeft = 0;
            this.OptionsBtn.IconMarginRight = 0;
            this.OptionsBtn.IconRightVisible = true;
            this.OptionsBtn.IconRightZoom = 0D;
            this.OptionsBtn.IconVisible = true;
            this.OptionsBtn.IconZoom = 90D;
            this.OptionsBtn.IsTab = true;
            this.OptionsBtn.Location = new System.Drawing.Point(0, 341);
            this.OptionsBtn.Name = "OptionsBtn";
            this.OptionsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OptionsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OptionsBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.OptionsBtn.selected = false;
            this.OptionsBtn.Size = new System.Drawing.Size(209, 48);
            this.OptionsBtn.TabIndex = 8;
            this.OptionsBtn.Text = "Options";
            this.OptionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptionsBtn.Textcolor = System.Drawing.Color.White;
            this.OptionsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.UpdateBtn.Location = new System.Drawing.Point(46, 451);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(76, 32);
            this.UpdateBtn.TabIndex = 7;
            this.UpdateBtn.Text = " Update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Version.ForeColor = System.Drawing.SystemColors.Control;
            this.Version.Location = new System.Drawing.Point(55, 430);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(64, 18);
            this.Version.TabIndex = 6;
            this.Version.Text = "4/5/2021";
            // 
            // ScanBtn
            // 
            this.ScanBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ScanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ScanBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ScanBtn.BorderRadius = 0;
            this.ScanBtn.ButtonText = "Scan";
            this.ScanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScanBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ScanBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ScanBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ScanBtn.Iconimage")));
            this.ScanBtn.Iconimage_right = null;
            this.ScanBtn.Iconimage_right_Selected = null;
            this.ScanBtn.Iconimage_Selected = null;
            this.ScanBtn.IconMarginLeft = 0;
            this.ScanBtn.IconMarginRight = 0;
            this.ScanBtn.IconRightVisible = true;
            this.ScanBtn.IconRightZoom = 0D;
            this.ScanBtn.IconVisible = true;
            this.ScanBtn.IconZoom = 90D;
            this.ScanBtn.IsTab = true;
            this.ScanBtn.Location = new System.Drawing.Point(0, 284);
            this.ScanBtn.Name = "ScanBtn";
            this.ScanBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ScanBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ScanBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ScanBtn.selected = false;
            this.ScanBtn.Size = new System.Drawing.Size(209, 48);
            this.ScanBtn.TabIndex = 5;
            this.ScanBtn.Text = "Scan";
            this.ScanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ScanBtn.Textcolor = System.Drawing.Color.White;
            this.ScanBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ToolsBtn
            // 
            this.ToolsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ToolsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ToolsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolsBtn.BorderRadius = 0;
            this.ToolsBtn.ButtonText = "Tools";
            this.ToolsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToolsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ToolsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ToolsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ToolsBtn.Iconimage")));
            this.ToolsBtn.Iconimage_right = null;
            this.ToolsBtn.Iconimage_right_Selected = null;
            this.ToolsBtn.Iconimage_Selected = null;
            this.ToolsBtn.IconMarginLeft = 0;
            this.ToolsBtn.IconMarginRight = 0;
            this.ToolsBtn.IconRightVisible = true;
            this.ToolsBtn.IconRightZoom = 0D;
            this.ToolsBtn.IconVisible = true;
            this.ToolsBtn.IconZoom = 90D;
            this.ToolsBtn.IsTab = true;
            this.ToolsBtn.Location = new System.Drawing.Point(0, 227);
            this.ToolsBtn.Name = "ToolsBtn";
            this.ToolsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ToolsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ToolsBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ToolsBtn.selected = false;
            this.ToolsBtn.Size = new System.Drawing.Size(209, 48);
            this.ToolsBtn.TabIndex = 4;
            this.ToolsBtn.Text = "Tools";
            this.ToolsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolsBtn.Textcolor = System.Drawing.Color.White;
            this.ToolsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashboardBtn.BorderRadius = 0;
            this.DashboardBtn.ButtonText = "Dashboard";
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DashboardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DashboardBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("DashboardBtn.Iconimage")));
            this.DashboardBtn.Iconimage_right = null;
            this.DashboardBtn.Iconimage_right_Selected = null;
            this.DashboardBtn.Iconimage_Selected = null;
            this.DashboardBtn.IconMarginLeft = 0;
            this.DashboardBtn.IconMarginRight = 0;
            this.DashboardBtn.IconRightVisible = true;
            this.DashboardBtn.IconRightZoom = 0D;
            this.DashboardBtn.IconVisible = true;
            this.DashboardBtn.IconZoom = 90D;
            this.DashboardBtn.IsTab = true;
            this.DashboardBtn.Location = new System.Drawing.Point(0, 170);
            this.DashboardBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DashboardBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DashboardBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DashboardBtn.selected = true;
            this.DashboardBtn.Size = new System.Drawing.Size(209, 48);
            this.DashboardBtn.TabIndex = 3;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardBtn.Textcolor = System.Drawing.Color.White;
            this.DashboardBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // IconImage
            // 
            this.IconImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IconImage.BackgroundImage")));
            this.IconImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconImage.Location = new System.Drawing.Point(16, 9);
            this.IconImage.Name = "IconImage";
            this.IconImage.Size = new System.Drawing.Size(174, 151);
            this.IconImage.TabIndex = 2;
            this.IconImage.TabStop = false;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.MinBtn);
            this.TopPanel.Controls.Add(this.ExitBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(903, 43);
            this.TopPanel.TabIndex = 4;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metaphor Antivirus - Github";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // MinBtn
            // 
            this.MinBtn.BackColor = System.Drawing.Color.Transparent;
            this.MinBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinBtn.BackgroundImage")));
            this.MinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.MinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.MinBtn.ForeColor = System.Drawing.Color.Transparent;
            this.MinBtn.Location = new System.Drawing.Point(811, 3);
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.Size = new System.Drawing.Size(38, 38);
            this.MinBtn.TabIndex = 1;
            this.MinBtn.UseVisualStyleBackColor = false;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitBtn.BackgroundImage")));
            this.ExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F);
            this.ExitBtn.ForeColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Location = new System.Drawing.Point(860, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(38, 38);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ComputerNameLbl
            // 
            this.ComputerNameLbl.AutoSize = true;
            this.ComputerNameLbl.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.ComputerNameLbl.ForeColor = System.Drawing.Color.White;
            this.ComputerNameLbl.Location = new System.Drawing.Point(225, 95);
            this.ComputerNameLbl.Name = "ComputerNameLbl";
            this.ComputerNameLbl.Size = new System.Drawing.Size(179, 21);
            this.ComputerNameLbl.TabIndex = 7;
            this.ComputerNameLbl.Text = "- Computer name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "System Information";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.usernameLbl.ForeColor = System.Drawing.Color.White;
            this.usernameLbl.Location = new System.Drawing.Point(225, 125);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(119, 21);
            this.usernameLbl.TabIndex = 9;
            this.usernameLbl.Text = "- Username: ";
            // 
            // VersionLbl
            // 
            this.VersionLbl.AutoSize = true;
            this.VersionLbl.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.VersionLbl.ForeColor = System.Drawing.Color.White;
            this.VersionLbl.Location = new System.Drawing.Point(225, 155);
            this.VersionLbl.Name = "VersionLbl";
            this.VersionLbl.Size = new System.Drawing.Size(96, 21);
            this.VersionLbl.TabIndex = 10;
            this.VersionLbl.Text = "- Version: ";
            // 
            // OSLbl
            // 
            this.OSLbl.AutoSize = true;
            this.OSLbl.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.OSLbl.ForeColor = System.Drawing.Color.White;
            this.OSLbl.Location = new System.Drawing.Point(225, 185);
            this.OSLbl.Name = "OSLbl";
            this.OSLbl.Size = new System.Drawing.Size(189, 21);
            this.OSLbl.TabIndex = 11;
            this.OSLbl.Text = "- Operating System: ";
            // 
            // ComputerName
            // 
            this.ComputerName.AutoSize = true;
            this.ComputerName.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.ComputerName.ForeColor = System.Drawing.Color.White;
            this.ComputerName.Location = new System.Drawing.Point(410, 95);
            this.ComputerName.Name = "ComputerName";
            this.ComputerName.Size = new System.Drawing.Size(160, 21);
            this.ComputerName.TabIndex = 12;
            this.ComputerName.Text = "Computer Name";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(350, 125);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(98, 21);
            this.Username.TabIndex = 13;
            this.Username.Text = "Username";
            // 
            // TextVersion
            // 
            this.TextVersion.AutoSize = true;
            this.TextVersion.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.TextVersion.ForeColor = System.Drawing.Color.White;
            this.TextVersion.Location = new System.Drawing.Point(327, 155);
            this.TextVersion.Name = "TextVersion";
            this.TextVersion.Size = new System.Drawing.Size(75, 21);
            this.TextVersion.TabIndex = 14;
            this.TextVersion.Text = "Version";
            // 
            // OS
            // 
            this.OS.AutoSize = true;
            this.OS.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.OS.ForeColor = System.Drawing.Color.White;
            this.OS.Location = new System.Drawing.Point(420, 185);
            this.OS.Name = "OS";
            this.OS.Size = new System.Drawing.Size(35, 21);
            this.OS.TabIndex = 15;
            this.OS.Text = "OS";
            // 
            // BitOsLbl
            // 
            this.BitOsLbl.AutoSize = true;
            this.BitOsLbl.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.BitOsLbl.ForeColor = System.Drawing.Color.White;
            this.BitOsLbl.Location = new System.Drawing.Point(225, 215);
            this.BitOsLbl.Name = "BitOsLbl";
            this.BitOsLbl.Size = new System.Drawing.Size(101, 21);
            this.BitOsLbl.TabIndex = 16;
            this.BitOsLbl.Text = "- 64 Bit OS:";
            // 
            // OsBit
            // 
            this.OsBit.AutoSize = true;
            this.OsBit.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.OsBit.ForeColor = System.Drawing.Color.White;
            this.OsBit.Location = new System.Drawing.Point(332, 215);
            this.OsBit.Name = "OsBit";
            this.OsBit.Size = new System.Drawing.Size(46, 21);
            this.OsBit.TabIndex = 17;
            this.OsBit.Text = "True";
            // 
            // BitProcessLbl
            // 
            this.BitProcessLbl.AutoSize = true;
            this.BitProcessLbl.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.BitProcessLbl.ForeColor = System.Drawing.Color.White;
            this.BitProcessLbl.Location = new System.Drawing.Point(226, 245);
            this.BitProcessLbl.Name = "BitProcessLbl";
            this.BitProcessLbl.Size = new System.Drawing.Size(142, 21);
            this.BitProcessLbl.TabIndex = 18;
            this.BitProcessLbl.Text = "- 64 Bit Process:";
            // 
            // ProcessBit
            // 
            this.ProcessBit.AutoSize = true;
            this.ProcessBit.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.ProcessBit.ForeColor = System.Drawing.Color.White;
            this.ProcessBit.Location = new System.Drawing.Point(374, 245);
            this.ProcessBit.Name = "ProcessBit";
            this.ProcessBit.Size = new System.Drawing.Size(46, 21);
            this.ProcessBit.TabIndex = 19;
            this.ProcessBit.Text = "True";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(226, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "- OS Platform:";
            // 
            // OsPlatform
            // 
            this.OsPlatform.AutoSize = true;
            this.OsPlatform.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.OsPlatform.ForeColor = System.Drawing.Color.White;
            this.OsPlatform.Location = new System.Drawing.Point(361, 275);
            this.OsPlatform.Name = "OsPlatform";
            this.OsPlatform.Size = new System.Drawing.Size(113, 21);
            this.OsPlatform.TabIndex = 21;
            this.OsPlatform.Text = "OS Platform";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(227, 81);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(219, 10);
            this.bunifuSeparator1.TabIndex = 22;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(227, 341);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(199, 10);
            this.bunifuSeparator2.TabIndex = 24;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(224, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 27);
            this.label4.TabIndex = 23;
            this.label4.Text = "About Metaphor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(223, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(454, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Metaphor is an open-source antivirus written in C#.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.linkLabel1.Location = new System.Drawing.Point(683, 354);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(190, 21);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[ Github Repository ]";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label6.Location = new System.Drawing.Point(223, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(663, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "The goal of this project is to make a free antivirus driven by the community";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.label7.Location = new System.Drawing.Point(218, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(663, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = " that can be easily changed to work in closed environments. ( Like InfANT )";
            // 
            // processesBtn
            // 
            this.processesBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.processesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.processesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.processesBtn.BorderRadius = 0;
            this.processesBtn.ButtonText = " All processes";
            this.processesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.processesBtn.DisabledColor = System.Drawing.Color.Gray;
            this.processesBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.processesBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.processesBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("processesBtn.Iconimage")));
            this.processesBtn.Iconimage_right = null;
            this.processesBtn.Iconimage_right_Selected = null;
            this.processesBtn.Iconimage_Selected = null;
            this.processesBtn.IconMarginLeft = 0;
            this.processesBtn.IconMarginRight = 0;
            this.processesBtn.IconRightVisible = true;
            this.processesBtn.IconRightZoom = 0D;
            this.processesBtn.IconVisible = true;
            this.processesBtn.IconZoom = 90D;
            this.processesBtn.IsTab = false;
            this.processesBtn.Location = new System.Drawing.Point(572, 476);
            this.processesBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.processesBtn.Name = "processesBtn";
            this.processesBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.processesBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.processesBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.processesBtn.selected = false;
            this.processesBtn.Size = new System.Drawing.Size(314, 48);
            this.processesBtn.TabIndex = 6;
            this.processesBtn.Text = " All processes";
            this.processesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.processesBtn.Textcolor = System.Drawing.Color.White;
            this.processesBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processesBtn.Click += new System.EventHandler(this.processesBtn_Click);
            // 
            // usageBtn
            // 
            this.usageBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.usageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.usageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usageBtn.BorderRadius = 0;
            this.usageBtn.ButtonText = " CPU && RAM usage";
            this.usageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usageBtn.DisabledColor = System.Drawing.Color.Gray;
            this.usageBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.usageBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.usageBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("usageBtn.Iconimage")));
            this.usageBtn.Iconimage_right = null;
            this.usageBtn.Iconimage_right_Selected = null;
            this.usageBtn.Iconimage_Selected = null;
            this.usageBtn.IconMarginLeft = 0;
            this.usageBtn.IconMarginRight = 0;
            this.usageBtn.IconRightVisible = true;
            this.usageBtn.IconRightZoom = 0D;
            this.usageBtn.IconVisible = true;
            this.usageBtn.IconZoom = 90D;
            this.usageBtn.IsTab = false;
            this.usageBtn.Location = new System.Drawing.Point(229, 476);
            this.usageBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usageBtn.Name = "usageBtn";
            this.usageBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.usageBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.usageBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.usageBtn.selected = false;
            this.usageBtn.Size = new System.Drawing.Size(314, 48);
            this.usageBtn.TabIndex = 5;
            this.usageBtn.Text = " CPU && RAM usage";
            this.usageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usageBtn.Textcolor = System.Drawing.Color.White;
            this.usageBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usageBtn.Click += new System.EventHandler(this.usageBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(903, 536);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.OsPlatform);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProcessBit);
            this.Controls.Add(this.BitProcessLbl);
            this.Controls.Add(this.OsBit);
            this.Controls.Add(this.BitOsLbl);
            this.Controls.Add(this.OS);
            this.Controls.Add(this.TextVersion);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.ComputerName);
            this.Controls.Add(this.OSLbl);
            this.Controls.Add(this.VersionLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComputerNameLbl);
            this.Controls.Add(this.processesBtn);
            this.Controls.Add(this.usageBtn);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metaphor Antivirus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconImage)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MinBtn;
        private System.Windows.Forms.PictureBox IconImage;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuFlatButton DashboardBtn;
        private ns1.BunifuFlatButton ToolsBtn;
        private ns1.BunifuFlatButton ScanBtn;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Button UpdateBtn;
        private ns1.BunifuFlatButton OptionsBtn;
        private ns1.BunifuFlatButton usageBtn;
        private ns1.BunifuFlatButton processesBtn;
        private System.Windows.Forms.Label ComputerNameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label VersionLbl;
        private System.Windows.Forms.Label OSLbl;
        private System.Windows.Forms.Label ComputerName;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label TextVersion;
        private System.Windows.Forms.Label OS;
        private System.Windows.Forms.Label BitOsLbl;
        private System.Windows.Forms.Label OsBit;
        private System.Windows.Forms.Label BitProcessLbl;
        private System.Windows.Forms.Label ProcessBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OsPlatform;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

