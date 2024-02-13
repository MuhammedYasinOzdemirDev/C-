namespace Timer_Ve_ProgesBar_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayac.Start();
        }
        int sayaccc = 0;
        private void sayac_Tick(object sender, EventArgs e)
        {
            sayaccc++;
            sayacc.Text = sayaccc.ToString();
            if (sayaccc == 100)
                sayac.Stop();

        }
        Random rnd = new Random();
        private void arkaplan_Tick(object sender, EventArgs e)

        {

            this.BackColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }
        int saniye = 0, dakika = 0, saatt = 0;
        private void saat_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 60)
            {
                dakika++;
                if (dakika == 60)
                {
                    saatt++;
                    label1.Text = saatt.ToString();
                    dakika = 0;
                }
                label2.Text = dakika.ToString();
                saniye = 0;
            }
            label3.Text = saniye.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != 100)
                progressBar1.Value += 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != 0)
                progressBar1.Value -= 5;
        }

        private void progess_Tick(object sender, EventArgs e)
        {
            if(progressBar2.Value == 100)
            {
                progressBar2.Value = 0;
            }
            progressBar2.Value++;
        }
    }
}