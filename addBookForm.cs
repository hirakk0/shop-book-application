using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class addBookForm : Form
    {
        private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";
        public addBookForm()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM shopBook";

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
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text))
            {
                MessageBox.Show("Please enter all required fields.");
                return;
            }

            string query = "INSERT INTO shopBook (bookTitle, authorID, publisherID, bookGenre, bookISBN, bookPrice, bookStock) VALUES (@bookTitle, @authorID, @publisherID, @bookGenre, @bookISBN, @bookPrice, @bookStock)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@bookTitle", textBox1.Text);
                command.Parameters.AddWithValue("@authorID", textBox2.Text);
                command.Parameters.AddWithValue("@publisherID", textBox3.Text);
                command.Parameters.AddWithValue("@bookGenre", textBox4.Text);
                command.Parameters.AddWithValue("@bookISBN", textBox5.Text);
                command.Parameters.AddWithValue("@bookPrice", Convert.ToDecimal(textBox6.Text));
                command.Parameters.AddWithValue("@bookStock", Convert.ToInt32(textBox7.Text));

                connection.Open();

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

            MessageBox.Show("Совпадения не найдены.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string columnName = textBox9.Text;

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

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text) || string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    MessageBox.Show("Please enter all required fields.");
                    return;
                }

                string query = "UPDATE shopBook SET bookTitle = @bookTitle, authorID = @authorID, publisherID = publisherID, bookGenre = @bookGenre, bookISBN = @bookISBN, bookPrice = @bookPrice, bookStock = @bookStock WHERE bookID = @bookID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@bookTitle", textBox1.Text);
                    command.Parameters.AddWithValue("@authorID", textBox2.Text);
                    command.Parameters.AddWithValue("@publisherID", textBox3.Text);
                    command.Parameters.AddWithValue("@bookGenre", textBox4.Text);
                    command.Parameters.AddWithValue("@bookISBN", textBox5.Text);
                    command.Parameters.AddWithValue("@bookPrice", Convert.ToDecimal(textBox6.Text));
                    command.Parameters.AddWithValue("@bookStock", Convert.ToInt32(textBox7.Text));
                    command.Parameters.AddWithValue("@bookID", textBox10.Text);

                    connection.Open();

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Book updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error while updating book.");
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                int selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row(s)?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlTransaction transaction = connection.BeginTransaction())
                            {
                                try
                                {
                                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                                    {
                                        int id = (int)row.Cells["bookID"].Value;
                                        string deleteQuery = "DELETE FROM shopBook WHERE bookID=@id";
                                        using (SqlCommand command = new SqlCommand(deleteQuery, connection, transaction))
                                        {
                                            command.Parameters.AddWithValue("@id", id);
                                            command.ExecuteNonQuery();
                                        }
                                    }
                                    transaction.Commit();
                                    MessageBox.Show("Selected row(s) deleted successfully!");
                                }
                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show($"Error while deleting row(s): {ex.Message}");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select row(s) to delete.");
                }
            }
        }
    }
}