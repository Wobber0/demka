using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class AdminWin : Form
    {
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        string nameT;
        string connectionString = "Server=localhost;Port=3306;Database=atelie;Username=root;Password=root;";//адрес подключения
        public AdminWin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(AdminWin_FormClosing);
        }


        private void LoadData(string table)
        {
            try
            {
                string query = $"SELECT * FROM `{table}`";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    adapter = new MySqlDataAdapter(query, connection);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    BDGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        public void SaveChanges(string table)
        {
            try
            {
                string query = $"SELECT * FROM `{table}`";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(adapter); // Автогенерация команд

                    DataTable dataTable = (DataTable)BDGridView.DataSource;
                    adapter.Update(dataTable); // Сохранение изменений

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private void AdminWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)//возвращение к вкладке авторизации
        {
            authorization autor = new authorization();
            autor.Show();
            this.Hide();
        }
        private void seeUsers_Click(object sender, EventArgs e)//показ пользователей
        {
                nameT = "user";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, "user");
                BDGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void addUsers_Click(object sender, EventArgs e)//открытие окна добавления пользователей
        {
            addUsersForm addUsersForm = new addUsersForm();
            addUsersForm.ShowDialog();
        }

        private void delitUsers_Click(object sender, EventArgs e)//открытие окна удаления пользователей
        {
            delUsers delUsers = new delUsers();
            delUsers.ShowDialog();
            
        }

        private void updateUsers_Click(object sender, EventArgs e)//открытие окна обновления пользователей
        {
            updateUsers updateUsers = new updateUsers();
            updateUsers.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            authorization AUTH = new authorization();
            AUTH.Show();
            this.Hide();
        }

        private void услугиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nameT = "service";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, "service");

        }

        private void платежиToolStripMenuItem_Click(object sender, EventArgs e)
        {   nameT = "payment";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, "payment");
        }

        private void MaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {   nameT = "material";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, "material");
        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {   nameT = "order";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, "order");
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {   nameT = "client";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, "client");
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            DatabaseHelper.SaveChanges(BDGridView, nameT);
        }
    }
    }