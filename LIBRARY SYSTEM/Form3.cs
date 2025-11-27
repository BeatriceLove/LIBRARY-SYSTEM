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
            int bookID = int.Parse(txtBookIDBorrow.Text);
            int borrowerID = int.Parse(txtBorrowerID.Text);
            DateTime borrowDate = dateTimePicker1.Value;
            DateTime returnDate = dateTimePicker2.Value;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO BorrowRecords 
                            (BookID, BorrowerID, BorrowDate, ReturnDate) 
                             VALUES (@BookID, @BorrowerID, @BorrowDate, NULL)";

                    SqlCommand cmd = new SqlCommand(query, con);
                   // cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.Parameters.AddWithValue("@BorrowerID", borrowerID);
                    //cmd.Parameters.AddWithValue("@BorrowDate", borrowDate);
                    cmd.Parameters.AddWithValue("@BookID", int.Parse(txtBookIDBorrow.Text));
                    cmd.Parameters.AddWithValue("@BorrowDate", dateTimePicker2.Value);


                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Book borrowed successfully.");
                LoadData();
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

                    cmd.Parameters.AddWithValue("@BookID", int.Parse(txtBorrowerID.Text));
                    
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rows > 0)
                        MessageBox.Show("Book returned successfully.");
                    else
                        MessageBox.Show("No borrowed record found for this book.");

                    txtBorrowerID.Clear();
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
                con.Open();

                string query = @"
            SELECT r.RecordID, b.Title, br.Name AS BorrowerName,
                   r.BorrowDate, r.ReturnDate
            FROM BorrowRecords r
            INNER JOIN Books b ON r.BookID = b.BookID
            INNER JOIN Borrowers br ON r.BorrowerID = br.BorrowerID";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewRecords.DataSource = dt;
            }
        }

        private void RecordsForm_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }
    }
}
