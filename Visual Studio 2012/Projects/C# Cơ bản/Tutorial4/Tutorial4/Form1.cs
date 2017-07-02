using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial4
{
    public partial class Form1 : Form
    {
        int i = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
            //timer2.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbDisplay_Click(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            lbDisplay.Text = i.ToString();
            i--;
            if (i < 0)
            {
                lbDisplay.Text = "Hết giờ!";
                timer1.Enabled = false;
            }
        }
        //private void timer1_Tick(object sender, EventArgs e)
        //{

        //    lbDisplay.Text = i.ToString();
        //    i--;
        //    if (i < 0)
        //    {
        //        lbDisplay.Text = "Hết giờ!";
        //        timer1.Enabled = false;
        //    }
        //}
    }
}
