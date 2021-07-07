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
    public partial class btdk : Form
    {
        public btdk()
        {
            InitializeComponent();
        }
  
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        public SqlConnection Ketnoi()
        {
            return new SqlConnection("Data Source=LAPTOP-K2IHP14D;Initial Catalog=login1;Integrated Security=True");
        }

        private void dkus_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //NguoiDung nd = new NguoiDung(dkus.Text, dkpw.Text, dkname.Text, dksdt.Text, dkemail.Text, dkadd.Text);
            //this.dkus.TextLength == 0 || this.dkpw.TextLength == 0 || this.dkname.TextLength == 0 || this.dksdt.TextLength == 0 || this.dkemail.TextLength == 0 || this.dkadd.TextLength == 0 || this.dkpw2.TextLength == 0
            if (dkus.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập username!", "Thông Báo");
                dkus.Focus();
            }
            else if (dkpw.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Password!", "Thông báo");
                dkpw.Focus();
            }
            else if(dkpw2.Text == "")
            {
                MessageBox.Show("Bạn chưa xác nhận lại mật khẩu", "Thông báo");
                dkpw2.Focus();
            }
            else if (dkname.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Họ Tên", "Thông báo");
                dkname.Focus();
            }
            else if (dksdt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Số Điện Thoại", "Thông báo");
                dksdt.Focus();
            }
            else if (dkemail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Email", "Thông báo");
                dkemail.Focus();
            }
            else if (dkadd.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Địa chỉ", "Thông báo");
                dkadd.Focus();
            }
            else if (dkpw2.Text != dkpw.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận phải giống với mật khẩu", "Thông báo");
                dkpw2.Focus();
                dkpw2.SelectAll();
            }           
            else
            {
                dkus.Focus();
                //NguoiDung nd = new NguoiDung(dkus.Text, dkpw.Text, dkname.Text, dksdt.Text, dkemail.Text, dkadd.Text);
                //dkus.Focus();
                //SqlConnection con = Ketnoi();
                //string sql = " INSERT INTO Table_1 VALUES ('" + dkus.Text + "','" + dkpw.Text + "',N'" + dkname.Text + "','" + dksdt.Text + "','" + dkemail.Text + "',N'" + dkadd.Text + "')";
                //NguoiDung nd = new NguoiDung(dkus.Text, dkpw.Text, dkname.Text, dksdt.Text, dkemail.Text, dkadd.Text);
                //if (nd.Kiemtramk() == false)
                //{
                   // MessageBox.Show("Mật khẩu phải có đủ 7 ký tự bao gồm số & chữ!", "Thông báo");
                    //dkpw.Focus();
                    //dkpw.SelectAll();
                //}
                //else
                //{
                    SqlConnection con = Ketnoi();
                    con.Open();
                    string sql = " INSERT INTO Table_1 VALUES ('" + dkus.Text + "','" + dkpw.Text + "',N'" + dkname.Text + "','" + dksdt.Text + "','" + dkemail.Text + "',N'" + dkadd.Text + "')";
                    MessageBox.Show("Đăng kí tài khoản thành công!!", "Thông báo");
                    //con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    ClearTextBox();
                    anct();
                    //MessageBox.Show("Mật khẩu phải có đủ 7 ký tự bao gồm số & chữ!", "Thông báo");
                    //dkpw.Focus();
                    //dkpw.SelectAll();
                //}
                //con.Open();
                //SqlCommand cmd = new SqlCommand(sql, con);
                //cmd.ExecuteNonQuery();
                //con.Close();
                //ClearTextBox();
                //anct();               
            }
            
            
        }
        private void anct()
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void ClearTextBox()
        {
            dkus.Clear();
            dkpw.Clear();
            dkname.Clear();
            dksdt.Clear();
            dkemail.Clear();
            dkadd.Clear();
        }

        private void dkpw_TextChanged(object sender, EventArgs e)
        {
           
                
            
        }

        private void dkpw2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
