using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelMgtSyst_Accounting
{
    public partial class hotelAccounts : Form
    {
        public hotelAccounts()
        {
            InitializeComponent();
        }

        private void hotelAccounts_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_expenses_Click(object sender, EventArgs e)
        {
            expense_form expenses_window = new expense_form();
            //display the new window
            expenses_window.Show();
            expenses_window.FormClosed += expenses_window_FormClosed;
            this.Hide();
        }

        private void expenses_window_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
