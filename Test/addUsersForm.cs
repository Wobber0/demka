using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class addUsersForm : Form
    {
        string connStr = "server=localhost;user=root;database=atelie;password=root;";
        public addUsersForm()
        {
            InitializeComponent();
            roleBox.Items.Clear();
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string query = "select distinct role from user";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            //добалвение вариантов в комбобокс с ролями
            while (reader.Read())
            {
                
                    roleBox.Items.Add(reader[0].ToString());
            }
            connection.Close();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                //создаем запрос обновления параметра бана и аутентификации
                //проблемы с изменеием аутентификации
                string query = $"insert into user (name, salary, login, password, role, ban, auth) value ('{FIOBox.Text}', '{payBox.Text}', '{loginBox.Text}', '{passwordBox.Text}', '{roleBox.Text}', 3, 0);";
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Новый пользватель добавлен!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не получилось добавить нового пользователя!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FIOBox.Clear();
            payBox.Clear();
            loginBox.Clear();
            passwordBox.Clear();
            roleBox.Text = "";
        }
    }
}


//прогнать пользователей через нового и если совпадений нет, то добавить