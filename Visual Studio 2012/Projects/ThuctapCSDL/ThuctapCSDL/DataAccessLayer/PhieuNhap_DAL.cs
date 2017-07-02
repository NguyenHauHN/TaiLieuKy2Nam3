using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;


namespace ThuctapCSDL.DataAccessLayer
{
    class PhieuNhap_DAL
    {
        public static DataTable Select()
        {
            return DataProvider.GetList("pntb_select", null);
        }

        public static int Insert(PhieuNhap pntb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma_phieu",pntb.MaPhieuNhap),
                new SqlParameter("@ma_ncc",pntb.MaNhaCungCap),
                new SqlParameter("@ma_cb",pntb.MaCanBo),
                new SqlParameter("@ma_phong",pntb.MaPhong),
                new SqlParameter("@ten_tb",pntb.TenThietBi),
                new SqlParameter("@ngaynhap",pntb.NgayNhap),
                new SqlParameter("@so_luong",pntb.SoLuong)
            };
            return DataProvider.Execute("pntb_insert", para);
        }

        public static int Update(PhieuNhap pntb)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma_phieu",pntb.MaPhieuNhap),
                new SqlParameter("@ma_ncc",pntb.MaNhaCungCap),
                new SqlParameter("@ma_cb",pntb.MaCanBo),
                new SqlParameter("@ma_phong",pntb.MaPhong),
                new SqlParameter("@ten_tb",pntb.TenThietBi),
                new SqlParameter("@ngaynhap",pntb.NgayNhap),
                new SqlParameter("@so_luong",pntb.SoLuong)
            };
            return DataProvider.Execute("pntb_update", para);
        }

        public static int Delete(string MaPhieu)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma_phieu",MaPhieu)
            };
            return DataProvider.Execute("pntb_delete", para);
        }
    }
}
