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
    public partial class frmEditarAdministradoresSADM : Form
    {
        Helper AES;
        public frmEditarAdministradoresSADM()
        {
            InitializeComponent();
            AES = new Helper();
        }

        void cargardgv()
        {
            dgvCargos.DataSource = Helper.Cargar("SELECT usu_adm, con_adm, nom_adm, ape_adm, sex_adm, correo_adm FROM Administradores");
            dgvCargos.Columns[0].HeaderText = "Usuario";
            dgvCargos.Columns[1].HeaderText = "Contraseña";
            dgvCargos.Columns[2].HeaderText = "Nombres";
            dgvCargos.Columns[3].HeaderText = "Apellidos";
            dgvCargos.Columns[4].HeaderText = "Sexo";
            dgvCargos.Columns[5].HeaderText = "Correo";
            txtUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            cmbSexo.Enabled = true;
            txtCorreo.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
        void limpiarcampos()
        {

            dgvCargos.DataSource = null;
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            cmbSexo.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargardgv();
        }

        private void dgvCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuario.Text = AES.Desencriptar(dgvCargos.CurrentRow.Cells[0].Value.ToString());
            txtContraseña.Text = AES.Desencriptar(dgvCargos.CurrentRow.Cells[1].Value.ToString());
            txtNombres.Text = dgvCargos.CurrentRow.Cells[2].Value.ToString();
            txtApellidos.Text = dgvCargos.CurrentRow.Cells[3].Value.ToString();
            cmbSexo.Text = dgvCargos.CurrentRow.Cells[4].Value.ToString();
            txtCorreo.Text = dgvCargos.CurrentRow.Cells[5].Value.ToString();
             usumod = AES.Encriptar(txtUsuario.Text);
        }

        public static string usumod;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            string usuario = AES.Encriptar(txtUsuario.Text);
            string contraseña = AES.Encriptar(txtContraseña.Text);
            if (txtUsuario.Text != "" && txtContraseña.Text != "" && txtNombres.Text != "" && txtApellidos.Text != "" && txtCorreo.Text != "" && cmbSexo.Text != "")
            {
                if (Helper.Execute("UPDATE Administradores SET usu_adm = '"+ usuario+"', con_adm = '"+ contraseña+"', nom_adm = '"+ txtNombres.Text+"', ape_adm = '"+ txtApellidos.Text+"', sex_adm = '"+ cmbSexo.Text+"', correo_adm = '"+ txtCorreo.Text+"' WHERE usu_adm = '"+ usumod+"'") > 0)
                {
                    Helper.MsgBox("Exito", "Operacion ejecutada con exito.", "", "Aceptar");
                    limpiarcampos();
                    cargardgv();
                }
            }
            else
            {
                Helper.MsgBox("Error", "Faltan campos por completar.", "", "Aceptar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Helper.Execute("DELETE * FROM Administradores WHERE usu_adm = '" + usumod + "'") > 0)
            {
                Helper.MsgBox("Exito", "Operacion ejecutada con exito.", "", "Aceptar");
                limpiarcampos();
                cargardgv();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            var men = new frmMenuSADM();
            men.Show();
            this.Hide();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.sololetras(e);
        }
    }
}
