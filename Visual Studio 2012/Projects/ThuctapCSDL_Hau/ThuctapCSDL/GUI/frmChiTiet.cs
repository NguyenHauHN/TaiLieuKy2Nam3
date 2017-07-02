using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using ThuctapCSDL.ValueObject;
using ThuctapCSDL.BusinessLogicLayer;

namespace ThuctapCSDL.GUI
{
    public partial class frmChiTiet : Form
    {
        public frmChiTiet()
        {
            InitializeComponent();
        }

        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            dtgList.DataSource = Bus.CTPN_select();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {

        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            frmDevice _frmtb = new frmDevice();
            ChiTietPhieuNhap _chitiet = new ChiTietPhieuNhap();
            _chitiet.MaPhieu = txtMaPhieu.Text;
            _chitiet.TenTB = txtTenTB.Text;
            _chitiet.SoLuong = Int32.Parse(txtSoLuong.Text);
            for (int i = 0; i < _chitiet.SoLuong; i++)
            {
                ThietBi _tb = new ThietBi();
                _tb.MaTB = _frmtb.GetCode();
                _tb.TenTB = _chitiet.TenTB;
                _tb.TinhTrang = "";
                _tb.MaLoaiTB = "";
                _tb.MaPhong = "";
                int res1 = Bus.TB_insert(_tb);
                if (res1 > 0)
                {
                    MessageBox.Show("Thành công!");

                }
                else
                {
                    MessageBox.Show("Thất baị!");
                }

            }
            
            int res = Bus.CTPN_insert(_chitiet);
            if (res > 0)
            {
                MessageBox.Show("Đã thêm!");
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }


    }
}
