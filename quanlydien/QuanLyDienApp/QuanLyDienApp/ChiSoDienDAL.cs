using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienApp
{
    class ChiSoDienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public ChiSoDienDAL()
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
        public bool ThemChiSoDien(ChiSo cs)
        {
            string sql = "insert into ChiSo(MaKH, MaThang, LoaiDien, ChiSoCu, ChiSoMoi) values(@MaKH, @MaThang, @LoaiDien, @ChiSoCu, @ChiSoMoi)";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = cs.MaKH;
                cmd.Parameters.Add("@MaThang", SqlDbType.NChar).Value = cs.MaThang;
                cmd.Parameters.Add("@LoaiDien", SqlDbType.NVarChar).Value = cs.LoaiDien;
                cmd.Parameters.Add("@ChiSoCu", SqlDbType.Int).Value = cs.ChiSoCu;
                cmd.Parameters.Add("@ChiSoMoi", SqlDbType.Int).Value = cs.ChiSoMoi;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool SuaChiSoDien(ChiSo cs)
        {
            string sql = "update ChiSo set MaKH = @MaKH, MaThang = @MaThang, LoaiDien = @LoaiDien, ChiSoCu = @ChiSoCu, ChiSoMoi= @ChiSoMoi where  MaKH = @MaKH and MaThang = @MaThang";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = cs.MaKH;
                cmd.Parameters.Add("@MaThang", SqlDbType.NChar).Value = cs.MaThang;
                cmd.Parameters.Add("@LoaiDien", SqlDbType.NVarChar).Value = cs.LoaiDien;
                cmd.Parameters.Add("@ChiSoCu", SqlDbType.Int).Value = cs.ChiSoCu;
                cmd.Parameters.Add("@ChiSoMoi", SqlDbType.Int).Value = cs.ChiSoMoi;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool XoaChiSoDien(ChiSo cs)
        {
            string sql = "delete ChiSo where MaKH = @MaKH and MaThang = @MaThang";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = cs.MaKH;
                cmd.Parameters.Add("@MaThang", SqlDbType.NChar).Value = cs.MaThang;
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
