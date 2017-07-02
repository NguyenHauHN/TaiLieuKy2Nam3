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

        public static DataTable TB_selectDetail()
        {
            return ThietBi_DAL.SelectDetail();
        }

        public static DataTable TB_selectByRoomCode(string maphong)
        {
            return ThietBi_DAL.SelectByRoomCode(maphong);
        }

        public static int TB_insert(ThietBi tb)
        {
            return ThietBi_DAL.Insert(tb);
        }

        public static int TB_update(ThietBi tb)
        {
            return ThietBi_DAL.Update(tb);
        }

        public static int TB_delete(string tb)
        {
            return ThietBi_DAL.Delete(tb);
        }

        public static int TB_check(string tb)
        {
            return ThietBi_DAL.Check(tb);
        }

        public static int TB_selectName(string name)
        {
            return ThietBi_DAL.SelectName(name);
        }

        public static DataTable TB_search(string keyword)
        {
            return ThietBi_DAL.Search(keyword);
        }
        #endregion

        #region Can Bo
        public static DataTable CB_select()
        {
            return CanBo_DAL.Select();
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

        public static DataTable NCC_SelectDetail()
        {
            return NhaCungCap_DAL.SelectDetail();
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

        public static int NCC_check(string id)
        {
            return NhaCungCap_DAL.Check(id);
        }

        public static int NCC_selectName(string name)
        {
            return NhaCungCap_DAL.SelectName(name);
        }

        public static string NCC_selectCode(string name)
        {
            return NhaCungCap_DAL.SelectCode(name);
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

        #region Loại thiết bị
        public static DataTable LoaiThietBi_select()
        {
            return LoaiThietBi_DAL.Select();
        }

        public static int LoaiThietBi_insert(LoaiThietBi tb)
        {
            return LoaiThietBi_DAL.Insert(tb);
        }

        public static int LoaiThietBi_update(LoaiThietBi tb)
        {
            return LoaiThietBi_DAL.Update(tb);
        }

        public static int LoaiThietBi_delete(string code)
        {
            return LoaiThietBi_DAL.Delete(code);
        }

        public static DataTable LoaiThietBi_search(string code)
        {
            return LoaiThietBi_DAL.Search(code);
        }
        #endregion

        #region Cung cấp thiết bị
        public static DataTable CCTB_select()
        {
            
            return CungCapThietBi_DAL.CCTB_select();
        }

        public static int CCTB_insert(CungCapTB cctb)
        {
            return CungCapThietBi_DAL.CCTB_insert(cctb);
        }

        public static int CCTB_update(CungCapTB cctb, string MaNCC, string MaTB)
        {
            return CungCapThietBi_DAL.CCTB_update(cctb, MaNCC, MaTB);
        }

        public static int CCTB_delete(string MaNCC,string MaTB)
        {
            return CungCapThietBi_DAL.CCTB_delete(MaNCC, MaTB);
        }

        public static int CCTB_check(string MaTB)
        {
            return CungCapThietBi_DAL.CCTB_selectCheck(MaTB);
        }

        public static int CCTB_check2( string MaNCC, string MaTB)
        {
            return CungCapThietBi_DAL.CCTB_selectCheck2(MaNCC, MaTB);
        }

        public static DataTable CCTB_search(string keyword)
        {
            return CungCapThietBi_DAL.CCTB_search(keyword);
        }
        #endregion


        #region phiếu nhập
        public static DataTable PN_select()
        {

            return PhieuNhap_DAL.Select();
        }

        public static int PN_insert(PhieuNhap pn)
        {
            return PhieuNhap_DAL.Insert(pn);
        }

        
        #endregion

        #region chi tiết phiếu nhập
        public static DataTable CTPN_select()
        {

            return ChiTiet_DAL.Select();
        }

        public static int CTPN_insert(ChiTietPhieuNhap pn)
        {
            return ChiTiet_DAL.Insert(pn);
        }


        #endregion
        public static string LayMaMaxBLL(string TenBang, string TenCot)
        {
            return TaoMa_DAL.LayMaMaxDAL(TenBang, TenCot);
        }
    }
}
