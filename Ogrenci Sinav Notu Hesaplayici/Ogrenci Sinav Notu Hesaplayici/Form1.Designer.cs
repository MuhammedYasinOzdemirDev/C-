namespace Ogrenci_Sinav_Notu_Hesaplayici
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
            ad = new TextBox();
            soyad = new TextBox();
            label5 = new Label();
            label6 = new Label();
            vize = new TextBox();
            final = new TextBox();
            proje = new TextBox();
            quiz = new TextBox();
            hesapla = new Button();
            label7 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 117);
            label1.Name = "label1";
            label1.Size = new Size(35, 23);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(339, 155);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 1;
            label2.Text = "Final:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 152);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(339, 117);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 3;
            label4.Text = "Vize:";
            // 
            // ad
            // 
            ad.Location = new Point(113, 114);
            ad.Name = "ad";
            ad.Size = new Size(172, 30);
            ad.TabIndex = 4;
            // 
            // soyad
            // 
            soyad.Location = new Point(113, 152);
            soyad.Name = "soyad";
            soyad.Size = new Size(172, 30);
            soyad.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(509, 114);
            label5.Name = "label5";
            label5.Size = new Size(53, 23);
            label5.TabIndex = 6;
            label5.Text = "Proje:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(509, 152);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 7;
            label6.Text = "Quiz:";
            // 
            // vize
            // 
            vize.Location = new Point(393, 112);
            vize.Name = "vize";
            vize.Size = new Size(89, 30);
            vize.TabIndex = 8;
            // 
            // final
            // 
            final.Location = new Point(393, 150);
            final.Name = "final";
            final.Size = new Size(89, 30);
            final.TabIndex = 9;
            // 
            // proje
            // 
            proje.Location = new Point(568, 114);
            proje.Name = "proje";
            proje.Size = new Size(89, 30);
            proje.TabIndex = 10;
            // 
            // quiz
            // 
            quiz.Location = new Point(568, 150);
            quiz.Name = "quiz";
            quiz.Size = new Size(89, 30);
            quiz.TabIndex = 11;
            // 
            // hesapla
            // 
            hesapla.Location = new Point(690, 132);
            hesapla.Name = "hesapla";
            hesapla.Size = new Size(88, 41);
            hesapla.TabIndex = 12;
            hesapla.Text = "Hesapla";
            hesapla.UseVisualStyleBackColor = true;
            hesapla.Click += hesapla_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(107, 26);
            label7.Name = "label7";
            label7.Size = new Size(531, 50);
            label7.TabIndex = 13;
            label7.Text = "Öğrenci Not Hesaplayıcı";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(37, 216);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(741, 280);
            listBox1.TabIndex = 14;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(811, 518);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(hesapla);
            Controls.Add(quiz);
            Controls.Add(proje);
            Controls.Add(final);
            Controls.Add(vize);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(soyad);
            Controls.Add(ad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
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
        private TextBox ad;
        private TextBox soyad;
        private Label label5;
        private Label label6;
        private TextBox vize;
        private TextBox final;
        private TextBox proje;
        private TextBox quiz;
        private Button hesapla;
        private Label label7;
        private ListBox listBox1;
    }
}