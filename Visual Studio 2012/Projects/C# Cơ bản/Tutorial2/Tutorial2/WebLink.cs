using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial2
{
    public partial class WebLink : Form
    {
        public WebLink()
        {
            InitializeComponent();
        }

        private void lBLink_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOKLBWebsite_Click(object sender, EventArgs e)
        {
            txtResult.Text = "Bạn đã chọn website: ";
            txtResult.Text += lBWebname.SelectedItem.ToString();
            lBLink.Items.Add(lBWebname.SelectedItem.ToString());
        }

        private void btnResetLBWebsite_Click(object sender, EventArgs e)
        {
            txtResult.ResetText();
        }

        private void btnResetLBLink_Click(object sender, EventArgs e)
        {
            lBLink.Items.Clear();
        }

       
    }
}
