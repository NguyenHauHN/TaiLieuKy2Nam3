using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KetNoiDS
{
    public partial class Form1 : Form
    {
        KetNoi _ketnoiDatabase = new KetNoi();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            if (_ketnoiDatabase.Connect() == true)
            {
                dtGridView.DataSource = _ketnoiDatabase.datatable;

            }
            else
            {
                MessageBox.Show("Chua ket noi duoc voi server!");
            }
        }

        private void dtGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
