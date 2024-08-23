namespace OnlineBookShop
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            panel2 = new Panel();
            LogOutBtnS = new Button();
            DashBoardBtn = new Button();
            HomeBtnB = new Button();
            InStockBtnB = new Button();
            AboutBtnB = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            ContactBtnB = new Button();
            BookBtnB = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            dataGridView4 = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView4);
            panel2.Controls.Add(dataGridView3);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(LogOutBtnS);
            panel2.Font = new Font("Garamond", 16.2F, FontStyle.Bold);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(320, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 696);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
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
            // DashBoardBtn
            // 
            DashBoardBtn.BackColor = SystemColors.ControlDarkDark;
            DashBoardBtn.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashBoardBtn.Location = new Point(48, 233);
            DashBoardBtn.Name = "DashBoardBtn";
            DashBoardBtn.Size = new Size(216, 44);
            DashBoardBtn.TabIndex = 24;
            DashBoardBtn.Text = "DASHBOARD";
            DashBoardBtn.UseVisualStyleBackColor = false;
            DashBoardBtn.Click += DashBoardBtn_Click;
            // 
            // HomeBtnB
            // 
            HomeBtnB.BackColor = SystemColors.ControlDarkDark;
            HomeBtnB.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtnB.ForeColor = Color.Black;
            HomeBtnB.Location = new Point(48, 136);
            HomeBtnB.Name = "HomeBtnB";
            HomeBtnB.Size = new Size(216, 45);
            HomeBtnB.TabIndex = 21;
            HomeBtnB.Text = "HOME";
            HomeBtnB.UseVisualStyleBackColor = false;
            // 
            // InStockBtnB
            // 
            InStockBtnB.BackColor = SystemColors.ControlDarkDark;
            InStockBtnB.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InStockBtnB.ForeColor = Color.Black;
            InStockBtnB.Location = new Point(48, 421);
            InStockBtnB.Name = "InStockBtnB";
            InStockBtnB.Size = new Size(216, 45);
            InStockBtnB.TabIndex = 20;
            InStockBtnB.Text = "IN STOCK";
            InStockBtnB.UseVisualStyleBackColor = false;
            // 
            // AboutBtnB
            // 
            AboutBtnB.BackColor = SystemColors.ControlDarkDark;
            AboutBtnB.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutBtnB.ForeColor = Color.Black;
            AboutBtnB.Location = new Point(48, 516);
            AboutBtnB.Name = "AboutBtnB";
            AboutBtnB.Size = new Size(216, 45);
            AboutBtnB.TabIndex = 19;
            AboutBtnB.Text = "ABOUT";
            AboutBtnB.UseVisualStyleBackColor = false;
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
            // ContactBtnB
            // 
            ContactBtnB.BackColor = SystemColors.ControlDarkDark;
            ContactBtnB.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactBtnB.ForeColor = Color.Black;
            ContactBtnB.Location = new Point(48, 610);
            ContactBtnB.Name = "ContactBtnB";
            ContactBtnB.Size = new Size(216, 45);
            ContactBtnB.TabIndex = 17;
            ContactBtnB.Text = "CONTACT";
            ContactBtnB.UseVisualStyleBackColor = false;
            // 
            // BookBtnB
            // 
            BookBtnB.BackColor = SystemColors.ControlDarkDark;
            BookBtnB.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookBtnB.ForeColor = SystemColors.ControlText;
            BookBtnB.Location = new Point(48, 327);
            BookBtnB.Name = "BookBtnB";
            BookBtnB.Size = new Size(216, 45);
            BookBtnB.TabIndex = 14;
            BookBtnB.Text = "BOOKS";
            BookBtnB.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(DashBoardBtn);
            panel1.Controls.Add(HomeBtnB);
            panel1.Controls.Add(InStockBtnB);
            panel1.Controls.Add(AboutBtnB);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(ContactBtnB);
            panel1.Controls.Add(BookBtnB);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 696);
            panel1.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(70, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 31);
            textBox1.TabIndex = 35;
            textBox1.Text = "Name  :";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(70, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 31);
            textBox2.TabIndex = 36;
            textBox2.Text = "Address  :";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(70, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 31);
            textBox3.TabIndex = 37;
            textBox3.Text = "Contact Number  :";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(70, 387);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(101, 31);
            textBox4.TabIndex = 38;
            textBox4.Text = "Email  :";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources._360_F_104965579_I7QiErzc032ylXRaWt9XsmIcgzu3BaDJ;
            pictureBox2.ErrorImage = null;
            pictureBox2.Location = new Point(656, 384);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(292, 309);
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(347, 309);
            label3.Name = "label3";
            label3.Size = new Size(0, 31);
            label3.TabIndex = 42;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(298, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(578, 45);
            dataGridView1.TabIndex = 43;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(298, 216);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(578, 45);
            dataGridView2.TabIndex = 44;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.Control;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(347, 299);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(578, 45);
            dataGridView3.TabIndex = 45;
            // 
            // dataGridView4
            // 
            dataGridView4.BackgroundColor = SystemColors.Control;
            dataGridView4.BorderStyle = BorderStyle.None;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(200, 380);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.Size = new Size(507, 45);
            dataGridView4.TabIndex = 46;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button LogOutBtnS;
        private Button DashBoardBtn;
        private Button HomeBtnB;
        private Button InStockBtnB;
        private Button AboutBtnB;
        private PictureBox pictureBox1;
        private Label label9;
        private Button ContactBtnB;
        private Button BookBtnB;
        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox4;
        private PictureBox pictureBox2;
        private Label label3;
        private DataGridView dataGridView4;
        private DataGridView dataGridView3;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
    }
}