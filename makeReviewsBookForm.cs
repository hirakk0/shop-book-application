using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

namespace BookManagementSystem
{
    public partial class makeReviewsBookForm : Form
    {
        private readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";
        private readonly int userId; // add a field to store the authenticated user ID

        public makeReviewsBookForm(int userId) // pass the authenticated user ID to the form constructor
        {
            InitializeComponent();
            this.userId = userId; // store the authenticated user ID in the field
        }

        private void makeReviewsBookForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("SELECT userID, bookID, reviewRating, reviewComment FROM reviewsBook", connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void InsertData(int userID, int bookID, int reviewRating, string reviewComment)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO reviewsBook (userID, bookID, reviewRating, reviewComment) VALUES (@userID, @bookID, @reviewRating, @reviewComment)", connection))
            {
                command.Parameters.AddWithValue("@userID", userID);
                command.Parameters.AddWithValue("@bookID", bookID);
                command.Parameters.AddWithValue("@reviewRating", reviewRating);
                command.Parameters.AddWithValue("@reviewComment", reviewComment);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            int bookID = Convert.ToInt32(textBox1.Text);
            int reviewRating = Convert.ToInt32(textBox2.Text);
            string reviewComment = textBox3.Text;
            InsertData(userId, bookID, reviewRating, reviewComment);
            LoadData();
        }

        private void viewShopBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shopBookForm form14 = new shopBookForm();
            form14.Show();
        }

        private void viewInformationBookAuthorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorBooksForm authorBooksForm = new AuthorBooksForm();
            authorBooksForm.ShowDialog();
        }

        private void systemExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
