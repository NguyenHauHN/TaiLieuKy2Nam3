using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThuctapCSDL.BusinessLogicLayer;
using ThuctapCSDL.ValueObject;
namespace ThuctapCSDL
{
    public partial class frmCompAccessories : Form
    {
        public frmCompAccessories()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            dgvList.CellClick += ListLK_CellClick;
            tsbRefresh.Click += TsbRefresh_Click;
        }

        private void TsbRefresh_Click(object sender, EventArgs e)
        {
            LinhKien_Load(sender, e);
            setnull();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "")
            {
                dgvList.DataSource = Bus.LK_search(txtTimKiem.Text);
            }
        }

        private bool themmoi;

        #region Mã tự động
        private string GetCode()
        {
            if (dgvList.Rows.Count == 1)
                return "LK001";

            List<string> dsMa = new List<string>();
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (row.Index < dgvList.Rows.Count - 1)
                    dsMa.Add(row.Cells["MaLinhKien"].Value.ToString());
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

        public void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtTinhTrang.Enabled = false;
            cmbMaMay.Enabled = false;
            tsbSua.Enabled = false;
            tsbXoa.Enabled = false;
            tsbLuu.Enabled = false;
        }

        public void MoDieuKhien()
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtTinhTrang.Enabled = true;
            cmbMaMay.Enabled = true;
            tsbLuu.Enabled = true;
        }

        void setnull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtTinhTrang.Text = "";
            txtTimKiem.Text = string.Empty;
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            MoDieuKhien();
            setnull();
            txtMa.Text = GetCode();
            themmoi = true;
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMa.Enabled = false;
            themmoi = false;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
                return;
            if (MessageBox.Show("Xóa thông tin đi kèm", "Xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int res = Bus.LK_delete(txtMa.Text);
                if (res > 0)
                {
                    MessageBox.Show("Đã xóa");
                    LoadDgvList();
                    setnull();
                }
                else MessageBox.Show("Thất bại");
            }
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                LinhKienMT pm = new LinhKienMT()
                {
                    MaLinhKien = txtMa.Text,
                    TenLinhKien = txtTen.Text,
                    TinhTrang = txtTinhTrang.Text,
                    MaMay = cmbMaMay.Text,
                };

                int res = 0;
                if (themmoi)
                    res = Bus.LK_insert(pm);
                else res = Bus.LK_update(pm);

                if (res > 0)
                {
                    MessageBox.Show("Đã cập nhật");
                    LoadDgvList();
                    setnull();
                }
                else MessageBox.Show("Thất bại");
            }
        }

        private void ListLK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvList.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
            txtTinhTrang.Text = dgvList.CurrentRow.Cells[2].Value.ToString();
            cmbMaMay.SelectedValue = dgvList.CurrentRow.Cells[3].Value;
            KhoaDieuKhien();
            tsbLuu.Enabled = false;
            tsbSua.Enabled = true;
            tsbXoa.Enabled = true;
        }

        private void Search()
        {
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            if (dgvList.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    if (row.Index < dgvList.Rows.Count - 1)
                    {
                        txtTimKiem.AutoCompleteCustomSource.Add(row.Cells["MaLinhKien"].Value.ToString());
                        txtTimKiem.AutoCompleteCustomSource.Add(row.Cells["TenLinhKien"].Value.ToString());
                        txtTimKiem.AutoCompleteCustomSource.Add(row.Cells["TinhTrang"].Value.ToString());
                        txtTimKiem.AutoCompleteCustomSource.Add(row.Cells["MaMay"].Value.ToString());
                    }
                }
            }
        }

        private void LoadDgvList()
        {
            dgvList.DataSource = Bus.LK_select();
            dgvList.Columns["MaLinhKien"].HeaderText = "Mã linh kiện";
            dgvList.Columns["TenLinhKien"].HeaderText = "Tên linh kiện";
            dgvList.Columns["TinhTrang"].HeaderText = "Tình trạng";
            dgvList.Columns["MaMay"].HeaderText = "Mã máy";
        }

        private void LinhKien_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            LoadDgvList();

            // load cmb Manager code
            cmbMaMay.DataSource = Bus.MT_select();
            cmbMaMay.ValueMember = "MaMay";
            cmbMaMay.DisplayMember = "MaMay";

            // tìm kiếm
            Search();
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
