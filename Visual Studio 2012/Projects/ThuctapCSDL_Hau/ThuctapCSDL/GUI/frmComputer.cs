using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThuctapCSDL.ValueObject;
using ThuctapCSDL.BusinessLogicLayer;

namespace ThuctapCSDL
{
    public partial class frmComputer : Form
    {
        private bool edit;

        public frmComputer()
        {
            InitializeComponent();
            Load += FrmComputer_Load;
            dgvList.CellClick += DgvList_CellClick;
            tsbThem.Click += TsbThem_Click;
            tsbSua.Click += TsbSua_Click;
            tsbLuu.Click += TsbLuu_Click;
            tsbXoa.Click += TsbXoa_Click;
            tsbRefresh.Click += TsbRefresh_Click;
            btnTimKiem.Click += BtnTimKiem_Click;
        }

        public void KhoaDieuKhien()
        {
            txtMaMay.Enabled = false;
            txtTenMay.Enabled = false;
            txtCauHinh.Enabled = false;
            tsbXoa.Enabled = false;
            tsbSua.Enabled = false;
            tsbLuu.Enabled = false;
            cmbMaPhong.Enabled = false;
        }
        public void MoDieuKhien()
        {
            txtMaMay.Enabled = true;
            txtTenMay.Enabled = true;
            txtCauHinh.Enabled = true;
            cmbMaPhong.Enabled = true;
            tsbLuu.Enabled = true;
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMay.Text = dgvList.CurrentRow.Cells["MaMay"].Value.ToString();
            txtTenMay.Text = dgvList.CurrentRow.Cells["TenMay"].Value.ToString();
            txtCauHinh.Text = dgvList.CurrentRow.Cells["CauHinh"].Value.ToString();
            dtpDate.Text = dgvList.CurrentRow.Cells["NgayLapDat"].Value.ToString();
            rtbTinhTrang.Text = dgvList.CurrentRow.Cells["TinhTrang"].Value.ToString();
            cmbMaPhong.SelectedValue = dgvList.CurrentRow.Cells["MaPhong"].Value;

            KhoaDieuKhien();
            tsbSua.Enabled = true;
            tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                return;
            dgvList.DataSource = Bus.MT_search(txtTimKiem.Text);
        }

        private void TsbRefresh_Click(object sender, EventArgs e)
        {
            FormRefresh();
            dgvList.DataSource = Bus.MT_select();
        }

        private void TsbXoa_Click(object sender, EventArgs e)
        {
            if (txtMaMay.Text == "")
                return;
            if (MessageBox.Show("Xóa thông tin linh kiện đi kèm", "Xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int res = Bus.MT_delete(txtMaMay.Text);
                if (res < 0)
                {
                    MessageBox.Show("Đã xóa");
                    dgvList.DataSource = Bus.MT_select();
                    FormRefresh();
                }
                else MessageBox.Show("Thất bại");
            }
        }

        private void TsbLuu_Click(object sender, EventArgs e)
        {
            MayTinh mt = new MayTinh()
            {
                MaMay = txtMaMay.Text,
                TenMay = txtTenMay.Text,
                CauHinh = txtCauHinh.Text,
                MaPhong = cmbMaPhong.SelectedValue.ToString(),
                NgayLapDat = DateTime.Parse(dtpDate.Text),
                TinhTrang = rtbTinhTrang.Text
            };

            int res = 0;
            if (edit)
                res = Bus.MT_update(mt);
            else res = Bus.MT_insert(mt);

            if (res < 0)
            {
                MessageBox.Show("Đã cập nhật");
                dgvList.DataSource = Bus.MT_select();
                FormRefresh();
            }
            else MessageBox.Show("Thất bại");
        }

        private void TsbSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            edit = true;
            txtMaMay.Enabled = false;
        }

        private void TsbThem_Click(object sender, EventArgs e)
        {
            FormRefresh();
            MoDieuKhien();
            txtMaMay.Text = GetCode();
            edit = false;
        }

        #region Ma tu dong
        private string GetCode()
        {
            if (dgvList.Rows.Count == 1)
            {
                return "May_001";
            }
            List<string> dsMa = new List<string>();
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (row.Index < dgvList.Rows.Count - 1)
                    dsMa.Add(row.Cells["MaMay"].Value.ToString());
            }
            string sub = dsMa[0].Substring(0, dsMa[0].Length - 3);
            int i = 1;
            int count = 0;
            string s = string.Empty;
            while (count <= dsMa.Count)
            {
                s = sub;
                if (i < 10) s = s + "00" + i;
                else if (10 < i && i < 100) s = s + "0" + i;
                else if (i >= 100) s = s + i;
                int t = 0;
                for (t = 0; t < dsMa.Count; t++)
                {
                    if (dsMa[t].Contains(s))
                    {
                        break;
                    }
                }
                if (t == dsMa.Count)
                    break;
                else
                {
                    count++;
                    i++;
                }
            }
            return s;
        }
        #endregion

        #region Dieu khien
        private void FormRefresh()
        {
            txtMaMay.Text = string.Empty;
            txtTenMay.Text = string.Empty;
            txtCauHinh.Text = string.Empty;
            txtTimKiem.Text = string.Empty;
            rtbTinhTrang.Text = string.Empty;

            KhoaDieuKhien();
        }
        #endregion

        private void FrmComputer_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            dgvList.DataSource = Bus.MT_select();
            // load cmb phong may
            cmbMaPhong.DataSource = Bus.PM_select();
            cmbMaPhong.ValueMember = "MaPhong";
            cmbMaPhong.DisplayMember = "TenPhong";
            // load txt tim kiem
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (row.Index < dgvList.Rows.Count - 1)
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(row.Cells["MaMay"].Value.ToString());
                    txtTimKiem.AutoCompleteCustomSource.Add(row.Cells["TenMay"].Value.ToString());
                    txtTimKiem.AutoCompleteCustomSource.Add(row.Cells["CauHinh"].Value.ToString());
                    txtTimKiem.AutoCompleteCustomSource.Add(row.Cells["TinhTrang"].Value.ToString());
                    txtTimKiem.AutoCompleteCustomSource.Add(row.Cells["MaPhong"].Value.ToString());
                    txtTimKiem.AutoCompleteCustomSource.Add(row.Cells["NgayLapDat"].Value.ToString());
                }
            }          
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
