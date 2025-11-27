using Microsoft.Data.SqlClient;
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


namespace LIBRARY_SYSTEM
{
    public partial class Form2 : Form
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=LibraryDB;Trusted_Connection=True;";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Books (Title, Author, Genre, YearPublished) 
                         VALUES (@Title, @Author, @Genre, @YearPublished)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                    cmd.Parameters.AddWithValue("@YearPublished", int.Parse(txtYear.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Book added successfully.");
                    txtTitle.Clear();
                    txtAuthor.Clear();
                    txtGenre.Clear();
                    txtYear.Clear();
                }
            }
        }
    }
}
