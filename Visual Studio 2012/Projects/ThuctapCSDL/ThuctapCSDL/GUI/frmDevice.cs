using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThuctapCSDL.BusinessLogicLayer;
using ThuctapCSDL.ValueObject;
namespace ThuctapCSDL
{
    public partial class frmDevice : Form
    {
        ThietBi tb = new ThietBi();
        private string action;
        private string MaTB;
        public frmDevice()
        {
            InitializeComponent();
        }

        private void frmDevice_Load(object sender, EventArgs e)
        {
            dgvList.DataSource = Bus.TB_select();
            this.dgvList.Columns[0].Visible = false;
            this.dgvList.Columns[4].Visible = false;
            this.dgvList.Columns[5].Visible = false;
            // khoi tao gia tri cho combobox
            cmbMaPhong.DataSource = Bus.PM_select();
            cmbMaPhong.ValueMember = "Mã phòng";
            cmbMaPhong.DisplayMember = "Tên phòng";

            cmbNhaCungCap.DataSource = Bus.NCC_Select();
            cmbNhaCungCap.ValueMember = "Mã nhà cung cấp";
            cmbNhaCungCap.DisplayMember = "Tên nhà cung cấp";
        }

        public void LayDuLieu()
        {
            tb.TenTB = txtTenThietBi.Text;
            if (txtSoLuong.Text != "")
            {
                tb.SoLuong = Int32.Parse(txtSoLuong.Text);
            }
            else
            {
                tb.SoLuong = 0;
            }
            tb.MaPhong = cmbMaPhong.SelectedValue.ToString();
            tb.MaNhaCungCap = cmbNhaCungCap.SelectedValue.ToString();
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            action = "Them";

        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            LayDuLieu();
            if (action == "Them")
            {
                if (ThemMoiThietBi(tb.SoLuong, tb) > 0)
                {
                    dgvList.DataSource = Bus.TB_select();
                    MessageBox.Show("Thêm mới thiết bị thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm mới thiết bị thất bại!");
                }
            }
            if (action == "Sua")
            {
                tb.MaTB = MaTB;
                if (CapNhatThietBi() > 0)
                {
                    dgvList.DataSource = Bus.TB_select();
                    MessageBox.Show("Cập nhật thiết bị thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thiết bị thất bại!");
                }
            }
        }

        public int ThemMoiThietBi(int SoLuong, ThietBi tbMoi)
        {
            int them = -1;
            string command = "insert into ThietBi values";
            for (int i = 0; i < SoLuong; i++)
            {
                if (i == SoLuong - 1)
                {
                    command += "(N'" + tbMoi.TenTB + "','" + tbMoi.MaPhong + "','" + tbMoi.MaNhaCungCap + "',null);";
                }
                else
                {
                    command += "(N'" + tbMoi.TenTB + "','" + tbMoi.MaPhong + "','" + tbMoi.MaNhaCungCap + "',null),"; 
                }
            }
            if (Bus.TB_insert(command) > 0)
            {
                them = 1;
            }
                return them;
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            action = "Sua";
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Bạn muốn xóa  thiết bị đã chọn?",
    "Xác nhận xóa",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);
            if (result2 == DialogResult.Yes)
            {
                if (Bus.TB_delete(Int32.Parse(MaTB), txtTenThietBi.Text) > 0)
                {

                    dgvList.DataSource = Bus.TB_select();
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Chưa xóa được thông tin thiết bị!");
                }

            }
        }

        public int CapNhatThietBi()
        {
            int sua = -1;
            if (Bus.TB_update(tb) > 0)
            {
                sua = 1;
            }
            return sua;
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            MaTB = dgvList.CurrentRow.Cells[0].Value.ToString();
            txtTenThietBi.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
            cmbMaPhong.SelectedValue = dgvList.CurrentRow.Cells[4].Value.ToString();
            cmbNhaCungCap.SelectedValue = dgvList.CurrentRow.Cells[5].Value.ToString();
        }

        

        


    }
}
