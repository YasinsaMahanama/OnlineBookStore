namespace OnlineBookShop
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            panel2 = new Panel();
            LogOutBtnS = new Button();
            panel1 = new Panel();
            HomeBtnS = new Button();
            InStockBtnS = new Button();
            AboutBtnS = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            ContactBtnS = new Button();
            SaleBtnS = new Button();
            BookBtnS = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(LogOutBtnS);
            panel2.Font = new Font("Garamond", 16.2F, FontStyle.Bold);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(320, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 696);
            panel2.TabIndex = 9;
            // 
            // LogOutBtnS
            // 
            LogOutBtnS.BackColor = Color.FromArgb(0, 0, 64);
            LogOutBtnS.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutBtnS.ForeColor = Color.White;
            LogOutBtnS.Location = new Point(841, 13);
            LogOutBtnS.Name = "LogOutBtnS";
            LogOutBtnS.Size = new Size(94, 45);
            LogOutBtnS.TabIndex = 34;
            LogOutBtnS.Text = "Log out";
            LogOutBtnS.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(HomeBtnS);
            panel1.Controls.Add(InStockBtnS);
            panel1.Controls.Add(AboutBtnS);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(ContactBtnS);
            panel1.Controls.Add(SaleBtnS);
            panel1.Controls.Add(BookBtnS);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 696);
            panel1.TabIndex = 8;
            // 
            // HomeBtnS
            // 
            HomeBtnS.BackColor = SystemColors.ControlDarkDark;
            HomeBtnS.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtnS.ForeColor = Color.Black;
            HomeBtnS.Location = new Point(47, 136);
            HomeBtnS.Name = "HomeBtnS";
            HomeBtnS.Size = new Size(216, 45);
            HomeBtnS.TabIndex = 22;
            HomeBtnS.Text = "HOME";
            HomeBtnS.UseVisualStyleBackColor = false;
            HomeBtnS.Click += HomeBtnS_Click;
            // 
            // InStockBtnS
            // 
            InStockBtnS.BackColor = SystemColors.ControlDarkDark;
            InStockBtnS.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InStockBtnS.ForeColor = Color.Black;
            InStockBtnS.Location = new Point(47, 419);
            InStockBtnS.Name = "InStockBtnS";
            InStockBtnS.Size = new Size(216, 45);
            InStockBtnS.TabIndex = 20;
            InStockBtnS.Text = "IN STOCK";
            InStockBtnS.UseVisualStyleBackColor = false;
            // 
            // AboutBtnS
            // 
            AboutBtnS.BackColor = SystemColors.ControlDarkDark;
            AboutBtnS.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutBtnS.ForeColor = Color.Black;
            AboutBtnS.Location = new Point(47, 515);
            AboutBtnS.Name = "AboutBtnS";
            AboutBtnS.Size = new Size(216, 45);
            AboutBtnS.TabIndex = 19;
            AboutBtnS.Text = "ABOUT";
            AboutBtnS.UseVisualStyleBackColor = false;
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
            // ContactBtnS
            // 
            ContactBtnS.BackColor = SystemColors.ControlDarkDark;
            ContactBtnS.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactBtnS.ForeColor = Color.Black;
            ContactBtnS.Location = new Point(47, 612);
            ContactBtnS.Name = "ContactBtnS";
            ContactBtnS.Size = new Size(216, 45);
            ContactBtnS.TabIndex = 17;
            ContactBtnS.Text = "CONTACT";
            ContactBtnS.UseVisualStyleBackColor = false;
            // 
            // SaleBtnS
            // 
            SaleBtnS.BackColor = Color.Teal;
            SaleBtnS.FlatStyle = FlatStyle.Popup;
            SaleBtnS.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaleBtnS.ForeColor = Color.Black;
            SaleBtnS.Location = new Point(47, 236);
            SaleBtnS.Name = "SaleBtnS";
            SaleBtnS.Size = new Size(216, 45);
            SaleBtnS.TabIndex = 16;
            SaleBtnS.Text = "DASHBOARD";
            SaleBtnS.UseVisualStyleBackColor = false;
            SaleBtnS.Click += SaleBtnS_Click;
            // 
            // BookBtnS
            // 
            BookBtnS.BackColor = SystemColors.ControlDarkDark;
            BookBtnS.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookBtnS.ForeColor = Color.Black;
            BookBtnS.Location = new Point(47, 327);
            BookBtnS.Name = "BookBtnS";
            BookBtnS.Size = new Size(216, 45);
            BookBtnS.TabIndex = 14;
            BookBtnS.Text = "BOOKS";
            BookBtnS.UseVisualStyleBackColor = false;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button LogOutBtnS;
        private Panel panel1;
        private Button HomeBtnS;
        private Button InStockBtnS;
        private Button AboutBtnS;
        private PictureBox pictureBox1;
        private Label label9;
        private Button ContactBtnS;
        private Button SaleBtnS;
        private Button BookBtnS;
    }
}