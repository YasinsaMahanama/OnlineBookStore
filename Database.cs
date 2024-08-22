using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineBookShop
{
    public partial class Database
    {
        private static string URL = "server=localhost;uid=root;pwd=;database=online_book_store";
        public static MySqlConnection getClient()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = URL;
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                return null;
            }
            return conn;
        }

        public static void insertBook(string bookName, string bookAuthor, float price, string imgName)
        {
            MySqlConnection connection = getClient();
            if (connection == null) { return; }
            string insert = "INSERT INTO book (BOOK_NAME, BOOK_AUTHOR, BOOK_PRICE, BOOK_IMG_NAME) VALUES (@v1, @v2, @v3, @v4);";
            using (MySqlCommand cmd = new MySqlCommand(insert, connection))
            {
                cmd.Parameters.AddWithValue("@v1", bookName);
                cmd.Parameters.AddWithValue("@v2", bookAuthor);
                cmd.Parameters.AddWithValue("@v3", price);
                cmd.Parameters.AddWithValue("@v4", imgName);
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    throw new Exception("ROWS NOT EFFECTED!");
                }
            }
            connection.Close();
        }

        public static void updateBookName(String bookNameOld, String bookNameNew) 
        {
            MySqlConnection connection = getClient();
            if (connection == null) { return; }
            string insert = "UPDATE book SET BOOK_NAME = @v2 WHERE BOOK_NAME = @v1";
            using (MySqlCommand cmd = new MySqlCommand(insert, connection))
            {
                cmd.Parameters.AddWithValue("@v1", bookNameOld);
                cmd.Parameters.AddWithValue("@v2", bookNameNew);
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    throw new Exception("ROWS NOT EFFECTED!");
                }
            }
            connection.Close();
        }
        public static void updateBookAuthor(String bookName, String bookAuthNew)
        {
            MySqlConnection connection = getClient();
            if (connection == null) { return; }
            string insert = "UPDATE book SET BOOK_AUTHOR = @v2 WHERE BOOK_NAME = @v1";
            using (MySqlCommand cmd = new MySqlCommand(insert, connection))
            {
                cmd.Parameters.AddWithValue("@v1", bookName);
                cmd.Parameters.AddWithValue("@v2", bookAuthNew);
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    throw new Exception("ROWS NOT EFFECTED!");
                }
            }
            connection.Close();
        }

        public static void updatePrice(String bookName, String bookPriceNew)
        {
            MySqlConnection connection = getClient();
            if (connection == null) { return; }
            string insert = "UPDATE book SET BOOK_PRICE = @v2 WHERE BOOK_NAME = @v1";
            using (MySqlCommand cmd = new MySqlCommand(insert, connection))
            {
                cmd.Parameters.AddWithValue("@v1", bookName);
                cmd.Parameters.AddWithValue("@v2", bookPriceNew);
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    throw new Exception("ROWS NOT EFFECTED!");
                }
            }
            connection.Close();
        }

        public static void updateQty(String bookName, int qtyNew)
        {
            MySqlConnection connection = getClient();
            if (connection == null) { return; }
            string insert = "UPDATE book SET QTY = @v2 WHERE BOOK_NAME = @v1";
            using (MySqlCommand cmd = new MySqlCommand(insert, connection))
            {
                cmd.Parameters.AddWithValue("@v1", bookName);
                cmd.Parameters.AddWithValue("@v2", qtyNew);
                int result = cmd.ExecuteNonQuery();
                if (result == 0)
                {
                    throw new Exception("ROWS NOT EFFECTED!");
                }
            }
            connection.Close();
        }

        public static int getBookCount()
        {
            MySqlConnection connection = getClient();
            if (connection == null) { return 0; }
            string count = "SELECT COUNT(*) FROM book;";
            using (MySqlCommand cmd = new MySqlCommand(count, connection))
            {
                int rows = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                return rows;
            }
        }

        public static int getMemberCount()
        {
            MySqlConnection connection = getClient();
            if (connection == null) { return 0; }
            string count = "SELECT COUNT(*) FROM worker;";
            using (MySqlCommand cmd = new MySqlCommand(count, connection))
            {
                int rows = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                return rows;
            }
        }

        public static string[,] getBooks()
        {
            MySqlConnection connection = getClient();
            if (connection == null) { return new string[0,0]; }
            string retrieve = "SELECT * FROM book;";
            string[,] data = null;
            using (MySqlCommand cmd = new MySqlCommand(retrieve, connection))
            {
                int rows = 0;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rows++;
                    }
                }
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    int cols = reader.FieldCount;
                    data = new string[rows, cols];
                    int row = 0;
                    while (reader.Read())
                    {
                        data[row, 0] = reader.GetString(0);
                        data[row, 1] = reader.GetString(1);
                        data[row, 2] = reader.GetString(2);
                        data[row, 3] = reader.GetString(3);
                        data[row, 4] = reader.GetInt32(4).ToString();
                        data[row, 5] = reader.GetString(5);
                        row++;
                    }
                }
            }
            connection.Close();
            return data;
        }

        public static string[,] getMembers()
        {
            MySqlConnection connection = getClient();
            if (connection == null) { return new string[0,0]; }
            string retrieve = "SELECT * FROM worker;";
            string[,] data = null;
            using (MySqlCommand cmd = new MySqlCommand(retrieve, connection))
            {
                int rows = 0;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rows++;
                    }
                }
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    int cols = reader.FieldCount;
                    data = new string[rows, cols];
                    int row = 0;
                    while (reader.Read())
                    {
                        data[row, 0] = reader.GetString(0);
                        data[row, 1] = reader.GetString(1);
                        data[row, 2] = reader.GetString(2);
                        row++;
                    }
                }
            }
            connection.Close();
            return data;
        }

        public static string getImage(string filename)
        {
            string path = Directory.GetCurrentDirectory();
            string dirFirst = Path.GetDirectoryName(path);
            DirectoryInfo dirInfo = Directory.GetParent(dirFirst);
            if (dirInfo != null) path = dirInfo.FullName;
            string dirLast = Path.GetDirectoryName(path);
            dirInfo = Directory.GetParent(dirLast);
            if (dirInfo != null) path = dirInfo.FullName;
            path = Path.Combine(Path.Combine(Path.Combine(path, "OnlineBookStore-main"), "Images"), filename);
            return path;
        }
    }
}
