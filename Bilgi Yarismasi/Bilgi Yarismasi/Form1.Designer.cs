namespace Bilgi_Yarismasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_yanlis = new Label();
            lbl = new Label();
            lbl_sorusayisi = new Label();
            btn_a = new Button();
            btn_b = new Button();
            btn_c = new Button();
            btn_d = new Button();
            btn_sonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(0, 3);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(554, 140);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(560, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 1;
            label1.Text = "Soru Sayısı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(614, 47);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 2;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(617, 80);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 3;
            label3.Text = "Yanlış:";
            // 
            // lbl_yanlis
            // 
            lbl_yanlis.AutoSize = true;
            lbl_yanlis.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_yanlis.Location = new Point(707, 80);
            lbl_yanlis.Name = "lbl_yanlis";
            lbl_yanlis.Size = new Size(25, 25);
            lbl_yanlis.TabIndex = 6;
            lbl_yanlis.Text = "0";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(707, 47);
            lbl.Name = "lbl";
            lbl.Size = new Size(25, 25);
            lbl.TabIndex = 5;
            lbl.Text = "0";
            // 
            // lbl_sorusayisi
            // 
            lbl_sorusayisi.AutoSize = true;
            lbl_sorusayisi.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sorusayisi.Location = new Point(707, 9);
            lbl_sorusayisi.Name = "lbl_sorusayisi";
            lbl_sorusayisi.Size = new Size(25, 25);
            lbl_sorusayisi.TabIndex = 4;
            lbl_sorusayisi.Text = "0";
            // 
            // btn_a
            // 
            btn_a.Location = new Point(0, 149);
            btn_a.Name = "btn_a";
            btn_a.Size = new Size(274, 37);
            btn_a.TabIndex = 7;
            btn_a.Text = "A";
            btn_a.UseVisualStyleBackColor = true;
            btn_a.Click += btn_a_Click;
            // 
            // btn_b
            // 
            btn_b.Location = new Point(280, 149);
            btn_b.Name = "btn_b";
            btn_b.Size = new Size(274, 37);
            btn_b.TabIndex = 8;
            btn_b.Text = "B";
            btn_b.UseVisualStyleBackColor = true;
            btn_b.Click += btn_b_Click;
            // 
            // btn_c
            // 
            btn_c.Location = new Point(0, 192);
            btn_c.Name = "btn_c";
            btn_c.Size = new Size(274, 37);
            btn_c.TabIndex = 9;
            btn_c.Text = "C";
            btn_c.UseVisualStyleBackColor = true;
            btn_c.Click += btn_c_Click;
            // 
            // btn_d
            // 
            btn_d.Location = new Point(280, 192);
            btn_d.Name = "btn_d";
            btn_d.Size = new Size(274, 37);
            btn_d.TabIndex = 10;
            btn_d.Text = "D";
            btn_d.UseVisualStyleBackColor = true;
            btn_d.Click += btn_d_Click;
            // 
            // btn_sonraki
            // 
            btn_sonraki.Location = new Point(560, 108);
            btn_sonraki.Name = "btn_sonraki";
            btn_sonraki.Size = new Size(228, 35);
            btn_sonraki.TabIndex = 11;
            btn_sonraki.Text = "Basla";
            btn_sonraki.UseVisualStyleBackColor = true;
            btn_sonraki.Click += btn_sonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(560, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(676, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 232);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_sonraki);
            Controls.Add(btn_d);
            Controls.Add(btn_c);
            Controls.Add(btn_b);
            Controls.Add(btn_a);
            Controls.Add(lbl_yanlis);
            Controls.Add(lbl);
            Controls.Add(lbl_sorusayisi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Bilgi Yarışması";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbl_yanlis;
        private Label lbl;
        private Label lbl_sorusayisi;
        private Button btn_a;
        private Button btn_b;
        private Button btn_c;
        private Button btn_d;
        private Button btn_sonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}