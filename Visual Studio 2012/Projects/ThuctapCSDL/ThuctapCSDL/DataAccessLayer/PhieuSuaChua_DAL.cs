using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.DataAccessLayer
{
    public class PhieuSuaChua_DAL
    {
        public static DataTable SelectJoin(string maphieu)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",maphieu)
            };
            return DataProvider.GetList("psc_selectJoin", para);
        }

        public static DataTable Select()
        {
            return DataProvider.GetList("psc_select", null);
        }

        public static int Insert(PhieuSuaChua psc)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",psc.MaPhieu),
                new SqlParameter("@noidung",psc.NoiDung),
                new SqlParameter("@ngaysua",psc.NgaySua),
                new SqlParameter("@macanbo",psc.MaCanBo)
            };
            return DataProvider.Execute("psc_insert", para);
        }

        public static int Update(PhieuSuaChua psc)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",psc.MaPhieu),
                new SqlParameter("@noidung",psc.NoiDung),
                new SqlParameter("@ngaysua",psc.NgaySua),
                new SqlParameter("@macanbo",psc.MaCanBo)
            };
            return DataProvider.Execute("psc_update", para);
        }

        public static int Delete(string id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",id)
            };
            return DataProvider.Execute("psc_delete", para);
        }

        public static DataTable Search(string keyword)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@keyword",keyword)
            };
            return DataProvider.GetList("psc_search", para);
        }
    }
}
