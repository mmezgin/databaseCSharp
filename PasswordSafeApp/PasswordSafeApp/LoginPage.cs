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
    
    public partial class LoginPage : Form


    {
        UserClass user = new UserClass();
       

        MySqlConnection con;     
        MySqlCommand cmd;
        MySqlDataReader dr;

        MySqlConnection con2;
        MySqlCommand cmd2;

        MySqlDataReader dr3;
        MySqlConnection con3;
        MySqlCommand cmd3;

        MySqlDataReader dr4;
        MySqlConnection con4;
        MySqlCommand cmd4;

        public LoginPage()
        {
            InitializeComponent();
             con  = new MySqlConnection("Server=localhost;Database=ps;user=root;Pwd=hype;SslMode=none");
             con2 = new MySqlConnection("Server=localhost;Database=ps;user=root;Pwd=hype;SslMode=none");
             con3 = new MySqlConnection("Server=localhost;Database=ps;user=root;Pwd=hype;SslMode=none");
             con4 = new MySqlConnection("Server=localhost;Database=ps;user=root;Pwd=hype;SslMode=none");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void GetUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                getPassword.PasswordChar = '\0';
            }
            // getPassword.UseSystemPasswordChar = true;
            else
            {
                getPassword.PasswordChar = '*';
            } 
           //  getPassword.UseSystemPasswordChar = false;
        
            }

        private void Button2_Click(object sender, EventArgs e)
        {
      
            cmd = new MySqlCommand();
            con.Open();
            
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM passlogin where username='" + getUserName.Text + "' AND password='" + getPassword.Text + "'";
          
            cmd2 = new MySqlCommand();
            
            cmd2.Connection = con2;
            dr = cmd.ExecuteReader();
            
            if (dr.Read())

                
            {

                //   UPDATE table_name SET column1 = value1, column2 = value2, ... WHERE condition;

                con2.Open();
                String tempun = getUserName.Text.ToString(); //'" + tempun + "'
                cmd2.CommandText = "UPDATE temp SET tempUsername = '" + tempun + "' ";
                cmd2.ExecuteNonQuery();

                cmd3 = new MySqlCommand();
                con3.Open();
                cmd3.Connection = con3;
                cmd3.CommandText = "SELECT * FROM passlogin where username='" + getUserName.Text + "' AND password='" + getPassword.Text + "' AND privilage = 'admin' ";

                //cmd4 = new MySqlCommand();
                //con4.Open();
                //cmd4.Connection = con4;
                //cmd4.CommandText = "SELECT * FROM passlogin where privilage=admin";
                //dr4 = cmd4.ExecuteReader();

                dr3 = cmd3.ExecuteReader();

                if (dr3.Read()) {

                    //if (dr4.Read())
                    //{

                    MessageBox.Show("Login succesfull ! Directing to Admin Menu ");
                    adminMenu m1 = new adminMenu();
                    LoginPage l1 = new LoginPage();
                    this.Visible = false; //this.close() sıkıntılı neden bilmiyorum...
                    m1.Show();
                    con.Close();
                    con2.Close();
                    con3.Close();
                    //}



                }
                else
                {
                    MessageBox.Show("Login succesfull ! Directing to Employee Menu ");
                    empMenu e1 = new empMenu();
                    this.Hide();
                    e1.Show();
                    con.Close();
                    con2.Close();
                    con3.Close();
                }
                /////////////////////////////////////////////////
                
                
            }
            else
            {
                MessageBox.Show("Wrong Username,Password or both !");
                con.Close();
                con2.Close();
                con3.Close();
            }
            
        }

       

        private void Label3_Click(object sender, EventArgs e)
        {
            signupPage s1 = new signupPage();
            this.Hide();
            s1.Show();
        }

      
    }
    }

