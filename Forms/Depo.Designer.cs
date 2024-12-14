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
            appDbContextBindingSource = new BindingSource(components);
            panelMenu = new Panel();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // appDbContextBindingSource
            // 
            appDbContextBindingSource.DataSource = typeof(AppDbContext);
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(34, 45, 63);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 727);
            panelMenu.TabIndex = 11;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.Gainsboro;
            button3.Image = Properties.Resources.icons8_logout_50;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 516);
            button3.Name = "button3";
            button3.Padding = new Padding(7, 0, 0, 0);
            button3.Size = new Size(220, 84);
            button3.TabIndex = 13;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.ForeColor = Color.Gainsboro;
            button6.Image = Properties.Resources.icons8_setting_50;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 432);
            button6.Name = "button6";
            button6.Padding = new Padding(7, 0, 0, 0);
            button6.Size = new Size(220, 84);
            button6.TabIndex = 12;
            button6.Text = "Ayarlar";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.ForeColor = Color.Gainsboro;
            button5.Image = Properties.Resources.icons8_users_50;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 348);
            button5.Name = "button5";
            button5.Padding = new Padding(7, 0, 0, 0);
            button5.Size = new Size(220, 84);
            button5.TabIndex = 11;
            button5.Text = "Üye";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.ForeColor = Color.Gainsboro;
            button4.Image = Properties.Resources.icons8_backup_50;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 264);
            button4.Name = "button4";
            button4.Padding = new Padding(7, 0, 0, 0);
            button4.Size = new Size(220, 84);
            button4.TabIndex = 10;
            button4.Text = "Yedekleme";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Gainsboro;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 180);
            button2.Name = "button2";
            button2.Padding = new Padding(7, 0, 0, 0);
            button2.Size = new Size(220, 84);
            button2.TabIndex = 8;
            button2.Text = "Raporlama";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Gainsboro;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 96);
            button1.Name = "button1";
            button1.Padding = new Padding(7, 0, 0, 0);
            button1.Size = new Size(220, 84);
            button1.TabIndex = 7;
            button1.Text = "Depo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(79, 104, 147);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 96);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 45, 63);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 96);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(579, 14);
            label1.Name = "label1";
            label1.Size = new Size(173, 65);
            label1.TabIndex = 0;
            label1.Text = "MENÜ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(220, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 631);
            panel2.TabIndex = 13;
            // 
            // Depo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1532, 727);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Depo";
            Text = "Depo";
            Load += Depo_Load;
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).EndInit();
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource appDbContextBindingSource;
        private Panel panelMenu;
        private Panel panelLogo;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button6;
        private PictureBox pictureBox1;
        private Button button3;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
    }
}