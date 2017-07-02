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
    public partial class Add : Form
    {
        ConnectDatabase _connect = new ConnectDatabase();
       public  Home _homeData = new Home();
        public Add()
        {
            InitializeComponent();
            radMale.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhanVien _nhanvienmoi = new NhanVien();
            
            _nhanvienmoi.code = txtCode.Text.ToString();
            _nhanvienmoi.name = txtName.Text.ToString();
            _nhanvienmoi.department = txtDepartment.Text.ToString();
            _nhanvienmoi.address = txtAddress.Text.ToString();
            if (radFemale.Checked == true)
            {
                _nhanvienmoi.gender = "Nữ";
            }
            else if (radMale.Checked == true)
            {
                _nhanvienmoi.gender = "Nam";
            }
            try
            {
                if (_connect.Connect() == true)
                {
                    _connect.insertData(_nhanvienmoi);
                    _homeData.showData();
                    this.Close();
                    if (txtCode.Text != null || txtName.Text != null || txtDepartment.Text != null || txtAddress.Text != null)
                    {
                        txtCode.Text = " ";
                        txtName.Text = " ";
                        txtDepartment.Text = " ";
                        txtAddress.Text = " ";
                    }
                }
                else
                {
                    MessageBox.Show("Chưa kết nối được đến server!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa thêm được thông tin nhân viên mới");
            }
        }
       
    }
}
