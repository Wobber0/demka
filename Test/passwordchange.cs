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
        private void ChangePassword_Click(object sender, EventArgs e)
        {
           UserWin user = new UserWin();
            // строка подключения к БД
            string connStr = "server=localhost;user=root;database=hotelbd;password=root;";
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = "SELECT password FROM users";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            while (reader.Read())
            {
                if (oldP == reader[0].ToString())
                {
                    user.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Такого пароля не существует!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            reader.Close(); // закрываем reader
            // закрываем соединение с БД
            conn.Close();
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
        }
    }
}
