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
    public partial class employeeSettings : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        
        
        public employeeSettings()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=ps;user=root;Pwd=hype;SslMode=none");
        }





        /*
         * SELECT ps.passlogin.ID,ps.passlogin.username,
ps.passlogin.privilage,ps.personel_info.ID
,ps.personel_info.surname,ps.personel_info.age FROM ps.passlogin LEFT JOIN ps.personel_info ON ps.passlogin.ID = ps.personel_info.ID
UNION 
SELECT ps.passlogin.ID,ps.passlogin.username,
ps.passlogin.privilage,ps.personel_info.ID
,ps.personel_info.surname,ps.personel_info.age FROM ps.personel_info RIGHT JOIN ps.passlogin ON ps.passlogin.ID = ps.personel_info.ID;


         */
         public void clearTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            maskedTextBox1.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
         //   textBox15.Clear();
           // textBox16.Clear();
            //textBox17.Clear();
            textBox18.Clear();
        }





        public void showData()
        {
            con.Open();
            /*
             * SELECT Orders.OrderID, Customers.CustomerName
FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;
            */
            //  MySqlDataAdapter my = new MySqlDataAdapter("SELECT * FROM passlogin", con);
            /* MySqlDataAdapter my = new MySqlDataAdapter("SELECT personel_info.ID,personel_info.name,personel_info.surname," +
                 "personel_info.age,passlogin.username,passlogin.password,passlogin.privilage FROM " +
                 "personel_info INNER JOIN passlogin ON personel_info.ID = passlogin.ID", con);
             DataTable d = new DataTable();
             my.Fill(d);
             dataGridView1.Rows.Clear(); */
            MySqlDataAdapter my1 = new MySqlDataAdapter("SELECT * FROM anomalyTable ", con);
            DataTable d1 = new DataTable();
            my1.Fill(d1);
            dataGridView1.Rows.Clear();


            foreach (DataRow item in d1.Rows)
            {
                int r = dataGridView1.Rows.Add();
                dataGridView1.Rows[r].Cells[0].Value = item["ID"].ToString();
                dataGridView1.Rows[r].Cells[1].Value = item["name"].ToString();
                dataGridView1.Rows[r].Cells[2].Value = item["surname"].ToString();
                dataGridView1.Rows[r].Cells[3].Value = item["age"].ToString();
                dataGridView1.Rows[r].Cells[4].Value = item["country"].ToString();
                dataGridView1.Rows[r].Cells[5].Value = item["city"].ToString();
                dataGridView1.Rows[r].Cells[6].Value = item["nationality"].ToString();
                dataGridView1.Rows[r].Cells[7].Value = item["email"].ToString();
                dataGridView1.Rows[r].Cells[8].Value = item["fax"].ToString();
                dataGridView1.Rows[r].Cells[9].Value = item["phone"].ToString();
                dataGridView1.Rows[r].Cells[10].Value = item["salary"].ToString();
                dataGridView1.Rows[r].Cells[11].Value = item["domain"].ToString();
                dataGridView1.Rows[r].Cells[12].Value = item["yearOnWork"].ToString();
                dataGridView1.Rows[r].Cells[13].Value = item["offDays"].ToString();
                dataGridView1.Rows[r].Cells[14].Value = item["username"].ToString();
                dataGridView1.Rows[r].Cells[15].Value = item["password"].ToString();
                dataGridView1.Rows[r].Cells[16].Value = item["privilage"].ToString();
                

            }
            con.Close();






        }
        private void Button1_Click(object sender, EventArgs e)
        {
            adminMenu m1 = new adminMenu();
            this.Hide();
            m1.Show();
        }

        private void EmployeeMenu_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible  = false;
            textBox2.Visible  = false;
            textBox3.Visible  = false;
            textBox4.Visible  = false;
            textBox5.Visible  = false;
            textBox6.Visible  = false;
            textBox7.Visible  = false;
            textBox8.Visible  = false;
            textBox9.Visible  = false;
            maskedTextBox1.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            //textBox15.Visible = false;
            //textBox16.Visible = false;
            //textBox17.Visible = false;
            textBox18.Visible = false;
            button6.Visible   = false;
            dataGridView1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            //label15.Visible = false;
            //label16.Visible = false;
            //label17.Visible = false;
            label18.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            showData();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            maskedTextBox1.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
          //  textBox15.Visible = true;
            //textBox16.Visible = true;
            //textBox17.Visible = true;
            textBox18.Visible = false;
            button6.Visible = true;
            dataGridView1.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            //label15.Visible = true;
            //label16.Visible = true;
            //label17.Visible = true;
            label18.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = true;
            button10.Visible = false;


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            maskedTextBox1.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
        //    textBox15.Visible = false;
          //  textBox16.Visible = false;
            //textBox17.Visible = false;
            textBox18.Visible = true;
            button6.Visible = false;
            dataGridView1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
         //   label15.Visible = false;
           // label16.Visible = false;
            //l//abel17.Visible = false;
            label18.Visible = true;
            button7.Visible = false;
            button8.Visible = true;
            button9.Visible = false;
            button10.Visible = true;
            showData();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            maskedTextBox1.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
        //    textBox15.Visible = false;
          //  textBox16.Visible = false;
            //textBox17.Visible = false;
            textBox18.Visible = true;
            button6.Visible = false;
            dataGridView1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
        //    label15.Visible = false;
          //  label16.Visible = false;
            //label17.Visible = false;
            label18.Visible = true;
            button7.Visible = true;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
            showData();
        }

        private void Button6_Click(object sender, EventArgs e)
        {

       
            MySqlConnection dt1 = new MySqlConnection("Server= 127.0.0.1;Database=ps;" + "User ID= root;PASSWORD=hype");
            MySqlConnection dt2 = new MySqlConnection("Server= 127.0.0.1;Database=ps;" + "User ID= root;PASSWORD=hype");
            MySqlConnection dt3 = new MySqlConnection("Server= 127.0.0.1;Database=ps;" + "User ID= root;PASSWORD=hype");
            MySqlConnection dt4 = new MySqlConnection("Server= 127.0.0.1;Database=ps;" + "User ID= root;PASSWORD=hype");
            MySqlConnection dt5 = new MySqlConnection("Server= 127.0.0.1;Database=ps;" + "User ID= root;PASSWORD=hype");

           MySqlConnection dt6 = new MySqlConnection("Server= 127.0.0.1;Database=ps;" + "User ID= root;PASSWORD=hype");
            dt1.Open();
            dt2.Open();
            dt3.Open();
            dt4.Open();
            dt5.Open();
            dt6.Open();

            var com1 ="INSERT INTO personel_info (ID,name,surname,age) VALUES('" + textBox1.Text + "'," +
                            "'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            var com2 ="INSERT INTO nation (ID,country,city,nationality) VALUES('" + textBox1.Text + "'," +
                            "'" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            var com3 ="INSERT INTO contact_info1 (ID,email,fax) VALUES('" + textBox1.Text + "'," +
                            "'" + textBox8.Text + "','" + textBox9.Text + "')";
            var com4 ="INSERT INTO contact_info2 (ID,phone) VALUES('" + textBox1.Text + "'," +
                            "'" + maskedTextBox1.Text + "')";
            var com5 ="INSERT INTO employee_info (ID,salary,domain,yearOnWork,offDays) VALUES('" + textBox1.Text + "'," +
                            "'" + textBox11.Text + "','" + textBox12.Text + "','" + textBox13.Text + "','" + textBox14.Text + "')";
            var com6 ="INSERT INTO anomalyTable (ID,name,surname,age,country,city,nationality,email,fax,phone,salary,domain,yearOnWork," +
                "offDays) VALUES('" + textBox1.Text + "'," +
                            "'" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'," +
                            "'" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "'," +
                            "'" + textBox9.Text + "','" + maskedTextBox1.Text + "','" + textBox11.Text + "','" + textBox12.Text + "'," +
                            "'" + textBox13.Text + "','" + textBox14.Text + "')";
            MySqlCommand command1 = dt1.CreateCommand();
            MySqlCommand command2 = dt2.CreateCommand();
            MySqlCommand command3 = dt3.CreateCommand();
            MySqlCommand command4 = dt4.CreateCommand();
            MySqlCommand command5 = dt5.CreateCommand();
            MySqlCommand command6 = dt6.CreateCommand();
            command1.CommandText = com1;
            command2.CommandText = com2;
            command3.CommandText = com3;
            command4.CommandText = com4;
            command5.CommandText = com5;
            command6.CommandText = com6;
            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            command3.ExecuteNonQuery();
            command4.ExecuteNonQuery();
            command5.ExecuteNonQuery();
            command6.ExecuteNonQuery();
            dt1.Close();
            dt2.Close();
            dt3.Close();
            dt4.Close();
            dt5.Close();
            dt6.Close();



            MessageBox.Show("Succesfully Added !!!");
            clearTextBoxes();
            showData(); 
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
       
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            string del = textBox18.Text;
            cmd = new MySqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM passlogin WHERE ID ='" + del +"' ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM nation WHERE ID ='" + del + "' ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM employee_info WHERE ID ='" + del + "' ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM personel_info WHERE ID ='" + del + "' ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM contact_info1 WHERE ID ='" + del + "' ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM contact_info2 WHERE ID ='" + del + "' ";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE FROM anomalyTable WHERE ID ='" + del + "' ";
            cmd.ExecuteNonQuery();
            con.Close();
            showData();
            clearTextBoxes();
            MessageBox.Show("Succesfully deleted !");

        }
    }
    }

