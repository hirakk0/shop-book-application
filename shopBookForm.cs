using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagementSystem
{
    public partial class shopBookForm : Form
    {
        public shopBookForm()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            {
                // Строка подключения к базе данных
                string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";

                // Создание объекта подключения к базе данных
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Открытие подключения к базе данных
                    connection.Open();

                    // Запрос к базе данных для выборки данных, связанных с пользователем
                    string query = "SELECT * FROM shopBook";
                    // string query = "SELECT * FROM usersBook WHERE UserID=@userID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Создание объекта DataTable для хранения результатов запроса
                        DataTable dataTable = new DataTable();

                        // Использование объекта SqlDataAdapter для заполнения DataTable данными из запроса
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            dataAdapter.Fill(dataTable);
                        }

                        // Назначение DataTable в качестве источника данных для DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

    }
}
