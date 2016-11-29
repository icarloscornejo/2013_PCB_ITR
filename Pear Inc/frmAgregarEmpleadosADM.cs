using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pear_Inc
{
    public partial class frmAgregarEmpleadosADM : Form
    {
        public frmAgregarEmpleadosADM()
        {
            InitializeComponent();
        }

        private void pctCargos_Click(object sender, EventArgs e)
        {
            var a = new frmAgregarCargosADM();
            a.Show();
            this.Hide();
        }
    }
}
