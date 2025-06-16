using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class AdminWin : Form
    {
        string nameT;
        public AdminWin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(AdminWin_FormClosing);
        }

        private void AdminWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)//возвращение к вкладке авторизации
        {
            authorization autor = new authorization();
            autor.Show();
            this.Hide();
        }
        private void seeUsers_Click(object sender, EventArgs e)//показ пользователей
        {
            nameT = "user";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, nameT);
        }

        private void addUsers_Click(object sender, EventArgs e)//открытие окна добавления пользователей
        {
            addUsersForm addUsersForm = new addUsersForm();
            addUsersForm.ShowDialog();
        }

        private void delitUsers_Click(object sender, EventArgs e)//открытие окна удаления пользователей
        {
            delUsers delUsers = new delUsers();
            delUsers.ShowDialog();
            
        }

        private void updateUsers_Click(object sender, EventArgs e)//открытие окна обновления пользователей
        {
            updateUsers updateUsers = new updateUsers();
            updateUsers.ShowDialog();
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

        private void услугиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nameT = "service";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, nameT);
            DatabaseHelper.LoadDataIntoGrid(BDGridView, nameT);

        }

        private void платежиToolStripMenuItem_Click(object sender, EventArgs e)
        {   nameT = "payment";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, nameT);
        }

        private void MaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {   nameT = "material";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, nameT);
        }

        private void OrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {   nameT = "order";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, nameT);
        }

        private void ClientToolStripMenuItem_Click(object sender, EventArgs e)
        {   nameT = "client";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, nameT);
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            DatabaseHelper.SaveChanges(BDGridView, nameT);
        }

        private void материалыЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameT = "order_has_material";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, nameT);
        }

        private void заказыПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameT = "user_has_order";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, nameT);
        }

        private void меркиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nameT = "measurements";
            DatabaseHelper.LoadDataIntoGrid(BDGridView, nameT);
        }
    }
    }