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
    public partial class FormChiSoDien : Form
    {
        ChiSoDienDAL csdal;
        public FormChiSoDien()
        {
            InitializeComponent();
            csdal = new ChiSoDienDAL();
        }
        public void ShowAllChiSo()
        {
            DataTable dt = csdal.GetAllChiSoDien();
            dataGridView1.DataSource = dt;
        }
        public bool CheckNhapDuLieu()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã khách hàng hoặc mã khách hàng không tồn tại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                return false;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã tháng hoặc mã tháng không tồn tại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Focus();
                return false;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chỉ số cũ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox3.Focus();
                return false;
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập chỉ số mới", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox4.Focus();
                return false;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn loại điện", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckNhapDuLieu())
            {
                ChiSo cs = new ChiSo();
                cs.MaKH = textBox1.Text;
                cs.MaThang = textBox2.Text;
                cs.ChiSoCu = int.Parse(textBox3.Text);
                cs.ChiSoMoi = int.Parse(textBox4.Text);
                if (comboBox1.SelectedIndex == 0)
                {
                    cs.LoaiDien = comboBox1.Text;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    cs.LoaiDien = comboBox1.Text;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    cs.LoaiDien = comboBox1.Text;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    cs.LoaiDien = comboBox1.Text;
                }
                if (csdal.ThemChiSoDien(cs))
                {
                    ShowAllChiSo();
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
                ChiSo cs = new ChiSo();
                cs.MaKH = textBox1.Text;
                cs.MaThang = textBox2.Text;
                cs.ChiSoCu = int.Parse(textBox3.Text);
                cs.ChiSoMoi = int.Parse(textBox4.Text);
                if (comboBox1.SelectedIndex == 0)
                {
                    cs.LoaiDien = comboBox1.Text;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    cs.LoaiDien = comboBox1.Text;
                }else if(comboBox1.SelectedIndex == 2)
                {
                    cs.LoaiDien = comboBox1.Text;
                }else if(comboBox1.SelectedIndex == 3)
                {
                    cs.LoaiDien = comboBox1.Text;
                }
                if (csdal.SuaChiSoDien(cs))
                {
                    ShowAllChiSo();
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
                ChiSo cs = new ChiSo();
                cs.MaKH = textBox1.Text;
                cs.MaThang = textBox2.Text;
                cs.ChiSoCu = int.Parse(textBox3.Text);
                cs.ChiSoMoi = int.Parse(textBox4.Text);
                cs.LoaiDien = comboBox1.Text;
                if (csdal.XoaChiSoDien(cs))
                {
                    ShowAllChiSo();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            int index = e.RowIndex;
            if (index >= 0)
            {
                textBox1.Text = dataGridView1.Rows[index].Cells["MaKH"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[index].Cells["MaThang"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[index].Cells["ChiSoCu"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[index].Cells["ChiSoMoi"].Value.ToString();
                if(dataGridView1.Rows[index].Cells["LoaiDien"].Value.ToString() == "Sinh hoạt")
                {
                    comboBox1.SelectedIndex = 0;
                }else if(dataGridView1.Rows[index].Cells["LoaiDien"].Value.ToString() == "Kinh doanh")
                {
                    comboBox1.SelectedIndex = 1;
                }else if(dataGridView1.Rows[index].Cells["LoaiDien"].Value.ToString() == "Sản xuất")
                {
                    comboBox1.SelectedIndex = 2;
                }else if(dataGridView1.Rows[index].Cells["LoaiDien"].Value.ToString() == "Hành chính, sự nghiệp")
                {
                    comboBox1.SelectedIndex = 3;
                }
            }
        }

        private void FormChiSoDien_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void FormChiSoDien_Activated(object sender, EventArgs e)
        {
            ShowAllChiSo();
        }
    }
}
