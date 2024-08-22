namespace OnlineBookShop
{
    partial class Contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact));
            panel2 = new Panel();
            LogOutBtnC = new Button();
            panel1 = new Panel();
            HomeBtnC = new Button();
            InStockBtnC = new Button();
            AboutBtnC = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            ContactBtnC = new Button();
            BookBtnC = new Button();
            DashBoardBtn = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(LogOutBtnC);
            panel2.Font = new Font("Garamond", 16.2F, FontStyle.Bold);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(320, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 696);
            panel2.TabIndex = 11;
            // 
            // LogOutBtnC
            // 
            LogOutBtnC.BackColor = Color.FromArgb(0, 0, 64);
            LogOutBtnC.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutBtnC.ForeColor = Color.White;
            LogOutBtnC.Location = new Point(841, 15);
            LogOutBtnC.Name = "LogOutBtnC";
            LogOutBtnC.Size = new Size(94, 45);
            LogOutBtnC.TabIndex = 34;
            LogOutBtnC.Text = "Log out";
            LogOutBtnC.UseVisualStyleBackColor = false;
            LogOutBtnC.Click += LogOutBtnC_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(DashBoardBtn);
            panel1.Controls.Add(HomeBtnC);
            panel1.Controls.Add(InStockBtnC);
            panel1.Controls.Add(AboutBtnC);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(ContactBtnC);
            panel1.Controls.Add(BookBtnC);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 696);
            panel1.TabIndex = 10;
            // 
            // HomeBtnC
            // 
            HomeBtnC.BackColor = SystemColors.ControlDarkDark;
            HomeBtnC.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtnC.ForeColor = Color.Black;
            HomeBtnC.Location = new Point(49, 136);
            HomeBtnC.Name = "HomeBtnC";
            HomeBtnC.Size = new Size(215, 45);
            HomeBtnC.TabIndex = 23;
            HomeBtnC.Text = "HOME";
            HomeBtnC.UseVisualStyleBackColor = false;
            HomeBtnC.Click += HomeBtnC_Click;
            // 
            // InStockBtnC
            // 
            InStockBtnC.BackColor = SystemColors.ControlDarkDark;
            InStockBtnC.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InStockBtnC.ForeColor = Color.Black;
            InStockBtnC.Location = new Point(49, 423);
            InStockBtnC.Name = "InStockBtnC";
            InStockBtnC.Size = new Size(215, 45);
            InStockBtnC.TabIndex = 20;
            InStockBtnC.Text = "IN STOCK";
            InStockBtnC.UseVisualStyleBackColor = false;
            InStockBtnC.Click += InStockBtnC_Click;
            // 
            // AboutBtnC
            // 
            AboutBtnC.BackColor = SystemColors.ControlDarkDark;
            AboutBtnC.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutBtnC.ForeColor = Color.Black;
            AboutBtnC.Location = new Point(49, 518);
            AboutBtnC.Name = "AboutBtnC";
            AboutBtnC.Size = new Size(215, 45);
            AboutBtnC.TabIndex = 19;
            AboutBtnC.Text = "ABOUT";
            AboutBtnC.UseVisualStyleBackColor = false;
            AboutBtnC.Click += AboutBtnC_Click;
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
            // ContactBtnC
            // 
            ContactBtnC.BackColor = Color.Teal;
            ContactBtnC.FlatStyle = FlatStyle.Popup;
            ContactBtnC.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactBtnC.ForeColor = Color.Black;
            ContactBtnC.Location = new Point(49, 610);
            ContactBtnC.Name = "ContactBtnC";
            ContactBtnC.Size = new Size(215, 45);
            ContactBtnC.TabIndex = 17;
            ContactBtnC.Text = "CONTACT";
            ContactBtnC.UseVisualStyleBackColor = false;
            ContactBtnC.Click += ContactBtnC_Click;
            // 
            // BookBtnC
            // 
            BookBtnC.BackColor = SystemColors.ControlDarkDark;
            BookBtnC.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookBtnC.ForeColor = Color.Black;
            BookBtnC.Location = new Point(49, 325);
            BookBtnC.Name = "BookBtnC";
            BookBtnC.Size = new Size(215, 45);
            BookBtnC.TabIndex = 14;
            BookBtnC.Text = "BOOKS";
            BookBtnC.UseVisualStyleBackColor = false;
            BookBtnC.Click += BookBtnC_Click;
            // 
            // DashBoardBtn
            // 
            DashBoardBtn.BackColor = SystemColors.ControlDarkDark;
            DashBoardBtn.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashBoardBtn.Location = new Point(48, 232);
            DashBoardBtn.Name = "DashBoardBtn";
            DashBoardBtn.Size = new Size(216, 44);
            DashBoardBtn.TabIndex = 25;
            DashBoardBtn.Text = "DASHBOARD";
            DashBoardBtn.UseVisualStyleBackColor = false;
            DashBoardBtn.Click += DashBoardBtn_Click;
            // 
            // Contact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Contact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contact";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Button InStockBtnC;
        private Button AboutBtnC;
        private PictureBox pictureBox1;
        private Label label9;
        private Button ContactBtnC;
        private Button BookBtnC;
        private Button HomeBtnC;
        private Button LogOutBtnC;
        private Button DashBoardBtn;
    }
}