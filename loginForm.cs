using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class loginForm : Form
    {
        private const string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";

        public loginForm()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the form?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            textBox1.ClearIfDefault("Please enter email ...");
        }

        private void textBox2_Click_1(object sender, EventArgs e)
        {
            textBox2.ClearIfDefault("Please enter password ...");
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Сначала проверяем, что пользователь ввел email и пароль
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("select * from adminsBook where adminEmail = @email and adminPassword = @password", conn))
            {
                cmd.Parameters.AddWithValue("@email", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        this.Hide();
                        adminForm form3 = new adminForm();
                        form3.Show();
                        return;
                    }
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("select userID from usersBook where userEmail = @email and userPassword = @password", conn))
            {
                cmd.Parameters.AddWithValue("@email", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);

                conn.Open();

                object userID = cmd.ExecuteScalar();

                if (userID != null)
                {
                    this.Hide();
                    userForm form4 = new userForm(Convert.ToInt32(userID));
                    form4.Show();
                    return;
                }
            }

            // Если ни один из запросов не вернул результатов, значит, email или пароль были введены неверно
            MessageBox.Show("Email or password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            registrationForm registrationForm = new registrationForm();
            registrationForm.Show();
        }
    }

    public static class TextBoxExtensions
    {
        public static void ClearIfDefault(this TextBox textBox, string defaultText)
        {
            if (textBox.Text == defaultText)
            {
                textBox.Text = "";
            }
        }
    }
}
