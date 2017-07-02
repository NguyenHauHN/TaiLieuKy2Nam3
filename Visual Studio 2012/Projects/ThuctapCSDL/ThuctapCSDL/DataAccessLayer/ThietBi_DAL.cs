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

        public static DataTable SelectByRoomCode(string maphong)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphong",maphong)
            };
            return DataProvider.GetList("tb_selectByRoomCode", para);
        }

        public static int Insert(string cmdInsert)
        {
            return DataProvider.ExecuteCmd(cmdInsert);
        }

        public static int Update(ThietBi tb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma_tb",tb.MaTB),
                new SqlParameter("@ten_tb",tb.TenTB),
                new SqlParameter("@ma_phong",tb.MaPhong),
                new SqlParameter("@ma_ncc",tb.MaNhaCungCap)
            };
            return DataProvider.Execute("tb_update", para);
        }

        public static int Delete(int MaTB, string TenTB)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma_tb",MaTB),
                new SqlParameter("@ten_tb",TenTB)
            };
            return DataProvider.Execute("tb_delete", para);
        }

        public static DataTable Search(string code)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@keyword",code)
            };
            return DataProvider.GetList("tb_search",para);
        }
    }
}
