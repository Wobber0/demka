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
    public partial class updateUsers : Form
    {
        string ban;
        string connStr = "server=localhost;user=root;database=atelie;password=root;";
        public updateUsers()
        {
            InitializeComponent();
            //очищение боксов
            SelectUserBox.Items.Clear();
            roleBox.Items.Clear();
            banBox.Items.Clear();
            //добавление вариантов бана для бокса
            banBox.Items.Add("Да");
            banBox.Items.Add("Нет");
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string query = "SELECT * FROM user";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            //добавление вариантов для бокса с логинами
            while (reader.Read())
            {
                SelectUserBox.Items.Add(reader["login"].ToString());
            }
            connection.Close();
        }

        private void ChangePassword_Click(object sender, EventArgs e)//изменение данных
        {
            string user = SelectUserBox.Text;
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string sql = $"UPDATE user SET password = '{passwordBox.Text}', role = '{roleBox.Text}', ban = '{ban}', id = '{IDBox.Text}', login = '{SelectUserBox.Text}', name = '{FIOBox.Text}', salary = '{payBox.Text}', WHERE login = '{user}';";
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            connection.Close();
            MessageBox.Show("Информация пользователя обновлена!", "База данных пользователей!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SelectUserBox_SelectedIndexChanged(object sender, EventArgs e)//заполнение полей при выборе логина
        {
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string query = $"SELECT * FROM user;";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //заполнение ролей, если они не совпадают с теми, что уже есть в боксе
                if (!roleBox.Items.Contains(reader["role"].ToString()))
                {
                    roleBox.Items.Add(reader["role"].ToString());
                }
                //если логин из БД совпадает с выбранным, то поля заполняются данными
                if (reader["login"].ToString() == SelectUserBox.Text)
                {
                    passwordBox.Text = reader["password"].ToString();
                    roleBox.Text = reader["role"].ToString();
                    FIOBox.Text = reader["name"].ToString();
                    IDBox.Text = reader["id"].ToString();
                    payBox.Text = reader["salary"].ToString();
                    if (Convert.ToInt32(reader["ban"]) > 0)
                    {
                        banBox.Text = "Нет";
                        ban = "3";
                    }
                    else 
                    {
                        banBox.Text = "Да";
                        ban = "0";
                    }
                }
            }
            connection.Close();
        }
    }
}