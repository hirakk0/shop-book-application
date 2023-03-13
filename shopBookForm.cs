using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class shopBookForm : Form
    {
        private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";

        public shopBookForm()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT * FROM shopBook", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void viewShopBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shopBookForm form14 = new shopBookForm();
            form14.Show();
        }

        private void viewInformationBookAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorBooksForm authorBooksForm = new AuthorBooksForm();
            authorBooksForm.ShowDialog();
        }

        private void systemExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
