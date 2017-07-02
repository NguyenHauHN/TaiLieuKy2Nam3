using System.Windows.Forms;
using ThuctapCSDL.DataAccessLayer;
using ThuctapCSDL.BusinessLogicLayer;

namespace ThuctapCSDL.GUI
{
    public enum ThongKe
    {
        SuaChua,
        ThanhLy,
        Khong
    }

    public partial class frmReport : Form
    {
        private ThongKe type;

        public frmReport()
        {
            InitializeComponent();
            type = ThongKe.Khong;
            Load += FrmReport_Load;
            chbSuaChua.CheckedChanged += ChbSuaChua_CheckedChanged;
            chbThanhLy.CheckedChanged += ChbThanhLy_CheckedChanged;
            rdbTinhTrang.CheckedChanged += RdbTinhTrang_CheckedChanged;
            rdbCanBo.CheckedChanged += RdbCanBo_CheckedChanged;
            btnXem.Click += BtnXem_Click;
            btnPrint.Click += BtnPrint_Click;
        }

        private void BtnPrint_Click(object sender, System.EventArgs e)
        {
            if (dgvList.Rows.Count > 1)
            {
                Export ex = new Export();
                ex.Print(dgvList);
            }
        }

        private void RdbCanBo_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rdbCanBo.Checked)
                txtMaCanBo.Enabled = true;
            else txtMaCanBo.Enabled = false;
        }

        private void RdbTinhTrang_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rdbTinhTrang.Checked)
                cmbTinhTrang.Enabled = true;
            else cmbTinhTrang.Enabled = false;
        }

        private void BtnXem_Click(object sender, System.EventArgs e)
        {
            string MaPhong = cmbPhongMay.SelectedValue.ToString();
            string MaCanBo = txtMaCanBo.Text;
            switch (type)
            {
                case ThongKe.Khong:
                    if (cmbChon.Text == "Máy tính")
                        dgvList.DataSource = MayTinhDAL.SelectByRoomCode(MaPhong);
                    else
                        dgvList.DataSource = ThietBi_DAL.SelectByRoomCode(MaPhong);
                    break;

                case ThongKe.SuaChua:
                    if (cmbChon.Text == "Máy tính")
                    {
                        if (rdbCanBo.Checked)
                            dgvList.DataSource = Report.ReportingRepairment("scmt_reportByManagerID", MaPhong, MaCanBo);
                        else if (rdbNgay.Checked)
                            dgvList.DataSource = Report.ReportingRepairment("scmt_reportByRepairingDate", MaPhong);
                        else if (rdbTinhTrang.Checked)
                        {
                            if (cmbTinhTrang.Text == "Đang sửa chữa")
                                dgvList.DataSource = Report.ReportingRepairment("scmt_reportByRepairingState", MaPhong);
                            else if (cmbTinhTrang.Text == "Đã sửa")
                                dgvList.DataSource = Report.ReportingRepairment("scmt_reportByRepairedState", MaPhong);
                        }
                    }
                    else
                    {
                        if (rdbCanBo.Checked)
                            dgvList.DataSource = Report.ReportingRepairment("sctb_reportByManagerID", MaPhong, MaCanBo);
                        else if (rdbNgay.Checked)
                            dgvList.DataSource = Report.ReportingRepairment("sctb_reportByRepairingDate", MaPhong);
                        else if (rdbTinhTrang.Checked)
                        {
                            if (cmbTinhTrang.Text == "Đang sửa chữa")
                                dgvList.DataSource = Report.ReportingRepairment("sctb_reportByRepairingState", MaPhong);
                            else if (cmbTinhTrang.Text == "Đã sửa")
                                dgvList.DataSource = Report.ReportingRepairment("sctb_reportByRepairedState", MaPhong);
                        }
                    }
                    break;

                case ThongKe.ThanhLy:
                    if (rdbCanBo.Checked)
                        dgvList.DataSource = Report.ReportingSale("phieuTL_reportByManagerID",MaCanBo);
                    else if (rdbNgay.Checked)
                        dgvList.DataSource = Report.ReportingSale("phieuTL_reportBySellingDate");
                    break;

                default:
                    break;
            }
            lblTong.Text = "Tổng số " + (dgvList.Rows.Count - 1) + " bản ghi";
        }

        private void ChbThanhLy_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbThanhLy.Checked)
            {
                type = ThongKe.ThanhLy;
                chbSuaChua.Checked = false;
                rdbTinhTrang.Enabled = false;
                rdbTinhTrang.Checked = false;
                rdbCanBo.Checked = false;
                groupBox1.Enabled = true;
            }
        }

        private void ChbSuaChua_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbSuaChua.Checked)
            {
                type = ThongKe.SuaChua;
                chbThanhLy.Checked = false;
                rdbTinhTrang.Enabled = true;
                groupBox1.Enabled = true;
            }
        }

        private void FrmReport_Load(object sender, System.EventArgs e)
        {
            cmbPhongMay.DataSource = PhongMay_DAL.Select();
            cmbPhongMay.DisplayMember = "Tên phòng";
            cmbPhongMay.ValueMember = "Mã phòng";

            groupBox1.Enabled = false;
            rdbTinhTrang.Enabled = false;
            cmbTinhTrang.Enabled = false;
        }

        private void chbNhap_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbNhap.Checked == true)
            {
                dgvList.DataSource = Bus.LayDSThietBiNhap(cmbPhongMay.SelectedValue.ToString());
            }
        }

    
    }
}
