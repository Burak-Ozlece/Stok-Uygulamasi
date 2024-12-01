namespace Stok_Uygulaması.Forms
{
    partial class UserUpdatePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUpdatePassword));
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(421, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(442, 22);
            label6.Name = "label6";
            label6.Size = new Size(355, 40);
            label6.TabIndex = 22;
            label6.Text = "Yeni şifre en az 6 karakter uzunluğunda olmalı, \r\nbir harf, bir rakam ve bir özel karakter içermelidir.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(506, 139);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(144, 136);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(221, 27);
            textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(144, 98);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(221, 27);
            textBox3.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 136);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 18;
            label4.Text = "Yeni Şifre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 98);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 17;
            label3.Text = "Yeni Şifre:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(144, 60);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(221, 27);
            textBox2.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 60);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 15;
            label2.Text = "Eski Şifre:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(144, 22);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 27);
            textBox1.TabIndex = 14;
            textBox1.Text = "admin";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 13;
            label1.Text = "Kullanıcı Adı:";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(108, 185);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(145, 51);
            button1.TabIndex = 12;
            button1.Text = "güncelle";
            button1.UseVisualStyleBackColor = false;
            // 
            // UserUpdatePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "UserUpdatePassword";
            Text = "UserUpdatePassword";
            Load += UserUpdatePassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}