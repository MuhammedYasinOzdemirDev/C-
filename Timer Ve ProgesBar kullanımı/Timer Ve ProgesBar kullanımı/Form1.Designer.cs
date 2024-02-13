namespace Timer_Ve_ProgesBar_kullanımı
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
            components = new System.ComponentModel.Container();
            sayac = new System.Windows.Forms.Timer(components);
            saat = new System.Windows.Forms.Timer(components);
            progess = new System.Windows.Forms.Timer(components);
            sayacc = new Label();
            arkaplan = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            button2 = new Button();
            button3 = new Button();
            progressBar2 = new ProgressBar();
            SuspendLayout();
            // 
            // sayac
            // 
            sayac.Tick += sayac_Tick;
            // 
            // saat
            // 
            saat.Enabled = true;
            saat.Interval = 10;
            saat.Tick += saat_Tick;
            // 
            // progess
            // 
            progess.Enabled = true;
            progess.Tick += progess_Tick;
            // 
            // sayacc
            // 
            sayacc.AutoSize = true;
            sayacc.Location = new Point(65, 118);
            sayacc.Name = "sayacc";
            sayacc.Size = new Size(17, 20);
            sayacc.TabIndex = 0;
            sayacc.Text = "0";
            // 
            // arkaplan
            // 
            arkaplan.Enabled = true;
            arkaplan.Interval = 250;
            arkaplan.Tick += arkaplan_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(32, 141);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Başlat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 153);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 153);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 153);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(54, 241);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(125, 29);
            progressBar1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(65, 288);
            button2.Name = "button2";
            button2.Size = new Size(37, 29);
            button2.TabIndex = 6;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(118, 288);
            button3.Name = "button3";
            button3.Size = new Size(37, 29);
            button3.TabIndex = 7;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(426, 251);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(125, 29);
            progressBar2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(progressBar1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(sayacc);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer sayac;
        private System.Windows.Forms.Timer saat;
        private System.Windows.Forms.Timer progess;
        private Label sayacc;
        private System.Windows.Forms.Timer arkaplan;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ProgressBar progressBar1;
        private Button button2;
        private Button button3;
        private ProgressBar progressBar2;
    }
}