using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class registrationForm : Form
    {
        private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";

        public registrationForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the form?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            ClearIfDefault(textBox1, "Please enter email ...");
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            ClearIfDefault(textBox2, "Please enter password ...");
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            ClearIfDefault(textBox3, "Please enter ZIPCode ...");
        }

        private void ClearIfDefault(TextBox textBox, string defaultValue)
        {
            if (textBox.Text == defaultValue)
            {
                textBox.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO usersBook (userEmail, userPassword, userZipCode) VALUES (@Email, @Password, @ZipCode)";
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(textBox1.Text) ? DBNull.Value : (object)textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", string.IsNullOrEmpty(textBox2.Text) ? DBNull.Value : (object)textBox2.Text);
                    cmd.Parameters.AddWithValue("@ZipCode", string.IsNullOrEmpty(textBox3.Text) ? DBNull.Value : (object)textBox3.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        int userID = 0;
                        cmd.CommandText = "SELECT SCOPE_IDENTITY()";
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            userID = Convert.ToInt32(result);
                        }

                        this.Hide();
                        userForm form4 = new userForm(userID);
                        form4.Show();
                    }
                }
            }
        }
    }
}