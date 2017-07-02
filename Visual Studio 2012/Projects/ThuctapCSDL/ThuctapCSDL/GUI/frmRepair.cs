using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThuctapCSDL.BusinessLogicLayer;
using ThuctapCSDL.ValueObject;

namespace ThuctapCSDL
{
    public partial class frmRepair : Form
    {
        private bool edit;

        public frmRepair()
        {
            InitializeComponent();
            Load += FrmRepair_Load;
            LockControls();
            // for insert, update, delete
            tsbAdd.Click += TsbAdd_Click;
            tsbEdit.Click += TsbEdit_Click;
            tsbSave.Click += TsbSave_Click;
            tsbDelete.Click += TsbDelete_Click;
            // controls
            cmbChon.TextChanged += CmbSelect_TextChanged;
            cmbPhongMay.TextChanged += CmbPhongMay_TextChanged;
            dgvList.CellClick += DgvList_CellClick;
            dgvDetails.CellClick += DgvDetails_CellClick;
            tsbRefresh.Click += TsbCancel_Click;
            txtTimKiem.Click += TxtTimKiem_Click;
            tsbHome.Click += TsbHome_Click;
            // for search
            btnTimKiem.Click += BtnTimKiem_Click;
        }

        private void TsbHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = string.Empty;
        }

        private void LoadDgvList()
        {
            dgvList.DataSource = Bus.PSC_select();
            dgvList.Columns["MaPhieu"].HeaderText = "Mã phiếu";
            dgvList.Columns["NoiDung"].HeaderText = "Nội dung";
            dgvList.Columns["NgaySua"].HeaderText = "Ngày sửa";
            dgvList.Columns["MaCanBo"].HeaderText = "Mã cán bộ";
        }

        private void FrmRepair_Load(object sender, EventArgs e)
        {
            // load data grid view
            LoadDgvList();
            // load cmb phòng máy
            cmbPhongMay.DataSource = Bus.PM_select();
            cmbPhongMay.DisplayMember = "TenPhong";
            cmbPhongMay.ValueMember = "MaPhong";
            // load cmb can bo
            cmbMaCanBo.DataSource = Bus.CB_select();
            cmbMaCanBo.DisplayMember = "TenCanBo";
            cmbMaCanBo.ValueMember = "MaCanBo";
            // tao search box voi txtTimKiem
            TimKiem();
        }

