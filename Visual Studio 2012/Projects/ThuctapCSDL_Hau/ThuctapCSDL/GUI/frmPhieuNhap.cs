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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
           
            txtMaPhieu.Text = GetCode();
           
        }

        public string GetCode()
        {
            string MaMoi;
            string MaMax = Bus.LayMaMaxBLL("PhieuNhap", "MaPhieu");
            if (MaMax.Length > 0)
            {
                int Ma = Int32.Parse(MaMax.Substring(2));
                if (Ma < 9)
                {
                    MaMoi = "PN0" + (Ma + 1).ToString();
                }
                else
                {
                    MaMoi = "PN" + (Ma + 1).ToString();
                }
            }
            else
            {
                MaMoi = "PN01";
            }
            
            return MaMoi;
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            dtgListPhieuNhap.DataSource = Bus.PN_select();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            PhieuNhap pn = new PhieuNhap();
            pn.MaPhieu = GetCode();
            pn.MaNCC = txtMaNCC.Text;
            pn.NgayNhap = dtpNgayNhap.Text;
            int res = Bus.PN_insert(pn);
            if (res > 0)
            {
                dtgListPhieuNhap.DataSource = Bus.PN_select();
                MessageBox.Show("Đã thêm!");
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmChiTiet _chitiet = new frmChiTiet();
            _chitiet.ShowDialog();
        }

    

    }
}
