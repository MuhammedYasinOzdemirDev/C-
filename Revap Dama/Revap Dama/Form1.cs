namespace Revap_Dama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 436;
            Height = 466;
            Button[,] buttons = new Button[8, 8];//çift katlı matris olusur
            int top = 0, left = 0;
            for(int i=0;i<buttons.GetUpperBound(0);i++)//ust katman
            {
                for(int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i,j] = new Button();
                    buttons[i, j].Width = 60;
                    buttons[i, j].Height = 60;
                    if((i+j)%2==0)
                        buttons[i, j].BackColor = Color.Black;
                    else
                        buttons[i, j].BackColor = Color.White;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    this.Controls.Add(buttons[i, j]);
                    left += 60;
                }
                left = 0;
                top += 60;
            }
        }
    }
}