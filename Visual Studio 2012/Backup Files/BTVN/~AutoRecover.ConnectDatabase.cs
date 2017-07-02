using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BTVN
{
    class ConnectDatabase
    {
        SqlConnection _connectDatabase = new SqlConnection();
        public DataTable datatable = new DataTable();
        public bool Connect()
        {
            string connetionString = null;
            
            connetionString = "Data Source=DESKTOP-V2HABOD;Initial Catalog=Quan_Ly_Nhan_Vien;Integrated Security=True";
            _connectDatabase = new SqlConnection(connetionString);
            try
            {
                _connectDatabase.Open();
                return true;
                //cnn.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void getData() 
        {
            string selectQuery = "select * from NhanVien";
            SqlCommand _sqlCommand = new SqlCommand();
            _sqlCommand.CommandText = selectQuery;
            _sqlCommand.CommandType = CommandType.Text;
            _sqlCommand.Connection = _connectDatabase;
            DataReader reader = _sqlCommand.ExecuteReader();
            List<NhanVien> customers = reader.AutoMap<NhanVien>()
                                   .ToList();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    nhanvien.Add(reader.GetValue(i));
                }
                
            }
            datatable.Load(reader);
            
        }
        public void insertData()
        {

        }
    }
}
