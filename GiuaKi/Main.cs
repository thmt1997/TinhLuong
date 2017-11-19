using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GiuaKi
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Cal()
        {
            int a = int.Parse(txtLuong.Text);
            int b = Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(Convert.ToInt32(txtNhap.Text) - 1)].Cells["HeSo"].Value.ToString());
            //double b = Convert.ToDouble(dataGridView1.Rows[Convert.ToInt32(txtNhap.Text)].Cells["HeSo"].Value.ToString());
            Calculation ca = new Calculation(a, b);
            int re = ca.Execute();
            label3.Text = re.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection comn1 = new SqlConnection(@"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=Tester;Integrated Security=True");
                comn1.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter("Select * From NhanVien where ID like '%" + txtNhap.Text + "%' ", comn1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                dataGridView1.DataSource = dt1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }
     
        
        public void updateTable()
        {
            try
            {
                SqlConnection comn1 = new SqlConnection(@"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=Tester;Integrated Security=True");
                comn1.Open();
                SqlDataAdapter sda1 = new SqlDataAdapter("Select * From NhanVien", comn1);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                comn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection comn1 = new SqlConnection(@"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=Tester;Integrated Security=True");
                comn1.Open();
                updateTable();
                this.Cal();
                //int heso = Convert.ToInt32(dataGridView1.Rows[Convert.ToInt32(Convert.ToInt32(txtNhap.Text)-1)].Cells["HeSo"].Value.ToString());
                //label3.Text = (heso * Convert.ToInt32(txtLuong.Text)).ToString();
                SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET Luong ='" + label3.Text + "' WHERE ID='" + txtNhap.Text + "'", comn1);
                cmd.ExecuteNonQuery();
                comn1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            updateTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
