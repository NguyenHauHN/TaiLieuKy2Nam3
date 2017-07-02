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
    class ChiTiet_DAL
    {
        public static DataTable Select()
        {
            return DataProvider.GetList("ctpn_select", null);
        }

        public static int Insert(ChiTietPhieuNhap ctpn)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",ctpn.MaPhieu),
                new SqlParameter("@tentb",ctpn.TenTB),
                new SqlParameter("@soluong",ctpn.SoLuong)
            };
            return DataProvider.Execute("ctpn_insert", para);
        }

    }
}
