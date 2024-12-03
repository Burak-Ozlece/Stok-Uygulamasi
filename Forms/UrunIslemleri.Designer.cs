namespace Stok_Uygulaması.Forms
{
    partial class UrunIslemleri
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
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(235, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(29, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(235, 32);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 5;
            label1.Text = "Ürün Adı";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(434, 32);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 9;
            label3.Text = "Barkod";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(434, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(130, 23);
            textBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(427, 144);
            button1.Name = "button1";
            button1.Size = new Size(105, 34);
            button1.TabIndex = 10;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(538, 144);
            button2.Name = "button2";
            button2.Size = new Size(105, 34);
            button2.TabIndex = 11;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(649, 144);
            button3.Name = "button3";
            button3.Size = new Size(105, 34);
            button3.TabIndex = 12;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(721, 192);
            dataGridView1.TabIndex = 13;
            // 
            // button4
            // 
            button4.Location = new Point(316, 144);
            button4.Name = "button4";
            button4.Size = new Size(105, 34);
            button4.TabIndex = 14;
            button4.Text = "Ürün Ekle";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // npgsqlCommandBuilder1
            // 
            npgsqlCommandBuilder1.QuotePrefix = "\"";
            npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // button5
            // 
            button5.Location = new Point(205, 144);
            button5.Name = "button5";
            button5.Size = new Size(105, 34);
            button5.TabIndex = 15;
            button5.Text = "Ürün Ekle";
            button5.UseVisualStyleBackColor = true;
            // 
            // UrunIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Name = "UrunIslemleri";
            Text = "UrunIslemleri";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private Button button4;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Button button5;
    }
}