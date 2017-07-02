using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.DataAccessLayer
{
    public class PhongMay_DAL
    {
        public static DataTable Select()
        {
            return DataProvider.GetList("pm_select", null);
        }

        public static int Insert(PhongMay pm)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphong",pm.MaPhong),
                new SqlParameter("@tenphong",pm.TenPhong)
            };
            return DataProvider.Execute("pm_insert", para);
        }

        public static int Update(PhongMay pm)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphong",pm.MaPhong),
                new SqlParameter("@tenphong",pm.TenPhong)
            };
            return DataProvider.Execute("pm_update", para);
        }

        public static int Delete(string id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphong",id)
            };
            return DataProvider.Execute("pm_delete", para);
        }
    }
}
