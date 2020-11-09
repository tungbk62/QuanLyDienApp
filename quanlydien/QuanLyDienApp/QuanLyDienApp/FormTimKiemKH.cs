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
    public partial class FormTimKiemKH : Form
    {
        KhachHangDAL khdal;
        public FormTimKiemKH()
        {
            InitializeComponent();
            khdal = new KhachHangDAL();           
        }
        public void ShowAllKhachHang()
        {
            DataTable dt = khdal.GetAllKhachHang();
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
                if (textBoxMaKH.Text != "")
                {
                    DataTable dt = khdal.TimKiemTheoMaKH(textBoxMaKH.Text);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
          }
        private void FormTimKiemKH_Activated(object sender, EventArgs e)
        {
            ShowAllKhachHang();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxHoTen.Text != "")
            {
                DataTable dt = khdal.TimKiemTheoTen(textBoxHoTen.Text);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxHoTen_TextChanged(object sender, EventArgs e)
        {
            if (textBoxHoTen.Text != "")
            {
                textBoxMaKH.Enabled = false;
                button1.Enabled = false;
                DataTable dt = khdal.TimKiemTheoTen(textBoxHoTen.Text);
                dataGridView1.DataSource = dt;
            }
            else
            {
                textBoxMaKH.Enabled = true;
                button1.Enabled = true;
                if(textBoxMaKH.Text == "")
                {
                    ShowAllKhachHang();
                }
            }
        }

        private void textBoxMaKH_TextChanged(object sender, EventArgs e)
        {
            if(textBoxMaKH.Text != "")
            {
                textBoxHoTen.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                textBoxHoTen.Enabled = true;
                button2.Enabled = true;
                if(textBoxHoTen.Text == "")
                {
                    ShowAllKhachHang();
                }
            }
        }       
    }
}
