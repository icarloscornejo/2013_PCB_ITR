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
    public partial class frmMenuADM : Form
    {
        public frmMenuADM()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var restart = new frmLogin();
            restart.Show();
            this.Close();
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            var busemp = new frmBuscarEmpleados();
            busemp.Show();
            this.Hide();
        }

        private void btnAgregarCargos_Click(object sender, EventArgs e)
        {
            var a = new frmAgregarCargosADM();
            a.Show();
            this.Hide();
        }

        private void btnEditarCargos_Click(object sender, EventArgs e)
        {
            var edcar = new frmEditarCargos();
            edcar.Show();
            this.Hide();
        }
    }
}
