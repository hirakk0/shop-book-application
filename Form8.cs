using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookManagementSystem
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";
            string selectQuery = "SELECT * FROM adminsBook";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dataTable = new DataTable();
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

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";
            string query = "INSERT INTO adminsBook (adminFirstName, adminLastName, adminEmail, adminPhone, adminPassword) VALUES (@adminFirstName, @adminLastName, @adminEmail, @adminPhone, @adminPassword)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@adminFirstName", textBox1.Text);
                command.Parameters.AddWithValue("@adminLastName", textBox2.Text);
                command.Parameters.AddWithValue("@adminEmail", textBox3.Text);
                command.Parameters.AddWithValue("@adminPhone", textBox4.Text);
                command.Parameters.AddWithValue("@adminPassword", textBox5.Text);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Book added successfully!");
                }
                else
                {
                    MessageBox.Show("Error while adding book.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string columnName = textBox9.Text.Trim();

            if (string.IsNullOrEmpty(columnName))
            {
                MessageBox.Show("Введите имя столбца для сортировки.");
                return;
            }

            DataGridViewColumn column = dataGridView1.Columns[columnName];

            if (column == null)
            {
                MessageBox.Show($"Столбец {columnName} не найден.");
                return;
            }

            dataGridView1.Sort(column, ListSortDirection.Ascending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = textBox8.Text.Trim();

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