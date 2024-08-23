using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnlineBookShop
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Handle panel paint event if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle label2 click event if needed
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Handle label3 click event if needed
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Handle label5 click event if needed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle pictureBox1 click event if needed
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // Handle textBox8 text changed event if needed
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle textBox1 text changed event if needed
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Handle textBox3 text changed event if needed
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void HomeBtnB_Click(object sender, EventArgs e)
        {
            this.HomeBtnB.Click += new System.EventHandler(this.HomeBtnB_Click);
            // Create an instance of the Contact form
            Home homeForm = new Home();

            // Show the Home form
            homeForm.Show();

            // Hide the current Book form
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the DashBoard form
            DashBoard dashBoardForm = new DashBoard();

            // Show the DashBoard form
            dashBoardForm.Show();

            // Hide the current Books form
            this.Hide();
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

        private void InStockBtnB_Click(object sender, EventArgs e)
        {

            // Create an instance of the In Stock form
            InStock inStockForm = new InStock();

            // Show the In Stock form
            inStockForm.Show();

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string message = textBox3.Text;

            // Check if any of the fields are empty
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                // Use the correct connection string format for SQL Server LocalDB
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Data Source=DESKTOP-741QDT1\SQLEXPRESS;Initial Catalog=ContactDB;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Contacts (Name, Email, Message) VALUES (@Name, @Email, @Message)";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Message", message);

                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Your message has been sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }
    }
}