        #region Tim kiem
        private void TimKiem()
        {
            if (dgvList.Rows.Count > 1)
            {
                txtTimKiem.AutoCompleteCustomSource = null;
                List<string> dsStatus = new List<string>();
                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    if (row.Index < dgvList.Rows.Count - 1)
                    {
                        dsStatus.Add(row.Cells["MaPhieu"].Value.ToString());
                        dsStatus.Add(row.Cells["NoiDung"].Value.ToString());
                        dsStatus.Add(row.Cells["MaCanBo"].Value.ToString());
                        dsStatus.Add(row.Cells["NgaySua"].Value.ToString());
                    }
                }
                txtTimKiem.AutoCompleteCustomSource.AddRange(dsStatus.ToArray());
            }
        }
        #endregion

        #region Ma tu dong
        private string GetCode()
        {
            if (dgvList.Rows.Count == 1)
                return string.Empty;
            List<string> dsMa = new List<string>();
            foreach (DataGridViewRow row in dgvList.Rows)
            {
                if (row.Index < dgvList.Rows.Count - 1)
                    dsMa.Add(row.Cells["MaPhieu"].Value.ToString());
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

        private void TsbCancel_Click(object sender, EventArgs e)
        {
            FormRefresh();
            dgvList.DataSource = Bus.PSC_select();
            LockControls();
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                return;
            dgvList.DataSource = Bus.PSC_search(txtTimKiem.Text);
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPhieu.Text = dgvList.CurrentRow.Cells["MaPhieu"].Value.ToString();
            dtpNgaySua.Text = dgvList.CurrentRow.Cells["NgaySua"].Value.ToString();
            cmbMaCanBo.SelectedValue = dgvList.CurrentRow.Cells["MaCanBo"].Value;
            rtbNoiDung.Text = dgvList.CurrentRow.Cells["NoiDung"].Value.ToString();

            // load dât grid view bang chi tiet
            string maphieu = dgvList.CurrentRow.Cells["MaPhieu"].Value.ToString();
            if (maphieu != "" && maphieu != null)
                LoadDgvDetails(maphieu);
            LockControls();
            tsbEdit.Enabled = true;
            tsbDelete.Enabled = true;
            tsbSave.Enabled = false;
        }

        private void LoadDgvDetails(string maphieu)
        {
            dgvDetails.DataSource = Bus.PSC_selectJoin(maphieu);
            dgvDetails.Columns["MaPhieu"].HeaderText = "Mã phiếu";
            dgvDetails.Columns["TenCanBo"].HeaderText = "Tên cán bộ";
            dgvDetails.Columns["MaMay"].HeaderText = "Mã máy";
            dgvDetails.Columns["TinhTrangTruocMay"].HeaderText = "Máy tính TT trước";
            dgvDetails.Columns["TinhTrangSauMay"].HeaderText = "Máy tính TT sau";
            dgvDetails.Columns["TinhTrangTruocTB"].HeaderText = "Thiết bị TT trước";
            dgvDetails.Columns["TinhTrangSauTB"].HeaderText = "Máy tính TT sau";
        }

        private void DgvDetails_CellClick(object sender, EventArgs e)
        {
            if (dgvDetails.Rows.Count > 1)
            {
                if ((txtTT1.Text = dgvDetails.CurrentRow.Cells["TinhTrangTruocMay"].Value.ToString()) == "")
                    txtTT1.Text = dgvDetails.CurrentRow.Cells["TinhTrangTruocTB"].Value.ToString();
                if ((txtTT2.Text = dgvDetails.CurrentRow.Cells["TinhTrangSauMay"].Value.ToString()) == "")
                    txtTT2.Text = dgvDetails.CurrentRow.Cells["TinhTrangSauTB"].Value.ToString();
                txtMaMay.Text = dgvDetails.CurrentRow.Cells["MaMay"].Value.ToString();
                txtMaTb.Text = dgvDetails.CurrentRow.Cells["MaTB"].Value.ToString();
            }
        }

        #region Them sua xoa
        private void TsbDelete_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text == "")
            {
                MessageBox.Show("Chưa chọn thông tin");
                return;
            }
            if (MessageBox.Show("Xóa tất cả bản ghi liên quan", "Xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Bus.PSC_delete(txtMaPhieu.Text) > 0)
                {
                    MessageBox.Show("Đã xóa");
                    FormRefresh();
                    LockControls();
                }
                else MessageBox.Show("Thất bại");
            }
        }

        private void TsbSave_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text == "")
            {
                return;
            }

            PhieuSuaChua psc = new PhieuSuaChua();
            psc.MaPhieu = txtMaPhieu.Text;
            psc.MaCanBo = cmbMaCanBo.SelectedValue.ToString();
            psc.NgaySua = DateTime.Parse(dtpNgaySua.Text);
            psc.NoiDung = rtbNoiDung.Text;

            int res = 0;
            List<SuaChuaMT> listMT = new List<SuaChuaMT>();
            List<SuaChuaTB> listTB = new List<SuaChuaTB>();
            // for insert
            if (!edit)
            {
                // load danh sach may tinh thiet bi can sua
                foreach (DataGridViewRow row in dgvChon.Rows)
                {
                    DataGridViewCheckBoxCell cell = row.Cells["Chon"] as DataGridViewCheckBoxCell;
                    if ((bool)cell.EditedFormattedValue == true)
                    {
                        if (cmbChon.Text == "Sửa máy tính")
                            listMT.Add(new SuaChuaMT()
                            {
                                MaMay = row.Cells["MaMay"].Value.ToString(),
                                MaPhieu = txtMaPhieu.Text,
                                TinhTrangTruoc = "Đang sửa chữa",
                                TinhTrangSau = txtTT2.Text
                            });
                        else
                            listTB.Add(new SuaChuaTB
                            {
                                MaTB = row.Cells["MaTB"].Value.ToString(),
                                MaPhieu = txtMaPhieu.Text,
                                TinhTrangTruoc = "Đang sửa chữa",
                                TinhTrangSau = txtTT2.Text
                            });
                    }
                }
                res = Bus.PSC_insert(psc);
                if (res == 0)
                {
                    MessageBox.Show("Thất bại");
                    return;
                }
                if (listMT.Count > 0)
                {
                    foreach (SuaChuaMT scmt in listMT)
                    {
                        res = Bus.SCMT_insert(scmt);
                        if (res == 0)
                            break;
                    }
                    if (res == 0)
                    {
                        MessageBox.Show("Thất bại");
                        return;
                    }
                }

                if (listTB.Count > 0)
                {
                    foreach (SuaChuaTB sctb in listTB)
                    {
                        res = Bus.SCTB_insert(sctb);
                        if (res == 0)
                            break;
                    }
                }
            }

            if (edit)
            {
                res = 0;
                if (txtMaMay.Text != "")
                {
                    SuaChuaMT mt = new SuaChuaMT()
                    {
                        MaMay = txtMaMay.Text,
                        MaPhieu = txtMaPhieu.Text,
                        TinhTrangTruoc = txtTT1.Text,
                        TinhTrangSau = txtTT2.Text
                    };
                    res = Bus.SCMT_update(mt);
                }
                if (txtMaTb.Text != "")
                {
                    SuaChuaTB tb = new SuaChuaTB()
                    {
                        MaTB = txtMaTb.Text,
                        MaPhieu = txtMaPhieu.Text,
                        TinhTrangTruoc = txtTT1.Text,
                        TinhTrangSau = txtTT2.Text
                    };
                    res = Bus.SCTB_update(tb);
                }
                if (res == 0)
                {
                    MessageBox.Show("Thất bại");
                    return;
                }
                res = Bus.PSC_update(psc);

            }

            if (res > 0)
            {
                MessageBox.Show("Đã cập nhật");
                FormRefresh();
                LockControls();
                CmbSelect_TextChanged(sender, e);
                return;
            }
            else
            {
                MessageBox.Show("Thất bại");
                return;
            }
        }

        private void TsbEdit_Click(object sender, EventArgs e)
        {
            edit = true;
            UnlockControls();
            txtMaPhieu.Enabled = false;
        }

        private void CmbSelect_TextChanged(object sender, EventArgs e)
        {
            if (cmbPhongMay.Text != "")
            {
                if (cmbChon.Text == "Sửa máy tính")
                    dgvChon.DataSource = Bus.MT_selectByRoomCode(cmbPhongMay.SelectedValue.ToString());
                else dgvChon.DataSource = Bus.TB_selectByRoomCode(cmbPhongMay.SelectedValue.ToString());
            }
        }

        private void CmbPhongMay_TextChanged(object sender, EventArgs e)
        {
            if (cmbChon.Text != "")
                CmbSelect_TextChanged(sender, e);
        }

        private void TsbAdd_Click(object sender, EventArgs e)
        {
            FormRefresh();
            txtMaPhieu.Text = GetCode();
            edit = false;
            UnlockControls();
        }
        #endregion

        #region Controls
        private void FormRefresh()
        {
            txtMaPhieu.Text = string.Empty;
            txtMaTb.Text = string.Empty;
            txtMaMay.Text = string.Empty;
            rtbNoiDung.Text = string.Empty;
            txtTT1.Text = string.Empty;
            txtTT2.Text = string.Empty;
            txtTimKiem.Text = string.Empty;
            txtTimKiem.Text = string.Empty;
            // refresh lai dgv List
            LoadDgvList();
            dgvDetails.DataSource = null;
            // load lai txt Tim kiem
            TimKiem();
        }

        private void LockControls()
        {
            txtMaPhieu.Enabled = false;
            txtMaMay.Enabled = false;
            txtMaTb.Enabled = false;
            dtpNgaySua.Enabled = false;
            rtbNoiDung.Enabled = false;
            cmbMaCanBo.Enabled = false;
            txtTT1.Enabled = false;
            txtTT2.Enabled = false;

            tsbSave.Enabled = false;
            tsbDelete.Enabled = false;
            tsbEdit.Enabled = false;
        }

        private void UnlockControls()
        {
            if (edit)
            {
                txtMaPhieu.Enabled = false;
                txtTT1.Enabled = true;
                txtTT2.Enabled = true;
            }
            txtMaPhieu.Enabled = true;
            dtpNgaySua.Enabled = true;
            rtbNoiDung.Enabled = true;
            cmbMaCanBo.Enabled = true;
            tsbSave.Enabled = true;
        }
        #endregion
    }
}
