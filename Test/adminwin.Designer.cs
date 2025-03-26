namespace Test
{
    partial class AdminWin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйПользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.платежиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BDGridView = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.новыйПользовательToolStripMenuItem,
            this.пользователиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.menuStrip1.Size = new System.Drawing.Size(767, 58);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.выходToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(85, 28);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // новыйПользовательToolStripMenuItem
            // 
            this.новыйПользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйЗаказToolStripMenuItem,
            this.MaterialToolStripMenuItem,
            this.OrdersToolStripMenuItem,
            this.услугиToolStripMenuItem1,
            this.платежиToolStripMenuItem});
            this.новыйПользовательToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.новыйПользовательToolStripMenuItem.Name = "новыйПользовательToolStripMenuItem";
            this.новыйПользовательToolStripMenuItem.Size = new System.Drawing.Size(111, 28);
            this.новыйПользовательToolStripMenuItem.Text = "Таблицы";
            // 
            // новыйЗаказToolStripMenuItem
            // 
            this.новыйЗаказToolStripMenuItem.Name = "новыйЗаказToolStripMenuItem";
            this.новыйЗаказToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.новыйЗаказToolStripMenuItem.Text = "Клиенты";
            this.новыйЗаказToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // MaterialToolStripMenuItem
            // 
            this.MaterialToolStripMenuItem.Name = "MaterialToolStripMenuItem";
            this.MaterialToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.MaterialToolStripMenuItem.Text = "Материалы";
            this.MaterialToolStripMenuItem.Click += new System.EventHandler(this.MaterialToolStripMenuItem_Click);
            // 
            // OrdersToolStripMenuItem
            // 
            this.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem";
            this.OrdersToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.OrdersToolStripMenuItem.Text = "Заказы";
            this.OrdersToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem1
            // 
            this.услугиToolStripMenuItem1.Name = "услугиToolStripMenuItem1";
            this.услугиToolStripMenuItem1.Size = new System.Drawing.Size(202, 28);
            this.услугиToolStripMenuItem1.Text = "Услуги";
            this.услугиToolStripMenuItem1.Click += new System.EventHandler(this.услугиToolStripMenuItem1_Click);
            // 
            // платежиToolStripMenuItem
            // 
            this.платежиToolStripMenuItem.Name = "платежиToolStripMenuItem";
            this.платежиToolStripMenuItem.Size = new System.Drawing.Size(202, 28);
            this.платежиToolStripMenuItem.Text = "Платежи";
            this.платежиToolStripMenuItem.Click += new System.EventHandler(this.платежиToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
            this.пользователиToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(166, 28);
            this.пользователиToolStripMenuItem.Text = "Пользователи";
            // 
            // показатьToolStripMenuItem
            // 
            this.показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            this.показатьToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.показатьToolStripMenuItem.Text = "Показать";
            this.показатьToolStripMenuItem.Click += new System.EventHandler(this.seeUsers_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.addUsers_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.delitUsers_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(181, 28);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.updateUsers_Click);
            // 
            // BDGridView
            // 
            this.BDGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BDGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BDGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BDGridView.Location = new System.Drawing.Point(81, 97);
            this.BDGridView.Name = "BDGridView";
            this.BDGridView.RowHeadersVisible = false;
            this.BDGridView.Size = new System.Drawing.Size(622, 362);
            this.BDGridView.TabIndex = 2;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.SandyBrown;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(54, 504);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(205, 59);
            this.save.TabIndex = 4;
            this.save.Text = "Сохранить изменения";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // AdminWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 592);
            this.Controls.Add(this.save);
            this.Controls.Add(this.BDGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdminWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminWin_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйПользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdersToolStripMenuItem;
        private System.Windows.Forms.DataGridView BDGridView;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem платежиToolStripMenuItem;
        private System.Windows.Forms.Button save;
    }
}