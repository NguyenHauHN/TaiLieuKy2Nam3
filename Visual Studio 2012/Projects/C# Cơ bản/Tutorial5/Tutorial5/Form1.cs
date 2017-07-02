using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial5
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            btnStop.Hide();
        }
        char[] arr = {'C','h','u','c', ' ', 'm','u','n','g',' ','n','a','m',' ','m','o','i' };
        int i = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnStart.Hide();
            btnStop.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                lbText.Text += arr[i].ToString();
                i++;
                if (i == arr.Length)
                {
                    timer1.Enabled = false;
                }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnStart.Show();
            btnStop.Hide();
        }
    }
}
