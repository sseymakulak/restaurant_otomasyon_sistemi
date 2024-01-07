namespace restaurant_os
{
    partial class GirişForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtpassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(110, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 16.2F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(172, 170);
            label1.Name = "label1";
            label1.Size = new Size(93, 33);
            label1.TabIndex = 1;
            label1.Text = "GİRİŞ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.kullanici;
            pictureBox2.Location = new Point(22, 285);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.sifre;
            pictureBox3.Location = new Point(22, 390);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DimGray;
            panel1.Location = new Point(22, 319);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 1);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Location = new Point(22, 424);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 1);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(22, 492);
            button1.Name = "button1";
            button1.Size = new Size(414, 44);
            button1.TabIndex = 6;
            button1.Text = "GİRİŞ YAP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(361, 453);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "Temizle";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(196, 558);
            label3.Name = "label3";
            label3.Size = new Size(54, 22);
            label3.TabIndex = 8;
            label3.Text = "Çıkış";
            label3.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(66, 292);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(370, 21);
            txtUsername.TabIndex = 9;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.White;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.Location = new Point(66, 397);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(370, 21);
            txtpassword.TabIndex = 10;
            // 
            // GirişForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(469, 620);
            Controls.Add(txtpassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GirişForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtpassword;
    }
}