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
    public partial class signupPage : Form
    {
        string z;
        MySqlConnection dt = new MySqlConnection("Server= 127.0.0.1;Database=ps;" + "User ID= root;PASSWORD=hype");

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        MySqlConnection con2;
        MySqlCommand cmd2;
       
        public signupPage()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=ps;user=root;Pwd=hype;SslMode=none");
            con2 = new MySqlConnection("Server=localhost;Database=ps;user=root;Pwd=hype;SslMode=none");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginPage l1 = new LoginPage();
            this.Visible = false;
            l1.Show();
            
        }

        private void SignupPage_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
             Random rnd = new Random();
            if (radioButtonAdmin.Checked==true)
                {
                string z = "admin";
            }
            else if (radioButtonUser.Checked == true)
            {
                string z = "emp";
            }

            int rndID = rnd.Next(1, 99999999);
            string x = getUsername.Text.ToString();
          //  int x = int.Parse(getUsername.Text);
            string y = getPassword.Text.ToString();
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;

            cmd2 = new MySqlCommand();
            con2.Open();
            cmd2.Connection = con2;
            cmd2.CommandText = "SELECT * FROM passlogin where username='" + x + "'";
            dr = cmd2.ExecuteReader();
            if (dr.Read())


            {
                MessageBox.Show("This username already exists.Change username please.");
                getPassword.Clear();
                getUsername.Clear();
                con.Close();
            }
            else
            {
                if (radioButtonUser.Checked == true || radioButtonAdmin.Checked == true)
                {

                    cmd.CommandText = "INSERT INTO passlogin (ID,username,password,privilage) VALUES ('" + rndID + "','" + x + "', '" + y + "','" + z + "')    ";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succesfully Registered !!! Directing to Log Screen...");
                    LoginPage l1 = new LoginPage();
                    this.Visible = false;
                    l1.Show();
                    con.Close();
                }else
                {
                    MessageBox.Show("Please select a privilage !(User or Admin)");
                    con.Close();
                }
            }
        }

        private void RadioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
