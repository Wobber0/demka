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
    public partial class passwordchange : Form
    {
        public passwordchange()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(passwordchange_FormClosing);
        }

        string oldP;
        string newP;
        string appP;
        string connStr = "server=localhost;user=root;database=atelie;password=root;";
        private void ChangePassword_Click(object sender, EventArgs e)
        {
            if(newP == appP)
            {
                AdminWin admin = new AdminWin();
                seamstressWin streams = new seamstressWin();
                accountantWin accountant = new accountantWin();
                // строка подключения к БД
                // создаём объект для подключения к БД
                MySqlConnection conn = new MySqlConnection(connStr);
                // устанавливаем соединение с БД
                conn.Open();
                // запрос
                string sql = "SELECT * FROM user";
                // объект для выполнения SQL-запроса
                MySqlCommand command = new MySqlCommand(sql, conn);
                // объект для чтения ответа сервера
                MySqlDataReader reader = command.ExecuteReader();
                // читаем результат
                while (reader.Read())
                {
                    if (oldP == reader["password"].ToString())
                    {
                        switch(reader["role"].ToString())
                        {
                            case "Швея":
                                streams.Show();
                                this.Hide();
                                return;
                            case "Администратор":
                                admin.Show();
                                this.Hide();
                                return;
                            case "Бухгалтер":
                                accountant.Show();
                                this.Hide();
                                return;
                        }
                    }
                }
                MessageBox.Show("Такого пароля не существует!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reader.Close(); // закрываем reader
                                // закрываем соединение с БД
                conn.Close();
            }
        }

        private void approvalPasswordBox_TextChanged(object sender, EventArgs e)
        {
            appP = approvalPasswordBox.Text;
            if (newP != appP) { warningLbl.Text = "Введенный пароль не совпадает с новым!"; }
            else { warningLbl.Text = ""; }
        }

        private void NewPasswordBox_TextChanged(object sender, EventArgs e)
        {
            newP = NewPasswordBox.Text;
        }

        private void OldPasswordBox_TextChanged(object sender, EventArgs e)
        {
            oldP = OldPasswordBox.Text;
        }

        private void passwordchange_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = $"UPDATE user SET password = '{NewPasswordBox.Text}' WHERE password = '{OldPasswordBox.Text}';";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
        }
    }
}
