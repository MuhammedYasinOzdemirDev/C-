namespace Kosul_İfadeleri_Uygulamalar
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            viz = new TextBox();
            final = new TextBox();
            proje = new TextBox();
            quiz = new TextBox();
            button1 = new Button();
            label6 = new Label();
            harf_n = new TextBox();
            label7 = new Label();
            k_sayisi = new TextBox();
            label8 = new Label();
            sonuc = new TextBox();
            label9 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 42);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(412, 27);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Sınav Durumu Hesaplayıcı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 90);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 1;
            label2.Text = "Vize:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 137);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 2;
            label3.Text = "Final:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 184);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 3;
            label4.Text = "Proje";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 230);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 25);
            label5.TabIndex = 4;
            label5.Text = "Quiz";
            // 
            // viz
            // 
            viz.Location = new Point(136, 90);
            viz.Margin = new Padding(5, 4, 5, 4);
            viz.Name = "viz";
            viz.Size = new Size(201, 32);
            viz.TabIndex = 5;
            // 
            // final
            // 
            final.Location = new Point(136, 137);
            final.Margin = new Padding(5, 4, 5, 4);
            final.Name = "final";
            final.Size = new Size(201, 32);
            final.TabIndex = 6;
            // 
            // proje
            // 
            proje.Location = new Point(136, 184);
            proje.Margin = new Padding(5, 4, 5, 4);
            proje.Name = "proje";
            proje.Size = new Size(201, 32);
            proje.TabIndex = 7;
            // 
            // quiz
            // 
            quiz.Location = new Point(136, 230);
            quiz.Margin = new Padding(5, 4, 5, 4);
            quiz.Name = "quiz";
            quiz.Size = new Size(201, 32);
            quiz.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(136, 286);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(203, 41);
            button1.TabIndex = 9;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 363);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 25);
            label6.TabIndex = 10;
            label6.Text = "Harf Notu:";
            label6.Click += label6_Click;
            // 
            // harf_n
            // 
            harf_n.Enabled = false;
            harf_n.Location = new Point(176, 360);
            harf_n.Name = "harf_n";
            harf_n.Size = new Size(125, 32);
            harf_n.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(550, 42);
            label7.Margin = new Padding(5, 0, 5, 0);
            label7.Name = "label7";
            label7.Size = new Size(538, 27);
            label7.TabIndex = 12;
            label7.Text = "Alışveriş İndirimli Toplam Tutar Hesaplayıcı";
            // 
            // k_sayisi
            // 
            k_sayisi.Location = new Point(771, 90);
            k_sayisi.Margin = new Padding(5, 4, 5, 4);
            k_sayisi.Name = "k_sayisi";
            k_sayisi.Size = new Size(201, 32);
            k_sayisi.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(622, 93);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(140, 25);
            label8.TabIndex = 13;
            label8.Text = "Kitap Sayısı:";
            // 
            // sonuc
            // 
            sonuc.Enabled = false;
            sonuc.Location = new Point(811, 211);
            sonuc.Name = "sonuc";
            sonuc.Size = new Size(125, 32);
            sonuc.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(654, 214);
            label9.Margin = new Padding(5, 0, 5, 0);
            label9.Name = "label9";
            label9.Size = new Size(149, 25);
            label9.TabIndex = 16;
            label9.Text = "Toplam Fiyat:";
            // 
            // button2
            // 
            button2.Location = new Point(771, 137);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(203, 41);
            button2.TabIndex = 15;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 562);
            Controls.Add(sonuc);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(k_sayisi);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(harf_n);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(quiz);
            Controls.Add(proje);
            Controls.Add(final);
            Controls.Add(viz);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox viz;
        private TextBox final;
        private TextBox proje;
        private TextBox quiz;
        private Button button1;
        private Label label6;
        private TextBox harf_n;
        private Label label7;
        private TextBox k_sayisi;
        private Label label8;
        private TextBox sonuc;
        private Label label9;
        private Button button2;
    }
}