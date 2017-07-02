using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3
{
    public partial class ChuyenFont : Form
    {
        public ChuyenFont()
        {
            InitializeComponent();
            radLowercase.Checked = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtString.Clear();
            txtResult.Clear();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (radLowercase.Checked == true)
            {
                txtResult.Text = txtString.Text.ToLower().ToString();
            }
            else if (radUppercase.Checked == true)
            {
                txtResult.Text = txtString.Text.ToUpper().ToString();
            }
        }
    }
}
