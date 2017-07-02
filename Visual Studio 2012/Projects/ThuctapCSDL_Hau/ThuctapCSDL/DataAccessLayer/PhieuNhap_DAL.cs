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
            return DataProvider.GetList("pn_select", null);
        }

        public static int Insert(PhieuNhap pn)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphieu",pn.MaPhieu),
                new SqlParameter("@mancc",pn.MaNCC),
                new SqlParameter("@ngaynhap",pn.NgayNhap)
            };
            return DataProvider.Execute("pn_insert", para);
        }
    }
}
