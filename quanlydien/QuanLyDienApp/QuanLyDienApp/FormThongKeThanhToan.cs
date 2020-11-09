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
    public partial class FormThongKeThanhToan : Form
    {
        HoaDonDAL hddal;
        HoaDon hd;
        public FormThongKeThanhToan()
        {
            InitializeComponent();
            hddal = new HoaDonDAL();
            hd = new HoaDon();
            hd.MaKH = "";
        }
        public void ShowAllHoaDon()
        {
            DataTable dt = hddal.GetAllHoaDon();
            dataGridView1.DataSource = dt.DefaultView.ToTable(true, "MaHD", "MaKH", "MaThang", "Tien", "DaNop");
        }

        private void FormThongKeThanhToan_Activated(object sender, EventArgs e)
        {
            ShowAllHoaDon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxMaThang.Text != "")
            {
                DataTable dt = hddal.TimKiemTheoThang(textBoxMaThang.Text);
                dataGridView1.DataSource = dt.DefaultView.ToTable(true, "MaHD", "MaKH", "MaThang", "Tien", "DaNop");
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã tháng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hd.MaKH != "")
            {
                hd.DaNop = true;
                hddal.Danop(hd);
                ShowAllHoaDon();
                hd.MaHD = "";
                hd.MaKH = "";
                hd.MaThang = "";
            }else
            {
                MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                hd.MaHD = dataGridView1.Rows[index].Cells["MaHD"].Value.ToString();
                hd.MaKH = dataGridView1.Rows[index].Cells["MaKH"].Value.ToString();
                hd.MaThang = dataGridView1.Rows[index].Cells["MaThang"].Value.ToString();
                hd.Tien = (int)dataGridView1.Rows[index].Cells["Tien"].Value;
                hd.DaNop = (bool)dataGridView1.Rows[index].Cells["DaNop"].Value;
            }
        }

        private void FormThongKeThanhToan_Click(object sender, EventArgs e)
        {
            hd.MaHD = "";
            hd.MaKH = "";
            hd.MaThang = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hd.MaKH != "")
            {
                hd.DaNop = false;
                hddal.Danop(hd);
                ShowAllHoaDon();
                hd.MaHD = "";
                hd.MaKH = "";
                hd.MaThang = "";
            }else
            {
                MessageBox.Show("Bạn chưa chọn khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBoxMaThang_TextChanged(object sender, EventArgs e)
        {
            if(textBoxMaThang.Text == "")
            {
                ShowAllHoaDon();
            }
        }
    }
}
