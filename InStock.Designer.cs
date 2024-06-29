namespace OnlineBookShop
{
    partial class InStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InStock));
            panel1 = new Panel();
            DashBoardBtn = new Button();
            HomeBtnB = new Button();
            InStockBtnI = new Button();
            AboutBtnI = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            ContactBtnI = new Button();
            BookBtnI = new Button();
            panel2 = new Panel();
            LogOutBtnI = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(DashBoardBtn);
            panel1.Controls.Add(HomeBtnB);
            panel1.Controls.Add(InStockBtnI);
            panel1.Controls.Add(AboutBtnI);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(ContactBtnI);
            panel1.Controls.Add(BookBtnI);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 696);
            panel1.TabIndex = 4;
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
            // HomeBtnB
            // 
            HomeBtnB.BackColor = SystemColors.ControlDarkDark;
            HomeBtnB.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtnB.ForeColor = Color.Black;
            HomeBtnB.Location = new Point(47, 136);
            HomeBtnB.Name = "HomeBtnB";
            HomeBtnB.Size = new Size(215, 45);
            HomeBtnB.TabIndex = 22;
            HomeBtnB.Text = "HOME";
            HomeBtnB.UseVisualStyleBackColor = false;
            HomeBtnB.Click += HomeBtnB_Click;
            // 
            // InStockBtnI
            // 
            InStockBtnI.BackColor = Color.Teal;
            InStockBtnI.FlatStyle = FlatStyle.Popup;
            InStockBtnI.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InStockBtnI.ForeColor = Color.Black;
            InStockBtnI.Location = new Point(47, 420);
            InStockBtnI.Name = "InStockBtnI";
            InStockBtnI.Size = new Size(215, 45);
            InStockBtnI.TabIndex = 20;
            InStockBtnI.Text = "IN STOCK";
            InStockBtnI.UseVisualStyleBackColor = false;
            InStockBtnI.Click += InStockBtnI_Click;
            // 
            // AboutBtnI
            // 
            AboutBtnI.BackColor = SystemColors.ControlDarkDark;
            AboutBtnI.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutBtnI.ForeColor = Color.Black;
            AboutBtnI.Location = new Point(47, 517);
            AboutBtnI.Name = "AboutBtnI";
            AboutBtnI.Size = new Size(215, 45);
            AboutBtnI.TabIndex = 19;
            AboutBtnI.Text = "ABOUT";
            AboutBtnI.UseVisualStyleBackColor = false;
            AboutBtnI.Click += AboutBtnI_Click;
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
            // ContactBtnI
            // 
            ContactBtnI.BackColor = SystemColors.ControlDarkDark;
            ContactBtnI.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactBtnI.ForeColor = Color.Black;
            ContactBtnI.Location = new Point(47, 614);
            ContactBtnI.Name = "ContactBtnI";
            ContactBtnI.Size = new Size(215, 45);
            ContactBtnI.TabIndex = 17;
            ContactBtnI.Text = "CONTACT";
            ContactBtnI.UseVisualStyleBackColor = false;
            ContactBtnI.Click += ContactBtnI_Click;
            // 
            // BookBtnI
            // 
            BookBtnI.BackColor = SystemColors.ControlDarkDark;
            BookBtnI.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookBtnI.ForeColor = Color.Black;
            BookBtnI.Location = new Point(47, 323);
            BookBtnI.Name = "BookBtnI";
            BookBtnI.Size = new Size(215, 45);
            BookBtnI.TabIndex = 14;
            BookBtnI.Text = "BOOKS";
            BookBtnI.UseVisualStyleBackColor = false;
            BookBtnI.Click += BookBtnI_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(LogOutBtnI);
            panel2.Font = new Font("Garamond", 16.2F, FontStyle.Bold);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(320, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 696);
            panel2.TabIndex = 5;
            // 
            // LogOutBtnI
            // 
            LogOutBtnI.BackColor = Color.FromArgb(0, 0, 64);
            LogOutBtnI.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutBtnI.ForeColor = Color.White;
            LogOutBtnI.Location = new Point(838, 13);
            LogOutBtnI.Name = "LogOutBtnI";
            LogOutBtnI.Size = new Size(94, 45);
            LogOutBtnI.TabIndex = 34;
            LogOutBtnI.Text = "Log out";
            LogOutBtnI.UseVisualStyleBackColor = false;
            LogOutBtnI.Click += LogOutBtnI_Click;
            // 
            // InStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InStock";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button InStockBtnI;
        private Button AboutBtnI;
        private PictureBox pictureBox1;
        private Label label9;
        private Button ContactBtnI;
        private Button BookBtnI;
        private Panel panel2;
        private Button HomeBtnB;
        private Button LogOutBtnI;
        private Button DashBoardBtn;
    }
}