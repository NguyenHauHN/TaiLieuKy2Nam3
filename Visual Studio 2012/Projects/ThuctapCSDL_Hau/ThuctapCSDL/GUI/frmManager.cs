using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ThuctapCSDL.BusinessLogicLayer;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL
{
    public partial class frmManager : Form
    {
        bool themmoi;
        public frmManager()
        {
            InitializeComponent();
            txtPhone.Leave += TxtPhone_Leave;
            refresh.Click += Refresh_Click;
            dgvList.CellClick += dgvCB_CellClick;
            btnSearch.Click += BtnSearch_Click;
            txtPhone.Validating += TxtPhone_Validating;
        }

        private void TxtPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex rgxPhoneNumber = new Regex(@"^(0|\+84)1[0-9]{9}|(0|\+84)(9|8)[0-9]{8}$");
            if ((rgxPhoneNumber.IsMatch(txtPhone.Text) == false) || string.IsNullOrEmpty(txtPhone.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(txtPhone, "Số điện thoại không đúng định dạng!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtPhone, null);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                dgvList.DataSource = Bus.CB_search(txtSearch.Text);
                dgvList.Columns["MaCanBo"].HeaderText = "Mã cán bộ";
                dgvList.Columns["TenCanBo"].HeaderText = "Tên cán bộ";
                dgvList.Columns["DiaChi"].HeaderText = "Địa chỉ";
                dgvList.Columns["GioiTinh"].HeaderText = "Giới tính";
                dgvList.Columns["SoDT"].HeaderText = "Số điện thoại";
                dgvList.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            setnull();
            dgvList.DataSource = Bus.CB_select();
        }

        #region Ma tu dong
        private string GetCode()
        {
            if (dgvList.Rows.Count == 1)
                return "cb001";
            List<string> dsMa = new List<string>();
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (row.Index < dgvList.Rows.Count - 1)
                    dsMa.Add(row.Cells["MaCanBo"].Value.ToString());
            }
            string sub = dsMa[0].Substring(0, dsMa[0].Length - 3);
            int i = 1;
            int count = 0;
            string s = string.Empty;
            while (count <= dsMa.Count)
            {
                s = sub;
                if (i < 10)
                    s = s + "00" + i;
                else if (10 <= i && i < 100)
                    s = s + "0" + i;
                else if (i >= 100)
                    s = s + i;

                int t;
                for (t = 0; t < dsMa.Count; t++)
                {
                    if (dsMa[t].Contains(s))
                        break;
                }
                if (t < dsMa.Count)
                {
                    i++;
                    count++;
                }
                else break;
            }
            return s;
        }
        #endregion

        private void TxtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text != "")
            {
                if (txtPhone.Text.StartsWith("01") || txtPhone.Text.StartsWith("09"))
                    txtPhone.Text = "(+84) " + txtPhone.Text;
                else txtPhone.Text = "(03) " + txtPhone.Text;
            }
        }

        public void KhoaDieuKhien()
        {
            txtId.Enabled = false;
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtAddress.Enabled = false;
            dtpBirth.Enabled = false;
            rbtNam.Enabled = false;
            rbtNu.Enabled = false;
            edit.Enabled = false;
            delete.Enabled = false;
            btnLuu.Enabled = false;
        }

        public void MoDieuKhien()
        {
            txtId.Enabled = true;
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            txtAddress.Enabled = true;
            dtpBirth.Enabled = true;
            rbtNam.Enabled = true;
            rbtNu.Enabled = true;
            btnLuu.Enabled = true;
        }

        public void setnull()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        private void edit_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtId.Enabled = false;
            themmoi = false;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            Refresh_Click(sender, e);
            MoDieuKhien();
            setnull();
            themmoi = true;
            txtId.Text = GetCode();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            CanBo cb = new CanBo();
            cb.MaCB = txtId.Text;
            cb.TenCB = txtName.Text;
            cb.NgaySinh = dtpBirth.Value;
            cb.SoDT = txtPhone.Text;

            cb.DiaChi = txtAddress.Text;
            cb.GioiTinh = rbtNam.Checked ? "Nam" : "Nữ";
            if (MessageBox.Show("Xóa thông tin đi kèm", "Xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.CB_delete(txtId.Text) > 0)
                {
                    frmCanBo_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Không thành công !!");
                }
            }
        }

        private void Search()
        {
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            if (dgvList.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    if (row.Index < dgvList.Rows.Count - 1)
                    {
                        txtSearch.AutoCompleteCustomSource.Add(row.Cells[0].Value.ToString());
                        txtSearch.AutoCompleteCustomSource.Add(row.Cells[1].Value.ToString());
                        txtSearch.AutoCompleteCustomSource.Add(row.Cells[2].Value.ToString());
                        txtSearch.AutoCompleteCustomSource.Add(row.Cells[3].Value.ToString());
                        txtSearch.AutoCompleteCustomSource.Add(row.Cells[4].Value.ToString());
                    }
                }
            }
        }

        private void frmCanBo_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            dgvList.DataSource = Bus.CB_select();
            Search();

            dgvList.Columns["MaCanBo"].HeaderText = "Mã cán bộ";
            dgvList.Columns["TenCanBo"].HeaderText = "Tên cán bộ";
            dgvList.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvList.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvList.Columns["SoDT"].HeaderText = "Số điện thoại";
            dgvList.Columns["NgaySinh"].HeaderText = "Ngày sinh";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                CanBo cb = new CanBo()
                {
                    MaCB = txtId.Text,
                    TenCB = txtName.Text,
                    NgaySinh = dtpBirth.Value,
                    SoDT = txtPhone.Text,

                    DiaChi = txtAddress.Text,
                    GioiTinh = rbtNam.Checked ? "Nam" : "Nữ",
                };

                int res = 0;
                if (themmoi)
                    res = Bus.CB_insert(cb);
                else res = Bus.CB_update(cb);

                if (res > 0)
                {
                    MessageBox.Show("Đã cập nhật");
                    Refresh_Click(sender, e);
                    KhoaDieuKhien();
                }
                else MessageBox.Show("Thất bại");
            }
        }

        private void dgvCB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvList.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dgvList.CurrentRow.Cells[2].Value.ToString();
            if (dgvList.CurrentRow.Cells[3].Value.ToString().Equals("Nam"))
                rbtNam.Checked = true;
            else rbtNu.Checked = true;
            txtPhone.Text = dgvList.CurrentRow.Cells[4].Value.ToString();
            dtpBirth.Text = dgvList.CurrentRow.Cells[5].Value.ToString();

            KhoaDieuKhien();
            edit.Enabled = true;
            delete.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void home_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
