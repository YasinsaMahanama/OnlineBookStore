using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBookShop
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void BookBtnB_Click(object sender, EventArgs e)
        {
            // Create an instance of the Book form
            Book bookForm = new Book();

            // Show the Book form
            bookForm.Show();

            // Hide the current Book form
            this.Hide();
        }

        private void UserBtnB_Click(object sender, EventArgs e)
        {
            // Create an instance of the User form
            User userForm = new User();

            // Show the User form
            userForm.Show();

            // Hide the current Book form
            this.Hide();
        }

        private void InStockBtnB_Click(object sender, EventArgs e)
        {
            // Create an instance of the In Stock form
            InStock inStockForm = new InStock();

            // Show the In Stock form
            inStockForm.Show();

            // Hide the current Book form
            this.Hide();
        }

        private void SaleBtnB_Click(object sender, EventArgs e)
        {
            // Create an instance of the DashBoard form
            DashBoard DashBoardForm = new DashBoard();

            // Show the DashBoard form
            DashBoardForm.Show();

            // Hide the current Book form
            this.Hide();
        }

        private void AboutBtnB_Click(object sender, EventArgs e)
        {
            // Create an instance of the About form
            About aboutForm = new About();

            // Show the About form
            aboutForm.Show();

            // Hide the current Book form
            this.Hide();
        }

        private void ContactBtnB_Click(object sender, EventArgs e)
        {
            // Create an instance of the Contact form
            Contact contactForm = new Contact();

            // Show the About form
            contactForm.Show();

            // Hide the current Book form
            this.Hide();
        }

        private void HomeBtnB_Click(object sender, EventArgs e)
        {
            // Create an instance of the Contact form
            Home HomeForm = new Home();

            // Show the Home form
            HomeForm.Show();

            // Hide the current Book form
            this.Hide();
        }

        private void LogOutBtnB_Click(object sender, EventArgs e)
        {
            // Create an instance of the Contact form
            Home HomeForm = new Home();

            // Show the Home form
            HomeForm.Show();

            // Hide the current Book form
            this.Hide();
        }
    }
}
