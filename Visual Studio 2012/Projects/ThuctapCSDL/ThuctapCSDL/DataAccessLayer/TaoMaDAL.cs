using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ThuctapCSDL.DataAccessLayer
{
    public class TaoMaDAL
    {
        public static string LayMaMaxDAL(string TenBang, string TenCot)
        {
            string _storeProcedure = string.Format("LayGiaTriMaxMa");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@ten_bang", TenBang);
            sqlParameters[1] = new SqlParameter("@ten_cot", TenCot);
            string MaMax = Convert.ToString(DataProvider.ExecuteResult(_storeProcedure, sqlParameters));
            return MaMax;
        }
    }
}
