namespace Stok_Uygulaması
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            appDbContextBindingSource = new BindingSource(components);
            panelMenu = new Panel();
            cikisbutton = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            depobuton = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            mainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)appDbContextBindingSource).BeginInit();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(34, 45, 63);
            panelMenu.Controls.Add(cikisbutton);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(depobuton);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(3, 4, 3, 4);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(251, 969);
            panelMenu.TabIndex = 11;
            // 
            // cikisbutton
            // 
            cikisbutton.Cursor = Cursors.Hand;
            cikisbutton.Dock = DockStyle.Top;
            cikisbutton.FlatAppearance.BorderSize = 0;
            cikisbutton.FlatStyle = FlatStyle.Flat;
            cikisbutton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cikisbutton.ForeColor = Color.Gainsboro;
            cikisbutton.Image = Properties.Resources.icons8_logout_50;
            cikisbutton.ImageAlign = ContentAlignment.MiddleLeft;
            cikisbutton.Location = new Point(0, 688);
            cikisbutton.Margin = new Padding(3, 4, 3, 4);
            cikisbutton.Name = "cikisbutton";
            cikisbutton.Padding = new Padding(8, 0, 0, 0);
            cikisbutton.Size = new Size(251, 112);
            cikisbutton.TabIndex = 13;
            cikisbutton.Text = "Çıkış";
            cikisbutton.UseVisualStyleBackColor = true;
            cikisbutton.Click += cikisbutton_Click;
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
            button6.Location = new Point(0, 576);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Padding = new Padding(8, 0, 0, 0);
            button6.Size = new Size(251, 112);
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
            button5.Location = new Point(0, 464);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Padding = new Padding(8, 0, 0, 0);
            button5.Size = new Size(251, 112);
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
            button4.Location = new Point(0, 352);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Padding = new Padding(8, 0, 0, 0);
            button4.Size = new Size(251, 112);
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
            button2.Location = new Point(0, 240);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(8, 0, 0, 0);
            button2.Size = new Size(251, 112);
            button2.TabIndex = 8;
            button2.Text = "Raporlama";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            // 
            // depobuton
            // 
            depobuton.Cursor = Cursors.Hand;
            depobuton.Dock = DockStyle.Top;
            depobuton.FlatAppearance.BorderSize = 0;
            depobuton.FlatStyle = FlatStyle.Flat;
            depobuton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            depobuton.ForeColor = Color.Gainsboro;
            depobuton.Image = (Image)resources.GetObject("depobuton.Image");
            depobuton.ImageAlign = ContentAlignment.MiddleLeft;
            depobuton.Location = new Point(0, 128);
            depobuton.Margin = new Padding(3, 4, 3, 4);
            depobuton.Name = "depobuton";
            depobuton.Padding = new Padding(8, 0, 0, 0);
            depobuton.Size = new Size(251, 112);
            depobuton.TabIndex = 7;
            depobuton.Text = "Depo";
            depobuton.UseVisualStyleBackColor = true;
            depobuton.Click += depobuton_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(79, 104, 147);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(251, 128);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 45, 63);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(251, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 128);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(663, 19);
            label1.Name = "label1";
            label1.Size = new Size(214, 81);
            label1.TabIndex = 0;
            label1.Text = "MENÜ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(251, 128);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1500, 841);
            mainPanel.TabIndex = 13;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1751, 969);
            Controls.Add(mainPanel);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainPage";
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
        private Button depobuton;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button6;
        private PictureBox pictureBox1;
        private Button cikisbutton;
        private Panel panel1;
        private Label label1;
        private Panel mainPanel;
    }
}