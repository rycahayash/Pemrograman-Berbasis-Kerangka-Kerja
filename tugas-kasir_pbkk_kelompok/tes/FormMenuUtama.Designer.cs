namespace tes
{
    partial class FormMenuUtama
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            masterToolStripMenuItem = new ToolStripMenuItem();
            kasirToolStripMenuItem = new ToolStripMenuItem();
            barangToolStripMenuItem = new ToolStripMenuItem();
            transaksiToolStripMenuItem = new ToolStripMenuItem();
            penjualanToolStripMenuItem = new ToolStripMenuItem();
            laporanToolStripMenuItem = new ToolStripMenuItem();
            lapDataMasterToolStripMenuItem = new ToolStripMenuItem();
            lapPenjualanToolStripMenuItem = new ToolStripMenuItem();
            utilityToolStripMenuItem = new ToolStripMenuItem();
            gantiPasswordToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, masterToolStripMenuItem, transaksiToolStripMenuItem, laporanToolStripMenuItem, utilityToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, logoutToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(270, 34);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(270, 34);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(267, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(270, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // masterToolStripMenuItem
            // 
            masterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kasirToolStripMenuItem, barangToolStripMenuItem });
            masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            masterToolStripMenuItem.Size = new Size(82, 29);
            masterToolStripMenuItem.Text = "Master";
            // 
            // kasirToolStripMenuItem
            // 
            kasirToolStripMenuItem.Name = "kasirToolStripMenuItem";
            kasirToolStripMenuItem.Size = new Size(270, 34);
            kasirToolStripMenuItem.Text = "Kasir";
            kasirToolStripMenuItem.Click += kasirToolStripMenuItem_Click;
            // 
            // barangToolStripMenuItem
            // 
            barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            barangToolStripMenuItem.Size = new Size(270, 34);
            barangToolStripMenuItem.Text = "Barang";
            barangToolStripMenuItem.Click += barangToolStripMenuItem_Click;
            // 
            // transaksiToolStripMenuItem
            // 
            transaksiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { penjualanToolStripMenuItem });
            transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            transaksiToolStripMenuItem.Size = new Size(98, 29);
            transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // penjualanToolStripMenuItem
            // 
            penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            penjualanToolStripMenuItem.Size = new Size(188, 34);
            penjualanToolStripMenuItem.Text = "Penjualan";
            // 
            // laporanToolStripMenuItem
            // 
            laporanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lapDataMasterToolStripMenuItem, lapPenjualanToolStripMenuItem });
            laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            laporanToolStripMenuItem.Size = new Size(92, 29);
            laporanToolStripMenuItem.Text = "Laporan";
            // 
            // lapDataMasterToolStripMenuItem
            // 
            lapDataMasterToolStripMenuItem.Name = "lapDataMasterToolStripMenuItem";
            lapDataMasterToolStripMenuItem.Size = new Size(243, 34);
            lapDataMasterToolStripMenuItem.Text = "Lap Data Master";
            // 
            // lapPenjualanToolStripMenuItem
            // 
            lapPenjualanToolStripMenuItem.Name = "lapPenjualanToolStripMenuItem";
            lapPenjualanToolStripMenuItem.Size = new Size(243, 34);
            lapPenjualanToolStripMenuItem.Text = "Lap Penjualan";
            // 
            // utilityToolStripMenuItem
            // 
            utilityToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gantiPasswordToolStripMenuItem, aboutUsToolStripMenuItem });
            utilityToolStripMenuItem.Name = "utilityToolStripMenuItem";
            utilityToolStripMenuItem.Size = new Size(73, 29);
            utilityToolStripMenuItem.Text = "Utility";
            // 
            // gantiPasswordToolStripMenuItem
            // 
            gantiPasswordToolStripMenuItem.Name = "gantiPasswordToolStripMenuItem";
            gantiPasswordToolStripMenuItem.Size = new Size(235, 34);
            gantiPasswordToolStripMenuItem.Text = "Ganti Password";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(235, 34);
            aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // FormMenuUtama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenuUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Menu Utama";
            WindowState = FormWindowState.Maximized;
            Load += FormMenuUtama_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem kasirToolStripMenuItem;
        private ToolStripMenuItem barangToolStripMenuItem;
        private ToolStripMenuItem penjualanToolStripMenuItem;
        private ToolStripMenuItem lapDataMasterToolStripMenuItem;
        private ToolStripMenuItem lapPenjualanToolStripMenuItem;
        private ToolStripMenuItem gantiPasswordToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem loginToolStripMenuItem;
        public ToolStripMenuItem logoutToolStripMenuItem;
        public ToolStripMenuItem masterToolStripMenuItem;
        public ToolStripMenuItem transaksiToolStripMenuItem;
        public ToolStripMenuItem laporanToolStripMenuItem;
        public ToolStripMenuItem utilityToolStripMenuItem;
    }
}