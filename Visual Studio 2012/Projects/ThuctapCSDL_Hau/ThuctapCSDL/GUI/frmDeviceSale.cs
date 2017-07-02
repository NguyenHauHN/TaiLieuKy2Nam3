using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ThuctapCSDL.BusinessLogicLayer;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL.GUI
{
    public partial class frmDeviceSale : Form
    {
        public frmDeviceSale()
        {
            InitializeComponent();
            dgvList.CellClick += dgvTL_CellClick;
            Load += ThanhliTB_Load;
            tsbThem.Click += tsbThem_Click;
            tsbXoa.Click += tsbXoa_Click;
            tsbSua.Click += tsbSua_Click;
            tsbLuu.Click += tsbLuu_Click;
            tsbHome.Click += tsbHome_Click;
            btnSearch.Click += BtnSearch_Click;
            tsbRefresh.Click += TsbRefresh_Click;
            txtTien.Validating += TxtTien_Validating;
        }

        private void TxtTien_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtTien.Text) || !txtTien.Text.IsNumber())
            {
                e.Cancel = false;
                errorProvider.SetError(txtTien, "Nhập dữ liệu không đúng!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtTien, null);
            }
        }

        private void TsbRefresh_Click(object sender, EventArgs e)
        {
            setnull();
            KhoaDieuKhien();
            dgvList.DataSource = Bus.TL_Select();
            dgvList.Columns["MaPhieuTL"].HeaderText = "Mã phiếu";
            dgvList.Columns["NgayTL"].HeaderText = "Ngày thanh lí";
            dgvList.Columns["SoTienTL"].HeaderText = "Số tiền thanh lí";
            dgvList.Columns["MaCanBo"].HeaderText = "Mã cán bộ";
            dgvList.Columns["MaMay"].HeaderText = "Mã máy";
            dgvList.Columns["MaTB"].HeaderText = "Mã thiết bị";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                DataTable dt = new DataTable();
                if ((dt = Bus.TL_search(txtSearch.Text)) != null)
                    dgvList.DataSource = dt;
                else MessageBox.Show("Không tìm thấy!", "Message");
            }
        }

        #region Ma tu dong
        private string GetCode()
        {
            if (dgvList.Rows.Count == 1)
                return "PTL001";
            List<string> dsMa = new List<string>();
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (row.Index < dgvList.Rows.Count - 1)
                    dsMa.Add(row.Cells["MaPhieuTL"].Value.ToString());
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

        private bool themmoi;

        public void KhoaDieuKhien()
        {
            txtMa.Enabled = false;
            txtNgay.Enabled = false;
            txtMacb.Enabled = false;
            txtMamay.Enabled = false;
            txtTien.Enabled = false;
            txtMatb.Enabled = false;
            tsbLuu.Enabled = false;
            tsbXoa.Enabled = false;
            tsbSua.Enabled = false;
        }

        public void MoDieuKhien()
        {
            txtMa.Enabled = true;
            txtNgay.Enabled = true;
            txtMatb.Enabled = true;
            txtMacb.Enabled = true;
            txtTien.Enabled = true;
            txtMamay.Enabled = true;
            tsbLuu.Enabled = true;
        }

        void setnull()
        {
            txtMa.Text = "";
            txtNgay.Text = "";
            txtMamay.Text = null;
            txtMatb.Text = null;
            txtTien.Text = null;
            txtSearch.Text = string.Empty;
        }

        private void ThanhliTB_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            dgvList.DataSource = Bus.TL_Select();
            txtMacb.DataSource = Bus.CB_select();
            txtMacb.ValueMember = "MaCanBo";
            txtMacb.DisplayMember = "MaCanBo";

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
                        txtSearch.AutoCompleteCustomSource.Add(row.Cells[5].Value.ToString());
                    }
                }
            }
            foreach (DataRow row in Bus.MT_select().Rows)
            {
                txtMamay.AutoCompleteCustomSource.Add(row.Field<string>("MaMay"));
            }
            foreach (DataRow row in Bus.TB_select().Rows)
            {
                txtMatb.AutoCompleteCustomSource.Add(row.Field<string>("MaTB"));
            }

            dgvList.Columns["MaPhieuTL"].HeaderText = "Mã phiếu";
            dgvList.Columns["NgayTL"].HeaderText = "Ngày thanh lí";
            dgvList.Columns["SoTienTL"].HeaderText = "Số tiền thanh lí";
            dgvList.Columns["MaCanBo"].HeaderText = "Mã cán bộ";
            dgvList.Columns["MaMay"].HeaderText = "Mã máy";
            dgvList.Columns["MaTB"].HeaderText = "Mã thiết bị";
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            setnull();
            themmoi = false;
            txtMa.Text = GetCode();
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMa.Enabled = false;
            themmoi = true;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == " ")
                return;
            if (MessageBox.Show("Xóa thông tin đi kèm", "Xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                int res = Bus.TL_Delete(txtMa.Text);
                if (res > 0)
                {
                    MessageBox.Show("Đã xóa");
                    dgvList.DataSource = Bus.TL_Select();
                    setnull();
                    KhoaDieuKhien();

                }
                else MessageBox.Show("Thất bại");
            }
        }

        private void tsbLuu_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == " ")
            {
                MessageBox.Show("Mời nhập đầy đủ thông tin!");
                return;
            }
            else
            {
                ThanhLiTB pm = new ThanhLiTB()
                {
                    Maphieutl = txtMa.Text,
                    Ngaytl = DateTime.Parse(txtNgay.Text),
                    Sotientl = txtTien.Text,
                    Macanbo = txtMacb.Text,
                    Mamay = txtMamay.Text,
                    Matb = txtMatb.Text
                };

                int res = 0;
                if (themmoi)
                    res = Bus.TL_Update(pm);
                else res = Bus.TL_Insert(pm);

                if (res > 0)
                {
                    MessageBox.Show("Đã cập nhật");
                    dgvList.DataSource = Bus.TL_Select();
                    setnull();
                    KhoaDieuKhien();
                }
                else MessageBox.Show("Thất bại");
            }
        }

        private void dgvTL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvList.CurrentRow.Cells[0].Value.ToString();
            txtNgay.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
            txtTien.Text = dgvList.CurrentRow.Cells[2].Value.ToString();
            txtMacb.Text = dgvList.CurrentRow.Cells[3].Value.ToString();
            txtMamay.Text = dgvList.CurrentRow.Cells[4].Value.ToString();
            txtMatb.Text = dgvList.CurrentRow.Cells[5].Value.ToString();

            KhoaDieuKhien();
            tsbLuu.Enabled = false;
            tsbXoa.Enabled = true;
            tsbSua.Enabled = true;
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
