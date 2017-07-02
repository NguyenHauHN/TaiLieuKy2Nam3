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
    public partial class Display : Form
    {
        private Controller _controller;
        public Display(Controller _controller)
        {
            InitializeComponent();
            lbUsername.Text = _controller.username;
            lbPassword.Text = _controller.password;
        }

        private void Display_Load(object sender, EventArgs e)
        {
           
        }
    }
}
