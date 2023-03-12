﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookManagementSystem
{
    public partial class userForm : Form
    {
        private int userID;

        public userForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Строка подключения к базе данных
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Database=bookShop;Integrated Security=True";

            // Создание объекта подключения к базе данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Открытие подключения к базе данных
                connection.Open();

                // Запрос к базе данных для выборки данных, связанных с пользователем
                string query = "SELECT * FROM ordersBook WHERE UserID=@userID";
                // string query = "SELECT * FROM usersBook WHERE UserID=@userID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Добавление параметра запроса
                    command.Parameters.AddWithValue("@userID", userID);

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

        private void viewShopBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shopBookForm form14 = new shopBookForm();
            form14.ShowDialog();
        }
    }
}