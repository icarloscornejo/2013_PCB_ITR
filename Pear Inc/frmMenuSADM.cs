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
    public partial class frmMenuSADM : Form
    {
        public frmMenuSADM()
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
            var cargos = new frmAgregarCargosSADM();
            cargos.Show();
            this.Hide();
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            var agreadms = new frmAgregarEmpleadosSADM();
            agreadms.Show();
            this.Hide();
        }

        private void btnEditarCargos_Click(object sender, EventArgs e)
        {
            var edcar = new frmEditarCargos();
            edcar.Show();
            this.Hide();
        }

        private void btnAgregarAdministradores_Click(object sender, EventArgs e)
        {
            var agreadm = new frmAgregarAdministradoresSADM();
            agreadm.Show();
            this.Hide();
        }

        private void btnEditarAdministradores_Click(object sender, EventArgs e)
        {
            var editadm = new frmEditarAdministradoresSADM();
            editadm.Show();
            this.Hide();
        }

    }
}
