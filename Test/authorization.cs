using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
//форма рабочая
namespace Test
{
    public partial class authorization : Form
    {
        // строка подключения к БД
        string connStr = "server=localhost;user=root;database=hotelbd;password=root;";
        string login;
        string password;
        int ban;
        int auth;
        bool schet = true;


        public authorization()
        {
            InitializeComponent();
            //закрытие других форм просле закрытия этой
            this.FormClosing += new FormClosingEventHandler(AutorWin_FormClosing);

        }

        void AutorWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            //создаем запрос обновления параметра бана и аутентификации
            string query = $"update users SET ban = {ban}, auth = {auth} WHERE login = '{loginBox.Text}';";
            MySqlCommand command = new MySqlCommand(query, conn);
            // выполняем запрос
            command.ExecuteNonQuery();
            conn.Close();
        }
        private void autorizating_Click(object sender, EventArgs e)
        {
            // конвертируем параметры
            login = Convert.ToString(loginBox.Text);
            password = Convert.ToString(passwordBox.Text);
            //проверяем на ноль или лишние пробелы
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Логин и пароль не должны быть пустыми!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // создаём объект для подключения к БД
            MySqlConnection conn = new MySqlConnection(connStr);
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = "SELECT login, password, role, ban, auth FROM users";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = command.ExecuteReader();
            // читаем результат
            while (reader.Read())
            {
                //обработка ошибки
                try
                {
                    //если логин и пароль равны
                    if (reader[0].ToString() == login && reader[1].ToString() == password)
                    {
                        //если аккаунт забанен
                        if (reader[3].ToString() == "0")
                        {
                            MessageBox.Show("Этот аккаунт был заблокирован за чрезмерное количество неправильных попыток входа!\nОбратитесь к администратору.", "Нарушение!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else //если не забанен
                        { // если роль читается как администратор
                            if (reader[2].ToString() == "admin")
                            {
                                AdminWin adm = new AdminWin();
                                MessageBox.Show("Вы успешно авторизовались, администратор!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                adm.Show();
                                this.Hide();
                                return;
                            }
                            else //если читается роль пользователя, по желанию можно разнообразить теми же swithc case
                            {
                                UserWin userWin = new UserWin();
                                passwordchange pass = new passwordchange();
                                MessageBox.Show("Вы успешно авторизовались, пользователь!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (reader[4].ToString() == "0") //если это первая аутентификация(парметр равен нулю)
                                {
                                    auth = 1;
                                    pass.Show();
                                }
                                else//иначе просто открываем форму
                                {
                                    userWin.Show();
                                }
                                this.Hide();
                                return;
                            }
                        }
                        
                    }
                    //если не равен пароль
                    else if (reader[0].ToString() == login && reader[1].ToString() != password)
                    {
                        if(schet)//костыль первого совпадения
                        {
                            ban = Convert.ToInt32(reader[3]);
                            schet = false;
                        }
                        //уменьшаем параметр бан до собственно самого бана(когда он равен 0)
                        ban--;
                        if (ban == 2)
                        {
                            MessageBox.Show("Введен неверный пароль. Пожалуйста проверьте введенные данные.\nОсталось " + ban + " попытки до блокировки!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (ban ==1)
                        {
                            MessageBox.Show("Введен неверный пароль. Пожалуйста проверьте введенные данные.\nОсталась " + ban + " попытка до блокировки!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Этот аккаунт был заблокирован за чрезмерное количество неправильных попыток входа!\nОбратитесь к администратору.", "Нарушение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                }
                //если что-то на этапах неудалось, выдает ошибку
                catch { MessageBox.Show("Проблема чтения с БД!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            reader.Close(); // закрываем reader
            // закрываем соединение с БД
            conn.Close();
        }

        //переключение enter'ом между полями ввода и кнопкой входа
        private void loginBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordBox.Focus();
            }
        }
        private void passwordBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                autorizating.Focus();
            }
        }
    }
}