namespace Ogrenci_Sinav_Notu_Hesaplayici
{
    public partial class Form1 : Form
    {
        int mod = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hesapla_Click(object sender, EventArgs e)
        {
            double ortalama = int.Parse(vize.Text) * 0.3 + int.Parse(final.Text) * 0.4 + int.Parse(proje.Text) * 0.2 + int.Parse(quiz.Text) * 0.1;
            listBox1.Items.Add(ad.Text + " " + soyad.Text + " Ortalama: " + ortalama);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}