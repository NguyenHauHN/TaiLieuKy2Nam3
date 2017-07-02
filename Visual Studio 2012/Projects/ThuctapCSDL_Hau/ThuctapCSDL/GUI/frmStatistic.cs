using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuctapCSDL.GUI
{
    public partial class frmStatistic : Form
    {
        public frmStatistic()
        {
            InitializeComponent();
            Load += FrmStatistic_Load;
        }

        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            chartSalary.Series["Salary"].Points.AddXY("Pusheen", 120);
            chartSalary.Series["Salary"].Points.AddXY("Stormy", 140);
            chartSalary.Series["Salary"].Points.AddXY("Oggy", 420);
        }
    }
}
