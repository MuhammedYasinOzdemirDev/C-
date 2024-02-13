namespace Ucak_Rezervasyon_Paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text + " //Yolcu Ad-Soyad: " + textBox1.Text + " T.C : " + maskedTextBox2.Text + " Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu Eklendi...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;
        }
    }
}