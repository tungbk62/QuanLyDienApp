using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienApp
{
    class TaiKhoanDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public TaiKhoanDAL()
        {
            dc = new DataConnection();
        }
        public bool CheckTaiKhoan(string username, string pass)
        {
            string sql = "select * from TaiKhoan where TenTaiKhoan = N'"+username+"' and MatKhau = N'"+pass+"'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if(dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoiTaiKhoan(string username, string pass, string newpass)
        {
            string sql = "update TaiKhoan set MatKhau = @newpass where TenTaiKhoan = @Username and MatKhau = @Pass";
            SqlConnection con = dc.getConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@newpass", SqlDbType.NVarChar).Value = newpass;
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = pass;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
