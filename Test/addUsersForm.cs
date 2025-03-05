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
        public addUsersForm()
        {
            InitializeComponent();
            roleBox.Items.Clear();
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=hotelbd;password=root;");
            connection.Open();
            string query = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            //добалвение вариантов в комбобокс с ролями
            while (reader.Read())
            {
                if (!roleBox.Items.Contains(reader["role"].ToString()))
                {
                    roleBox.Items.Add(reader["role"].ToString());
                }
            }
            connection.Close();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        { try
            {
                string connStr = "server=localhost;user=root;database=hotelbd;password=root;";
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                //создаем запрос обновления параметра бана и аутентификации
                //проблемы с изменеием аутентификации
                string query = $"insert into users (login, password, role, ban, auth) value ('{loginBox.Text}', '{passwordBox.Text}', '{roleBox.Text}', 3, 0);;";
                MySqlCommand command = new MySqlCommand(query, conn);
                // выполняем запрос
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Новый пользватель добавлен!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Не получилось добавить нового пользователя!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


//прогнать пользователей через нового и если совпадений нет, то добавить