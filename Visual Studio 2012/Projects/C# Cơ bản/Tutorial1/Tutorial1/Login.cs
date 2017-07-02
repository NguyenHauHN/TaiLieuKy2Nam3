using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Controller _controller = new Controller();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == " " && txtPassword.Text == " ") 
            {
                MessageBox.Show("Bạn không được để trống Tên đăng nhập và Mật khẩu.");
            }
            else if (txtUsername.Text == " ")
            {
                MessageBox.Show("Bạn không được để trống Tên đăng nhập.");
            }
            else if (txtPassword.Text == " ")
            {
                MessageBox.Show("Bạn không được để trống Mật khẩu.");
            }
            else
            {
                _controller.username = txtUsername.Text;
                _controller.password = txtPassword.Text;
                Display _display = new Display(_controller);
                _display.Show();
                //this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult _result = new DialogResult();
            _result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Lựa chọn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (_result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
