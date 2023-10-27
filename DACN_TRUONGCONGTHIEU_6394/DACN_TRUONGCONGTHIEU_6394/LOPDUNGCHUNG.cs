using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DACN_TRUONGCONGTHIEU_6394
{
    class LOPDUNGCHUNG
    {
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Documents\CS462\DACN_TRUONGCONGTHIEU_6394\DACN_TRUONGCONGTHIEU_6394\DACN_TRUONGCONGTHIEU_6394\DACN_TRUONGCONGTHIEU.mdf;Integrated Security=True";
        }
        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            int kq = comm.ExecuteNonQuery();
            conn.Close();
            return kq;
        }
        public object Scalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            object kq = comm.ExecuteScalar();
            conn.Close();
            return kq;
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        
    }
}
