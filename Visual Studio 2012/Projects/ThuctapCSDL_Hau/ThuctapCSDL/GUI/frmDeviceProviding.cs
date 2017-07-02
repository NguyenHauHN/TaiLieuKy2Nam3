using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThuctapCSDL.BusinessLogicLayer;
using ThuctapCSDL.ValueObject;
using ThuctapCSDL.DataAccessLayer;

namespace ThuctapCSDL.GUI
{
    public partial class frmDeviceProviding : Form
    {
        private string TrangThaiAction;
        CungCapTB CungCapTB = new CungCapTB();
        private string TenNhaCungCap;
        private string MaNhaCungCap;
        private string TenNCCUpdate;
        private string TenThietBi;
        private string MaNCC;
        private string MaTB;
        private int checkThemCCTBMoi = 0;
        private int errUpdate =1;
        List<CungCapTB> ListTB = new List<CungCapTB>();

        public frmDeviceProviding()
        {
            InitializeComponent();
        }

        private void frmDeviceProviding_Load(object sender, EventArgs e)
        {
            HienThiDanhSachCCTB();
            HienThiDanhSachNCC();
            HienThiDanhSachTB();
            txtThoiHanBH.Enabled = false;
            rtbChatLuong.Enabled = false;
            dtpNgayCap.Enabled = false;
            dtpNgayCap.Value = DateTime.Now;
        }

        public void HienThiDanhSachCCTB()
        {
            dgvListDeviceProvided.DataSource = Bus.CCTB_select();
            dgvListDeviceProvided.Columns["Mã nhà cung cấp"].Visible = false;
            dgvListDeviceProvided.Columns["Mã thiết bị"].Visible = false;
        }

        public void LayThongTinNhaCungCap()
        {
            if (ckbModeProvider.Checked == true)
            {
                MaNhaCungCap = cbListProvider.SelectedValue.ToString(); 
            }
            else
            {
                TenNhaCungCap = txtTenNCC.Text;
            }
        }


        private void tsAdd_Click(object sender, EventArgs e)
        {
            // thay doi trang thai cac button chuc nang khac
            tsDelete.Enabled = false;
            tsUpdate.Enabled = false;
            tsSave.Enabled = true;

            // thay doi trang thai txt
            ckbModeProvider.Enabled = true;
            cbListProvider.Enabled = false;
            ckbModeDevice.Enabled = true;
            ckbModeDevice.Enabled = true;
            dtgListDevice.Enabled = false;
            txtNameDevice.Enabled = true;
            txtTenNCC.Enabled = true;
            txtThoiHanBH.Enabled = true;
            rtbChatLuong.Enabled = true;
            dtpNgayCap.Enabled = true;
            txtSelectDevice.Enabled = false;
            txtSelectProvider.Enabled = false;
            // 
            TrangThaiAction = "Them moi NCC";
           

        }

        private void ckbModeProvider_CheckedChanged(object sender, EventArgs e)
        {
            if (TrangThaiAction == "Them moi NCC")
            {
                if (ckbModeProvider.Checked == true)
                {
                    txtTenNCC.Enabled = false;
                    cbListProvider.Enabled = true;
                }
                else
                {
                    txtTenNCC.Enabled = true;
                    cbListProvider.Enabled = false;
                }
            }
            else
            {
                if (TrangThaiAction == "Cap nhat CCTB")
                {
                    if (ckbModeProvider.Checked == true)
                    {
                        txtSelectProvider.Enabled = false;
                        cbListProvider.Enabled = true;
                    }
                    else
                    {
                        txtSelectProvider.Enabled = true;
                        cbListProvider.Enabled = false;
                    }
                }
            }
           
        }

        private void ckbModeDevice_CheckedChanged(object sender, EventArgs e)
        {
            if (TrangThaiAction == "Them moi NCC")
            {
                if (ckbModeDevice.Checked == true)
                {
                    txtNameDevice.Enabled = false;
                    dtgListDevice.Enabled = true;
                }
                else
                {
                    txtNameDevice.Enabled = true;
                    dtgListDevice.Enabled = false;
                }
            }
            else
            {
                if (TrangThaiAction == "Cap nhat CCTB")
                {
                    if (ckbModeDevice.Checked == true)
                    {
                        txtSelectDevice.Enabled = false;
                        dtgListDevice.Enabled = true;
                    }
                    else
                    {
                        txtSelectDevice.Enabled = true;
                        dtgListDevice.Enabled = false;
                    }
                }
            }
            
        }

