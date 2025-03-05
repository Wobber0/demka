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
    public partial class delUsers : Form
    {
        string connStr = "server=localhost;user=root;database=hotelbd;password=root;";
        public delUsers()
        {
            InitializeComponent();
            //очищение комбобокса с пользователями
            userBox.Items.Clear();
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string query = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            //добавление вариантов выбора в комбобокс с логинами
            while (reader.Read())
            {
                string name = reader["login"].ToString();
                userBox.Items.Add(name);
            }
            connection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try//удачное удаление пользователя
            {
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                string qu = $"DELETE FROM users WHERE login = '{userBox.Text}'";
                MySqlCommand comm = new MySqlCommand(qu, conn);
                MySqlDataReader read = comm.ExecuteReader();
                conn.Close();
                MessageBox.Show("Пользователь удален!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //обновление списка
                MySqlConnection connection = new MySqlConnection(connStr);
                connection.Open();
                string query = "SELECT * FROM users";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                userBox.Items.Clear();
                while (reader.Read())
                {
                    string name = reader["login"].ToString();
                    userBox.Items.Add(name);
                }
                connection.Close();
            }
            catch (Exception ex)//неудачное удаление пользователя
            {
                MessageBox.Show(ex.ToString(), "Ошибка подключения к БД!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
