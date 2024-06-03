namespace OnlineBookShop
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            panel1 = new Panel();
            InStockBtnB = new Button();
            AboutBtnB = new Button();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            ContactBtnB = new Button();
            SaleBtnB = new Button();
            UserBtnB = new Button();
            BookBtnB = new Button();
            panel2 = new Panel();
            label4 = new Label();
            Refreshbtn = new Button();
            CatCbAearch = new ComboBox();
            dataGridView1 = new DataGridView();
            EditBtn = new Button();
            Deletebtn = new Button();
            ResetBtn = new Button();
            Savebtn = new Button();
            PriceTb = new TextBox();
            label7 = new Label();
            QtyTb = new TextBox();
            label5 = new Label();
            BCatCb = new ComboBox();
            label2 = new Label();
            button7 = new Button();
            label8 = new Label();
            BAuthorTb = new TextBox();
            BTitleTb = new TextBox();
            label3 = new Label();
            label1 = new Label();
            HomeBtnB = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(HomeBtnB);
            panel1.Controls.Add(InStockBtnB);
            panel1.Controls.Add(AboutBtnB);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(ContactBtnB);
            panel1.Controls.Add(SaleBtnB);
            panel1.Controls.Add(UserBtnB);
            panel1.Controls.Add(BookBtnB);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 696);
            panel1.TabIndex = 2;
            // 
            // InStockBtnB
            // 
            InStockBtnB.BackColor = SystemColors.ControlDarkDark;
            InStockBtnB.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InStockBtnB.ForeColor = Color.Black;
            InStockBtnB.Location = new Point(59, 385);
            InStockBtnB.Name = "InStockBtnB";
            InStockBtnB.Size = new Size(193, 45);
            InStockBtnB.TabIndex = 20;
            InStockBtnB.Text = "IN STOCK";
            InStockBtnB.UseVisualStyleBackColor = false;
            InStockBtnB.Click += InStockBtnB_Click;
            // 
            // AboutBtnB
            // 
            AboutBtnB.BackColor = SystemColors.ControlDarkDark;
            AboutBtnB.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AboutBtnB.ForeColor = Color.Black;
            AboutBtnB.Location = new Point(59, 546);
            AboutBtnB.Name = "AboutBtnB";
            AboutBtnB.Size = new Size(193, 45);
            AboutBtnB.TabIndex = 19;
            AboutBtnB.Text = "ABOUT";
            AboutBtnB.UseVisualStyleBackColor = false;
            AboutBtnB.Click += AboutBtnB_Click;
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
            ContactBtnB.Location = new Point(59, 622);
            ContactBtnB.Name = "ContactBtnB";
            ContactBtnB.Size = new Size(193, 45);
            ContactBtnB.TabIndex = 17;
            ContactBtnB.Text = "CONTACT";
            ContactBtnB.UseVisualStyleBackColor = false;
            ContactBtnB.Click += ContactBtnB_Click;
            // 
            // SaleBtnB
            // 
            SaleBtnB.BackColor = SystemColors.ControlDarkDark;
            SaleBtnB.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaleBtnB.ForeColor = Color.Black;
            SaleBtnB.Location = new Point(59, 468);
            SaleBtnB.Name = "SaleBtnB";
            SaleBtnB.Size = new Size(193, 45);
            SaleBtnB.TabIndex = 16;
            SaleBtnB.Text = "SALE";
            SaleBtnB.UseVisualStyleBackColor = false;
            SaleBtnB.Click += SaleBtnB_Click;
            // 
            // UserBtnB
            // 
            UserBtnB.BackColor = SystemColors.ControlDarkDark;
            UserBtnB.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserBtnB.ForeColor = Color.Black;
            UserBtnB.Location = new Point(59, 303);
            UserBtnB.Name = "UserBtnB";
            UserBtnB.Size = new Size(193, 45);
            UserBtnB.TabIndex = 15;
            UserBtnB.Text = "USERS";
            UserBtnB.UseVisualStyleBackColor = false;
            UserBtnB.Click += UserBtnB_Click;
            // 
            // BookBtnB
            // 
            BookBtnB.BackColor = Color.Teal;
            BookBtnB.FlatStyle = FlatStyle.Popup;
            BookBtnB.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BookBtnB.ForeColor = Color.Black;
            BookBtnB.Location = new Point(59, 219);
            BookBtnB.Name = "BookBtnB";
            BookBtnB.Size = new Size(193, 45);
            BookBtnB.TabIndex = 14;
            BookBtnB.Text = "BOOKS";
            BookBtnB.UseVisualStyleBackColor = false;
            BookBtnB.Click += BookBtnB_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(Refreshbtn);
            panel2.Controls.Add(CatCbAearch);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(Deletebtn);
            panel2.Controls.Add(ResetBtn);
            panel2.Controls.Add(Savebtn);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(QtyTb);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(BCatCb);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(BAuthorTb);
            panel2.Controls.Add(BTitleTb);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Font = new Font("Garamond", 16.2F, FontStyle.Bold);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(320, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 696);
            panel2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(407, 289);
            label4.Name = "label4";
            label4.Size = new Size(132, 31);
            label4.TabIndex = 32;
            label4.Text = "Book List";
            // 
            // Refreshbtn
            // 
            Refreshbtn.BackColor = Color.Indigo;
            Refreshbtn.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Refreshbtn.ForeColor = Color.White;
            Refreshbtn.Location = new Point(492, 336);
            Refreshbtn.Name = "Refreshbtn";
            Refreshbtn.Size = new Size(93, 36);
            Refreshbtn.TabIndex = 31;
            Refreshbtn.Text = "Refresh";
            Refreshbtn.UseVisualStyleBackColor = false;
            // 
            // CatCbAearch
            // 
            CatCbAearch.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CatCbAearch.ForeColor = SystemColors.WindowFrame;
            CatCbAearch.FormattingEnabled = true;
            CatCbAearch.Items.AddRange(new object[] { "Programming", "Networkng", "Maths", "Physics", "Bio", "English" });
            CatCbAearch.Location = new Point(298, 343);
            CatCbAearch.Name = "CatCbAearch";
            CatCbAearch.Size = new Size(151, 26);
            CatCbAearch.TabIndex = 30;
            CatCbAearch.Text = "Filter Category";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 396);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(927, 271);
            dataGridView1.TabIndex = 28;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Indigo;
            EditBtn.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(492, 178);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(110, 45);
            EditBtn.TabIndex = 27;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.Indigo;
            Deletebtn.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebtn.ForeColor = Color.White;
            Deletebtn.Location = new Point(143, 178);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(110, 45);
            Deletebtn.TabIndex = 26;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Indigo;
            ResetBtn.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(322, 178);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(110, 45);
            ResetBtn.TabIndex = 25;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            // 
            // Savebtn
            // 
            Savebtn.BackColor = Color.Indigo;
            Savebtn.Font = new Font("Garamond", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.ForeColor = Color.White;
            Savebtn.Location = new Point(672, 178);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(110, 45);
            Savebtn.TabIndex = 24;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(731, 117);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(180, 38);
            PriceTb.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(731, 86);
            label7.Name = "label7";
            label7.Size = new Size(51, 24);
            label7.TabIndex = 22;
            label7.Text = "Price";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(545, 117);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(180, 38);
            QtyTb.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(545, 86);
            label5.Name = "label5";
            label5.Size = new Size(40, 24);
            label5.TabIndex = 18;
            label5.Text = "Qty";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // BCatCb
            // 
            BCatCb.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BCatCb.ForeColor = SystemColors.WindowFrame;
            BCatCb.FormattingEnabled = true;
            BCatCb.Items.AddRange(new object[] { "Programming", "Networkng", "Maths", "Physics", "Bio", "English" });
            BCatCb.Location = new Point(388, 117);
            BCatCb.Name = "BCatCb";
            BCatCb.Size = new Size(151, 26);
            BCatCb.TabIndex = 17;
            BCatCb.Text = "Select Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(388, 86);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 16;
            label2.Text = "Categories";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // button7
            // 
            button7.BackColor = Color.Teal;
            button7.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(373, 20);
            button7.Name = "button7";
            button7.Size = new Size(193, 45);
            button7.TabIndex = 15;
            button7.Text = "Books";
            button7.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(192, 0, 0);
            label8.Location = new Point(1028, 0);
            label8.Name = "label8";
            label8.Size = new Size(20, 22);
            label8.TabIndex = 12;
            label8.Text = "X";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // BAuthorTb
            // 
            BAuthorTb.Location = new Point(202, 116);
            BAuthorTb.Name = "BAuthorTb";
            BAuthorTb.Size = new Size(180, 38);
            BAuthorTb.TabIndex = 9;
            // 
            // BTitleTb
            // 
            BTitleTb.Location = new Point(16, 116);
            BTitleTb.Name = "BTitleTb";
            BTitleTb.Size = new Size(180, 38);
            BTitleTb.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(202, 89);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 7;
            label3.Text = "Author";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(16, 89);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 6;
            label1.Text = "Book Title ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // HomeBtnB
            // 
            HomeBtnB.BackColor = SystemColors.ControlDarkDark;
            HomeBtnB.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeBtnB.ForeColor = Color.Black;
            HomeBtnB.Location = new Point(59, 136);
            HomeBtnB.Name = "HomeBtnB";
            HomeBtnB.Size = new Size(193, 45);
            HomeBtnB.TabIndex = 21;
            HomeBtnB.Text = "HOME";
            HomeBtnB.UseVisualStyleBackColor = false;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1280, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Book";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ContactBtnB;
        private Button SaleBtnB;
        private Button UserBtnB;
        private Button BookBtnB;
        private Label label9;
        private PictureBox pictureBox1;
        private Button InStockBtnB;
        private Button AboutBtnB;
        private Panel panel2;
        private Button Refreshbtn;
        private ComboBox CatCbAearch;
        private DataGridView dataGridView1;
        private Button EditBtn;
        private Button Deletebtn;
        private Button ResetBtn;
        private Button Savebtn;
        private TextBox PriceTb;
        private Label label7;
        private TextBox QtyTb;
        private Label label5;
        private ComboBox BCatCb;
        private Label label2;
        private Button button7;
        private Label label8;
        private TextBox BAuthorTb;
        private TextBox BTitleTb;
        private Label label3;
        private Label label1;
        private Label label4;
        private Button HomeBtnB;
    }
}