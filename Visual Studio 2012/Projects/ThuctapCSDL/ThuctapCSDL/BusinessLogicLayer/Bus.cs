using System.Data;
using ThuctapCSDL.DataAccessLayer;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.BusinessLogicLayer
{
    public class Bus
    {
        #region Phieu Sua chua
        public static DataTable PSC_selectJoin(string maphieu)
        {
            return PhieuSuaChua_DAL.SelectJoin(maphieu);
        }

        public static DataTable PSC_select()
        {
            return PhieuSuaChua_DAL.Select();
        }

        public static int PSC_insert(PhieuSuaChua psc)
        {
            return PhieuSuaChua_DAL.Insert(psc);
        }

        public static int PSC_update(PhieuSuaChua psc)
        {
            return PhieuSuaChua_DAL.Update(psc);
        }

        public static int PSC_delete(string id)
        {
            return PhieuSuaChua_DAL.Delete(id);
        }

        public static DataTable PSC_search(string keyword)
        {
            return PhieuSuaChua_DAL.Search(keyword);
        }
        #endregion

        #region Sua Chua Thiet Bi
        public static int SCTB_insert(SuaChuaTB tb)
        {
            return SuaChuaTB_DAL.Insert(tb);
        }

        public static int SCTB_update(SuaChuaTB tb)
        {
            return SuaChuaTB_DAL.Update(tb);
        }

        public static int SCTB_delete(string id)
        {
            return SuaChuaTB_DAL.Delete(id);
        }
        #endregion

        #region Sua Chua May Tinh
        public static int SCMT_insert(SuaChuaMT mt)
        {
            return SuaChuaMT_DAL.Insert(mt);
        }

        public static int SCMT_update(SuaChuaMT mt)
        {
            return SuaChuaMT_DAL.Update(mt);
        }

        public static int SCMT_delete(string id)
        {
            return SuaChuaMT_DAL.Delete(id);
        }
        #endregion

        #region May Tinh
        public static DataTable MT_select()
        {
            return MayTinhDAL.Select();
        }

        public static DataTable MT_search(string keyword)
        {
            return MayTinhDAL.Search(keyword);
        }

        public static DataTable MT_selectByRoomCode(string maphong)
        {
            return MayTinhDAL.SelectByRoomCode(maphong);
        }

        public static int MT_insert(MayTinh mt)
        {
            return MayTinhDAL.Insert(mt);
        }

        public static int MT_update(MayTinh mt)
        {
            return MayTinhDAL.Update(mt);
        }

        public static int MT_delete(string id)
        {
            return MayTinhDAL.Delete(id);
        }
        #endregion

        #region Thiet Bi
        public static DataTable TB_select()
        {
            return ThietBi_DAL.Select();
        }

        public static DataTable TB_selectByRoomCode(string maphong)
        {
            return ThietBi_DAL.SelectByRoomCode(maphong);
        }

        public static int TB_insert(string cmdInsert)
        {
            return ThietBi_DAL.Insert(cmdInsert);
        }

        public static int TB_update(ThietBi tb)
        {
            return ThietBi_DAL.Update(tb);
        }

        public static int TB_delete(int MaTB, string TenTB)
        {
            return ThietBi_DAL.Delete(MaTB, TenTB);
        }

        public static DataTable TB_search(string code)
        {
            return ThietBi_DAL.Search(code);
        }
        #endregion

        #region Can Bo
        public static DataTable CB_select()
        {
            return CanBo_DAL.Select();
        }

        public static string CB_selectByName(string TenCanBo)
        {
            return CanBo_DAL.SelectByName(TenCanBo);
        }

        public static DataTable CB_search(string keyword)
        {
            return CanBo_DAL.Search(keyword);
        }

        public static int CB_insert(CanBo cb)
        {
            return CanBo_DAL.Insert(cb);
        }

        public static int CB_update(CanBo cb)
        {
            return CanBo_DAL.Update(cb);
        }

        public static int CB_delete(string cb)
        {
            return CanBo_DAL.Delete(cb);
        }

        #endregion

        #region Phong may
        public static DataTable PM_select()
        {
            return PhongMay_DAL.Select();
        }

        public static int PM_insert(PhongMay pm)
        {
            return PhongMay_DAL.Insert(pm);
        }

        public static int PM_update(PhongMay pm)
        {
            return PhongMay_DAL.Update(pm);
        }

        public static int PM_delete(string id)
        {
            return PhongMay_DAL.Delete(id);
        }
        #endregion

        #region LinhKien
        public static DataTable LK_select()
        {
            return LinhKienMT_DAL.Select();
        }

        public static int LK_insert(LinhKienMT lk)
        {
            return LinhKienMT_DAL.Insert(lk);
        }

        public static int LK_update(LinhKienMT lk)
        {
            return LinhKienMT_DAL.Update(lk);
        }

        public static int LK_delete(string id)
        {
            return LinhKienMT_DAL.Delete(id);
        }

        public static DataTable LK_search(string keyword)
        {
            return LinhKienMT_DAL.Search(keyword);
        }
        #endregion

        #region NhaCungCap
        public static DataTable NCC_Select()
        {
            return NhaCungCap_DAL.Select();
        }

        public static string NCC_SelectByName(string TenNhaCungCap)
        {
            return NhaCungCap_DAL.SelectByName(TenNhaCungCap);
        }

        public static DataTable NCC_Search(string keyword)
        {
            return NhaCungCap_DAL.Search(keyword);
        }

        public static int NCC_insert(NhaCungCap ncc)
        {
           return NhaCungCap_DAL.Insert(ncc);
        }

        public static int NCC_update(NhaCungCap ncc)
        {
            return NhaCungCap_DAL.Update(ncc);
        }

        public static int NCC_delete(string id)
        {
            return NhaCungCap_DAL.Delete(id);
        }
         #endregion

        #region Thanh li
        public static DataTable TL_Select()
        {
            return ThanhLiTB_DAL.Select();
        }

        public static int TL_Insert(ThanhLiTB tl)
        {
            return ThanhLiTB_DAL.Insert(tl);
        }

        public static int TL_Update(ThanhLiTB tl)
        {
            return ThanhLiTB_DAL.Update(tl);
        }

        public static int TL_Delete(string tl)
        {
            return ThanhLiTB_DAL.Delete(tl);
        }

        public static DataTable TL_search(string id)
        {
            return ThanhLiTB_DAL.Search(id);
        }
        #endregion

        #region Phiếu nhập thiết bị
        public static DataTable PNTB_Select()
        {
            return PhieuNhap_DAL.Select();
        }

        public static int PNTB_Insert(PhieuNhap pntb)
        {
            return PhieuNhap_DAL.Insert(pntb);
        }

        public static int PNTB_Update(PhieuNhap pntb)
        {
            return PhieuNhap_DAL.Update(pntb);
        }

        public static int PNTB_Delete(string MaPhieu)
        {

            return PhieuNhap_DAL.Delete(MaPhieu);
        }

        //public static DataTable TL_search(string id)
        //{
        //    return ThanhLiTB_DAL.Search(id);
        //}
        #endregion

        public static string LayMaMaxBLL(string TenBang, string TenCot)
        {
            string MaMax = TaoMaDAL.LayMaMaxDAL(TenBang, TenCot);
            return MaMax;
        }

        public static DataTable LayDSThietBiNhap(string MaPhong)
        {
            return Report.GetListDeviceImport(MaPhong);
        }
    }
}
