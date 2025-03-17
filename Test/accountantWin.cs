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
        public accountantWin()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(accountantWin_FormClosing);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accountantWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
