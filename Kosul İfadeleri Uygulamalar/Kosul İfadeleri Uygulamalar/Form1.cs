namespace Kosul_İfadeleri_Uygulamalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v = int.Parse(viz.Text);
            int f = int.Parse(final.Text);
            int p = int.Parse(proje.Text);
            int q = int.Parse(quiz.Text);
            double ort = v * 0.3 + f * 0.4 + p * 0.2 + q * 0.1;
            if (ort > 85 && ort <= 100)
                harf_n.Text = "AA";
            else if (ort > 70 && ort <= 85)
                harf_n.Text = "BA";
            else if (ort > 65 && ort <= 70)
                harf_n.Text = "BB";
            else if (ort > 55 && ort <= 65)
                harf_n.Text = "CB";
            else if (ort > 45 && ort <= 55)
                harf_n.Text = "CC";
            else if (ort > 40 && ort <= 45)
                harf_n.Text = "DC";
            else if (ort > 35 && ort <= 40)
                harf_n.Text = "DD";
            else if (ort > 0 && ort <= 35)
                harf_n.Text = "FF";
            else
                harf_n.Text = "FG";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kitap_sayisi = int.Parse(k_sayisi.Text);
            if (kitap_sayisi > 0 && kitap_sayisi < 20)
                sonuc.Text = ((kitap_sayisi * 8) * 0.8).ToString();
            else if (kitap_sayisi > 20 && kitap_sayisi < 50)
                sonuc.Text = ((kitap_sayisi * 8) * 0.6).ToString();
            else if (kitap_sayisi > 50 && kitap_sayisi < 100)
                sonuc.Text = ((kitap_sayisi * 8) * 0.5).ToString();
            else if (kitap_sayisi >= 100)
                sonuc.Text = ((kitap_sayisi * 8) * 0.4).ToString();
            else
                sonuc.Text = (kitap_sayisi * 8).ToString();
        }
    }
}