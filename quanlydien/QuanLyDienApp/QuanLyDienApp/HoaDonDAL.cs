using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienApp
{
    class HoaDonDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public HoaDonDAL()
        {
            dc = new DataConnection();
        }
        public DataTable GetAllChiSoDien()
        {
            string sql = "select * from ChiSo";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetAllHoaDon()
        {
            string sql = "select * from HoaDon";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool ThemHoaDon(HoaDon hd)
        {
            string sql = "insert into HoaDon(MaHD, MaKH, MaThang, LDTT, Tien, DaNop) values (@MaHD, @MaKH, @MaThang, @LDTT, @Tien, @DaNop)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = hd.MaHD;
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = hd.MaKH;
                cmd.Parameters.Add("@MaThang", SqlDbType.NChar).Value = hd.MaThang;
                cmd.Parameters.Add("@LDTT", SqlDbType.Int).Value = hd.LDTT;
                cmd.Parameters.Add("@Tien", SqlDbType.Int).Value = hd.Tien;
                cmd.Parameters.Add("@DaNop", SqlDbType.Bit).Value = hd.DaNop;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool XoaHoaDon(HoaDon hd)
        {
            string sql = "delete HoaDon where MaHD = @MaHD";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = hd.MaHD;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable TimKiemHoaDon(string mahd)
        {
            string sql = "select * from HoaDon where HoaDon.MaHD like '%" + mahd + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable TimKiemTheoThang(string mathang)
        {
            string sql = "select * from HoaDon where HoaDon.MaThang like '%" + mathang + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Danop(HoaDon hd)
        {
            string sql = "update HoaDon set DaNop = @DaNop where MaHD = @MaHD and MaKH = @MaKH";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@DaNop", SqlDbType.Bit).Value = hd.DaNop;
                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = hd.MaHD;
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = hd.MaKH;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
