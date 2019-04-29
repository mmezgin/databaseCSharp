using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSafeApp
{
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginPage l = new LoginPage();
            this.Hide();
            l.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            accountmenu a = new accountmenu();
            this.Hide();
            a.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            employeeSettings e1 = new employeeSettings();
            this.Hide();
            e1.Show();
        }
    }
}
