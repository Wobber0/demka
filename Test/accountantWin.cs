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
    public partial class accountantWin: Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=atelie;Username=root;Password=root;";
        public accountantWin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(accountantWin_FormClosing);
            ShowInGrid(@"SELECT 
                                s.name AS 'Название услуги',
                                COUNT(o.id) AS 'Общее количество заказов',
                                SUM(o.cost) AS 'Суммарная выручка',
                                SUM(CASE WHEN o.status = 'Готово' THEN 1 ELSE 0 END) AS 'Завершенные заказы',
                                SUM(CASE WHEN o.status = 'Отменено' THEN 1 ELSE 0 END) AS 'Отмененные заказы'

                            FROM 
                                `order` o
                            INNER JOIN 
                                `service` s ON o.service_id = s.id
                            GROUP BY 
                                o.service_id, s.name
                            ORDER BY 
                                SUM(o.cost) DESC;");
        }

        void ShowInGrid(string query)
        {
            try
            {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
            }
            catch { MessageBox.Show("Ошибка подключения к БД!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Создаем форму подтверждения
            ConfExitWin confirmForm = new ConfExitWin();
            DialogResult result = confirmForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                // Закрываем текущую форму и открываем авторизацию
                this.Hide();
                authorization Form = new authorization();
                Form.Show();
            }
            else
            {
                // Просто закрываем диалог, основная форма остается
                confirmForm.Close();
            }
        }

        private void accountantWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void отччетToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ShowInGrid(@"WITH 
                               salary_expenses AS (
                             SELECT SUM(salary) AS total_salary 
                             FROM user
                             ),
                               material_expenses AS (
                             SELECT SUM(m.price_unit) AS total_materials 
                             FROM material o
                             INNER JOIN order_has_material om ON o.id = om.order_id
                             INNER JOIN material m ON om.material_id = m.id
                             )
                             SELECT 
                               s.total_salary AS 'Расходы на зарплаты',
                               m.total_materials AS 'Расходы на материалы',
                               s.total_salary + m.total_materials AS 'Общие расходы'
                             FROM salary_expenses s, material_expenses m;");            
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseHelper.LoadDataIntoGrid(dataGridView1, "order");
        }

        private void платежиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseHelper.LoadDataIntoGrid(dataGridView1, "payment");
        }

        private void материалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseHelper.LoadDataIntoGrid(dataGridView1, "material");
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ShowInGrid(@"SELECT 
                                s.name AS 'Название услуги',
                                COUNT(o.id) AS 'Общее количество заказов',
                                SUM(o.cost) AS 'Суммарная выручка',
                                SUM(CASE WHEN o.status = 'Готово' THEN 1 ELSE 0 END) AS 'Завершенные заказы',
                                SUM(CASE WHEN o.status = 'Отменено' THEN 1 ELSE 0 END) AS 'Отмененные заказы'

                            FROM 
                                `order` o
                            INNER JOIN 
                                `service` s ON o.service_id = s.id
                            GROUP BY 
                                o.service_id, s.name
                            ORDER BY 
                                SUM(o.cost) DESC;");
        }
    }
}
