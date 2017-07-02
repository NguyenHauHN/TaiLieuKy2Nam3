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
    public class NguoiDung_DAL
    {
        public static List<NguoiDung> GetUserList()
        {
            DataTable dt = DataProvider.GetList("nd_select", null);
            List<NguoiDung> ds = new List<NguoiDung>();
            foreach (DataRow row in dt.Rows)
            {
                ds.Add(new NguoiDung
                {
                    TaiKhoan = row.Field<string>("TaiKhoan"),
                    MatKhau = row.Field<string>("MatKhau"),
                    MaCanBo = row.Field<string>("MaCanBo"),
                    TenNguoiDung = row.Field<string>("TenNguoiDung"),
                    CauHoi = row.Field<string>("CauHoi"),
                    DapAn = row.Field<string>("DapAn")
                });
            }
            return ds;
        }

        public static int Insert(NguoiDung nd)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@taikhoan",nd.TaiKhoan),
                new SqlParameter("@matkhau",nd.MatKhau),
                new SqlParameter("@tennguoidung",nd.TenNguoiDung),
                new SqlParameter("@macanbo",nd.MaCanBo),
                new SqlParameter("@cauhoi",nd.CauHoi),
                new SqlParameter("@dapan",nd.DapAn)
            };
            return DataProvider.Execute("nd_insert", para);
        }
    }
}
