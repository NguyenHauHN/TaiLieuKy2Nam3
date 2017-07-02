using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThuctapCSDL.BusinessLogicLayer;
using ThuctapCSDL.ValueObject;
namespace ThuctapCSDL
{
    public partial class frmDevice : Form
    {
        public frmDevice()
        {
            InitializeComponent();
            tsbRefresh.Click += TsbRefresh_Click;
        }

        private void TsbRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private bool themmoi;

        #region Ma tu dong
        public string GetCode()
        {
            string MaMoi;
            string MaMax = Bus.LayMaMaxBLL("ThietBi", "MaTB");
            int Ma = Int32.Parse(MaMax.Substring(2));
            if (Ma < 9)
            {
                 MaMoi = "TB0" + (Ma + 1).ToString();
            }
            else
            {
                 MaMoi = "TB" + (Ma + 1).ToString();
            }
            return MaMoi;
        }
        #endregion

        public void ThayDoiTrangThai(bool TrangThai)
        {
            txtTen.Enabled = TrangThai;
            cmbLoaiTB.Enabled = TrangThai;
            cmbMaPhong.Enabled = TrangThai;
            rtbTinhTrang.Enabled = TrangThai;
        }

        public void Refresh()
        {
            dgvList.DataSource = Bus.TB_select();

            ThayDoiTrangThai(false);

            tsbLuu.Enabled = false;
            tsbSua.Enabled = true;
            tsbThem.Enabled = true;
            tsbXoa.Enabled = true;

            XoaTextBox();

            cmbLoaiTB.DataSource = Bus.LoaiThietBi_select();
            cmbLoaiTB.DisplayMember = "Tên loại thiết bị";
            cmbLoaiTB.ValueMember = "Mã loại thiết bị";

            cmbMaPhong.DataSource = Bus.PM_select();
            cmbMaPhong.ValueMember = "MaPhong";
            cmbMaPhong.DisplayMember = "TenPhong";

        }

        public void XoaTextBox()
        {
            txtTen.Text = "";
            txtMa.Text = "";
            txtTimKiem.Text = "";
            rtbTinhTrang.Text = "";

        }
    

        private void tsbThem_Click(object sender, EventArgs e)
        {
            ThayDoiTrangThai(true);
            tsbLuu.Enabled = true;
            tsbSua.Enabled = false;
            tsbXoa.Enabled = false;
            txtMa.Text = GetCode();
            themmoi = true;
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            ThayDoiTrangThai(true);
            txtMa.Enabled = false;
            themmoi = false;
            tsbXoa.Enabled = false;
            tsbThem.Enabled = false;
            tsbLuu.Enabled = true;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            tsbLuu.Enabled = false;
            tsbSua.Enabled = false;
            tsbThem.Enabled = false;

            if (txtMa.Text != "")
            {
                DialogResult resultDelete = MessageBox.Show("Bạn chắc chắn muốn xóa tất cả thông tin thiết bị  khỏi cơ sở dữ liệu?",
    "Xác nhận xóa",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);
                if (resultDelete == DialogResult.Yes)
                {
                    int res = Bus.TB_delete(txtMa.Text);
                    if (res > 0)
                    {
                        MessageBox.Show("Đã xóa thông tin thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Chưa xóa được thông tin thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thông tin thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
          
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hoặc chọn thông tin thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                ThietBi ptb = new ThietBi()
                {
                    MaTB = txtMa.Text,
                    TenTB = txtTen.Text,
                    MaLoaiTB = cmbLoaiTB.SelectedValue.ToString(),
                    TinhTrang = rtbTinhTrang.Text,
                    MaPhong = cmbMaPhong.SelectedValue.ToString(),
                };
                if (!themmoi)
                {
                    int resUpdate = Bus.TB_update(ptb);
                    if (resUpdate > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Chưa cập nhật được thông tin thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    int resInsert = Bus.TB_insert(ptb);
                    if (resInsert > 0)
                    {
                        MessageBox.Show("Thêm mới thông tin thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Chưa thêm mới thông tin thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvList.DataSource = Bus.TB_search(txtTimKiem.Text);
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            txtMa.Text = dgvList.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
            rtbTinhTrang.Text = dgvList.CurrentRow.Cells[2].Value.ToString();
            cmbLoaiTB.SelectedValue = dgvList.CurrentRow.Cells[3].Value;
            cmbMaPhong.SelectedValue = dgvList.CurrentRow.Cells[4].Value;
        }

    }
}
