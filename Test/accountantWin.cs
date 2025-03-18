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
        }

        void ShowClienttInGrid(string query)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void accountantWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void отччетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ShowClienttInGrid(@"WITH 
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
            catch
            {
                MessageBox.Show("Ошибка подключения к БД!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void бДToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
