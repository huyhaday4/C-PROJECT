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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbtk.Focus();
            tbmk.Focus();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public SqlConnection Ketnoi()
        {
            return new SqlConnection("Data Source=LAPTOP-K2IHP14D;Initial Catalog=login1;Integrated Security=True");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.tbtk.TextLength == 0 || this.tbmk.TextLength == 0
            if (tbtk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản!", "Warning!!");
                tbtk.Focus();
            }       
            else if(tbmk.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Warning!!");
                tbmk.Focus();
            }
            else 
            {
                SqlConnection conn = Ketnoi();
                String sql = "Select * from Table_1 where Taikhoan = N'" + tbtk.Text + "' and Matkhau= N'" + tbmk.Text + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                {
                    if (dr.Read() == true)
                    {
                        conn.Close();
                        MessageBox.Show("Đăng nhập thành công xin " +
                            "chờ trong giây lát....!","Thông báo");
                        hidesg();
                    }
                    else
                    {
                        conn.Close();
                        MessageBox.Show("Đăng nhập thất bại,xin thử lại!", "Warning");
                        this.tbtk.Clear();
                        this.tbtk.Focus();
                        this.tbmk.Clear();
                    }
                }
            }
        }
        private void hidesg()
        {
            prg1 a = new prg1();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void btrg_Click(object sender, EventArgs e)
        {
            btdk f = new btdk();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
