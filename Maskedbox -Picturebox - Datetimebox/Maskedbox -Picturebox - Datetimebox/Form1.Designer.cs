namespace Maskedbox__Picturebox___Datetimebox
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
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label3 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label4 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(103, 29);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(128, 27);
            maskedTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 36);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 69);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 2;
            label2.Text = "T.C";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(103, 69);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(128, 27);
            maskedTextBox2.TabIndex = 3;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 104);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 4;
            label3.Text = "Tarih";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(103, 106);
            maskedTextBox3.Mask = "00/00/0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(128, 27);
            maskedTextBox3.TabIndex = 5;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 145);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 6;
            label4.Text = "Saat";
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(103, 145);
            maskedTextBox4.Mask = "00:00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(125, 27);
            maskedTextBox4.TabIndex = 7;
            maskedTextBox4.ValidatingType = typeof(DateTime);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(443, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 240);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(29, 291);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(275, 104);
            listBox1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(75, 200);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(maskedTextBox4);
            Controls.Add(label4);
            Controls.Add(maskedTextBox3);
            Controls.Add(label3);
            Controls.Add(maskedTextBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label2;
        private MaskedTextBox maskedTextBox2;
        private Label label3;
        private MaskedTextBox maskedTextBox3;
        private Label label4;
        private MaskedTextBox maskedTextBox4;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Button button1;
    }
}