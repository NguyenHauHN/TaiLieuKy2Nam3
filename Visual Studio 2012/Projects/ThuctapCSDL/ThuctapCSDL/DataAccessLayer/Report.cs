using System.Data;
using System.Data.SqlClient;

namespace ThuctapCSDL.DataAccessLayer
{
    class Report
    {
        public static DataTable ReportingRepairment(string proc, string maphong, string macanbo)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphong",maphong),
                new SqlParameter("@macanbo",macanbo)
            };
            return DataProvider.GetList(proc, para);
        }

        public static DataTable ReportingRepairment(string proc, string maphong)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maphong",maphong)
            };
            return DataProvider.GetList(proc, para);
        }

        public static DataTable ReportingSale(string proc, string macanbo)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@macanbo",macanbo)
            };
            return DataProvider.GetList(proc, para);
        }

        public static DataTable ReportingSale(string proc)
        {
            return DataProvider.GetList(proc, null);
        }

        public static DataTable GetListDeviceImport(string MaPhong)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ma_pm",MaPhong)
            };
            return DataProvider.GetList("tk_nhapTB", para);
        }
    }
}
