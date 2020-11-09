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
    public partial class FormTimKiemHD : Form
    {
        HoaDonDAL hddal;
        public FormTimKiemHD()
        {
            InitializeComponent();
            hddal = new HoaDonDAL();
        }
        public void ShowAllHoaDon()
        {
            DataTable dt = hddal.GetAllHoaDon();
            dataGridView1.DataSource = dt.DefaultView.ToTable(true, "MaHD", "MaKH", "MaThang", "LDTT", "Tien");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text != "")
            {
                DataTable dt = hddal.TimKiemHoaDon(textBoxMaHD.Text);
                dataGridView1.DataSource = dt.DefaultView.ToTable(true, "MaHD", "MaKH", "MaThang", "LDTT", "Tien");
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormTimKiemHD_Activated(object sender, EventArgs e)
        {
            ShowAllHoaDon();
        }

        private void textBoxMaHD_TextChanged(object sender, EventArgs e)
        {
            if(textBoxMaHD.Text == "")
            {
                ShowAllHoaDon();
            }
        }
    }
}
