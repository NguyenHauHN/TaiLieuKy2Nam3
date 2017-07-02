using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThuctapCSDL.BusinessLogicLayer;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL
{
    public partial class frmDeviceType : Form
    {
        private bool edit;

        public frmDeviceType()
        {
            InitializeComponent();
        }

        #region Ma tu dong
        private string GetCode()
        {
            string MaMoi;
            string MaMax = Bus.LayMaMaxBLL("LoaiThietBi", "MaLoaiTB");
            int Ma = Int32.Parse(MaMax.Substring(3));
            if (Ma < 9)
            {
                MaMoi = "LTB0" + (Ma + 1).ToString();
            }
            else
            {
                MaMoi = "LTB" + (Ma + 1).ToString();
            }
            return MaMoi;
        }
        #endregion

        public void ThayDoiTrangThai(bool TrangThai)
        {
            txtName.Enabled = TrangThai;
        }

        public void Refresh()
        {
            txtCode.Text = "";
            txtName.Text = "";
            tsSave.Enabled = false;
            dgvListDeviceType.DataSource = Bus.LoaiThietBi_select();
        }

        private void dgvListDeviceType_SelectionChanged(object sender, EventArgs e)
        {
            txtCode.Text = dgvListDeviceType.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvListDeviceType.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvListDeviceType.DataSource = Bus.LoaiThietBi_search(txtSearch.Text);
        }

        private void frmDeviceType_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            edit = false;
            ThayDoiTrangThai(true);
            txtCode.Text = GetCode();
            tsDelete.Enabled = false;
            tsUpdate.Enabled = false;
            tsSave.Enabled = true;
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hoặc nhập thông tin loại thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoaiThietBi ltb = new LoaiThietBi
            {
                MaLoaiThietBi = txtCode.Text,
                TenLoaiThietBi = txtName.Text
            };
            if (edit)
            {
                int resUpdate = Bus.LoaiThietBi_update(ltb);
                if (resUpdate > 0)
                {
                    MessageBox.Show("Cập nhật thông tin loại thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Chưa cập nhật được thông tin loại thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                int resInsert = Bus.LoaiThietBi_insert(ltb);
                if (resInsert > 0)
                {
                    MessageBox.Show("Thêm mới thông tin loại thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                }
                else
                {
                    MessageBox.Show("Chưa thêm mới được thông tin loại thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsUpdate_Click(object sender, EventArgs e)
        {
            edit = true;
            ThayDoiTrangThai(true);
            tsSave.Enabled = true;
            tsDelete.Enabled = false;
            tsAdd.Enabled = false;
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            tsSave.Enabled = false;
            tsUpdate.Enabled = false;
            tsAdd.Enabled = false;
            if (txtCode.Text != "")
            {
                DialogResult resultDelete = MessageBox.Show("Bạn chắc chắn muốn xóa tất cả thông tin loại thiết bị  khỏi cơ sở dữ liệu?",
    "Xác nhận xóa",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);
                if (resultDelete == DialogResult.Yes)
                {
                    int res = Bus.LoaiThietBi_delete(txtCode.Text);
                    if (res > 0)
                    {
                        MessageBox.Show("Đã xóa thông tin loại thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refresh();
                    }
                    else
                    {
                        MessageBox.Show("Chưa xóa được thông tin loại thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thông tin loại thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tsRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            txtCode.Text = "";
            txtName.Text = "";
            txtName.Enabled = false;
            tsAdd.Enabled = true;
            tsDelete.Enabled = true;
            tsUpdate.Enabled = true;
            tsSave.Enabled = false;
        }
    }
}