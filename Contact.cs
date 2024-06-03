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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void BookBtnC_Click(object sender, EventArgs e)
        {
            // Create an instance of the Book form
            Book bookForm = new Book();

            // Show the Book form
            bookForm.Show();

            // Hide the current Contact form
            this.Hide();
        }

        private void UserBtnC_Click(object sender, EventArgs e)
        {
            // Create an instance of the User form
            User userForm = new User();

            // Show the User form
            userForm.Show();

            // Hide the current Contact form
            this.Hide();
        }

        private void InStockBtnC_Click(object sender, EventArgs e)
        {
            // Create an instance of the In Stock form
            InStock inStockForm = new InStock();

            // Show the In Stock form
            inStockForm.Show();

            // Hide the current Contact form
            this.Hide();
        }

        private void SaleBtnC_Click(object sender, EventArgs e)
        {
            // Create an instance of the Sale form
            Sale saleForm = new Sale();

            // Show the Sale form
            saleForm.Show();

            // Hide the current Contact form
            this.Hide();
        }

        private void AboutBtnC_Click(object sender, EventArgs e)
        {
            // Create an instance of the About form
            About aboutForm = new About();

            // Show the About form
            aboutForm.Show();

            // Hide the current Contact form
            this.Hide();
        }

        private void ContactBtnC_Click(object sender, EventArgs e)
        {
            // Create an instance of the Contact form
            Contact contactForm = new Contact();

            // Show the About form
            contactForm.Show();

            // Hide the current Contact form
            this.Hide();
        }
    }
}
