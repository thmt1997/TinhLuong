using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GiuaKi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection comn = new SqlConnection(@"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=Tester;Integrated Security=True");
            SqlDataAdapter sda =new SqlDataAdapter("Select count(*) From DangNhap where ID='"+txtID.Text + "'and Pass ='"+txtPass.Text+"'",comn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                this.Hide();
                Main ss = new Main();
                Form1 s = new Form1();
                ss.Show();
                s.Close();
             }
            else
            {
                MessageBox.Show("Sai ID hoặc Password");
            }
        }
     }
 }

