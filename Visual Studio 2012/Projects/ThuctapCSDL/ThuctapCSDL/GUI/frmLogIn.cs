using System;
using System.Windows.Forms;
using ThuctapCSDL.DataAccessLayer;
using ThuctapCSDL.ValueObject;
using System.IO;

namespace ThuctapCSDL
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private string user;
        private string pwd;
        private bool save;

        private void LogIn_Load(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\" + "user.txt"))
            {
                using (StreamReader sr = new StreamReader("user.txt"))
                {
                    if (sr.ReadLine() == "true")
                    {
                        txtTaiKhoan.Text = sr.ReadLine();
                        txtMatKhau.Text = sr.ReadLine();
                        chbLuuDangNhap.Checked = true;
                    }
                }
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (NguoiDung nd in NguoiDung_DAL.GetUserList())
            {
                if (user == nd.TaiKhoan && pwd == nd.MatKhau)
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                using (StreamWriter sw = new StreamWriter("user.txt"))
                {
                    if (save)
                    {
                        sw.WriteLine("true");
                        sw.WriteLine(user);
                        sw.WriteLine(pwd);
                    }
                    else
                    {
                        sw.WriteLine("false");
                    }
                }
                // chuyen form
                frmHome home = new frmHome();
                this.Hide();
                home.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chbLuuDangNhap_CheckedChanged(object sender, EventArgs e)
        {
            save = chbLuuDangNhap.Checked ? true : false;
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            user = txtTaiKhoan.Text;
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            pwd = txtMatKhau.Text;
        }
    }
}
