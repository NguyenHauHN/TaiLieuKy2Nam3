using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.DataAccessLayer
{
    public class ThietBi_DAL
    {
        public static DataTable Select()
        {
            return DataProvider.GetList("tb_select", null);
        }

        public static DataTable SelectDetail()
        {
            return DataProvider.GetList("TB_selectDetail", null);
        }

        public static DataTable SelectByRoomCode(string maphong)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphong",maphong)
            };
            return DataProvider.GetList("tb_selectByRoomCode", para);
        }

        public static int Insert(ThietBi tb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matb",tb.MaTB),
                new SqlParameter("@tentb",tb.TenTB),
                new SqlParameter("@tinhtrang",tb.TinhTrang),
                new SqlParameter("@maltb",tb.MaLoaiTB),
                new SqlParameter("@maphong",tb.MaPhong)
            };
            return DataProvider.Execute("tb_insert", para);
        }

        public static int Update(ThietBi tb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matb",tb.MaTB),
                new SqlParameter("@tentb",tb.TenTB),
                new SqlParameter("@tinhtrang",tb.TinhTrang),
                new SqlParameter("@maltb",tb.MaLoaiTB),
                new SqlParameter("@maphong",tb.MaPhong)
            };
            return DataProvider.Execute("tb_update", para);
        }

        public static int Delete(string id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@matb",id)
            };
            return DataProvider.Execute("tb_delete", para);
        }

        public static int Check(string id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma_tb",id)
            };
            return DataProvider.ExecuteCheck("tb_selectByCode", para);
        }

        public static int SelectName(string name)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ten_tb",name)
            };
            return DataProvider.ExecuteCheck("tb_selectByName", para);
        }

        public static DataTable Search(string keyword)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@keyword",keyword)
            };
            return DataProvider.GetList("tb_search",para);
        }
    }
}
