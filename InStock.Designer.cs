using System.Drawing.Text;

namespace OnlineBookShop
{
    partial class InStock
    {
        private System.ComponentModel.IContainer components = null;
        public static System.ComponentModel.ComponentResourceManager resources;

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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resources = new System.ComponentModel.ComponentResourceManager(typeof(InStock));
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
            InStockBtnHeading = new Button(); // Ensure this line is present
            searchTextBox = new TextBox();
            searchButton = new Button();

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
            panel2.Controls.Add(InStockBtnHeading); // Ensure this line is present
            panel2.Controls.Add(searchTextBox);
            panel2.Controls.Add(searchButton);
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
            // InStockBtnHeading
            // 
            InStockBtnHeading.BackColor = Color.Teal;
            InStockBtnHeading.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InStockBtnHeading.ForeColor = Color.Black;
            InStockBtnHeading.Location = new Point(373, 20);
            InStockBtnHeading.Name = "InStockBtnHeading";
            InStockBtnHeading.Size = new Size(193, 45);
            InStockBtnHeading.TabIndex = 15;
            InStockBtnHeading.Text = "InStock";
            InStockBtnHeading.UseVisualStyleBackColor = false;

            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Garamond", 16.2F, FontStyle.Bold);
            searchTextBox.Location = new Point(240, 75);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(400, 38);
            searchTextBox.TabIndex = 16;
            searchTextBox.Text="Search for books by Title/Author";
            searchTextBox.GotFocus += OnGotFocusByUser;
            searchTextBox.LostFocus += OnLostFocusByUser;

            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Teal;
            searchButton.Font = new Font("Garamond", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.ForeColor = Color.Black;
            searchButton.Location = new Point(640, 75);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(130, 38);
            searchButton.TabIndex = 17;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += new System.EventHandler(SearchButton_Click);

            // Placeholder label for searchTextBox
            searchPlaceholderLabel = new Label();
            searchPlaceholderLabel.Text = "Search for books by title/author";
            searchPlaceholderLabel.ForeColor = Color.Gray;
            searchPlaceholderLabel.Font = new Font(searchTextBox.Font, FontStyle.Italic);
            searchPlaceholderLabel.Location = new Point(searchTextBox.Left + 5, searchTextBox.Top + searchTextBox.Height / 2 - searchPlaceholderLabel.Height / 2);
            panel2.Controls.Add(searchPlaceholderLabel);

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
            panel2.PerformLayout();
            ResumeLayout(false);

            ScrollableControl scrollableControl = new ScrollableControl();
            scrollableControl.Location = new System.Drawing.Point(10, 120);
            scrollableControl.Size = new System.Drawing.Size(928, 566);
            scrollableControl.AutoScroll = true;    
            scrollableControl.HorizontalScroll.Enabled = true;
            scrollableControl.HorizontalScroll.Visible = true;
            scrollableControl.VerticalScroll.Enabled = true;
            scrollableControl.VerticalScroll.Visible = true;
            panel2.Controls.Add(scrollableControl);

            container.BackColor = Color.White;
            container.Location = new Point(0, 0);
            container.Name = "panel2";
            container.Size = new Size(930, 566);
            container.TabIndex = 5;
            scrollableControl.Controls.Add(container);

            flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight; 
            flowLayoutPanel.WrapContents = true; 
            flowLayoutPanel.Dock = DockStyle.Fill; 
            flowLayoutPanel.Location = new Point(10, 100);

            string[] images = {
                "D:\\2 year 2 ns semister 2024\\visual programming\\OnlineBookStore-main\\Images\\1.png",
                "D:\\2 year 2 ns semister 2024\\visual programming\\OnlineBookStore-main\\Images\\2.png",
                "D:\\2 year 2 ns semister 2024\\visual programming\\OnlineBookStore-main\\Images\\3.png",
                "D:\\2 year 2 ns semister 2024\\visual programming\\OnlineBookStore-main\\Images\\4.png",
                "D:\\2 year 2 ns semister 2024\\visual programming\\OnlineBookStore-main\\Images\\5.png",
                "D:\\2 year 2 ns semister 2024\\visual programming\\OnlineBookStore-main\\Images\\6.png",
            };

            string[,] items_info = {
                {"Think Like a Monk", "Jay Shetty", "Rs. 2,690"},
                {"Rich Dad Poor Dad", "Robert T.Kiyosaki", "Rs. 2,990.00"},
                {"The Subtle Art of Not Giving a F*ck", "Mark Menson", "Rs. 2,790.00"},
                {"The 5 AM Club", "Robin Sharma", "Rs. 1,990.00"},
                {"The Richest Man in Babylon", "George S.Glason", "Rs. 990.00"},
                {"Death", "Sadhguru", "Rs. 1,590.00"}
            };

            for (int i = 0; i < 6; i++) {
                ItemContainer itemContainer = new ItemContainer(images[i]);
                itemContainer.setBookName(items_info[i,0]);
                itemContainer.setAuthor(items_info[i,1]);
                itemContainer.setPrice(items_info[i,2]);
                flowLayoutPanel.Controls.Add(itemContainer);

                if (i > 3) {
                    int div = (int)Math.Ceiling((double)i / 3);
                    container.Height = div * ItemContainer.Height + 10;
                }
            }

            container.Controls.Add(flowLayoutPanel);
                
            void SearchButton_Click(object sender, EventArgs e) {
                string query = searchTextBox.Text;
                // Implement search functionality
                MessageBox.Show($"Searching for: {query}");
            }     

        }

