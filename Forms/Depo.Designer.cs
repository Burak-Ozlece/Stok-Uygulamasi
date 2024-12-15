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
            teslimEdilenlerButon = new Button();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            duzenlemeButon = new Button();
            teslimAlButon = new Button();
            teslimEtButon = new Button();
            panel2 = new Panel();
            label2 = new Label();
            secilenUrunlerDataGrid = new DataGridView();
            label1 = new Label();
            depodakiUrunlerDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)urunResmi).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)secilenUrunlerDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)depodakiUrunlerDataGrid).BeginInit();
            SuspendLayout();
            // 
            // urunResmi
            // 
            urunResmi.Image = Properties.Resources.icons8_product_100;
            urunResmi.Location = new Point(16, 4);
            urunResmi.Margin = new Padding(3, 4, 3, 4);
            urunResmi.Name = "urunResmi";
            urunResmi.Size = new Size(256, 328);
            urunResmi.SizeMode = PictureBoxSizeMode.Zoom;
            urunResmi.TabIndex = 1;
            urunResmi.TabStop = false;
            // 
            // barkodTextBox
            // 
            barkodTextBox.Cursor = Cursors.IBeam;
            barkodTextBox.Location = new Point(363, 49);
            barkodTextBox.Margin = new Padding(3, 4, 3, 4);
            barkodTextBox.MinimumSize = new Size(4, 10);
            barkodTextBox.Name = "barkodTextBox";
            barkodTextBox.PlaceholderText = "Ürün Adı veya Barkod Yazınız";
            barkodTextBox.Size = new Size(208, 27);
            barkodTextBox.TabIndex = 2;
            // 
            // barkodLabel
            // 
            barkodLabel.AutoSize = true;
            barkodLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            barkodLabel.Location = new Point(360, 17);
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
            urunAraButon.Location = new Point(371, 107);
            urunAraButon.Margin = new Padding(3, 4, 3, 4);
            urunAraButon.Name = "urunAraButon";
            urunAraButon.Size = new Size(173, 49);
            urunAraButon.TabIndex = 4;
            urunAraButon.Text = "Ürün Ara";
            urunAraButon.UseVisualStyleBackColor = false;
            urunAraButon.Click += urunAraButon_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(teslimEdilenlerButon);
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
            // teslimEdilenlerButon
            // 
            teslimEdilenlerButon.BackColor = Color.FromArgb(34, 45, 63);
            teslimEdilenlerButon.Cursor = Cursors.Hand;
            teslimEdilenlerButon.FlatStyle = FlatStyle.Flat;
            teslimEdilenlerButon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            teslimEdilenlerButon.ForeColor = Color.Gainsboro;
            teslimEdilenlerButon.Location = new Point(606, 107);
            teslimEdilenlerButon.Margin = new Padding(3, 4, 3, 4);
            teslimEdilenlerButon.Name = "teslimEdilenlerButon";
            teslimEdilenlerButon.Size = new Size(173, 49);
            teslimEdilenlerButon.TabIndex = 10;
            teslimEdilenlerButon.Text = "Teslim Edilenler";
            teslimEdilenlerButon.UseVisualStyleBackColor = false;
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
            // duzenlemeButon
            // 
            duzenlemeButon.BackColor = Color.FromArgb(34, 45, 63);
            duzenlemeButon.Cursor = Cursors.Hand;
            duzenlemeButon.FlatStyle = FlatStyle.Flat;
            duzenlemeButon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            duzenlemeButon.ForeColor = Color.Gainsboro;
            duzenlemeButon.Location = new Point(1220, 734);
            duzenlemeButon.Margin = new Padding(3, 4, 3, 4);
            duzenlemeButon.Name = "duzenlemeButon";
            duzenlemeButon.Size = new Size(184, 49);
            duzenlemeButon.TabIndex = 9;
            duzenlemeButon.Text = "Stok Düzenleme";
            duzenlemeButon.UseVisualStyleBackColor = false;
            // 
            // teslimAlButon
            // 
            teslimAlButon.BackColor = Color.FromArgb(34, 45, 63);
            teslimAlButon.Cursor = Cursors.Hand;
            teslimAlButon.FlatStyle = FlatStyle.Flat;
            teslimAlButon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            teslimAlButon.ForeColor = Color.Gainsboro;
            teslimAlButon.Location = new Point(1021, 734);
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
            teslimEtButon.Location = new Point(822, 734);
            teslimEtButon.Margin = new Padding(3, 4, 3, 4);
            teslimEtButon.Name = "teslimEtButon";
            teslimEtButon.Size = new Size(173, 49);
            teslimEtButon.TabIndex = 7;
            teslimEtButon.Text = "Teslim Et";
            teslimEtButon.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(secilenUrunlerDataGrid);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(depodakiUrunlerDataGrid);
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
            // secilenUrunlerDataGrid
            // 
            secilenUrunlerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            secilenUrunlerDataGrid.Location = new Point(808, 56);
            secilenUrunlerDataGrid.Margin = new Padding(3, 4, 3, 4);
            secilenUrunlerDataGrid.Name = "secilenUrunlerDataGrid";
            secilenUrunlerDataGrid.RowHeadersWidth = 51;
            secilenUrunlerDataGrid.Size = new Size(625, 243);
            secilenUrunlerDataGrid.TabIndex = 2;
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
            // depodakiUrunlerDataGrid
            // 
            depodakiUrunlerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            depodakiUrunlerDataGrid.Location = new Point(16, 56);
            depodakiUrunlerDataGrid.Margin = new Padding(3, 4, 3, 4);
            depodakiUrunlerDataGrid.Name = "depodakiUrunlerDataGrid";
            depodakiUrunlerDataGrid.RowHeadersWidth = 51;
            depodakiUrunlerDataGrid.Size = new Size(625, 243);
            depodakiUrunlerDataGrid.TabIndex = 0;
            // 
            // Depo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1482, 794);
            Controls.Add(panel2);
            Controls.Add(duzenlemeButon);
            Controls.Add(panel1);
            Controls.Add(teslimAlButon);
            Controls.Add(teslimEtButon);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Depo";
            Text = " ";
            Load += Depo_Load;
            ((System.ComponentModel.ISupportInitialize)urunResmi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)secilenUrunlerDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)depodakiUrunlerDataGrid).EndInit();
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
        private DataGridView depodakiUrunlerDataGrid;
        private Label label2;
        private DataGridView secilenUrunlerDataGrid;
        private Button teslimEtButon;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button teslimAlButon;
        private Button duzenlemeButon;
        private Button teslimEdilenlerButon;
    }
}