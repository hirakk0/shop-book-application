using System;
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
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("INSERT INTO usersBook (userEmail, userPassword, userZipCode) VALUES (@Email, @Password, @ZipCode); SELECT SCOPE_IDENTITY();", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(textBox1.Text) ? DBNull.Value : (object)textBox1.Text);
                    cmd.Parameters.AddWithValue("@Password", string.IsNullOrEmpty(textBox2.Text) ? DBNull.Value : (object)textBox2.Text);
                    cmd.Parameters.AddWithValue("@ZipCode", string.IsNullOrEmpty(textBox3.Text) ? DBNull.Value : (object)textBox3.Text);

                    int userID = Convert.ToInt32(cmd.ExecuteScalar());

                    this.Hide();
                    userForm form4 = new userForm(userID);
                    form4.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during registration: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