        private void OnGotFocusByUser(object sender, EventArgs e) {
            if (searchTextBox.Text == "Search for books by Title/Author") {
                searchTextBox.Text = "";
            }
        }

        private void OnLostFocusByUser(Object sender, EventArgs e) {
            if (searchTextBox.Text == "") {
                searchTextBox.Text = "Search for books by Title/Author";
            }
        }

        #endregion
        private Panel container = new Panel();
        private FlowLayoutPanel flowLayoutPanel;
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
        private Button InStockBtnHeading;
        private TextBox searchTextBox;
        private Button searchButton;
        private Label searchPlaceholderLabel;

        // Event handler for searchButton click
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            // Add search functionality here
            MessageBox.Show($"Search for: {searchText}");
        }

        private class ItemContainer : Panel {
            public static int Height = 430;
            private String path;
            private Label author;
            private Label bookName;
            private Label price;
            public ItemContainer(String path) {
                this.path = path;
                this.BackColor = Color.White;
                this.Name = "itemcontainer";
                this.Size = new Size(300, Height);
                this.TabIndex = 5;
                createComponents();
            }

            private void createComponents() {
                try {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(10, 10);
                    pictureBox.Size = new Size(this.Width - 20, this.Width - 20);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.BorderStyle = BorderStyle.Fixed3D; 
                    pictureBox.Image = Image.FromFile(path);

                    author = new Label();
                    author.AutoSize = true;
                    author.Font = new Font("Segeo UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    author.ForeColor = Color.Black;
                    author.Location = new Point(10, this.Width);
                    author.Name = "txt";
                    author.Size = new Size(125, 25);
                    author.TabIndex = 13;
                    author.Text = "Book Shop";
                    author.TextAlign = ContentAlignment.TopCenter;

                    bookName = new Label();
                    bookName.AutoSize = true;
                    bookName.Font = new Font("Segeo UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    bookName.ForeColor = Color.Black;
                    bookName.Location = new Point(10, this.Width + 30);
                    bookName.Name = "txt";
                    bookName.Size = new Size(125, 25);
                    bookName.TabIndex = 13;
                    bookName.Text = "Book Shop";
                    bookName.TextAlign = ContentAlignment.TopCenter;

                    price = new Label();
                    price.AutoSize = true;
                    price.Font = new Font("Segeo UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    price.ForeColor = Color.Black;
                    price.Location = new Point(10, this.Width + 60);
                    price.Name = "txt";
                    price.Size = new Size(125, 25);
                    price.TabIndex = 13;
                    price.Text = "Book Shop";
                    price.TextAlign = ContentAlignment.TopCenter;

                    Button addtocard = new Button();
                    addtocard.BackColor = Color.Teal;
                    addtocard.FlatStyle = FlatStyle.Popup;
                    addtocard.Font = new Font("Segeo UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    addtocard.ForeColor = Color.White;
                    addtocard.Location = new Point(10, this.Width + 90);
                    addtocard.Name = "addtocard";
                    addtocard.Size = new Size(this.Width - 20, 30);
                    addtocard.TabIndex = 20;
                    addtocard.Text = "Add to Cart";
                    addtocard.UseVisualStyleBackColor = false;
                    
                    this.Controls.Add(pictureBox);
                    this.Controls.Add(author);
                    this.Controls.Add(bookName);
                    this.Controls.Add(price);
                    this.Controls.Add(addtocard);
                } catch (NullReferenceException ex) {
                    Console.WriteLine(ex);
                }
            }

            public void setAuthor(string auth) {
                this.author.Text = auth;
            }

            public void setBookName(string name) {
                this.bookName.Text = name;
            }

            public void setPrice(string price) {
                this.price.Text = price;
            }

            private Label label;
        }
    }
}
