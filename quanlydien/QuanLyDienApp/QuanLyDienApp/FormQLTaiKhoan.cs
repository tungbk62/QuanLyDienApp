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
    public partial class FormQLTaiKhoan : Form
    {
        TaiKhoanDAL tkdal;
        public FormQLTaiKhoan()
        {
            InitializeComponent();
            tkdal = new TaiKhoanDAL();
        }
        public bool CheckNhapDuLieu()
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return false;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Focus();
                return false;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu mới", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Focus();
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckNhapDuLieu())
            {

                if (string.Compare(textBox3.Text, textBox4.Text, false) != 0)
                {
                    MessageBox.Show("Thay đổi mật khẩu không thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (tkdal.DoiTaiKhoan(textBox1.Text, textBox2.Text, textBox3.Text))
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi mật khẩu không thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                 }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
