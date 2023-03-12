using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class addAdminForm : Form
    {
        private const string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";
        private const string SelectQuery = "SELECT * FROM adminsBook";
        private const string InsertQuery = "INSERT INTO adminsBook (adminFirstName, adminLastName, adminEmail, adminPhone, adminPassword) VALUES (@adminFirstName, @adminLastName, @adminEmail, @adminPhone, @adminPassword)";

        public addAdminForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(SelectQuery, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please enter all required fields.");
                return;
            }

            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(InsertQuery, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@adminFirstName", textBox1.Text);
                command.Parameters.AddWithValue("@adminLastName", textBox2.Text);
                command.Parameters.AddWithValue("@adminEmail", textBox3.Text);
                command.Parameters.AddWithValue("@adminPhone", textBox4.Text);
                command.Parameters.AddWithValue("@adminPassword", textBox5.Text);

                var result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Book added successfully!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Error while adding book.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var columnName = textBox9.Text.Trim();

            if (string.IsNullOrEmpty(columnName))
            {
                MessageBox.Show("Введите имя столбца для сортировки.");
                return;
            }

            var column = dataGridView1.Columns[columnName];

            if (column == null)
            {
                MessageBox.Show($"Столбец {columnName} не найден.");
                return;
            }

            dataGridView1.Sort(column, ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var searchText = textBox8.Text.Trim();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchText))
                    {
                        row.Selected = true;
                        dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                        return;
                    }
                }
            }

            MessageBox.Show("Совпадения не найдены.");
        }
    }
}
