namespace OnlineBookShop
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            panel2 = new Panel();
            panel1 = new Panel();
            InStockBtnA = new Button();
            AboutBtnA = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            ContactBtnA = new Button();
            SaleBtnA = new Button();
            UserBtnA = new Button();
            BookBtnA = new Button();
            HomeBtnA = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Font = new Font("Garamond", 16.2F, FontStyle.Bold);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(320, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 696);
            panel2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(HomeBtnA);
            panel1.Controls.Add(InStockBtnA);
            panel1.Controls.Add(AboutBtnA);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(ContactBtnA);
            panel1.Controls.Add(SaleBtnA);
            panel1.Controls.Add(UserBtnA);
            panel1.Controls.Add(BookBtnA);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 696);
            panel1.TabIndex = 8;
            // 
            // InStockBtnA
            // 
            InStockBtnA.BackColor = SystemColors.ControlDarkDark;
            InStockBtnA.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InStockBtnA.ForeColor = Color.Black;
            InStockBtnA.Location = new Point(59, 378);
            InStockBtnA.Name = "InStockBtnA";
            InStockBtnA.Size = new Size(193, 45);
            InStockBtnA.TabIndex = 20;
            InStockBtnA.Text = "IN STOCK";
            InStockBtnA.UseVisualStyleBackColor = false;
            InStockBtnA.Click += InStockBtnA_Click;
            // 
            // AboutBtnA
            // 
            AboutBtnA.BackColor = Color.Teal;
            AboutBtnA.FlatStyle = FlatStyle.Popup;
            AboutBtnA.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutBtnA.ForeColor = Color.Black;
            AboutBtnA.Location = new Point(59, 539);
            AboutBtnA.Name = "AboutBtnA";
            AboutBtnA.Size = new Size(193, 45);
            AboutBtnA.TabIndex = 19;
            AboutBtnA.Text = "ABOUT";
            AboutBtnA.UseVisualStyleBackColor = false;
            AboutBtnA.Click += AboutBtnA_Click;
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
            // ContactBtnA
            // 
            ContactBtnA.BackColor = SystemColors.ControlDarkDark;
            ContactBtnA.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactBtnA.ForeColor = Color.Black;
            ContactBtnA.Location = new Point(59, 623);
            ContactBtnA.Name = "ContactBtnA";
            ContactBtnA.Size = new Size(193, 45);
            ContactBtnA.TabIndex = 17;
            ContactBtnA.Text = "CONTACT";
            ContactBtnA.UseVisualStyleBackColor = false;
            ContactBtnA.Click += ContactBtnA_Click;
            // 
            // SaleBtnA
            // 
            SaleBtnA.BackColor = SystemColors.ControlDarkDark;
            SaleBtnA.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaleBtnA.ForeColor = Color.Black;
            SaleBtnA.Location = new Point(59, 458);
            SaleBtnA.Name = "SaleBtnA";
            SaleBtnA.Size = new Size(193, 45);
            SaleBtnA.TabIndex = 16;
            SaleBtnA.Text = "SALE";
            SaleBtnA.UseVisualStyleBackColor = false;
            SaleBtnA.Click += SaleBtnA_Click;
            // 
            // UserBtnA
            // 
            UserBtnA.BackColor = SystemColors.ControlDarkDark;
            UserBtnA.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserBtnA.ForeColor = Color.Black;
            UserBtnA.Location = new Point(59, 296);
            UserBtnA.Name = "UserBtnA";
            UserBtnA.Size = new Size(193, 45);
            UserBtnA.TabIndex = 15;
            UserBtnA.Text = "USERS";
            UserBtnA.UseVisualStyleBackColor = false;
            UserBtnA.Click += UserBtnA_Click;
            // 
            // BookBtnA
            // 
            BookBtnA.BackColor = SystemColors.ControlDarkDark;
            BookBtnA.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookBtnA.ForeColor = Color.Black;
            BookBtnA.Location = new Point(59, 215);
            BookBtnA.Name = "BookBtnA";
            BookBtnA.Size = new Size(193, 45);
            BookBtnA.TabIndex = 14;
            BookBtnA.Text = "BOOKS";
            BookBtnA.UseVisualStyleBackColor = false;
            BookBtnA.Click += BookBtnA_Click;
            // 
            // HomeBtnA
            // 
            HomeBtnA.BackColor = SystemColors.ControlDarkDark;
            HomeBtnA.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtnA.ForeColor = Color.Black;
            HomeBtnA.Location = new Point(59, 136);
            HomeBtnA.Name = "HomeBtnA";
            HomeBtnA.Size = new Size(193, 45);
            HomeBtnA.TabIndex = 22;
            HomeBtnA.Text = "HOME";
            HomeBtnA.UseVisualStyleBackColor = false;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button InStockBtnA;
        private Button AboutBtnA;
        private PictureBox pictureBox1;
        private Label label9;
        private Button ContactBtnA;
        private Button SaleBtnA;
        private Button UserBtnA;
        private Button BookBtnA;
        private Button HomeBtnA;
    }
}