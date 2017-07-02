using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.DataAccessLayer
{
    public class NhaCungCap_DAL
    {
        public static DataTable Select()
        {
            return DataProvider.GetList("ncc_select", null);
        }

        public static int Insert(NhaCungCap ncc)
        {
            SqlParameter[] para = new SqlParameter[]
             {
                new SqlParameter("@ma_ncc",ncc.MaNhaCC),
                new SqlParameter("@ten_ncc",ncc.TenNhaCC),
                new SqlParameter("@dia_chi",ncc.DiaChi),
                new SqlParameter("@sdt",ncc.SDT)
             };
            return DataProvider.Execute("ncc_insert", para);
        }

        public static int Update(NhaCungCap psc)
        {
            SqlParameter[] para = new SqlParameter[]
             {
                new SqlParameter("@ma_ncc",psc.MaNhaCC),
                new SqlParameter("@ten_ncc",psc.TenNhaCC),
                new SqlParameter("@dia_chi",psc.DiaChi),
                new SqlParameter("@sdt",psc.SDT)
             };
            return DataProvider.Execute("ncc_update", para);
        }

        public static int Delete(string id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma_ncc",id)
            };
            return DataProvider.Execute("ncc_delete", para);
        }

        public static DataTable Search(string keyword)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@keyword",keyword)
            };
            return DataProvider.GetList("ncc_search", para);
        }

        public static string SelectByName(string TenNhaCungCap)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ten_ncc",TenNhaCungCap)
            };
            return DataProvider.ExecuteResult("ncc_selectByName", para);
        }
    }
}
