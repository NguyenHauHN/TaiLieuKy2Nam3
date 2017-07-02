using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ThuctapCSDL.BusinessLogicLayer;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.GUI
{
    public partial class frmSupplier : Form
    {
        private bool edit;

        public frmSupplier()
        {
            InitializeComponent();
            LockControls();
            Load += FrmSupplier_Load;
            tsAdd.Click += TsAdd_Click;
            tsUpdate.Click += TsUpdate_Click;
            tsSave.Click += TsSave_Click;
            tsDelete.Click += TsDelete_Click;
            tsRefresh.Click += TsRefresh_Click;
            btnSearch.Click += BtnSearch_Click;
            txtPhoneNumber.Validating += TxtPhoneNumber_Validating;
        }

        private void TxtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex rgxPhoneNumber = new Regex(@"^(0|\+84)1[0-9]{9}|(0|\+84)(9|8)[0-9]{8}$");
            if (txtPhoneNumber.Text != "" && (rgxPhoneNumber.IsMatch(txtPhoneNumber.Text) == false) || string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(txtPhoneNumber, "Số điện thoại không đúng định dạng!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPhoneNumber, null);
            }
        }

        #region Ma tu dong
        public string GetCode()
        {
            string MaMoi;
            string MaMax = Bus.LayMaMaxBLL("NhaCungCap", "MaNhaCC");
            int Ma = Int32.Parse(MaMax.Substring(3));
            if (Ma < 9)
            {
                MaMoi = "NCC0" + (Ma + 1).ToString();
            }
            else
            {
                MaMoi = "NCC" + (Ma + 1).ToString();
            }
            return MaMoi;
        }
        #endregion

        private void BtnSearch_Click(object sender, System.EventArgs e)
        {
            if (txtSearch.Text != "")
                dgvListProviders.DataSource = Bus.NCC_Search(txtSearch.Text);
        }

        private void TsRefresh_Click(object sender, System.EventArgs e)
        {
            FrmSupplier_Load(sender, e);
            LockControls();
            RefreshForm();
            tsAdd.Enabled = true;
            tsDelete.Enabled = true;
            tsUpdate.Enabled = true;
            tsSave.Enabled = false;
        }

        private void TsDelete_Click(object sender, System.EventArgs e)
        {
            tsAdd.Enabled = false;
            tsUpdate.Enabled = false;
            tsSave.Enabled = false;
                 
            if (txtCode.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn thông tin nhà cung cấp cần xóa.",
"Thông bào",
MessageBoxButtons.OK,
MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result2 = MessageBox.Show("Bạn chắc chắn muốn xóa tất cả thông tin cung cấp thiết bị  khỏi cơ sở dữ liệu?",
    "Xác nhận xóa",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);
                if (result2 == DialogResult.Yes)
                {
                        int res = Bus.NCC_delete(txtCode.Text);
                        if (res > 0)
                        {
                            MessageBox.Show("Đã xóa tất cả thông tin nhà cung cấp  khỏi cơ sở dữ liệu!",
        "Thông báo", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
                            RefreshForm();
                            LockControls();
                            FrmSupplier_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Chưa xóa được thông tin nhà cung cấp!",
        "Thông báo", MessageBoxButtons.OK,
            MessageBoxIcon.Error);
                            RefreshForm();
                            LockControls();
                        }

                    }
                  
                }


            }
           
        private void TsSave_Click(object sender, System.EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            NhaCungCap ncc = new NhaCungCap()
            {
                MaNhaCC = txtCode.Text,
                TenNhaCC = txtName.Text,
                DiaChi = txtAddress.Text,
                SDT = txtPhoneNumber.Text
            };
            if (edit)
            {
                int resUpdate = Bus.NCC_update(ncc);
                if (resUpdate > 0)
                {
                    MessageBox.Show("Cập nhật thành công nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshForm();
                    LockControls();
                    FrmSupplier_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Chưa cập nhật được nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {

                int  resInsert = Bus.NCC_insert(ncc);
                if (resInsert > 0)
                {
                    MessageBox.Show("Thêm mới thành công nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshForm();
                    LockControls();
                    FrmSupplier_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Chưa thêm mới thành công nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
           
        }

        private void TsUpdate_Click(object sender, System.EventArgs e)
        {
            edit = true;
            UnlockControls();
            txtCode.Enabled = false;
            tsAdd.Enabled = false;
            tsDelete.Enabled = false;
            
        }

        private void TsAdd_Click(object sender, System.EventArgs e)
        {
            edit = false;
            RefreshForm();
            UnlockControls();
            txtCode.Text = GetCode();
            tsDelete.Enabled = false;
            tsUpdate.Enabled = false;
        }

        private void FrmSupplier_Load(object sender, System.EventArgs e)
        {
            dgvListProviders.DataSource = Bus.NCC_Select();

            dgvListProviders.Columns["MaNhaCC"].HeaderText = "Mã nhà cung cấp";
            dgvListProviders.Columns["TenNhaCC"].HeaderText = "Tên nhà cung cấp";
            dgvListProviders.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvListProviders.Columns["SoDT"].HeaderText = "Số điện thoại";
        }

        #region Controls
      
        private void LockControls()
        {
            txtName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtAddress.Enabled = false;
            tsDelete.Enabled = true;
            tsSave.Enabled = false;
            tsUpdate.Enabled = true;

        }

        public void UnlockControls()
        {
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtPhoneNumber.Enabled = true;
            tsSave.Enabled = true;
        }

        private void RefreshForm()
        {
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }
        #endregion

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            dgvListProviders.DataSource = Bus.NCC_Search(txtSearch.Text);

            dgvListProviders.Columns["MaNhaCC"].HeaderText = "Mã nhà cung cấp";
            dgvListProviders.Columns["TenNhaCC"].HeaderText = "Tên nhà cung cấp";
            dgvListProviders.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvListProviders.Columns["SoDT"].HeaderText = "Số điện thoại";
        }

        private void dgvListProviders_SelectionChanged(object sender, System.EventArgs e)
        {
            txtCode.Text = dgvListProviders.CurrentRow.Cells["MaNhaCC"].Value.ToString();
            txtName.Text = dgvListProviders.CurrentRow.Cells["TenNhaCC"].Value.ToString();
            txtAddress.Text = dgvListProviders.CurrentRow.Cells["DiaChi"].Value.ToString();
            txtPhoneNumber.Text = dgvListProviders.CurrentRow.Cells["SoDT"].Value.ToString();
            tsDelete.Enabled = true;
            tsUpdate.Enabled = true;
            tsSave.Enabled = false;
        }

      
    }
}
