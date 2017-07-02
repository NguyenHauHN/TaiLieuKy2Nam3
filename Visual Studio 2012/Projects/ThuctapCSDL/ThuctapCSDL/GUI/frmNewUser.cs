using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ThuctapCSDL.DataAccessLayer;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
            txtTenTaiKhoan.Validating += TxtTenTaiKhoan_Validating;
            txtXacNhan.Validating += TxtXacNhan_Validating;
            txtMaCanBo.Validating += TxtMaCanBo_Validating;
            txtMatKhau.Validating += TxtMatKhau_Validating;
            txtDapAn.Validating += TxtDapAn_Validating;
            btnHuy.Click += BtnHuy_Click;
        }

        private void TxtMatKhau_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                e.Cancel = true;
                txtMatKhau.Focus();
                errorProvider.SetError(txtMatKhau, "Invalid password!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtMatKhau, null);
            }
        }

        private void TxtDapAn_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtDapAn.Text == "")
            {
                e.Cancel = true;
                txtDapAn.Focus();
                errorProvider.SetError(txtDapAn, "Please answer the following question!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDapAn, null);
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtMaCanBo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtMaCanBo.Text == "")
            {
                e.Cancel = true;
                txtMaCanBo.Focus();
                errorProvider.SetError(txtMaCanBo, "Please select a manager code!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtMaCanBo, null);
            }
        }

        private void TxtXacNhan_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtXacNhan.Text == "" || !txtXacNhan.Text.Equals(txtMatKhau.Text))
            {
                e.Cancel = true;
                txtXacNhan.Focus();
                errorProvider.SetError(txtXacNhan, "Validation error!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtXacNhan, null);
            }
        }

        private void TxtTenTaiKhoan_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtTenTaiKhoan.Text == "" || dsNguoiDung.Find(x => x.TaiKhoan == txtTenTaiKhoan.Text) != null)
            {
                e.Cancel = false;
                txtTenTaiKhoan.Focus();
                errorProvider.SetError(txtTenTaiKhoan, "Tên tài khoản không hợp lệ!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTenTaiKhoan, null);
            }
        }

        private List<NguoiDung> dsNguoiDung;

        private void formUser_Load(object sender, EventArgs e)
        {
            dsNguoiDung = NguoiDung_DAL.GetUserList();
            txtMaCanBo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMaCanBo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            foreach (DataRow row in CanBo_DAL.Select().Rows)
                txtMaCanBo.AutoCompleteCustomSource.Add(row.Field<string>("MaCanBo"));
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            NguoiDung nd = new NguoiDung()
            {
                TaiKhoan = txtTenTaiKhoan.Text,
                MatKhau = txtMatKhau.Text,
                TenNguoiDung = txtTenNguoiDung.Text,
                MaCanBo = txtMaCanBo.Text,
                CauHoi = cmbCauHoi.Text,
                DapAn = txtDapAn.Text
            };
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (NguoiDung_DAL.Insert(nd) > 0)
                {
                    MessageBox.Show("Đã thêm", "Message");
                    Close();
                }
                else MessageBox.Show("Thất bại");
            }
        }
    }
}
