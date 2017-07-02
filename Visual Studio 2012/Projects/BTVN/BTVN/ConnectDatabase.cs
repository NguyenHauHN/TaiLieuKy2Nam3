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
    public class ConnectDatabase
    {
        SqlConnection _connectDatabase = new SqlConnection();
        SqlCommand _sqlCommand = new SqlCommand();
        SqlDataAdapter adapt;  
        IDataReader reader;
        public bool Connect()
        {
            string connetionString = null;

            connetionString = "Data Source=DESKTOP-V2HABOD;Initial Catalog=Quan_Ly_Nhan_Vien;Integrated Security=True";
            _connectDatabase = new SqlConnection(connetionString);
            try
            {
                _connectDatabase.Open();
                return true;
                
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable getData()
        {
            DataTable datatable = new DataTable();
            if (this.Connect() == true)
            {
                try
                {
                    adapt = new SqlDataAdapter("GetListEmployee", _connectDatabase);
                    adapt.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);
                    datatable = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không lấy được dữ liệu từ database!");
                }

            }
            else
            {
                MessageBox.Show("Không kết nối được đến database!");
            }

            return datatable;
        }
        public void insertData(NhanVien _nhanvien)
        {
            try
            {

                _sqlCommand.CommandText = "AddNewEmployee";
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.Parameters.Add(new SqlParameter("@code", _nhanvien.code));
                _sqlCommand.Parameters.Add(new SqlParameter("@name", _nhanvien.name));
                _sqlCommand.Parameters.Add(new SqlParameter("@gender", _nhanvien.gender));
                _sqlCommand.Parameters.Add(new SqlParameter("@department", _nhanvien.department));
                _sqlCommand.Parameters.Add(new SqlParameter("@address", _nhanvien.address));

                _sqlCommand.Connection = _connectDatabase;
                _sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thêm dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình thêm dữ liệu vào database! Vui lòng thử lại.");

            }
        }
        public void updateData(NhanVien _nhanvien)
        {
            try
            {
                _sqlCommand.CommandText = "UpdateEmployee";
                _sqlCommand.Parameters.Add(new SqlParameter("@code", _nhanvien.code));
                _sqlCommand.Parameters.Add(new SqlParameter("@name", _nhanvien.name));
                _sqlCommand.Parameters.Add(new SqlParameter("@gender", _nhanvien.gender));
                _sqlCommand.Parameters.Add(new SqlParameter("@department", _nhanvien.department));
                _sqlCommand.Parameters.Add(new SqlParameter("@address", _nhanvien.address));

                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.Connection = _connectDatabase;
                _sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Sửa dữ liệu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình sửa dữ liệu! Vui lòng thử lại.");

            }
        }
        public void deleteData(NhanVien _nhanvien)
        {
            try
            {
                _sqlCommand.CommandText = "DeleteEmployee";
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.Parameters.Add(new SqlParameter("@code", _nhanvien.code));
                _sqlCommand.Connection = _connectDatabase;
                _sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Đã xóa nhân viên!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi trong quá trình xóa dữ liệu! Vui lòng thử lại.");

            }
        }
 

    }
}
