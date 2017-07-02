using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.DataAccessLayer
{
    class LoaiThietBi_DAL
    {
       public static DataTable Select()
        {
            return DataProvider.GetList("loaiTB_select", null);
        }

        public static DataTable Search(string keyword)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@keyword",keyword)
            };
            return DataProvider.GetList("loaiTB_search", para);
        }

        public static int Insert(LoaiThietBi ltb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maloaitb",ltb.MaLoaiThietBi),
                new SqlParameter("@tenloaitb",ltb.TenLoaiThietBi)
            };
            return DataProvider.Execute("loaiTB_insert", para);
        }

        public static int Update(LoaiThietBi ltb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maloaitb",ltb.MaLoaiThietBi),
                new SqlParameter("@tenloaitb",ltb.TenLoaiThietBi)
            };
            return DataProvider.Execute("loaiTB_update", para);
        }

        public static int Delete(string code)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maloaitb",code)
            };
            return DataProvider.Execute("loaiTB_delete", para);
        }
    }
}
