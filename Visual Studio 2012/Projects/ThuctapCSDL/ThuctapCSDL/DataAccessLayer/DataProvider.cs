using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ThuctapCSDL.DataAccessLayer
{
    class DataProvider
    {
        public static SqlConnection conn;
        public static SqlTransaction transaction;
        public class GenericList<T>
        {
            void Add(T input) { }
        }
        public static SqlConnection Connect()
        {
            try
            {
                string sql = @"Data Source=DESKTOP-V2HABOD;Initial Catalog=TTCSDL;Integrated Security=True;";
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
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                transaction = conn.BeginTransaction();
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = transaction;
                if (para != null)
                    cmd.Parameters.AddRange(para);
                int res = cmd.ExecuteNonQuery();
                transaction.Commit();
                conn.Close();
                return res;
            }
            catch (SqlException)
            {
                transaction.Rollback();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 0;
            }
        }

        public static int ExecuteCmd(string cmdQuery)
        {
            try
            {
                conn = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = cmdQuery;
                cmd.CommandType = CommandType.Text;
                int res = cmd.ExecuteNonQuery();
                conn.Close();
                return res;
            }
            catch (SqlException)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                return 0;
            }
        }

        public static string ExecuteResult(string proc, SqlParameter[] para)
        {
            string res = " ";
            try
            {
                conn = Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = proc;
                cmd.CommandType = CommandType.StoredProcedure;
                if (para != null)
                    cmd.Parameters.AddRange(para);
                if (cmd.ExecuteScalar() != null)
                {
                    res = cmd.ExecuteScalar().ToString();
                }
                conn.Close();
            }
            catch (SqlException)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                
            }
            return res;
        }
    }
}
