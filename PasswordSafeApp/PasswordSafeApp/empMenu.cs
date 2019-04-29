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
    public partial class empMenu : Form
    {
        
        MySqlConnection con;
        MySqlCommand cmd;
        public empMenu()
        {
         //   showData();
            InitializeComponent();
           // label1.Text = Güncel_date.ToString();
            label1.Text = DateTime.Now.ToString();
            //  timer1.Interval = 1000;
            con = new MySqlConnection("Server=localhost;Database=ps;user=root;Pwd=hype;SslMode=none");


        }
        public void showData()
        {
            con.Open();

            MySqlDataAdapter my1 = new MySqlDataAdapter("SELECT * FROM anomalyTable WHERE NOT domain='admin' ", con);
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
            Environment.Exit(0);
            LoginPage l1 = new LoginPage();
            this.Hide();
            l1.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void EmpMenu_Load(object sender, EventArgs e)
        {
            //timer1.Interval = 10000;

            //timer1.Enabled = true;
            //timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           // label1.Text = DateTime.Now.ToString();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            showData();
            //showData();
        }
    }
}
