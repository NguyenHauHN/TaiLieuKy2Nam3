using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.DataAccessLayer
{
    public class MayTinhDAL
    {
        public static DataTable Select()
        {
            return DataProvider.GetList("mt_select", null);
        }

        public static DataTable SelectByRoomCode(string maphong)
        {
            SqlParameter[] para = new SqlParameter[]
                { new SqlParameter("@maphong", maphong) };
            return DataProvider.GetList("mt_selectByRoomCode", para);
        }

        public static DataTable Search(string keyword)
        {
            SqlParameter[] para = new SqlParameter[]
                { new SqlParameter("@keyword", keyword) };
            return DataProvider.GetList("mt_search", para);
        }

        public static int Insert(MayTinh mt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",mt.MaMay),
                new SqlParameter("@ten",mt.TenMay),
                new SqlParameter("@tinhtrang",mt.TinhTrang),
                new SqlParameter("@cauhinh",mt.CauHinh),
                new SqlParameter("@ngaylapdat",mt.NgayLapDat),
                new SqlParameter("@maphong",mt.MaPhong)
            };
            return DataProvider.Execute("mt_insert", para);
        }

        public static int Update(MayTinh mt)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",mt.MaMay),
                new SqlParameter("@ten",mt.TenMay),
                new SqlParameter("@tinhtrang",mt.TinhTrang),
                new SqlParameter("@cauhinh",mt.CauHinh),
                new SqlParameter("@ngaylapdat",mt.NgayLapDat),
                new SqlParameter("@maphong",mt.MaPhong)
            };
            return DataProvider.Execute("mt_update", para);
        }

        public static int Delete(string id)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma",id)
            };
            return DataProvider.Execute("mt_delete", para);
        }
       
    }
}
