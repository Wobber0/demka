using DocumentFormat.OpenXml.Spreadsheet;
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

        string connectionString = "Server=localhost;Port=3306;Database=atelie;Username=root;Password=root;";//адрес подключения
        public AdminWin()
        {
            InitializeComponent();

            this.FormClosing += new FormClosingEventHandler(AdminWin_FormClosing);
        }


        void ShowClienttInGrid(string comm)//шаблон показа таблиц
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            string query = comm;
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            BDGridView.DataSource = table;
            conn.Close();
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
            try
            {
                ShowClienttInGrid("SELECT * FROM user");
                BDGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch
            {
                MessageBox.Show("Ошибка подключения к БД!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
    }
    }