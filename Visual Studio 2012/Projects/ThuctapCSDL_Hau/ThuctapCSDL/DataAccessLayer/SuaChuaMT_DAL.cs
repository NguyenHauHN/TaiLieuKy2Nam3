using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.DataAccessLayer
{
    public class SuaChuaMT_DAL
    {
        public static DataTable Select()
        {
            return DataProvider.GetList("scmt_select", null);
        }

        public static int Insert(SuaChuaMT sc)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mamay",sc.MaMay),
                new SqlParameter("@maphieu",sc.MaPhieu),
                new SqlParameter("@tinhtrangtruoc",sc.TinhTrangTruoc),
                new SqlParameter("@tinhtrangsau",sc.TinhTrangSau)
            };
            return DataProvider.Execute("scmt_insert", para);
        }

        public static int Update(SuaChuaMT sc)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mamay",sc.MaMay),
                new SqlParameter("@maphieu",sc.MaPhieu),
                new SqlParameter("@tinhtrangtruoc",sc.TinhTrangTruoc),
                new SqlParameter("@tinhtrangsau",sc.TinhTrangSau)
            };
            return DataProvider.Execute("scmt_update", para);
        }

        public static int Delete(string id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",id)
            };
            return DataProvider.Execute("scmt_delete", para);
        }
    }
}
