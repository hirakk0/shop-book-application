using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the form?", "Confirmation", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
            }
            else
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
            using (SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True"))
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;

                cmd.CommandText = "select * from adminsBook where adminEmail = @email and adminPassword = @password";
                cmd.Parameters.AddWithValue("@email", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                SqlDataAdapter adapterAdmin = new SqlDataAdapter(cmd);
                DataSet dataSetAdmin = new DataSet();
                adapterAdmin.Fill(dataSetAdmin);

                cmd.CommandText = "select * from usersBook where userEmail = @email and userPassword = @password";
                SqlDataAdapter adapterUser = new SqlDataAdapter(cmd);
                DataSet dataSetUser = new DataSet();
                adapterUser.Fill(dataSetUser);

                if (dataSetUser.Tables[0].Rows.Count != 0)
                {
                    // Запоминаем userID текущего пользователя
                    int userID = Convert.ToInt32(dataSetUser.Tables[0].Rows[0]["userID"]);

                    this.Hide();
                    Form4 form4 = new Form4(userID); // Передаем userID в форму Form4
                    form4.Show();
                }

                if (dataSetAdmin.Tables[0].Rows.Count != 0)
                {
                    this.Hide();
                    Form3 form3 = new Form3();
                    form3.Show();
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
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
