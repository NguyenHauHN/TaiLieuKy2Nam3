using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;
namespace ThuctapCSDL.DataAccessLayer
{
    public class ThanhLiTB_DAL
    {
        public static DataTable Select()
        {
            return DataProvider.GetList("phieuTL_select", null);
        }

        public static int Insert(ThanhLiTB tl)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",tl.Maphieutl),
                new SqlParameter("@ngaytl",tl.Ngaytl),
                new SqlParameter("@sotien",tl.Sotientl),
                new SqlParameter("@macb",tl.Macanbo),
                new SqlParameter("@mamay",tl.Mamay),
                new SqlParameter("@matb",tl.Matb),
            };
            return DataProvider.Execute("phieuTL_insert", para);
        }

        public static int Update(ThanhLiTB tl)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",tl.Maphieutl),
                new SqlParameter("@ngaytl",tl.Ngaytl),
                new SqlParameter("@sotien",tl.Sotientl),
                new SqlParameter("@macb",tl.Macanbo),
                new SqlParameter("@mamay",tl.Mamay),
                new SqlParameter("@matb",tl.Matb),
            };
            return DataProvider.Execute("phieuTL_update", para);
        }

        public static int Delete(string tl)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",tl)
            };
            return DataProvider.Execute("phieuTL_delete", para);
        }

        public static DataTable Search(string keyword)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@keyword",keyword)
            };
            return DataProvider.GetList("phieuTL_search", para);
        }
    }
}
