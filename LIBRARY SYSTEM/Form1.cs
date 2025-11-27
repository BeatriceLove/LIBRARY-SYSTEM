using System.Xml.Linq;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.Win32.SafeHandles;
using System.Security.Policy;

namespace LIBRARY_SYSTEM
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=LibraryDB;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        } 

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtContact.Text == "")
            {
                MessageBox.Show("Please Enter your Name and Contact Number");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Borrowers (Names, Contacts) VALUES (@Names, @Contacts)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Names", txtName.Text);
                    cmd.Parameters.AddWithValue("@Contacts", txtContact.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Borrower registered successfully.");
                    txtName.Clear();
                    txtContact.Clear();
                }

                Form3 next = new Form3();
                next.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
