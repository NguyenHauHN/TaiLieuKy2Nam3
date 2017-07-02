using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ThuctapCSDL.DataAccessLayer
{
    public class TaoMa_DAL
    {
        public static string LayMaMaxDAL(string TenBang, string TenCot)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ten_bang", TenBang),
                new SqlParameter("@ten_cot", TenCot)
            };
            return DataProvider.ExecuteGet("LayGiaTriMaxMa", para);
        }
    }
}
