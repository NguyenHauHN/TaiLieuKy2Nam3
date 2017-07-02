using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ThuctapCSDL.ValueObject;
using ThuctapCSDL.BusinessLogicLayer;


namespace ThuctapCSDL
{
    public partial class frmCompRoom : Form
    {
        public frmCompRoom()
        {
            InitializeComponent();
            dgvRoomList.CellClick += DgvRoomList_CellClick;
            tsbRefresh.Click += TsbRefresh_Click;
        }

        private void TsbRefresh_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            setnull();
        }

        private void DgvRoomList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text = dgvRoomList.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvRoomList.CurrentRow.Cells[1].Value.ToString();
            KhoaDieuKhien();
            tsbXoa.Enabled = true;
            tsbLuu.Enabled = false;
            tsbSua.Enabled = true;
        }

        private bool themmoi;

        #region Mã tự động
        private string GetCode()
        {
            if (dgvRoomList.Rows.Count == 1)
                return "PM001";

            List<string> dsMa = new List<string>();
            foreach (DataGridViewRow row in dgvRoomList.Rows)
            {
                if (row.Index < dgvRoomList.Rows.Count - 1)
                    dsMa.Add(row.Cells["MaPhong"].Value.ToString());
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
            tsbLuu.Enabled = false;
            tsbSua.Enabled = false;
            tsbXoa.Enabled = false;
        }

        public void MoDieuKhien()
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            tsbLuu.Enabled = true;
        }

        void setnull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }

        private void PhongMay_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            dgvRoomList.DataSource = Bus.PM_select();

            dgvRoomList.Columns["Maphong"].HeaderText = "Số phòng";
            dgvRoomList.Columns["Tenphong"].HeaderText = "Tên phòng";

            cmbMaPhong.DataSource = Bus.PM_select();
            cmbMaPhong.ValueMember = "MaPhong";
            cmbMaPhong.DisplayMember = "MaPhong";
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            MoDieuKhien();
            setnull();
            txtMa.Text = GetCode();
            themmoi = false;
        }

        private void tsbSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMa.Enabled = false;
            themmoi = true;
        }

        private void tsbXoa_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
                return;
            if (MessageBox.Show("Xóa thông tin liên quan ?", "Xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int res = Bus.PM_delete(txtMa.Text);
                if (res > 0)
                {
                    MessageBox.Show("Đã xóa");
                    dgvRoomList.DataSource = Bus.PM_select();

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
                PhongMay pm = new PhongMay()
                {
                    MaPhong = txtMa.Text,
                    TenPhong = txtTen.Text,
                };

                int res = 0;
                if (themmoi)
                    res = Bus.PM_update(pm);
                else res = Bus.PM_insert(pm);

                if (res > 0)
                {
                    MessageBox.Show("Đã cập nhật");
                    dgvRoomList.DataSource = Bus.PM_select();
                    setnull();
                    KhoaDieuKhien();
                }
                else MessageBox.Show("Thất bại");
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cmbXem.Text == "Máy Tính")
            {
                dgvSL.DataSource = Bus.MT_selectByRoomCode(cmbMaPhong.Text);
                dgvSL.Columns["MaMay"].HeaderText = "Mã máy";
                dgvSL.Columns["TenMay"].HeaderText = "Tên máy";
                dgvSL.Columns["TinhTrang"].HeaderText = "Tình trạng";
                dgvSL.Columns["NgayLapDat"].HeaderText = "Ngày lắp đặt";
            }
            else
            {
                dgvSL.DataSource = Bus.TB_selectByRoomCode(cmbMaPhong.Text);
                dgvSL.Columns["MaTB"].HeaderText = "Mã thiết bị";
                dgvSL.Columns["TenTB"].HeaderText = "Tên thiết bị";
                dgvSL.Columns["TinhTrang"].HeaderText = "Tình trạng";
                dgvSL.Columns["MaLoaiTB"].HeaderText = "Mã loại thiết bị";
            }
        }

        private void tsbHome_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

