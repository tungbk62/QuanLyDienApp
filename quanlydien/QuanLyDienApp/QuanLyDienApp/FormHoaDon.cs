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
    public partial class FormHoaDon : Form
    {
        HoaDonDAL hddal;
        ChiSo cs;
        HoaDon hd;
        public FormHoaDon()
        {
            InitializeComponent();
            hddal = new HoaDonDAL();
            cs = new ChiSo();
            hd = new HoaDon();
        }
        public void ShowAllChiSoDien()
        {
            DataTable dt = hddal.GetAllChiSoDien();
            dataGridView1.DataSource = dt;
        }
        public void ShowAllHoaDon()
        {
            DataTable dt = hddal.GetAllHoaDon();
            dataGridView2.DataSource = dt.DefaultView.ToTable(true, "MaHD", "MaKH", "MaThang", "LDTT", "Tien");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckDuLieu())
            {
                hd.MaHD = textBox1.Text;
                hd.MaKH = cs.MaKH;
                hd.MaThang = cs.MaThang;
                hd.LDTT = cs.ChiSoMoi - cs.ChiSoCu;
                hd.Tien = (hd.LDTT) * 1000;
                hd.DaNop = false;
                if (hddal.ThemHoaDon(hd))
                {
                    ShowAllHoaDon();
                    hd.MaKH = "";
                }else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn hoặc chưa chọn khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(hd.MaKH != null || hd.MaKH != "")
            {
                if (hddal.XoaHoaDon(hd))
                {
                    ShowAllHoaDon();
                    hd.MaKH = "";
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                cs.MaKH = dataGridView1.Rows[index].Cells["MaKH"].Value.ToString();
                cs.MaThang = dataGridView1.Rows[index].Cells["MaThang"].Value.ToString();
                cs.LoaiDien = dataGridView1.Rows[index].Cells["LoaiDien"].Value.ToString();
                cs.ChiSoCu = (int)dataGridView1.Rows[index].Cells["ChiSoCu"].Value;
                cs.ChiSoMoi = (int)dataGridView1.Rows[index].Cells["ChiSoMoi"].Value;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                hd.MaHD = dataGridView2.Rows[index].Cells["MaHD"].Value.ToString();
                hd.MaKH = dataGridView2.Rows[index].Cells["MaKH2"].Value.ToString();
                hd.MaThang = dataGridView2.Rows[index].Cells["MaThang2"].Value.ToString();
                hd.LDTT = (int)dataGridView2.Rows[index].Cells["LDTT"].Value;
                hd.Tien = (int)dataGridView2.Rows[index].Cells["Tien"].Value;
            }
        }
        public bool CheckDuLieu()
        {
            if(textBox1.Text == "")
            {
                return false;
            }
            if(cs.MaKH == null || cs.MaKH == "")
            {
                return false;
            }
            return true;
        }

        private void FormHoaDon_Activated(object sender, EventArgs e)
        {
            ShowAllChiSoDien();
            ShowAllHoaDon();
        }

        private void FormHoaDon_Click(object sender, EventArgs e)
        {
            hd.MaHD = "";
            hd.MaKH = "";
        }
    }
}
