namespace Sinema_Büfesi_Satış_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t = double.Parse(misir.Text) * 16 + double.Parse(su.Text) * 3 + double.Parse(cay.Text) * 8 + double.Parse(bilet.Text) * 30;
            toplam.Text = t.ToString() + " TL";
            kasa.Text = (double.Parse(kasa.Text.Split()[0]) + t).ToString();

        }
    }
}