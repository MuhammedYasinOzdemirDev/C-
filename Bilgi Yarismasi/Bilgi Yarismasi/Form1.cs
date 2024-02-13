namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soru_sayisi = 0, dogru = 0, yanlis = 0;
        string cevap;
        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            if (soru_sayisi == 0)
                btn_sonraki.Text = "Sonraki";
            if (soru_sayisi < 4)
                soru_sayisi++;
            lbl_sorusayisi.Text = soru_sayisi.ToString();
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            switch (soru_sayisi)
            {
                case 1:
                    richTextBox1.Text = "\n\tCumhuriyet Hang yılında ilan edilmiştir?";
                    btn_a.Text = "1921";
                    btn_b.Text = "1922";
                    btn_c.Text = "1923";
                    btn_d.Text = "1924";
                    cevap = "1923";
                    break;
                case 2:
                    richTextBox1.Text = "\n\tBeşiktaş Kurulus Yılı nedir?";
                    btn_a.Text = "1900";
                    btn_b.Text = "1901";
                    btn_c.Text = "1903";
                    btn_d.Text = "1904";
                    cevap = "1903";
                    break;
                case 3:
                    richTextBox1.Text = "\n\tHangi İl Ege Bölgesinde Bulunmaz?";
                    btn_a.Text = "İzmir";
                    btn_b.Text = "Manisa";
                    btn_c.Text = "Aydın";
                    btn_d.Text = "Bursa";
                    cevap = "Bursa";
                    break;
                default:
                    btn_sonraki.Text = "Sonuçlar";
                    MessageBox.Show("\nDoğru:" + dogru + "\nYanlış:" + yanlis + "\nPuan:" + (dogru * 10 - yanlis * 10));
                    richTextBox1.Text = $"Puan:{dogru * 10 - yanlis * 10}"; break;
            }
        }

        private void btn_a_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            if (cevap == btn_a.Text)
            {
                dogru++;
                lbl.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btn_b_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            if (cevap == btn_b.Text)
            {
                dogru++;
                lbl.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            if (cevap == btn_c.Text)
            {
                dogru++;
                lbl.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = false;
            if (cevap == btn_d.Text)
            {
                dogru++;
                lbl.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}