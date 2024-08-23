namespace OnlineBookShop
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            // Create an instance of the Login form
            Login loginForm = new Login();

            // Show the Login form
            loginForm.Show();

            // Hide the current Home form
            this.Hide();
        }



        private void BookBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the Book form
            Book bookForm = new Book();

            // Show the Book form
            bookForm.Show();

            // Hide the current Home form
            this.Hide();
        }

        private void InStockBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the In Stock form
            InStock inStockForm = new InStock();

            // Show the In Stock form
            inStockForm.Show();

            // Hide the current Home form
            this.Hide();
        }


        private void AboutBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the About form
            About aboutForm = new About();

            // Show the About form
            aboutForm.Show();

            // Hide the current Home form
            this.Hide();
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the Contact form
            Contact contactForm = new Contact();

            // Show the About form
            contactForm.Show();

            // Hide the current Home form
            this.Hide();
        }

        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the DashBoard form
            DashBoard dashBoardForm = new DashBoard();

            // Show the DashBoard form
            dashBoardForm.Show();

            // Hide the current Home form
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
