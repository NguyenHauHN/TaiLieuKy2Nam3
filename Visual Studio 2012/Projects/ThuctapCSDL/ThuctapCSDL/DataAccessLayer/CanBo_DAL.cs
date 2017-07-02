using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.DataAccessLayer
{
    public class CanBo_DAL
    {
        public static DataTable Select()
        {
            return DataProvider.GetList("cb_select", null);
        }

        public static string SelectByName(string TenCanBo)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ten_cb",TenCanBo)
            };
            return DataProvider.ExecuteResult("cb_selectByName", para);
        }

        public static DataTable Search(string keyword)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@keyword",keyword)
            };
            return DataProvider.GetList("cb_search", para);
        }

        public static int Insert(CanBo tl)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macb",tl.MaCB),
                new SqlParameter("@tencb",tl.TenCB),
                new SqlParameter("@diachi",tl.DiaChi),
                new SqlParameter("@gioitinh",tl.GioiTinh),
                new SqlParameter("@sdt",tl.SoDT),
                new SqlParameter("@ngay",tl.NgaySinh),
            };
            return DataProvider.Execute("cb_insert", para);
        }

        public static int Update(CanBo tl)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macb",tl.MaCB),
                new SqlParameter("@tencb",tl.TenCB),
                new SqlParameter("@diachi",tl.DiaChi),
                new SqlParameter("@gioitinh",tl.GioiTinh),
                new SqlParameter("@sdt",tl.SoDT),
                new SqlParameter("@ngay",tl.NgaySinh),
            };
            return DataProvider.Execute("cb_update", para);
        }

        public static int Delete(string ma)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macb",ma),
            };
            return DataProvider.Execute("cb_delete", para);
        }
    }
}
