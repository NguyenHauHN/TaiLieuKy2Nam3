using System.Data;
using System.Data.SqlClient;

namespace ThuctapCSDL.DataAccessLayer
{
    class DataProvider
    {
        public static SqlConnection conn;
        private static SqlTransaction transaction;

        public static SqlConnection Connect()
        {
            try
            {
                string sql = @"Data Source=DESKTOP-V2HABOD;Initial Catalog=QLPhongMay;Integrated Security=True";
                SqlConnection con = new SqlConnection(sql);
                if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
                    con.Open();
                return con;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public static DataTable GetList(string proc, SqlParameter[] para)
        {
            try
            {
                conn = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (SqlException)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return null;
            }
        }

        public static int Execute(string proc, SqlParameter[] para)
        {
            try
            {
                conn = Connect();
                transaction = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;
                if (para != null)
                    cmd.Parameters.AddRange(para);
                int res = cmd.ExecuteNonQuery();
                transaction.Commit();
                
                return res;
            }
            catch (SqlException)
            {
                transaction.Rollback();
                return 0;
            }
            conn.Close();
        }

        public static int ExecuteCheck(string proc, SqlParameter[] para)
        {
            try
            {
                conn = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);
                int res = (int)cmd.ExecuteScalar();
                conn.Close();
                return res;
            }
            catch (SqlException)
            {
                return -1;
            }
        }

        public static string ExecuteGet(string proc, SqlParameter[] para)
        {
            try
            {
                conn = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);
                string res = cmd.ExecuteScalar().ToString();
                conn.Close();
                return res;
            }
            catch (SqlException)
            {
                return "";
            }
        }
    }
}
