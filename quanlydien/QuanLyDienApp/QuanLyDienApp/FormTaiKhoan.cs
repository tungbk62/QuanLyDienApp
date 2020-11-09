using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDienApp
{
    public partial class FormTaiKhoan : Form
    {
        TaiKhoanDAL tkdal;
        public FormTaiKhoan()
        {
            InitializeComponent();
            tkdal = new TaiKhoanDAL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa điền tên tài khoản", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Bạn chưa điền mật khẩu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                string user = textBox1.Text;
                string pass = textBox2.Text;
                if (tkdal.CheckTaiKhoan(user, pass))
                {
                    FormKhachHang f = new FormKhachHang();
                    this.Hide();
                    f.ShowDialog();
                    textBox2.Text = null;
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo!", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
