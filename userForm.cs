using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class userForm : Form
    {
        private int userID;

        public userForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM ordersMakeBook WHERE userID=@userId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@userId", SqlDbType.Int).Value = userID;

                    DataTable dataTable = new DataTable();

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }

                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void viewShopBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shopBookForm form14 = new shopBookForm();
            form14.Show();
        }

        private void viewBookOrderInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeOrderBookForm makeOrderBookForm = new makeOrderBookForm(userID);
            makeOrderBookForm.ShowDialog();
        }
    }
}
