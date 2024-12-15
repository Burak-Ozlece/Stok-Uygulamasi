namespace Stok_Uygulaması.Forms
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
            urunResmi = new PictureBox();
            barkodTextBox = new TextBox();
            barkodLabel = new Label();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            urunAraButon = new Button();
            panel1 = new Panel();
            teslimAlButon = new Button();
            teslimEtButon = new Button();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            panel2 = new Panel();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)urunResmi).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // urunResmi
            // 
            urunResmi.Location = new Point(57, 4);
            urunResmi.Margin = new Padding(3, 4, 3, 4);
            urunResmi.Name = "urunResmi";
            urunResmi.Size = new Size(267, 316);
            urunResmi.TabIndex = 1;
            urunResmi.TabStop = false;
            // 
            // barkodTextBox
            // 
            barkodTextBox.Cursor = Cursors.IBeam;
            barkodTextBox.Location = new Point(368, 49);
            barkodTextBox.Margin = new Padding(3, 4, 3, 4);
            barkodTextBox.MinimumSize = new Size(4, 10);
            barkodTextBox.Name = "barkodTextBox";
            barkodTextBox.PlaceholderText = "Ürün Adı veya Barkod Yazınız";
            barkodTextBox.Size = new Size(196, 27);
            barkodTextBox.TabIndex = 2;
            // 
            // barkodLabel
            // 
            barkodLabel.AutoSize = true;
            barkodLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            barkodLabel.Location = new Point(363, 17);
            barkodLabel.Name = "barkodLabel";
            barkodLabel.Size = new Size(184, 28);
            barkodLabel.TabIndex = 3;
            barkodLabel.Text = "Ürün Adı / Barkod";
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // urunAraButon
            // 
            urunAraButon.BackColor = Color.FromArgb(34, 45, 63);
            urunAraButon.Cursor = Cursors.Hand;
            urunAraButon.FlatStyle = FlatStyle.Flat;
            urunAraButon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            urunAraButon.ForeColor = Color.Gainsboro;
            urunAraButon.Location = new Point(381, 107);
            urunAraButon.Margin = new Padding(3, 4, 3, 4);
            urunAraButon.Name = "urunAraButon";
            urunAraButon.Size = new Size(173, 49);
            urunAraButon.TabIndex = 4;
            urunAraButon.Text = "Ürün Ara";
            urunAraButon.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(teslimAlButon);
            panel1.Controls.Add(teslimEtButon);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(urunResmi);
            panel1.Controls.Add(barkodTextBox);
            panel1.Controls.Add(urunAraButon);
            panel1.Controls.Add(barkodLabel);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1454, 349);
            panel1.TabIndex = 6;
            // 
            // teslimAlButon
            // 
            teslimAlButon.BackColor = Color.FromArgb(34, 45, 63);
            teslimAlButon.Cursor = Cursors.Hand;
            teslimAlButon.FlatStyle = FlatStyle.Flat;
            teslimAlButon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            teslimAlButon.ForeColor = Color.Gainsboro;
            teslimAlButon.Location = new Point(841, 133);
            teslimAlButon.Margin = new Padding(3, 4, 3, 4);
            teslimAlButon.Name = "teslimAlButon";
            teslimAlButon.Size = new Size(173, 49);
            teslimAlButon.TabIndex = 8;
            teslimAlButon.Text = "Teslim Al";
            teslimAlButon.UseVisualStyleBackColor = false;
            // 
            // teslimEtButon
            // 
            teslimEtButon.BackColor = Color.FromArgb(34, 45, 63);
            teslimEtButon.Cursor = Cursors.Hand;
            teslimEtButon.FlatStyle = FlatStyle.Flat;
            teslimEtButon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            teslimEtButon.ForeColor = Color.Gainsboro;
            teslimEtButon.Location = new Point(841, 49);
            teslimEtButon.Margin = new Padding(3, 4, 3, 4);
            teslimEtButon.Name = "teslimEtButon";
            teslimEtButon.Size = new Size(173, 49);
            teslimEtButon.TabIndex = 7;
            teslimEtButon.Text = "Teslim Et";
            teslimEtButon.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(618, 17);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 6;
            label3.Text = "Miktar Sayısı";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(624, 49);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(137, 27);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(14, 403);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1454, 323);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(808, 12);
            label2.Name = "label2";
            label2.Size = new Size(298, 30);
            label2.TabIndex = 3;
            label2.Text = "Seçilen Ürünler";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(808, 56);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(625, 243);
            dataGridView2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(317, 30);
            label1.TabIndex = 1;
            label1.Text = "Depodaki Ürünler";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 56);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(625, 243);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 45, 63);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(841, 210);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(173, 49);
            button1.TabIndex = 9;
            button1.Text = "Teslim Al";
            button1.UseVisualStyleBackColor = false;
            // 
            // Depo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1481, 789);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Depo";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)urunResmi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox urunResmi;
        private TextBox barkodTextBox;
        private Label barkodLabel;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Button urunAraButon;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridView dataGridView2;
        private Button teslimEtButon;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button teslimAlButon;
        private Button button1;
    }
}