        public void HienThiDanhSachNCC()
        {
            cbListProvider.DataSource = Bus.NCC_Select();
            cbListProvider.DisplayMember = "TenNhaCC";
            cbListProvider.ValueMember = "MaNhaCC";
        }

        public void HienThiDanhSachTB()
        {
            dtgListDevice.DataSource = Bus.TB_select();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            if (TrangThaiAction == "Them moi NCC")
            {
                int ThemCCTB = ThemMoiCCTB();
                if (checkThemCCTBMoi == -5)
                {
                    MessageBox.Show("Thông tin cung cấp thiết bị đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (ThemCCTB < 0)
                {
                    MessageBox.Show("Xảy ra lỗi khi thêm cung cấp thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    HienThiDanhSachCCTB();
                    MessageBox.Show("Thêm mới thành công cung cấp thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (TrangThaiAction == "Cap nhat CCTB")
            {
                LayThongTinCapNhatCCTB();
                if (errUpdate == -5)
                {
                    MessageBox.Show("Thông tin cung cấp thiết bị đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (errUpdate < 0)
                {
                }
                else
                {

                    int UpdateCCTB = Bus.CCTB_update(CungCapTB, MaNCC, MaTB);
                    if (UpdateCCTB > 0)
                    {
                        HienThiDanhSachCCTB();
                        MessageBox.Show("Đã cập nhật thông tin cung cấp thiêt bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xảy ra lỗi khi cập nhật cung cấp thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }

        }

        public int ThemMoiNCC()
        {
            int ThemNCC = 2;
            LayThongTinNhaCungCap();
            NhaCungCap _ncc = new NhaCungCap();
            frmSupplier _nccFrm = new frmSupplier();
            _ncc.MaNhaCC = _nccFrm.GetCode();
            if (TrangThaiAction == "Them moi NCC")
            {
                _ncc.TenNhaCC = TenNhaCungCap;
            }
            if (TrangThaiAction == "Cap nhat CCTB")
            {
                _ncc.TenNhaCC = txtSelectProvider.Text;
            }
            _ncc.DiaChi = "";
            _ncc.SDT = "";
            int resCheckNCC = Bus.NCC_selectName(_ncc.TenNhaCC);
            if (resCheckNCC <= 0)
            {
                int resInsert = Bus.NCC_insert(_ncc);
                if (resInsert > 0)
                {
                    CungCapTB.MaNhaCC = _ncc.MaNhaCC;
                    MessageBox.Show("Thêm mới nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ThemNCC = 1;
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi khi thêm nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ThemNCC = -1;
                }
            }
            else
            {

            }
            return ThemNCC;
        }

        public int ThemMoiTB()
        {
            int ThemTB = 2;
            frmDevice _deviceFrm = new frmDevice();
            ThietBi _tb = new ThietBi();
            _tb.MaTB = _deviceFrm.GetCode();
            if (TrangThaiAction == "Cap nhat CCTB")
            {
                _tb.TenTB = txtSelectDevice.Text;
            }
            if (TrangThaiAction == "Them moi NCC")
            {
                _tb.TenTB = txtNameDevice.Text;
            }
            
            _tb.TinhTrang = "";
            _tb.MaLoaiTB = "";
            _tb.MaPhong = "";

            int resThemTb = Bus.TB_insert(_tb);
            if (resThemTb > 0)
            {
                ThemTB = 1;
                CungCapTB.MaTB = _tb.MaTB;
                MessageBox.Show("Đã thêm mới thành công thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                ThemTB = -1;
                MessageBox.Show("Xảy ra lỗi khi thêm thiết bị mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return ThemTB;
        }

        private int ThemMoiCCTB()
        {
            int checkThemCCTB = 2;
            int resInsertCCTB = -1;
            // lay thong tin nha cung cap 
                if (ckbModeProvider.Checked == false)
                {
                    int resCheckNCC = Bus.NCC_selectName(txtTenNCC.Text);
                    if (resCheckNCC <= 0)
                    {
                        int checkThemNCC = ThemMoiNCC();
                        if (checkThemNCC < 0)
                        {
                            checkThemCCTB = -1;
                        }
                    }
                    else
                    {

                        CungCapTB.MaNhaCC = Bus.NCC_selectCode(txtTenNCC.Text);
                    }
                }
                else
                {
                    CungCapTB.MaNhaCC = cbListProvider.SelectedValue.ToString();
                }
                // lay thong tin thiet bi

                if (ckbModeDevice.Checked == false)
                {
                    int checkThemTb = ThemMoiTB();
                    if (checkThemTb < 0)
                    {
                        checkThemCCTB = -2;
                    }
                }
                else
                {
                    LayDanhSachCCTB();
                }
                
                if (ListTB.Count > 0)
                {
                    int checkCCTBMoi = 2;
                    foreach (CungCapTB cctb in ListTB)
                    {
                        checkCCTBMoi = Bus.CCTB_check2(cctb.MaNhaCC, cctb.MaTB);
                        if ( checkCCTBMoi > 0)
                        {
                            checkThemCCTBMoi = -5;
                        }
                        else
                        {
                            resInsertCCTB = Bus.CCTB_insert(cctb);
                        }
                        
                    }
                }
                else
                {
                    CungCapTB.ChatLuong = rtbChatLuong.Text;
                    CungCapTB.NgayCap = dtpNgayCap.Text;
                    CungCapTB.TgianBaoHanh = txtThoiHanBH.Text;
                    if (Bus.CCTB_check2(CungCapTB.MaNhaCC, CungCapTB.MaTB) > 0)
                    {
                        checkThemCCTB = -5;
                    }
                    else
                    {
                        resInsertCCTB = Bus.CCTB_insert(CungCapTB);
                    }
                    
                }
                
                if (resInsertCCTB > 0)
                {
                    rtbChatLuong.Text = "";
                    txtThoiHanBH.Text = "";
                }
                else
                {
                    checkThemCCTB = -3;
                }
                return checkThemCCTB;
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
           // thay doi trang thai cac button
            tsSave.Enabled = false;
            tsAdd.Enabled = false;
            tsUpdate.Enabled = false;
            if (MaNCC != "" && MaTB != "")
            {
                // thuc hien xoa
                DialogResult result2 = MessageBox.Show("Bạn chắc chắn muốn xóa tất cả thông tin cung cấp thiết bị  khỏi cơ sở dữ liệu?",
        "Xác nhận xóa",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                    int res = Bus.CCTB_delete(MaNCC, MaTB);
                    if (res > 0)
                    {
                        MessageBox.Show("Đã xóa tất cả thông tin cung cấp thiết bị khỏi cơ sở dữ liệu!",
    "Thông báo", MessageBoxButtons.OK,
        MessageBoxIcon.Information);
                        HienThiDanhSachCCTB();
                    }
                    else
                    {
                        MessageBox.Show("Chưa xóa được thông tin cung cấp thiết bị!",
    "Thông báo", MessageBoxButtons.OK,
        MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thông tin cung cấp thiết bị để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;            
             }
        }

        private void dgvListDeviceProvided_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListDeviceProvided.SelectedRows.Count == 1)
            {
                int selectedRowIndex = dgvListDeviceProvided.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvListDeviceProvided.Rows[selectedRowIndex];
                txtSelectProvider.Text = selectedRow.Cells["Tên nhà cung cấp"].Value.ToString();
                TenNCCUpdate = selectedRow.Cells["Tên nhà cung cấp"].Value.ToString();
                MaNCC = selectedRow.Cells["Mã nhà cung cấp"].Value.ToString();
                txtSelectDevice.Text = selectedRow.Cells["Tên thiết bị"].Value.ToString();
                TenThietBi = selectedRow.Cells["Tên thiết bị"].Value.ToString();
                MaTB = selectedRow.Cells["Mã thiết bị"].Value.ToString();
                txtThoiHanBH.Text = selectedRow.Cells["Thời gian bảo hành"].Value.ToString();
                rtbChatLuong.Text = selectedRow.Cells["Chất lượng"].Value.ToString();
                string date = selectedRow.Cells["Ngày cấp"].Value.ToString();
                if (date != "")
                {
                    dtpNgayCap.Value = DateTime.ParseExact(date, "dd/MM/yyyy", null);
                }
                else
                {
                    dtpNgayCap.Value = DateTime.Now;
                }

                
            }
        }

        public void LayThongTinCapNhatCCTB()
        {
            if (ckbModeProvider.Checked == true)
            {
                CungCapTB.MaNhaCC = cbListProvider.SelectedValue.ToString();
            }
            else
            {

                if (txtSelectProvider.Text != TenNCCUpdate)
                {
                    int resCheckNCCUpdate = Bus.NCC_selectName(txtSelectProvider.Text);
                    if (resCheckNCCUpdate > 0)
                    {
                        CungCapTB.MaNhaCC = Bus.NCC_selectCode(txtSelectProvider.Text);
                    }
                    else
                    {
                        int resThemNCC = ThemMoiNCC();
                        if (resThemNCC <= 0)
                        {
                            errUpdate = -4;
                        }
                    }
                }
                else
                {
                    CungCapTB.MaNhaCC = MaNCC;
                }
                //CungCapTB.MaNhaCC = Bus.NCC_selectCode(txtSelectProvider.Text);
            }
            if (ckbModeDevice.Checked == true)
            {
                LayDanhSachCCTB();
                if (ListTB.Count > 1)
                {
                    MessageBox.Show("Bạn chỉ được chọn 1 thông tin thiết bị để cập nhật cung cấp thiêt bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errUpdate = -1;
                }
                else
                {
                    if (ListTB.Count == 1)
                    {
                        CungCapTB.MaTB = ListTB[0].MaTB;
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn thông tin thiết bị để cập nhật cung cấp thiêt bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errUpdate = -2;
                    }

                }
            }
            else
            {
                if (txtSelectDevice.Text != TenThietBi)
                {
                    int resCheckTBUpdate = Bus.TB_selectName(txtSelectDevice.Text);
                    if (resCheckTBUpdate > 0)
                    {
                        MessageBox.Show("Thiết bị đã tồn tại, bạn vui lòng chọn trong danh sách thiết bị và nhán lưu để cập nhật cung câp thiết bị!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        errUpdate = -5;
                    }
                    else
                    {
                        int resThemTB = ThemMoiTB();
                        if (resThemTB <= 0)
                        {
                            errUpdate = -4;
                        }
                    }
                }
                else
                {
                    CungCapTB.MaTB = MaTB;
                }
                
            }
            CungCapTB.ChatLuong = rtbChatLuong.Text;
            CungCapTB.NgayCap = dtpNgayCap.Text;
            CungCapTB.TgianBaoHanh = txtThoiHanBH.Text;
        }

        private void tsUpdate_Click(object sender, EventArgs e)
        {
            // thay doi trang thai cac txt
            txtNameDevice.Enabled = false;
            txtTenNCC.Enabled = false;
            txtSelectDevice.Enabled = true;
            txtSelectProvider.Enabled = true;
            cbListProvider.Enabled = false;
            dtgListDevice.Enabled = false;
            ckbModeDevice.Enabled = true;
            ckbModeProvider.Enabled = true;
            txtThoiHanBH.Enabled = true;
            rtbChatLuong.Enabled = true;
            dtpNgayCap.Enabled = true;

            // thay doi trang thai button
            tsAdd.Enabled = false;
            tsDelete.Enabled = false;
            tsSave.Enabled = true;
            // 
            TrangThaiAction = "Cap nhat CCTB";

            

        }

        public void LayDanhSachCCTB()
        {
            ListTB.Clear();
            foreach (DataGridViewRow row in dtgListDevice.Rows)
            {
                DataGridViewCheckBoxCell cell = row.Cells["SelectRow"] as DataGridViewCheckBoxCell;
                if ((bool)cell.EditedFormattedValue == true)
                {
                    ListTB.Add(new CungCapTB()
                    {
                        MaTB = row.Cells["Mã thiết bị"].Value.ToString(),
                        MaNhaCC = CungCapTB.MaNhaCC,
                        ChatLuong = rtbChatLuong.Text,
                        NgayCap = dtpNgayCap.Text,
                        TgianBaoHanh = txtThoiHanBH.Text
                    });
                }
            }
        }

        private void tsRefresh_Click(object sender, EventArgs e)
        {
            tsAdd.Enabled = true;
            tsDelete.Enabled = true;
            tsSave.Enabled = false;
            tsUpdate.Enabled = true;
            txtSelectDevice.Enabled = false;
            txtSelectProvider.Enabled = false;
            txtNameDevice.Enabled = false;
            txtTenNCC.Enabled = false;
            txtThoiHanBH.Enabled = false;
            rtbChatLuong.Enabled = false;
            dtpNgayCap.Enabled = false;
            ckbModeDevice.Enabled = false;
            ckbModeProvider.Enabled = false;
            cbListProvider.Enabled = false;
            txtSelectProvider.Text = "";
            txtSelectDevice.Text = "";
            txtNameDevice.Text = "";
            txtTenNCC.Text = "";
            dtpNgayCap.Value = DateTime.Now;
            rtbChatLuong.Text = "";
            txtThoiHanBH.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvListDeviceProvided.DataSource = Bus.CCTB_search(txtSearch.Text);
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            Export export = new Export();
            export.Print(dgvListDeviceProvided);
        }
      
    }
}
