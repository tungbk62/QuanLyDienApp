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
    public partial class FormThongKeDoanhSo : Form
    {
        HoaDonDAL hddal;
        public FormThongKeDoanhSo()
        {
            InitializeComponent();
            hddal = new HoaDonDAL();
        }
        public void ShowAllHoaDon()
        {
            DataTable dt = hddal.GetAllHoaDon();
            dataGridView1.DataSource = dt.DefaultView.ToTable(true, "MaKH", "MaThang", "Tien");
        }

        private void FormThongKeDoanhSo_Activated(object sender, EventArgs e)
        {
            ShowAllHoaDon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                DataTable dt = hddal.TimKiemTheoThang(textBox1.Text);
                dataGridView1.DataSource = dt.DefaultView.ToTable(true, "MaKH", "MaThang", "Tien");
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã tháng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                ShowAllHoaDon();
            }
        }
    }
}
