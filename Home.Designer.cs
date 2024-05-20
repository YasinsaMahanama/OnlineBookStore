namespace OnlineBookShop
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            Login = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            panel3 = new Panel();
            ContactBtn = new Button();
            AboutBtn = new Button();
            UserBtn = new Button();
            InStockBtn = new Button();
            BookBtn = new Button();
            SaleBtn = new Button();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 29);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(218, 29);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(57, 28);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "ALL";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-11, -27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(Login);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(comboBox1);
            panel2.Location = new Point(45, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(1196, 86);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(895, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            Login.BackColor = Color.White;
            Login.Location = new Point(1026, 21);
            Login.Name = "Login";
            Login.Size = new Size(147, 43);
            Login.TabIndex = 6;
            Login.Text = "Login / Register";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(786, 23);
            button1.Name = "button1";
            button1.Size = new Size(65, 34);
            button1.TabIndex = 4;
            button1.Text = "search";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(319, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(461, 34);
            textBox1.TabIndex = 3;
            textBox1.Text = "Search For Books Title or Author";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(ContactBtn);
            panel3.Controls.Add(AboutBtn);
            panel3.Controls.Add(UserBtn);
            panel3.Controls.Add(InStockBtn);
            panel3.Controls.Add(BookBtn);
            panel3.Controls.Add(SaleBtn);
            panel3.Location = new Point(0, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(1280, 50);
            panel3.TabIndex = 4;
            // 
            // ContactBtn
            // 
            ContactBtn.BackColor = Color.Teal;
            ContactBtn.FlatStyle = FlatStyle.Popup;
            ContactBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ContactBtn.Location = new Point(1100, 3);
            ContactBtn.Name = "ContactBtn";
            ContactBtn.Size = new Size(141, 44);
            ContactBtn.TabIndex = 12;
            ContactBtn.Text = "CONTACT";
            ContactBtn.UseVisualStyleBackColor = false;
            ContactBtn.Click += ContactBtn_Click;
            // 
            // AboutBtn
            // 
            AboutBtn.BackColor = Color.Teal;
            AboutBtn.FlatStyle = FlatStyle.Popup;
            AboutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutBtn.Location = new Point(888, 3);
            AboutBtn.Name = "AboutBtn";
            AboutBtn.Size = new Size(141, 44);
            AboutBtn.TabIndex = 11;
            AboutBtn.Text = "ABOUT";
            AboutBtn.UseVisualStyleBackColor = false;
            AboutBtn.Click += AboutBtn_Click;
            // 
            // UserBtn
            // 
            UserBtn.BackColor = Color.Teal;
            UserBtn.FlatStyle = FlatStyle.Popup;
            UserBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserBtn.Location = new Point(253, 3);
            UserBtn.Name = "UserBtn";
            UserBtn.Size = new Size(141, 44);
            UserBtn.TabIndex = 10;
            UserBtn.Text = "USERS";
            UserBtn.UseVisualStyleBackColor = false;
            UserBtn.Click += UserBtn_Click;
            // 
            // InStockBtn
            // 
            InStockBtn.BackColor = Color.Teal;
            InStockBtn.FlatStyle = FlatStyle.Popup;
            InStockBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InStockBtn.Location = new Point(464, 3);
            InStockBtn.Name = "InStockBtn";
            InStockBtn.Size = new Size(141, 44);
            InStockBtn.TabIndex = 9;
            InStockBtn.Text = "IN STOCK";
            InStockBtn.UseVisualStyleBackColor = false;
            InStockBtn.Click += InStockBtn_Click;
            // 
            // BookBtn
            // 
            BookBtn.BackColor = Color.Teal;
            BookBtn.FlatStyle = FlatStyle.Popup;
            BookBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookBtn.Location = new Point(45, 3);
            BookBtn.Name = "BookBtn";
            BookBtn.Size = new Size(141, 44);
            BookBtn.TabIndex = 8;
            BookBtn.Text = "NEW BOOKS";
            BookBtn.UseVisualStyleBackColor = false;
            BookBtn.Click += BookBtn_Click;
            // 
            // SaleBtn
            // 
            SaleBtn.BackColor = Color.Teal;
            SaleBtn.FlatStyle = FlatStyle.Popup;
            SaleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaleBtn.Location = new Point(675, 3);
            SaleBtn.Name = "SaleBtn";
            SaleBtn.Size = new Size(150, 44);
            SaleBtn.TabIndex = 0;
            SaleBtn.Text = "SALE";
            SaleBtn.UseVisualStyleBackColor = false;
            SaleBtn.Click += SaleBtn_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(45, 234);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(578, 451);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel4.Location = new Point(621, 234);
            panel4.Name = "panel4";
            panel4.Size = new Size(620, 451);
            panel4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(183, 328);
            label5.Name = "label5";
            label5.Size = new Size(255, 31);
            label5.TabIndex = 5;
            label5.Text = "access to new releases.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(63, 286);
            label4.Name = "label4";
            label4.Size = new Size(512, 31);
            label4.TabIndex = 4;
            label4.Text = "recommendations, special discounts, and early";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(84, 240);
            label3.Name = "label3";
            label3.Size = new Size(452, 31);
            label3.TabIndex = 3;
            label3.Text = "member benefits, including personalized";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(3, 198);
            label2.Name = "label2";
            label2.Size = new Size(612, 31);
            label2.TabIndex = 2;
            label2.Text = "Join our community of book lovers and enjoy exclusive ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 46.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(8, 21);
            label1.Name = "label1";
            label1.Size = new Size(606, 102);
            label1.TabIndex = 1;
            label1.Text = "NEW ARRIVALS";
            label1.Click += label1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSkyBlue;
            panel5.Location = new Point(0, 694);
            panel5.Name = "panel5";
            panel5.Size = new Size(1280, 29);
            panel5.TabIndex = 7;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(pictureBox3);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Button Login;
        private Panel panel3;
        private Button BookBtn;
        private Button SaleBtn;
        private Button ContactBtn;
        private Button AboutBtn;
        private Button UserBtn;
        private Button InStockBtn;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Panel panel5;
    }
}
