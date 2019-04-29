using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PasswordSafeApp
{
    public partial class accountmenu : Form
    {
        //UserClass user = new UserClass();
        MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=ps;" + "User ID= root;PASSWORD=hype");
        MySqlConnection con;
        MySqlCommand cmd;

        MySqlConnection con2;
        MySqlCommand cmd2;

        






        public accountmenu()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=ps;user=root;Pwd=hype;SslMode=none");
            con2 = new MySqlConnection("Server=localhost;Database=ps;user=root;Pwd=hype;SslMode=none");

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            adminMenu m = new adminMenu();
            this.Hide();
            m.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {







            //////////////////////////
            con2.Open();
            cmd2 = new MySqlCommand();
            cmd2.Connection = con2;
            cmd2.CommandText = "Select tempUsername FROM temp WHERE ID=0";
            cmd2.ExecuteNonQuery();
            cmd2.Parameters.AddWithValue("@x", 1);

            //////////////////////////////////////////////////////// HATALI KOD BLOĞU
            con.Open();
            cmd = new MySqlCommand();
            cmd.Connection = con;
           // cmd.CommandText = "DELETE FROM passlogin WHERE username='"+  +"' ";
            cmd.ExecuteNonQuery();
            con2.Close();
            con.Close();
        }
    }
}
