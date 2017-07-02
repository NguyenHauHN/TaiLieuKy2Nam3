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

        public static DataTable SelectDetail()
        {
            return DataProvider.GetList("NCC_selectDetail", null);
        }

     
        public static int Insert(NhaCungCap ncc)
        {
            SqlParameter[] para = new SqlParameter[]
             {
                new SqlParameter("@mancc",ncc.MaNhaCC),
                new SqlParameter("@tenncc",ncc.TenNhaCC),
                new SqlParameter("@diachi",ncc.DiaChi),
                new SqlParameter("@SDT",ncc.SDT)
             };
            return DataProvider.Execute("ncc_insert", para);
        }

        public static int Update(NhaCungCap psc)
        {
            SqlParameter[] para = new SqlParameter[]
             {
                new SqlParameter("@mancc",psc.MaNhaCC),
                new SqlParameter("@tenncc",psc.TenNhaCC),
                new SqlParameter("@diachi",psc.DiaChi),
                new SqlParameter("@SDT",psc.SDT)
             };
            return DataProvider.Execute("ncc_update", para);
        }

        public static int Delete(string id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@mancc",id)
            };
            return DataProvider.Execute("ncc_delete", para);
        }

        public static int Check(string id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma_ncc",id)
            };
            return DataProvider.ExecuteCheck("ncc_selectByCode", para);
        }

        public static int SelectName(string name)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ten_ncc",name)
            };
            return DataProvider.ExecuteCheck("ncc_selectByName", para);
        }

        public static string SelectCode(string name)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ten_ncc",name)
            };
            return DataProvider.ExecuteGet("ncc_selectCodeByName", para);
        }

        public static DataTable Search(string keyword)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@keyword",keyword)
            };
            return DataProvider.GetList("ncc_search", para);
        }
    }
}
