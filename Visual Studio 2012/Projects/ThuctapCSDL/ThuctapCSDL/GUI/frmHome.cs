using System;
using System.Windows.Forms;
using ThuctapCSDL.BusinessLogicLayer;
using ThuctapCSDL.GUI;

namespace ThuctapCSDL
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewUser nd = new frmNewUser();
            nd.ShowDialog();
        }

        private void linhKiệnMáyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompAccessories lk = new frmCompAccessories();
            lk.ShowDialog();
        }

        private void máyTínhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmComputer f = new frmComputer();
            f.ShowDialog();
        }

        private void phòngMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompRoom mt = new frmCompRoom();
            mt.ShowDialog();
        }

        private void phiếuThanhLíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeviceSale tl = new frmDeviceSale();
            tl.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = Bus.MT_select();
            dgvList.Columns["MaPhong"].HeaderText = "Mã phòng";
            dgvList.Columns["MaMay"].HeaderText = "Mã máy";
            dgvList.Columns["TenMay"].HeaderText = "Tên máy";
            dgvList.Columns["TinhTrang"].HeaderText = "Tình trạng";
            dgvList.Columns["CauHinh"].HeaderText = "Cấu hình";
            dgvList.Columns["NgayLapDat"].HeaderText = "Ngày lắp đặt";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = Bus.PSC_select();
            dgvList.Columns["MaPhieu"].HeaderText = "Mã phiếu";
            dgvList.Columns["MaCanBo"].HeaderText = "Mã cán bộ";
            dgvList.Columns["NoiDung"].HeaderText = "Nội dung";
            dgvList.Columns["NgaySua"].HeaderText = "Ngày sửa";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = Bus.TL_Select();
            dgvList.Columns["MaPhieuTL"].HeaderText = "Mã phiếu TL";
            dgvList.Columns["MaCanBo"].HeaderText = "Mã cán bộ";
            dgvList.Columns["NgayTL"].HeaderText = "Ngày TL";
            dgvList.Columns["SoTienTL"].HeaderText = "Số tiền TL";
            dgvList.Columns["MaMay"].HeaderText = "Mã máy";
            dgvList.Columns["MaTB"].HeaderText = "Mã thiết bị";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = Bus.TB_select();
            dgvList.Columns["MaTB"].HeaderText = "Mã thiết bị";
            dgvList.Columns["TenTB"].HeaderText = "Tên thiết bị";
            dgvList.Columns["MaPhong"].HeaderText = "Mã phòng";
            dgvList.Columns["MaLoaiTB"].HeaderText = "Mã loại thiết bị";
            dgvList.Columns["TinhTrang"].HeaderText = " Tình trạng";
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sửaChữaThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepair sc = new frmRepair();
            sc.ShowDialog();
        }

        private void cánBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManager cb = new frmManager();
            cb.ShowDialog();
        }

        private void phòngMáyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCompRoom cr = new frmCompRoom();
            cr.ShowDialog();
        }

        private void mstLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mstThongKe_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.ShowDialog();
        }

        private void mstNhaCungCap_Click(object sender, EventArgs e)
        {
            frmSupplier ncc = new frmSupplier();
            ncc.ShowDialog();
        }

        private void mstThietBi_Click(object sender, EventArgs e)
        {
            frmDevice frmtb = new frmDevice();
            frmtb.ShowDialog();
        }

        private void mstPhieuNhap_Click(object sender, EventArgs e)
        {
            frmImportDevice pntb = new frmImportDevice();
            pntb.ShowDialog();
        }

     
    }
}
