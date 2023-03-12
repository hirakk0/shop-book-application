using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class addAuthorForm : Form
    {
        private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";

        public addAuthorForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM authorsBook", connection))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please enter all required fields.");
                return;
            }

            const string query = "INSERT INTO authorsBook (authorFirstName, authorLastName, authorBirthDate, authorCountry) VALUES (@firstName, @lastName, @birthDate, @country)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@firstName", textBox1.Text);
                command.Parameters.AddWithValue("@lastName", textBox2.Text);
                command.Parameters.AddWithValue("@birthDate", textBox3.Text);
                command.Parameters.AddWithValue("@country", textBox4.Text);

                connection.Open();

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Author added successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error while adding author.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = textBox8.Text.Trim();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value?.ToString().Contains(searchText) ?? false)
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }

            MessageBox.Show("No matches found.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string columnName = textBox9.Text;

            if (string.IsNullOrEmpty(columnName))
            {
                MessageBox.Show("Please enter a column name to sort by.");
                return;
            }

            if (dataGridView1.Columns[columnName] == null)
            {
                MessageBox.Show($"Column {columnName} not found.");
                return;
            }

            dataGridView1.Sort(dataGridView1.Columns[columnName], ListSortDirection.Ascending);
        }
    }
}
