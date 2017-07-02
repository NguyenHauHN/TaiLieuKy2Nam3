using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ThuctapCSDL.BusinessLogicLayer;
using ThuctapCSDL.ValueObject;
using System.Data;
using System.Data.SqlClient;

namespace ThuctapCSDL.GUI
{
    public partial class frmSupplier : Form
    {
        private string action;
        NhaCungCap ncc = new NhaCungCap();
        private string MaNCC;
        public frmSupplier()
        {
            InitializeComponent();
           
        }

        public string TaoMa()
        {
            string MaMoi;
            string MaMax = Bus.LayMaMaxBLL("NhaCungCap", "MaNhaCungCap");
            int Ma = System.Int32.Parse(MaMax.Substring(3));
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

        private void frmSupplier_Load(object sender, System.EventArgs e)
        {
            dgvListProviders.DataSource = Bus.NCC_Select();
            this.dgvListProviders.Columns[0].Visible = false;
        }

        private void tsAdd_Click(object sender, System.EventArgs e)
        {
            action = "Them";
        }

        private void tsSave_Click(object sender, System.EventArgs e)
        {
            LayDuLieu();
            if (action == "Them")
            {
                ncc.MaNhaCC = TaoMa();
                if (ThemNhaCungCap() > 0)
                {
                    dgvListProviders.DataSource = Bus.NCC_Select();
                    MessageBox.Show("Thêm nhà cung cấp thành công!");
                }
                else
                {
                    MessageBox.Show("Chưa thêm được nhà cung cấp mới!");
                }

            }
            if (action == "Sua")
            {
                ncc.MaNhaCC = MaNCC;
                if (CapNhatNhaCungCap() > 0)
                {
                    dgvListProviders.DataSource = Bus.NCC_Select();
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!");
                }
                else
                {
                    MessageBox.Show("Chưa cập nhật được nhà cung cấp!");
                }
            }
        }

        public void LayDuLieu()
        {
            ncc.TenNhaCC = txtName.Text;
            ncc.DiaChi = txtAddress.Text;
            ncc.SDT = txtPhoneNumber.Text;
        }

        public int ThemNhaCungCap()
        {
            int them = -1;
            if (Bus.NCC_insert(ncc) > 0)
            {
                them = 1;
            }
            return them;
        }

        private void tsDelete_Click(object sender, System.EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Bạn muốn xóa nhà cung cấp đã chọn?",
    "Xác nhận xóa",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);
            if (result2 == DialogResult.Yes)
            {
                if (Bus.NCC_delete(MaNCC) > 0)
                {
                    dgvListProviders.DataSource = Bus.NCC_Select();
                    MessageBox.Show("Đã xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Chưa xóa được thông tin nhà cung cấp!");
                }

            }
        }

        private void dgvListProviders_SelectionChanged(object sender, System.EventArgs e)
        {
            MaNCC = dgvListProviders.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvListProviders.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dgvListProviders.CurrentRow.Cells[2].Value.ToString();
            txtPhoneNumber.Text = dgvListProviders.CurrentRow.Cells[3].Value.ToString();
        }

        private void tsUpdate_Click(object sender, System.EventArgs e)
        {
            action = "Sua";
        }

        public int CapNhatNhaCungCap()
        {
            int sua = -1;
            if (Bus.NCC_update(ncc) > 0)
            {
                sua = 1;
            }
            return sua;
        }
        
    }
}
