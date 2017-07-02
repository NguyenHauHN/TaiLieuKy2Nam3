using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.DataAccessLayer
{
    public class LinhKienMT_DAL
    {
        public static DataTable Select()
        {
            return DataProvider.GetList("lk_select", null);
        }

        public static int Insert(LinhKienMT mt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@malk",mt.MaLinhKien),
                new SqlParameter("@tenlk",mt.TenLinhKien),
                new SqlParameter("@tinhtrang",mt.TinhTrang),
                new SqlParameter("@mamay",mt.MaMay)
            };
            return DataProvider.Execute("lk_insert", para);
        }

        public static int Update(LinhKienMT mt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@malk",mt.MaLinhKien),
                new SqlParameter("@tenlk",mt.TenLinhKien),
                new SqlParameter("@tinhtrang",mt.TinhTrang),
                new SqlParameter("@mamay",mt.MaMay)
            };
            return DataProvider.Execute("lk_update", para);
        }

        public static int Delete(string id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@malk",id)
            };
            return DataProvider.Execute("lk_delete", para);
        }

        public static DataTable Search(string keyword)
        {
            SqlParameter[] para = new SqlParameter[] 
            { new SqlParameter("@keyword", keyword) };
            return DataProvider.GetList("lk_search", para);
        }
    }
}

