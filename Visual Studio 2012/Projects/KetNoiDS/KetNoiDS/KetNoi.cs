using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KetNoiDS
{
    class KetNoi
    {
        SqlConnection _conDatabase = new SqlConnection();
        string _connectionString = "Data Source=DESKTOP-V2HABOD;Initial Catalog=Quan_Ly_Thiet_Bi_Phong_may;Integrated Security=True";
        public DataTable datatable = new DataTable();
        public KetNoi()
        {
        }
        public bool Connect()
        {
            _conDatabase.ConnectionString = _connectionString;
            _conDatabase.Open();
            if (_conDatabase.State == ConnectionState.Open)
            {
                SqlCommand _sqlCommand = new SqlCommand();
                try
                {
                    //_sqlCommand.CommandText = "select * from MayTinh";
                    _sqlCommand.CommandText = "ThemMayTinh";
                    _sqlCommand.CommandType = CommandType.StoredProcedure;
                    // truyen tham so 
                    _sqlCommand.Parameters.Add(new SqlParameter("@mamay", "07"));
                    _sqlCommand.Parameters.Add(new SqlParameter("@tenmay", "Dell"));
                    _sqlCommand.Parameters.Add(new SqlParameter("@ngaynhap", "07/11/2016"));

                    //_sqlCommand.CommandType = CommandType.Text;
                    _sqlCommand.Connection = _conDatabase;
                    //IDataReader reader = _sqlCommand.ExecuteReader();                    
                    //datatable.Load(reader);
                    _sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch (Exception e)
                {

                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
