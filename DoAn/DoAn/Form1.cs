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
using System.Data;

namespace DoAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-PGNO1ME\DANGTRUONG1;Initial Catalog=DoAn;User ID=sa ; Password=123456");
            try {
                conn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select * from DANGNHAP where TaiKhoan ='" + tk + "'and MatKhau ='" + mk + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader db = cmd.ExecuteReader();
                if (db.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.Hide();
                    //FrmMain frmMain = new FrmMain();
                    //frmMain.ShowDialog();
                }
                else
                    MessageBox.Show("Đăng nhập thất bại","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi conn");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không ?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
            {
                Application.Exit();
            }    
        }
    }
}
