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
            LogOutBtnA = new Button();
            panel1 = new Panel();
            HomeBtnA = new Button();
            InStockBtnA = new Button();
            AboutBtnA = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            ContactBtnA = new Button();
            BookBtnA = new Button();
            DashBoardBtn = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(LogOutBtnA);
            panel2.Font = new Font("Garamond", 16.2F, FontStyle.Bold);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(320, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 696);
            panel2.TabIndex = 9;
            // 
            // LogOutBtnA
            // 
            LogOutBtnA.BackColor = Color.FromArgb(0, 0, 64);
            LogOutBtnA.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutBtnA.ForeColor = Color.White;
            LogOutBtnA.Location = new Point(842, 12);
            LogOutBtnA.Name = "LogOutBtnA";
            LogOutBtnA.Size = new Size(94, 45);
            LogOutBtnA.TabIndex = 34;
            LogOutBtnA.Text = "Log out";
            LogOutBtnA.UseVisualStyleBackColor = false;
            LogOutBtnA.Click += LogOutBtnA_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(DashBoardBtn);
            panel1.Controls.Add(HomeBtnA);
            panel1.Controls.Add(InStockBtnA);
            panel1.Controls.Add(AboutBtnA);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(ContactBtnA);
            panel1.Controls.Add(BookBtnA);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 696);
            panel1.TabIndex = 8;
            // 
            // HomeBtnA
            // 
            HomeBtnA.BackColor = SystemColors.ControlDarkDark;
            HomeBtnA.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtnA.ForeColor = Color.Black;
            HomeBtnA.Location = new Point(47, 136);
            HomeBtnA.Name = "HomeBtnA";
            HomeBtnA.Size = new Size(216, 45);
            HomeBtnA.TabIndex = 22;
            HomeBtnA.Text = "HOME";
            HomeBtnA.UseVisualStyleBackColor = false;
            HomeBtnA.Click += HomeBtnA_Click;
            // 
            // InStockBtnA
            // 
            InStockBtnA.BackColor = SystemColors.ControlDarkDark;
            InStockBtnA.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InStockBtnA.ForeColor = Color.Black;
            InStockBtnA.Location = new Point(47, 420);
            InStockBtnA.Name = "InStockBtnA";
            InStockBtnA.Size = new Size(216, 45);
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
            AboutBtnA.Location = new Point(47, 517);
            AboutBtnA.Name = "AboutBtnA";
            AboutBtnA.Size = new Size(216, 45);
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
            ContactBtnA.Location = new Point(47, 613);
            ContactBtnA.Name = "ContactBtnA";
            ContactBtnA.Size = new Size(216, 45);
            ContactBtnA.TabIndex = 17;
            ContactBtnA.Text = "CONTACT";
            ContactBtnA.UseVisualStyleBackColor = false;
            ContactBtnA.Click += ContactBtnA_Click;
            // 
            // BookBtnA
            // 
            BookBtnA.BackColor = SystemColors.ControlDarkDark;
            BookBtnA.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookBtnA.ForeColor = Color.Black;
            BookBtnA.Location = new Point(47, 328);
            BookBtnA.Name = "BookBtnA";
            BookBtnA.Size = new Size(216, 45);
            BookBtnA.TabIndex = 14;
            BookBtnA.Text = "BOOKS";
            BookBtnA.UseVisualStyleBackColor = false;
            BookBtnA.Click += BookBtnA_Click;
            // 
            // DashBoardBtn
            // 
            DashBoardBtn.BackColor = SystemColors.ControlDarkDark;
            DashBoardBtn.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashBoardBtn.Location = new Point(47, 230);
            DashBoardBtn.Name = "DashBoardBtn";
            DashBoardBtn.Size = new Size(216, 44);
            DashBoardBtn.TabIndex = 25;
            DashBoardBtn.Text = "DASHBOARD";
            DashBoardBtn.UseVisualStyleBackColor = false;
            DashBoardBtn.Click += DashBoardBtn_Click;
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
            panel2.ResumeLayout(false);
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
        private Button BookBtnA;
        private Button HomeBtnA;
        private Button LogOutBtnA;
        private Button DashBoardBtn;
    }
}
