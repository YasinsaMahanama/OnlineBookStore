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


namespace OnlineBookShop
{
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\YASINSA MAHANAMA\Documents\OnlineBookStoreDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void PopulateBooks()
        {
            con.Open();
            string query = "SELECT * FROM Books";
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            BookList.DataSource = ds.Tables[0];
            con.Close();
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

        private void HomeBtnB_Click(object sender, EventArgs e)
        {
            // Create an instance of the Contact form
            Home homeForm = new Home();

            // Show the Home form
            homeForm.Show();

            // Hide the current Book form
            this.Hide();
        }

        private void LogOutBtnB_Click(object sender, EventArgs e)
        {
            // Create an instance of the Contact form
            Home homeForm = new Home();

            // Show the Home form
            homeForm.Show();

            // Hide the current Book form
            this.Hide();
        }

        private void DashBoardBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the DashBoard form
            DashBoard dashBoardForm = new DashBoard();

            // Show the DashBoard form
            dashBoardForm.Show();

            // Hide the current Books form
            this.Hide();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (BTitleTb.Text == "" || BAuthorTb.Text == "" || QtyTb.Text == "" || PriceTb.Text == "" || BCatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into Books values('" + BTitleTb.Text + "', '" + BAuthorTb.Text + "', '" + BCatCb.SelectedItem.ToString() + "','" + QtyTb.Text + "', '" + PriceTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book save Successfully");
                    con.Close();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
