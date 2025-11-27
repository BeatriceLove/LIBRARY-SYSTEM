using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml.Linq;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Security.AccessControl;


namespace LIBRARY_SYSTEM
{
    public partial class Form3 : Form
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=LibraryDB;Trusted_Connection=True;";
        public Form3()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateToReturn = dateTimePicker2.Value;
            int bookID = int.Parse(txtBookIDBorrow.Text);

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True");
                con.Open();
                string query = "INSERT INTO BorrowRecords (BookID, DateToReturn) VALUES (@BookID, @DateToReturn)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@DateToReturn", dateToReturn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book borrowed successfully.");
                con.Close();

                LoadData(); // 🔁
                //Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)    
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"UPDATE BorrowRecords 
                         SET ReturnDate = @ReturnDate 
                         WHERE BookID = @BookID AND ReturnDate IS NULL";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@BookID", int.Parse(txtBOOKID.Text));
                    
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rows > 0)
                        MessageBox.Show("Book returned successfully.");
                    else
                        MessageBox.Show("No borrowed record found for this book.");

                    txtBOOKID.Clear();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                /*con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(
                    @"SELECT b.BookID, b.Title, b.Author, br.Name AS BorrowerName, r.BorrowDate, r.ReturnDate
              FROM Books b
              LEFT JOIN BorrowRecords r ON b.BookID = r.BookID
              LEFT JOIN Borrowers br ON r.BorrowerID = br.BorrowerID", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewRecords.DataSource = dt;
                con.Close();
                */
                try
                {
                    using (SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=LibraryDB;Trusted_Connection=True;"))
                    {
                        conn.Open();

                        // Load borrowed books for the current user
                        string query = @"
                SELECT b.BorrowId, bk.Title, b.DateBorrowed, b.DateToReturn, b.DateReturned
                FROM BorrowedBooks b
                INNER JOIN Books bk ON b.BookId = bk.BookId
                WHERE b.UserId = @uid";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@BookID", txtBookIDBorrow);
                        cmd.Parameters.AddWithValue("@BorrowDate", dateTimePicker2);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dataGridViewRecords.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading borrowed books: " + ex.Message);
                }
            }
        }

        private void RecordsForm_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }
    }
}
