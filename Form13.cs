using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookManagementSystem
{
    public partial class Form13 : Form
    {
        private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            {
                string selectQuery = "SELECT * FROM usersBook";

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please enter all required fields.");
                return;
            }

            const string query = "UPDATE usersBook SET userFirstName = @userFirstName, userLastName = @userLastName, userEmail = @userEmail, userPhone = @userPhone, userPassword = @userPassword, userAddress = @userAddress, userCity = @userCity, userZipCode = @userZipCode WHERE userID = @userID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userFirstName", textBox1.Text);
                command.Parameters.AddWithValue("@userLastName", textBox2.Text);
                command.Parameters.AddWithValue("@userEmail", textBox3.Text);
                command.Parameters.AddWithValue("@userPhone", textBox4.Text);
                command.Parameters.AddWithValue("@userPassword", textBox5.Text);
                command.Parameters.AddWithValue("@userAddress", textBox6.Text);
                command.Parameters.AddWithValue("@userCity", textBox7.Text);
                command.Parameters.AddWithValue("@userZipCode", textBox10.Text);
                command.Parameters.AddWithValue("@userID", textBox11.Text);

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

        private void button2_Click(object sender, EventArgs e)
        {
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string columnName = textBox9.Text;

            if (string.IsNullOrEmpty(columnName))
            {
                MessageBox.Show("Введите имя столбца для сортировки.");
                return;
            }

            if (dataGridView1.Columns[columnName] == null)
            {
                MessageBox.Show($"Столбец {columnName} не найден.");
                return;
            }

            dataGridView1.Sort(dataGridView1.Columns[columnName], ListSortDirection.Ascending);
        }

        private void button5_Click(object sender, EventArgs e)
        {
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
                                            int id = (int)row.Cells["userID"].Value;
                                            string deleteQuery = "DELETE FROM usersBook WHERE userID=@id";
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
}