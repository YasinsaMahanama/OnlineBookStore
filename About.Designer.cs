namespace OnlineBookShop
{
    partial class About
    {
        private string[,] members;
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
            blueLabel = new Label(); // Add label declaration

            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(blueLabel); // Add the blue label to panel2
            panel2.Controls.Add(LogOutBtnA);
            panel2.Font = new Font("Garamond", 16.2F, FontStyle.Bold);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(320, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(948, 696);
            panel2.TabIndex = 9;
            // 
            // blueLabel
            // 
            blueLabel.BackColor = Color.Blue;
            blueLabel.Location = new Point(0, 75);
            blueLabel.Size = new Size(panel2.Width, 180); // Set height to 150 pixels (15 cm)
            blueLabel.Name = "blueLabel";
            blueLabel.Font = new Font("Segeo UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            blueLabel.Text = "\"we believe that books can change your life\"".ToUpper();
            blueLabel.TabIndex = 35;
            blueLabel.TextAlign = ContentAlignment.MiddleCenter;
            blueLabel.Padding = new Padding(100, 20, 100, 60);
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
            //
            // Container
            //
            container.BackColor = Color.White;
            container.Location = new Point(234, 296);
            container.Name = "panel2";
            container.Size = new Size(500, 300);
            container.TabIndex = 5;
            panel2.Controls.Add(container);



            next.BackColor = Color.Teal;
            next.FlatStyle = FlatStyle.Popup;
            next.Font = new Font("Segeo UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            next.ForeColor = Color.White;
            next.Location = new Point(784, 431);
            next.Name = "addtocard";
            next.Size = new Size(120, 30);
            next.TabIndex = 20;
            next.Text = "Next";
            next.Click += NextBtn_Click;
            next.UseVisualStyleBackColor = false;
            panel2.Controls.Add(next);


            back.BackColor = Color.Teal;
            back.FlatStyle = FlatStyle.Popup;
            back.Font = new Font("Segeo UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            back.ForeColor = Color.White;
            back.Location = new Point(60, 431);
            back.Name = "addtocard";
            back.Size = new Size(120, 30);
            back.TabIndex = 20;
            back.Text = "Back";
            back.Click += BackBtn_Click;
            back.UseVisualStyleBackColor = false;
            panel2.Controls.Add(back);

            members = Database.getMembers();

            panels = new List<Panel>();

            for (int i = 0; i < Database.getMemberCount(); i++) {
                MemberProfile memberProfile = new MemberProfile(Database.getImage(members[i, 2]));
                memberProfile.setName(members[i,0]);
                memberProfile.setProfession(members[i,1]);
                container.Controls.Add(memberProfile);
                panels.Add(memberProfile);
            }

            switchMember(memberIndex);

        }

        private void NextBtn_Click(object sender, EventArgs e) {
            if (memberIndex < MAX_MEMBERS) {
                back.Enabled = true;
                memberIndex++;
                if (memberIndex == MAX_MEMBERS - 1) {
                    next.Enabled = false;
                }
                switchMember(memberIndex);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e) {
            if (memberIndex > 0) {
                next.Enabled = true;
                memberIndex--;
                if (memberIndex == 0) {
                    back.Enabled = false;
                }
                switchMember(memberIndex);
            }
        }

        public void switchMember(int idx) {
            foreach (Panel panel in panels) {
                panel.Visible = false;
            }
            int i = 0;
            foreach (Panel panel in panels) {
                if (i == idx) {
                    panel.Visible = true;
                }
                i++;
            }
        }

        private class MemberProfile : Panel {
            private PictureBox pictureBox;
            private Label name;
            private Label profession;
            private String path;
            public MemberProfile(String path) {
                this.path = path;
                this.Size = new Size(500, 300);
                this.Name = "Profile";
                this.TabIndex = 5;
                this.BackColor = Color.White;
                InitializeComponent();
            }

            private void InitializeComponent() {
                pictureBox = new PictureBox();
                name = new Label();
                profession = new Label();

                pictureBox.Location = new Point(5, 10);
                pictureBox.Size = new Size(this.Height - this.Height/5, this.Height);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.BorderStyle = BorderStyle.Fixed3D; 
                pictureBox.Image = Image.FromFile(path);

                name.AutoSize = true;
                name.Font = new Font("Segeo UI", 11.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                name.ForeColor = Color.Black;
                name.Location = new Point(this.Height-45,  90);
                name.Name = "txt";
                name.Size = new Size(125, 25);
                name.TabIndex = 13;
                name.Text = "Name";
                name.TextAlign = ContentAlignment.TopCenter;

                profession.AutoSize = true;
                profession.Font = new Font("Segeo UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                profession.ForeColor = Color.Black;
                profession.Location = new Point(this.Height-35,  135);
                profession.Name = "txt";
                profession.Size = new Size(125, 25);
                profession.TabIndex = 13;
                profession.Text = "Profession";
                profession.TextAlign = ContentAlignment.TopCenter;

                this.Controls.Add(pictureBox);
                this.Controls.Add(name);
                this.Controls.Add(profession);
            }

            public void setName(string name) {
                this.name.Text = name;
            }

            public void setProfession(string pro) {
                this.profession.Text = pro;
            }

        }

        #endregion

        private List<Panel> panels;
        private Panel container = new Panel();
        private Button next = new Button();
        private Button back = new Button();
        private int memberIndex = 0;
        private const int MAX_MEMBERS = 6;
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
        private Label blueLabel; // Declare label
    }
}
