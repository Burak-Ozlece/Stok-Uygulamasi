namespace Stok_Uygulaması
{
    partial class Depo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depo));
            textBox1 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            appDbContextBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button8 = new Button();
            button11 = new Button();
            button7 = new Button();
            button10 = new Button();
            button9 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(509, 181);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Barkod No İle Arama";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(975, 281);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Ürün Ara";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 214);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1283, 268);
            dataGridView1.TabIndex = 2;
            // 
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(AppDbContext);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(726, 181);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Stok Kodu İle Arama";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(912, 181);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Ürün Adı İle arama";
            textBox3.Size = new Size(457, 27);
            textBox3.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1751, 144);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button10);
            panel2.Controls.Add(button9);
            panel2.Location = new Point(330, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1039, 138);
            panel2.TabIndex = 6;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            button8.ForeColor = Color.IndianRed;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.TopCenter;
            button8.Location = new Point(828, 6);
            button8.Name = "button8";
            button8.Size = new Size(177, 129);
            button8.TabIndex = 7;
            button8.Text = "Üyeler";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            button11.ForeColor = Color.IndianRed;
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.TopCenter;
            button11.Location = new Point(439, 6);
            button11.Name = "button11";
            button11.Size = new Size(177, 129);
            button11.TabIndex = 10;
            button11.Text = "Hareket İncele";
            button11.TextAlign = ContentAlignment.BottomCenter;
            button11.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            button7.ForeColor = Color.IndianRed;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.TopCenter;
            button7.Location = new Point(52, 6);
            button7.Name = "button7";
            button7.Size = new Size(177, 129);
            button7.TabIndex = 6;
            button7.Text = "Hareket İncele";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            button10.ForeColor = Color.IndianRed;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.TopCenter;
            button10.Location = new Point(634, 6);
            button10.Name = "button10";
            button10.Size = new Size(177, 129);
            button10.TabIndex = 9;
            button10.Text = "Ürün Arama";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            button9.ForeColor = Color.IndianRed;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.TopCenter;
            button9.Location = new Point(244, 6);
            button9.Name = "button9";
            button9.Size = new Size(177, 129);
            button9.TabIndex = 8;
            button9.Text = "Ürün İşlemleri";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = false;
            // 
            // Depo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1751, 784);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Depo";
            Text = "Depo";
            WindowState = FormWindowState.Maximized;
            Load += Depo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource appDbContextBindingSource;
        private TextBox textBox2;
        private TextBox textBox3;
        private Panel panel1;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Panel panel2;
    }
}