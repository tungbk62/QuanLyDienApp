using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDienApp
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source = DESKTOP-R5F9GC2\\SQLEXPRESS; Initial Catalog = QuanLyDien; Integrated Security = true";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
