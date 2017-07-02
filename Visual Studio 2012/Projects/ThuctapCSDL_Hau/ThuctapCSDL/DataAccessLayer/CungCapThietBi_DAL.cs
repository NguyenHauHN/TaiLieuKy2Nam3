using System.Data.SqlClient;
using System.Data;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.DataAccessLayer
{
    public class CungCapThietBi_DAL
    {
        public static DataTable CCTB_select()
        {
            return DataProvider.GetList("cctb_select", null);
        }

        public static DataTable CCTB_search(string keyword)
        {
            SqlParameter[] SqlPara = new SqlParameter[]
            {
                new SqlParameter("@keyword",keyword)
            };
            return DataProvider.GetList("cctb_search", SqlPara);
        }

        public static int CCTB_insert(CungCapTB ncc)
        {
            SqlParameter[] SqlPara = new SqlParameter[]
            {
                new SqlParameter("@mancc",ncc.MaNhaCC),
                new SqlParameter("@matb",ncc.MaTB),
                new SqlParameter("@chatluong",ncc.ChatLuong),
                new SqlParameter("@baohanh",ncc.TgianBaoHanh),
                new SqlParameter("@ngaycap",ncc.NgayCap),

            };
            return DataProvider.Execute("cctb_insert", SqlPara);
        }
        public static int CCTB_update(CungCapTB ncc, string MaNCC, string MaTB)
        {
            SqlParameter[] SqlPara = new SqlParameter[]
            {
                new SqlParameter("@ma_ncc",MaNCC),
                new SqlParameter("@ma_tb",MaTB),
                new SqlParameter("@ma_ncc_edit",ncc.MaNhaCC),
                new SqlParameter("@ma_tb_edit",ncc.MaTB),
                new SqlParameter("@ngay_cap",ncc.NgayCap),
                new SqlParameter("@chat_luong",ncc.ChatLuong),
                new SqlParameter("@bao_hanh",ncc.TgianBaoHanh),

            };
            return DataProvider.Execute("cctb_update", SqlPara);
        }

        public static int CCTB_delete(string MaNCC, string MaTB)
        {
            SqlParameter[] SqlPara = new SqlParameter[]
            {
                new SqlParameter("@ma_ncc",MaNCC),
                new SqlParameter("@ma_tb",MaTB)
            };
            return DataProvider.Execute("cctb_delete", SqlPara);
        }

        public static int CCTB_selectCheck(string MaTB)
        {
            SqlParameter[] SqlPara = new SqlParameter[]
            {
                
                new SqlParameter("@ma_tb",MaTB)
            };
            return DataProvider.ExecuteCheck("cctb_selectByCode", SqlPara);
        }

        public static int CCTB_selectCheck2(string MaNCC, string MaTB)
        {
            SqlParameter[] SqlPara = new SqlParameter[]
            {
                new SqlParameter("@ma_ncc",MaNCC),
                new SqlParameter("@ma_tb",MaTB)
            };
            return DataProvider.ExecuteCheck("cctb_selectByCode2", SqlPara);
        }
    }
}
