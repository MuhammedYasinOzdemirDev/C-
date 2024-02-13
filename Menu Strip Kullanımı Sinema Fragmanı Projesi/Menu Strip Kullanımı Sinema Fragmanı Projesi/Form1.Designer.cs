namespace Menu_Strip_Kullanımı_Sinema_Fragmanı_Projesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            kategorilerToolStripMenuItem = new ToolStripMenuItem();
            aksiyonToolStripMenuItem = new ToolStripMenuItem();
            romantikToolStripMenuItem = new ToolStripMenuItem();
            korkuToolStripMenuItem = new ToolStripMenuItem();
            bilimKurguToolStripMenuItem = new ToolStripMenuItem();
            renkToolStripMenuItem = new ToolStripMenuItem();
            maviToolStripMenuItem = new ToolStripMenuItem();
            griToolStripMenuItem = new ToolStripMenuItem();
            yesilToolStripMenuItem = new ToolStripMenuItem();
            hızlıErişimToolStripMenuItem = new ToolStripMenuItem();
            hakkımızdaToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            folderBrowserDialog1 = new FolderBrowserDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            hızlıVeÖfkeliToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kategorilerToolStripMenuItem, renkToolStripMenuItem, hızlıErişimToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // kategorilerToolStripMenuItem
            // 
            kategorilerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aksiyonToolStripMenuItem, romantikToolStripMenuItem, korkuToolStripMenuItem, bilimKurguToolStripMenuItem });
            kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            kategorilerToolStripMenuItem.Size = new Size(97, 24);
            kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // aksiyonToolStripMenuItem
            // 
            aksiyonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hızlıVeÖfkeliToolStripMenuItem });
            aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            aksiyonToolStripMenuItem.Size = new Size(224, 26);
            aksiyonToolStripMenuItem.Text = "Aksiyon";
            aksiyonToolStripMenuItem.Click += aksiyonToolStripMenuItem_Click;
            // 
            // romantikToolStripMenuItem
            // 
            romantikToolStripMenuItem.Name = "romantikToolStripMenuItem";
            romantikToolStripMenuItem.Size = new Size(224, 26);
            romantikToolStripMenuItem.Text = "Romantik";
            // 
            // korkuToolStripMenuItem
            // 
            korkuToolStripMenuItem.Name = "korkuToolStripMenuItem";
            korkuToolStripMenuItem.Size = new Size(224, 26);
            korkuToolStripMenuItem.Text = "Korku";
            // 
            // bilimKurguToolStripMenuItem
            // 
            bilimKurguToolStripMenuItem.Name = "bilimKurguToolStripMenuItem";
            bilimKurguToolStripMenuItem.Size = new Size(224, 26);
            bilimKurguToolStripMenuItem.Text = "Bilim Kurgu";
            // 
            // renkToolStripMenuItem
            // 
            renkToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { maviToolStripMenuItem, griToolStripMenuItem, yesilToolStripMenuItem });
            renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            renkToolStripMenuItem.Size = new Size(55, 24);
            renkToolStripMenuItem.Text = "Renk";
            // 
            // maviToolStripMenuItem
            // 
            maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            maviToolStripMenuItem.Size = new Size(124, 26);
            maviToolStripMenuItem.Text = "Mavi";
            maviToolStripMenuItem.Click += maviToolStripMenuItem_Click;
            // 
            // griToolStripMenuItem
            // 
            griToolStripMenuItem.Name = "griToolStripMenuItem";
            griToolStripMenuItem.Size = new Size(124, 26);
            griToolStripMenuItem.Text = "Gri";
            griToolStripMenuItem.Click += griToolStripMenuItem_Click;
            // 
            // yesilToolStripMenuItem
            // 
            yesilToolStripMenuItem.Name = "yesilToolStripMenuItem";
            yesilToolStripMenuItem.Size = new Size(124, 26);
            yesilToolStripMenuItem.Text = "Yesil";
            yesilToolStripMenuItem.Click += yesilToolStripMenuItem_Click;
            // 
            // hızlıErişimToolStripMenuItem
            // 
            hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hakkımızdaToolStripMenuItem, çıkışToolStripMenuItem });
            hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            hızlıErişimToolStripMenuItem.Size = new Size(97, 24);
            hızlıErişimToolStripMenuItem.Text = "Hızlı Erişim";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            hakkımızdaToolStripMenuItem.Size = new Size(170, 26);
            hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            hakkımızdaToolStripMenuItem.Click += hakkımızdaToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(170, 26);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // hızlıVeÖfkeliToolStripMenuItem
            // 
            hızlıVeÖfkeliToolStripMenuItem.Name = "hızlıVeÖfkeliToolStripMenuItem";
            hızlıVeÖfkeliToolStripMenuItem.Size = new Size(224, 26);
            hızlıVeÖfkeliToolStripMenuItem.Text = "Hızlı ve Öfkeli";
            hızlıVeÖfkeliToolStripMenuItem.Click += hızlıVeÖfkeliToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kategorilerToolStripMenuItem;
        private ToolStripMenuItem aksiyonToolStripMenuItem;
        private ToolStripMenuItem romantikToolStripMenuItem;
        private ToolStripMenuItem korkuToolStripMenuItem;
        private ToolStripMenuItem bilimKurguToolStripMenuItem;
        private ToolStripMenuItem renkToolStripMenuItem;
        private ToolStripMenuItem maviToolStripMenuItem;
        private ToolStripMenuItem griToolStripMenuItem;
        private ToolStripMenuItem yesilToolStripMenuItem;
        private ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem hızlıVeÖfkeliToolStripMenuItem;
    }
}