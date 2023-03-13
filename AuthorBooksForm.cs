using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class AuthorBooksForm : Form
    {
        private const string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";

        public AuthorBooksForm()
        {
            InitializeComponent();
        }

        private void AuthorBooksForm_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT authorFirstName, authorLastName, authorBirthDate, authorCountry FROM authorsBook";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
