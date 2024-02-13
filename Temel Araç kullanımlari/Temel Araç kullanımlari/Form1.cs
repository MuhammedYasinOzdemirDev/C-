namespace Temel_Araç_kullanımlari
{
    public partial class Form1 : Form
    {
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Muhammed Yasin";
            label4.Text = "Özdemir";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            mesaj += "Yasin\n";
            mesaj += "Özdemir\n";
            MessageBox.Show(mesaj);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mesaj = "\n";

            mesaj += textBox2.Text + "\n";
            mesaj += textBox3.Text + "\n";
            a++;

            mesaj += "Sıra:" + a;
            label6.Text = mesaj;


        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Text = (int.Parse(textBox4.Text) + int.Parse(textBox5.Text)).ToString();
            //textBox6.Text = string.Format("{0}",int.Parse(textBox4.Text) + int.Parse(textBox5.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.Text = string.Format("{0}", int.Parse(textBox8.Text) * int.Parse(textBox9.Text));
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox10.Text = string.Format("{0}", int.Parse(textBox12.Text) - int.Parse(textBox11.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox13.Text = string.Format("{0}", int.Parse(textBox15.Text) / float.Parse(textBox14.Text));
        }
    }
}