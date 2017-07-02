using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN
{
    public partial class Update : Form
    {
        public Home _home = new Home();
        ConnectDatabase _connect = new ConnectDatabase();
        public Update()
        {
            InitializeComponent();
            //_nhanvienUpdate = _home.getObjectUpdate();
            if (CheckEmptyObject(Home._nhanvienUpdate))
            {
                MessageBox.Show("Chưa có thông tin sinh viên!");
            }
            else
            {
                txtName.Text = Home._nhanvienUpdate.name;
                if (Home._nhanvienUpdate.gender == "Nam")
                {
                    radMale.Checked = true;
                }
                else
                {
                    if (Home._nhanvienUpdate.gender == "Nữ")
                    {
                        radFemale.Checked = true;
                    }
                }
                txtDepartment.Text = Home._nhanvienUpdate.department;
                txtAddress.Text = Home._nhanvienUpdate.address;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            NhanVien _nhanvienInfoUpdate = new NhanVien();
            _nhanvienInfoUpdate.code = Home._nhanvienUpdate.code;
            _nhanvienInfoUpdate.name = txtName.Text;
            _nhanvienInfoUpdate.department = txtDepartment.Text;
            _nhanvienInfoUpdate.address = txtAddress.Text;
            if (radMale.Checked == true)
            {
                _nhanvienInfoUpdate.gender = "Nam";
            }
            else
            {
                if (radFemale.Checked == true)
                {
                    _nhanvienInfoUpdate.gender = "Nữ";
                }
            }
            try
            {
                if (_connect.Connect() == true)
                {
                    _connect.updateData(_nhanvienInfoUpdate);
                    _home.showData();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Chưa kết nối được đến server!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa chỉnh sửa thành công thông tin nhân viên");
            }
        }
        public bool CheckEmptyObject(NhanVien _nhanvien)
        {
            if (_nhanvien.name == null && _nhanvien.gender == null && _nhanvien.department == null && _nhanvien.address == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
