namespace OnlineBookShop
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            panel1 = new Panel();
            HomeBtnU = new Button();
            InStockBtnU = new Button();
            AboutBtnU = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            ContactBtnU = new Button();
            SaleBtnU = new Button();
            UserBtnU = new Button();
            BookBtnU = new Button();
            panel2 = new Panel();
            LogOutBtnU = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(HomeBtnU);
            panel1.Controls.Add(InStockBtnU);
            panel1.Controls.Add(AboutBtnU);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(ContactBtnU);
            panel1.Controls.Add(SaleBtnU);
            panel1.Controls.Add(UserBtnU);
            panel1.Controls.Add(BookBtnU);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 696);
            panel1.TabIndex = 3;
            // 
            // HomeBtnU
            // 
            HomeBtnU.BackColor = SystemColors.ControlDarkDark;
            HomeBtnU.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtnU.ForeColor = Color.Black;
            HomeBtnU.Location = new Point(59, 136);
            HomeBtnU.Name = "HomeBtnU";
            HomeBtnU.Size = new Size(193, 45);
            HomeBtnU.TabIndex = 22;
            HomeBtnU.Text = "HOME";
            HomeBtnU.UseVisualStyleBackColor = false;
            HomeBtnU.Click += HomeBtnU_Click;
            // 
            // InStockBtnU
            // 
            InStockBtnU.BackColor = SystemColors.ControlDarkDark;
            InStockBtnU.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InStockBtnU.ForeColor = Color.Black;
            InStockBtnU.Location = new Point(59, 376);
            InStockBtnU.Name = "InStockBtnU";
            InStockBtnU.Size = new Size(193, 45);
            InStockBtnU.TabIndex = 20;
            InStockBtnU.Text = "IN STOCK";
            InStockBtnU.UseVisualStyleBackColor = false;
            InStockBtnU.Click += InStockBtnU_Click;
            // 
            // AboutBtnU
            // 
            AboutBtnU.BackColor = SystemColors.ControlDarkDark;
            AboutBtnU.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutBtnU.ForeColor = Color.Black;
            AboutBtnU.Location = new Point(59, 540);
            AboutBtnU.Name = "AboutBtnU";
            AboutBtnU.Size = new Size(193, 45);
            AboutBtnU.TabIndex = 19;
            AboutBtnU.Text = "ABOUT";
            AboutBtnU.UseVisualStyleBackColor = false;
            AboutBtnU.Click += AboutBtnU_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-15, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Gabriola", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Turquoise;
            label9.Location = new Point(164, 30);
            label9.Name = "label9";
            label9.Size = new Size(125, 53);
            label9.TabIndex = 13;
            label9.Text = "Book Shop";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // ContactBtnU
            // 
            ContactBtnU.BackColor = SystemColors.ControlDarkDark;
            ContactBtnU.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactBtnU.ForeColor = Color.Black;
            ContactBtnU.Location = new Point(59, 618);
            ContactBtnU.Name = "ContactBtnU";
            ContactBtnU.Size = new Size(193, 45);
            ContactBtnU.TabIndex = 17;
            ContactBtnU.Text = "CONTACT";
            ContactBtnU.UseVisualStyleBackColor = false;
            ContactBtnU.Click += ContactBtnU_Click;
            // 
            // SaleBtnU
            // 
            SaleBtnU.BackColor = SystemColors.ControlDarkDark;
            SaleBtnU.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaleBtnU.ForeColor = Color.Black;
            SaleBtnU.Location = new Point(59, 456);
            SaleBtnU.Name = "SaleBtnU";
            SaleBtnU.Size = new Size(193, 45);
            SaleBtnU.TabIndex = 16;
            SaleBtnU.Text = "SALE";
            SaleBtnU.UseVisualStyleBackColor = false;
            SaleBtnU.Click += SaleBtnU_Click;
            // 
            // UserBtnU
            // 
            UserBtnU.BackColor = Color.Teal;
            UserBtnU.FlatStyle = FlatStyle.Popup;
            UserBtnU.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserBtnU.ForeColor = Color.Black;
            UserBtnU.Location = new Point(59, 295);
            UserBtnU.Name = "UserBtnU";
            UserBtnU.Size = new Size(193, 45);
            UserBtnU.TabIndex = 15;
            UserBtnU.Text = "USERS";
            UserBtnU.UseVisualStyleBackColor = false;
            UserBtnU.Click += UserBtnU_Click;
            // 
            // BookBtnU
            // 
            BookBtnU.BackColor = SystemColors.ControlDarkDark;
            BookBtnU.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookBtnU.ForeColor = Color.Black;
            BookBtnU.Location = new Point(59, 214);
            BookBtnU.Name = "BookBtnU";
            BookBtnU.Size = new Size(193, 45);
            BookBtnU.TabIndex = 14;
            BookBtnU.Text = "BOOKS";
            BookBtnU.UseVisualStyleBackColor = false;
            BookBtnU.Click += BookBtnU_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(LogOutBtnU);
            panel2.Font = new Font("Garamond", 16.2F, FontStyle.Bold);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(320, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 696);
            panel2.TabIndex = 4;
            // 
            // LogOutBtnU
            // 
            LogOutBtnU.BackColor = Color.FromArgb(0, 0, 64);
            LogOutBtnU.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutBtnU.ForeColor = Color.White;
            LogOutBtnU.Location = new Point(840, 17);
            LogOutBtnU.Name = "LogOutBtnU";
            LogOutBtnU.Size = new Size(94, 45);
            LogOutBtnU.TabIndex = 34;
            LogOutBtnU.Text = "Log out";
            LogOutBtnU.UseVisualStyleBackColor = false;
            LogOutBtnU.Click += LogOutBtnU_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button InStockBtnU;
        private Button AboutBtnU;
        private PictureBox pictureBox1;
        private Label label9;
        private Button ContactBtnU;
        private Button SaleBtnU;
        private Button UserBtnU;
        private Button BookBtnU;
        private Panel panel2;
        private Button HomeBtnU;
        private Button LogOutBtnU;
    }
}