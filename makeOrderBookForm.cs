using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace BookManagementSystem
{
    public partial class makeOrderBookForm : Form
    {
        private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";
        private readonly int userId; // add a field to store the authenticated user ID

        public makeOrderBookForm(int userId) // pass the authenticated user ID to the form constructor
        {
            InitializeComponent();
            this.userId = userId; // store the authenticated user ID in the field
        }

        private void makeOrderBookForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT bookID, bookTitle, publicationYear, bookGenre, bookISBN, bookPrice, bookStock FROM shopBook", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void InsertData(int userId, string userEmail, string userFirstName, string userSecondName, int bookID, string PaymentMethod, string DeliveryLocation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO ordersBook (userId, userEmail, userFirstName, userSecondName, bookID, paymentMethod, DeliveryLocation) VALUES (@userId, @userEmail, @userFirstName, @userSecondName, @bookID, @paymentMethod, @DeliveryLocation)", connection))
            {
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@userEmail", userEmail);
                command.Parameters.AddWithValue("@userFirstName", userFirstName);
                command.Parameters.AddWithValue("@userSecondName", userSecondName);
                command.Parameters.AddWithValue("@bookID", bookID);
                command.Parameters.AddWithValue("@PaymentMethod", PaymentMethod);
                command.Parameters.AddWithValue("@DeliveryLocation", DeliveryLocation);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userEmail = textBox1.Text;
            string userFirstName = textBox2.Text;
            string userSecondName = textBox3.Text;
            int bookID = Convert.ToInt32(textBox4.Text);
            string paymentMethod = comboBox1.SelectedItem.ToString();
            string mailServiceLocation = comboBox2.SelectedItem.ToString();
            InsertData(userId, userEmail, userFirstName, userSecondName, bookID, paymentMethod, mailServiceLocation);
            LoadData();
        }
    }
}
