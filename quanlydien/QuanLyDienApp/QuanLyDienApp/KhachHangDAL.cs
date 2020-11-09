using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienApp
{
    class KhachHangDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public KhachHangDAL()
        {
            dc = new DataConnection();
        }
        public DataTable GetAllKhachHang()
        {
            string sql = "select * from KhachHang";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool ThemKhachHang(KhachHang kh)
        {
            string sql = "insert into KhachHang(MaKH, HoTen, GioiTinh, NgaySinh, SoCMT, DiaChi, SDT, NgayDangKy) values(@MaKH, @HoTen, @GioiTinh, @NgaySinh, @SoCMT, @DiaChi, @SDT, @NgayDangKy)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = kh.MaKH;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = kh.HoTen;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = kh.GioiTinh;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = kh.NgaySinh;
                cmd.Parameters.Add("@SoCMT", SqlDbType.Int).Value = kh.SoCMT;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = kh.SDT;
                cmd.Parameters.Add("@NgayDangKy", SqlDbType.Date).Value = kh.NgayDangKy;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool SuaKhachHang(KhachHang kh)
        {
            string sql = "update KhachHang set MaKH = @MaKH, HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, SoCMT = @SoCMT, DiaChi = @DiaChi, SDT = @SDT, NgayDangKy = @NgayDangKy where MaKH = @MaKH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = kh.MaKH;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = kh.HoTen;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = kh.GioiTinh;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = kh.NgaySinh;
                cmd.Parameters.Add("@SoCMT", SqlDbType.Int).Value = kh.SoCMT;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = kh.DiaChi;
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = kh.SDT;
                cmd.Parameters.Add("@NgayDangKy", SqlDbType.Date).Value = kh.NgayDangKy;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool XoaKhachHang(KhachHang kh)
        {
            string sql = "delete KhachHang where MaKH = @MaKH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = kh.MaKH;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable TimKiemTheoMaKH(string makh)
        {
            string sql = "select * from KhachHang where KhachHang.MaKH like '%" + makh +"%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable TimKiemTheoTen(String tenkh)
        {
            string sql = "select * from KhachHang where KhachHang.HoTen like '%" + tenkh +"%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool CheckUnicode(string input)
        {
            const int MaxAnsiCode = 255;
            return input.Any(c => c > MaxAnsiCode);
        }
    }
}
