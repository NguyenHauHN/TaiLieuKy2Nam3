using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;
using ThuctapCSDL.BusinessLogicLayer;
using System.Globalization;

namespace ThuctapCSDL.GUI
{
    public partial class frmImportDevice : Form
    {
        PhieuNhap pntb = new PhieuNhap();
        CultureInfo provider = CultureInfo.InvariantCulture;
        private string action;
        private string MaPhieuNhap;
        public frmImportDevice()
        {
            InitializeComponent();
        }

        private void frmImportDevice_Load(object sender, EventArgs e)
        {
            
            dtgListPhieuNhap.DataSource = Bus.PNTB_Select();
            this.dtgListPhieuNhap.Columns[0].Visible = false;
            this.dtgListPhieuNhap.Columns[7].Visible = false;
            // khoi tao du liêu combobox
            cbPhongMay.DataSource = Bus.PM_select();
            cbPhongMay.ValueMember = "Mã phòng";
            cbPhongMay.DisplayMember = "Tên phòng";

            cbTenCanBo.DataSource = Bus.CB_select();
            cbTenCanBo.ValueMember = "Mã cán bộ";
            cbTenCanBo.DisplayMember = "Tên cán bộ";
        }

        public void LayDuLieu()
        {
            
            if (Bus.NCC_SelectByName(txtTenNhaCungCap.Text) != " ")
            {
                pntb.MaNhaCungCap = Bus.NCC_SelectByName(txtTenNhaCungCap.Text);
            }
            else
            {
                NhaCungCap ncc = new NhaCungCap();
                frmSupplier nccFrm = new frmSupplier();
                ncc.MaNhaCC = nccFrm.TaoMa();
                ncc.TenNhaCC = txtTenNhaCungCap.Text;
                ncc.DiaChi = "";
                ncc.SDT = "";
                if (Bus.NCC_insert(ncc) > 0)
                {
                    pntb.MaNhaCungCap = ncc.MaNhaCC;
                }
                else
                {
                    pntb.MaNhaCungCap = " ";
                }
                
            }
            pntb.MaCanBo = cbTenCanBo.SelectedValue.ToString();
            pntb.NgayNhap = dtpNgayNhap.Value;
            pntb.MaPhong = cbPhongMay.SelectedValue.ToString();
            pntb.TenThietBi = txtTenThietBi.Text;
            pntb.SoLuong = Int32.Parse( txtSoLuong.Text);
        }

        public string TaoMa()
        {
            string MaMoi;
            string MaMax = Bus.LayMaMaxBLL("PhieuNhapThietBi", "MaPhieuNhap");
            int Ma = Int32.Parse(MaMax.Substring(2));
            if (Ma < 9)
            {
                MaMoi = "PN0" + (Ma + 1).ToString();
            }
            else
            {
                MaMoi = "PN" + (Ma + 1).ToString();
            }
            return MaMoi;
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            LayDuLieu();
            if (action == "Them")
            {
                pntb.MaPhieuNhap = TaoMa();
                if (ThemMoiPhieuNhap() > 0)
                {
                    dtgListPhieuNhap.DataSource = Bus.PNTB_Select();
                    MessageBox.Show("Thêm mới phiếu nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới phiếu nhập thất bại!");
                }
            }
            if (action == "Sua")
            {
                pntb.MaPhieuNhap = MaPhieuNhap;
                if (CapNhatPhieuNhap() > 0)
                {
                    dtgListPhieuNhap.DataSource = Bus.PNTB_Select();
                    MessageBox.Show("Chỉnh sửa phiếu nhập thành công!");
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa phiếu nhập thất bại!");
                }
            }
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            action = "Them";
        }

        public int ThemMoiPhieuNhap()
        {
            int them = -1;
            frmDevice tbFrm = new frmDevice();
            ThietBi tb = new ThietBi();
            if (Bus.PNTB_Insert(pntb) > 0)
            {
                tb.MaNhaCungCap = pntb.MaNhaCungCap;
                tb.MaPhong = pntb.MaPhong;
                tb.TenTB = pntb.TenThietBi;
                if (tbFrm.ThemMoiThietBi(pntb.SoLuong, tb) > 0)
                {
                    them = 1;
                }
                else
                {
                    int resDel = Bus.PNTB_Delete(pntb.MaPhieuNhap);
                    them = -1;
                }
            }
            return them;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Bạn muốn xóa phiếu nhập thiết bị đã chọn?",
    "Xác nhận xóa phiếu nhập thiết bị",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);
            if (result2 == DialogResult.Yes)
            {
                if (Bus.PNTB_Delete(MaPhieuNhap) > 0)
                {
                    dtgListPhieuNhap.DataSource = Bus.PNTB_Select();
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Chưa xóa được thông tin phiếu nhập!");
                }

            }
        }

        private void dtgListPhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            cbTenCanBo.SelectedValue = dtgListPhieuNhap.CurrentRow.Cells[7].Value.ToString();
            txtTenNhaCungCap.Text = dtgListPhieuNhap.CurrentRow.Cells[2].Value.ToString();
            txtTenThietBi.Text = dtgListPhieuNhap.CurrentRow.Cells[3].Value.ToString();
            cbPhongMay.SelectedValue = dtgListPhieuNhap.CurrentRow.Cells[8].Value.ToString();
            txtSoLuong.Text = dtgListPhieuNhap.CurrentRow.Cells[5].Value.ToString();
            dtpNgayNhap.Text = dtgListPhieuNhap.CurrentRow.Cells[6].Value.ToString();
            MaPhieuNhap = dtgListPhieuNhap.CurrentRow.Cells[0].Value.ToString();
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            action = "Sua";
        }

        public int CapNhatPhieuNhap()
        {
            int sua = -1;
            if (Bus.PNTB_Update(pntb) >= 0)
            {
                sua = 1;
            }
            return sua;
        }

    }
}
