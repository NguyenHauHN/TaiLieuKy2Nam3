using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.DataAccessLayer
{
    public class SuaChuaTB_DAL
    {
        public static DataTable Select()
        {
            return DataProvider.GetList("sctb_select", null);
        }

        public static int Insert(SuaChuaTB sc)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matb",sc.MaTB),
                new SqlParameter("@maphieu",sc.MaPhieu),
                new SqlParameter("@tinhtrangtruoc",sc.TinhTrangTruoc),
                new SqlParameter("@tinhtrangsau",sc.TinhTrangSau)
            };
            return DataProvider.Execute("sctb_insert", para);
        }

        public static int Update(SuaChuaTB sc)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matb",sc.MaTB),
                new SqlParameter("@maphieu",sc.MaPhieu),
                new SqlParameter("@tinhtrangtruoc",sc.TinhTrangTruoc),
                new SqlParameter("@tinhtrangsau",sc.TinhTrangSau)
            };
            return DataProvider.Execute("sctb_update", para);
        }

        public static int Delete(string id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",id)
            };
            return DataProvider.Execute("sctb_delete", para);
        }
    }
}
