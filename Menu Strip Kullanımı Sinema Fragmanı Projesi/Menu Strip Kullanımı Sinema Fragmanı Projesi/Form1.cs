namespace Menu_Strip_Kullanımı_Sinema_Fragmanı_Projesi
{
    public partial class Form1 : Form
    {
        WebBrowser web;
        public Form1()
        {
            InitializeComponent();
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void yesilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             web = new WebBrowser();
            web.Width = this.Width;
            web.Height = this.Height - 20;
            web.Top += 20;
            this.Controls.Add(web);
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void aksiyonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hızlıVeÖfkeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            web.Navigate("https://www.youtube.com/watch?v=RnJbSIqOQCE");
        }
    }
}