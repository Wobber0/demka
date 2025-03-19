using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new authorization());
        }
    }
    static class usersID
    {
        public static string Value { get; set; }
    }

    public static class DatabaseHelper
    {
        // Общая строка подключения
        public static string ConnectionString { get; set; } = "Server=localhost;Port=3306;Database=atelie;Username=root;Password=root;";

        // Загрузка данных в DataGridView
        public static void LoadDataIntoGrid(DataGridView dataGridView, string tableName)
        {
            try
            {
                using (var connection = new MySqlConnection(ConnectionString))
                {
                    string query = $"SELECT * FROM `{tableName}`";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.Invoke((MethodInvoker)delegate
                    {
                        dataGridView.DataSource = dataTable;
                    });
                }
            }
            catch (MySqlException ex)
            {
                ShowError($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        // Сохранение изменений
        public static void SaveChanges(DataGridView dataGridView, string tableName)
        {
            try
            {
                if (dataGridView.DataSource is DataTable dataTable)
                {
                    using (var connection = new MySqlConnection(ConnectionString))
                    {
                        string query = $"SELECT * FROM `{tableName}`";
                        var adapter = new MySqlDataAdapter(query, connection);
                        var commandBuilder = new MySqlCommandBuilder(adapter);

                        adapter.Update(dataTable);
                        ShowInfo("Данные успешно сохранены!");
                    }
                }
            }
            catch (MySqlException ex)
            {
                ShowError($"Ошибка сохранения: {ex.Message}");
            }
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
