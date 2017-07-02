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
    public partial class Home : Form
    {
        ConnectDatabase _connect = new ConnectDatabase();
        public static NhanVien _nhanvienUpdate = new NhanVien();
        public Home()
        {
            InitializeComponent();
            
        }

        public void showData()
        {
            dataListEmployee.DataSource = _connect.getData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Add _formAdd = new Add();
            _formAdd._homeData = this;
            _formAdd.Show();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Update _formSua = new Update();
            _formSua._home = this;
            _formSua.Show();
         
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn xóa thông tin nhân viên khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (dialogResult == DialogResult.Yes)
            {
                if (_connect.Connect() == true)
                {
                    _connect.deleteData(Home._nhanvienUpdate);
                    this.showData();
                }
                else
                {
                    MessageBox.Show("Không kết nối được với server!");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void dataListEmployee_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _nhanvienUpdate.code = dataListEmployee.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString();
            _nhanvienUpdate.name = dataListEmployee.Rows[e.RowIndex].Cells["Họ tên"].Value.ToString();
            _nhanvienUpdate.gender = dataListEmployee.Rows[e.RowIndex].Cells["Giới tính"].Value.ToString();
            _nhanvienUpdate.department = dataListEmployee.Rows[e.RowIndex].Cells["Bộ phận làm việc"].Value.ToString();
            _nhanvienUpdate.address = dataListEmployee.Rows[e.RowIndex].Cells["Địa chỉ hiện tại"].Value.ToString();
        }

        private void dataListEmployee_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //_nhanvienUpdate.code = dataListEmployee.Rows[e.RowIndex].Cells["Mã nhân viên"].Value.ToString();
            //_nhanvienUpdate.name = dataListEmployee.Rows[e.RowIndex].Cells["Họ tên"].Value.ToString();
            //_nhanvienUpdate.gender = dataListEmployee.Rows[e.RowIndex].Cells["Giới tính"].Value.ToString();
            //_nhanvienUpdate.department = dataListEmployee.Rows[e.RowIndex].Cells["Bộ phận làm việc"].Value.ToString();
            //_nhanvienUpdate.address = dataListEmployee.Rows[e.RowIndex].Cells["Địa chỉ hiện tại"].Value.ToString();
        }
        public void ReloadData()
        {
            dataListEmployee.Update();
            dataListEmployee.Refresh();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            if (_connect.Connect() == true)
            {
                showData();
            }
            else
            {
                MessageBox.Show("Chưa kết nối với server!");
            }
        }

        
      
    }
}
