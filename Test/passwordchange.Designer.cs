namespace Test
{
    partial class passwordchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passwordchange));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.warningLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.approvalPasswordBox = new System.Windows.Forms.TextBox();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OldPasswordBox = new System.Windows.Forms.TextBox();
            this.NewPasswordBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SandyBrown;
            this.groupBox1.Controls.Add(this.warningLbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.approvalPasswordBox);
            this.groupBox1.Controls.Add(this.ChangePassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.OldPasswordBox);
            this.groupBox1.Controls.Add(this.NewPasswordBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(40, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 357);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменение пароля";
            // 
            // warningLbl
            // 
            this.warningLbl.AutoSize = true;
            this.warningLbl.Location = new System.Drawing.Point(32, 242);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(0, 21);
            this.warningLbl.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(83, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Подтвердите новый пароль: *";
            // 
            // approvalPasswordBox
            // 
            this.approvalPasswordBox.Location = new System.Drawing.Point(86, 215);
            this.approvalPasswordBox.Name = "approvalPasswordBox";
            this.approvalPasswordBox.Size = new System.Drawing.Size(212, 27);
            this.approvalPasswordBox.TabIndex = 4;
            this.approvalPasswordBox.UseSystemPasswordChar = true;
            this.approvalPasswordBox.TextChanged += new System.EventHandler(this.approvalPasswordBox_TextChanged);
            this.approvalPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.approvalPasswordBox_KeyDown);
            // 
            // ChangePassword
            // 
            this.ChangePassword.BackColor = System.Drawing.Color.Bisque;
            this.ChangePassword.FlatAppearance.BorderSize = 0;
            this.ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePassword.Location = new System.Drawing.Point(113, 279);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(161, 59);
            this.ChangePassword.TabIndex = 3;
            this.ChangePassword.Text = "Изменить";
            this.ChangePassword.UseVisualStyleBackColor = false;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            this.ChangePassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangePassword_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(83, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введите новый пароль: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(83, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Введите старый пароль: *";
            // 
            // OldPasswordBox
            // 
            this.OldPasswordBox.Location = new System.Drawing.Point(86, 77);
            this.OldPasswordBox.Name = "OldPasswordBox";
            this.OldPasswordBox.Size = new System.Drawing.Size(212, 27);
            this.OldPasswordBox.TabIndex = 0;
            this.OldPasswordBox.UseSystemPasswordChar = true;
            this.OldPasswordBox.TextChanged += new System.EventHandler(this.OldPasswordBox_TextChanged);
            this.OldPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OldPasswordBox_KeyDown);
            // 
            // NewPasswordBox
            // 
            this.NewPasswordBox.Location = new System.Drawing.Point(87, 144);
            this.NewPasswordBox.Name = "NewPasswordBox";
            this.NewPasswordBox.Size = new System.Drawing.Size(212, 27);
            this.NewPasswordBox.TabIndex = 1;
            this.NewPasswordBox.TextChanged += new System.EventHandler(this.NewPasswordBox_TextChanged);
            this.NewPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewPasswordBox_KeyDown);
            // 
            // passwordchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 443);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "passwordchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ashy Horizon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.passwordchange_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OldPasswordBox;
        private System.Windows.Forms.TextBox NewPasswordBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox approvalPasswordBox;
        private System.Windows.Forms.Label warningLbl;
    }
}