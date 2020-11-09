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
    public partial class FormKhachHang : Form
    {
        KhachHangDAL khdal;
        public FormKhachHang()
        {
            InitializeComponent();
            khdal = new KhachHangDAL();
        }
        public void ShowAllKhachHang()
        {
            DataTable dt = khdal.GetAllKhachHang();
            dataGridView1.DataSource = dt;
        }


        private void CapNhatChiSo_Click(object sender, EventArgs e)
        {
            FormChiSoDien f = new FormChiSoDien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void QuanLyHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon f = new FormHoaDon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void TimKiemKhachHang_Click(object sender, EventArgs e)
        {
            FormTimKiemKH f = new FormTimKiemKH();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void TimKiemHoaDon_Click(object sender, EventArgs e)
        {
            FormTimKiemHD f = new FormTimKiemHD();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ThongKeDoanhSo_Click(object sender, EventArgs e)
        {
            FormThongKeDoanhSo f = new FormThongKeDoanhSo();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void ThongKeThanhToan_Click(object sender, EventArgs e)
        {
            FormThongKeThanhToan f = new FormThongKeThanhToan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void FormKhachHang_Activated(object sender, EventArgs e)
        {
            ShowAllKhachHang();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaKH.ReadOnly = true;
            int index = e.RowIndex;
            if(index >= 0)
            {
                textBoxMaKH.Text = dataGridView1.Rows[index].Cells["MaKH"].Value.ToString();
                textBoxHoTen.Text = dataGridView1.Rows[index].Cells["HoTen"].Value.ToString();
                if(dataGridView1.Rows[index].Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    comboBoxGioiTinh.SelectedIndex = 0;
                }else if(dataGridView1.Rows[index].Cells["GioiTinh"].Value.ToString() == "Nữ")
                {
                    comboBoxGioiTinh.SelectedIndex = 1;
                }
                dateTimePickerNgaySinh.Value = (DateTime)dataGridView1.Rows[index].Cells["NgaySinh"].Value;
                textBoxSoCMT.Text = dataGridView1.Rows[index].Cells["SoCMT"].Value.ToString();
                textBoxDiaChi.Text = dataGridView1.Rows[index].Cells["DiaChi"].Value.ToString();
                textBoxSDT.Text = dataGridView1.Rows[index].Cells["SDT"].Value.ToString();
                dateTimePickerNgayDangKi.Value = (DateTime)dataGridView1.Rows[index].Cells["NgayDangKy"].Value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckNhapDuLieu())
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = textBoxMaKH.Text;
                kh.HoTen = textBoxHoTen.Text;
                if (comboBoxGioiTinh.SelectedIndex == 0)
                {
                    kh.GioiTinh = comboBoxGioiTinh.Text;
                }
                else if (comboBoxGioiTinh.SelectedIndex == 1)
                {
                    kh.GioiTinh = comboBoxGioiTinh.Text;
                }
                kh.NgaySinh = (DateTime)dateTimePickerNgaySinh.Value;
                kh.SoCMT = int.Parse(textBoxSoCMT.Text);
                kh.DiaChi = textBoxDiaChi.Text;
                kh.SDT = int.Parse(textBoxSDT.Text);
                kh.NgayDangKy = (DateTime)dateTimePickerNgayDangKi.Value;
                if (khdal.ThemKhachHang(kh))
                {
                    ShowAllKhachHang();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckNhapDuLieu())
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = textBoxMaKH.Text;
                kh.HoTen = textBoxHoTen.Text;
                if (comboBoxGioiTinh.SelectedIndex == 0)
                {
                    kh.GioiTinh = comboBoxGioiTinh.Text;
                }
                else if (comboBoxGioiTinh.SelectedIndex == 1)
                {
                    kh.GioiTinh = comboBoxGioiTinh.Text;
                }
                kh.NgaySinh = (DateTime)dateTimePickerNgaySinh.Value;
                kh.SoCMT = int.Parse(textBoxSoCMT.Text);
                kh.DiaChi = textBoxDiaChi.Text;
                kh.SDT = int.Parse(textBoxSDT.Text);
                kh.NgayDangKy = (DateTime)dateTimePickerNgayDangKi.Value;
                if (khdal.SuaKhachHang(kh))
                {
                    ShowAllKhachHang();
                    textBoxMaKH.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckNhapDuLieu())
            {
                KhachHang kh = new KhachHang();
                kh.MaKH = textBoxMaKH.Text;
                kh.HoTen = textBoxHoTen.Text;
                if (comboBoxGioiTinh.SelectedIndex == 0)
                {
                    kh.GioiTinh = comboBoxGioiTinh.Text;
                }
                else if (comboBoxGioiTinh.SelectedIndex == 1)
                {
                    kh.GioiTinh = comboBoxGioiTinh.Text;
                }
                kh.NgaySinh = (DateTime)dateTimePickerNgaySinh.Value;
                kh.SoCMT = int.Parse(textBoxSoCMT.Text);
                kh.DiaChi = textBoxDiaChi.Text;
                kh.SDT = int.Parse(textBoxSDT.Text);
                kh.NgayDangKy = (DateTime)dateTimePickerNgayDangKi.Value;
                if (khdal.XoaKhachHang(kh))
                {
                    ShowAllKhachHang();
                }else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool CheckNhapDuLieu()
        {
            if (textBoxMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxMaKH.Focus();
                return false;
            }
            if (textBoxHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ và tên", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxHoTen.Focus();
                return false;
            }
            if (comboBoxGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (dateTimePickerNgaySinh == null)
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (textBoxSoCMT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số chứng minh thư", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSoCMT.Focus();
                return false;
            }
            if (textBoxDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxDiaChi.Focus();
                return false;
            }
            if (textBoxSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxSDT.Focus();
                return false;
            }
            if (dateTimePickerNgayDangKi == null)
            {
                MessageBox.Show("Bạn chưa nhập ngày đăng kí", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void FormKhachHang_Click(object sender, EventArgs e)
        {
            textBoxMaKH.ReadOnly = false;
            textBoxMaKH.Text = "";
            textBoxHoTen.Text = "";
            comboBoxGioiTinh.SelectedIndex = -1;
            textBoxSoCMT.Text = "";
            textBoxDiaChi.Text = "";
            textBoxSDT.Text = "";
        }

        private void TaiKhoanDoiMatKhau_Click(object sender, EventArgs e)
        {
            FormQLTaiKhoan f = new FormQLTaiKhoan();
            f.ShowDialog();
        }

        private void TaiKhoanDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
