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
    public partial class frmAgregarAdministradoresSADM : Form
    {
        Helper AES;
        public frmAgregarAdministradoresSADM()
        {
            InitializeComponent();
            AES = new Helper();
        }

        void limpiarcampos()
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            cmbSexo.SelectedIndex = -1;
            txtCorreo.Clear();
            txtUsuario.Focus();
        }

        private void pctEmpleados_Click(object sender, EventArgs e)
        {
            var agreadms = new frmAgregarEmpleadosSADM();
            agreadms.Show();
            this.Hide();
        }

        private void pctCargos_Click(object sender, EventArgs e)
        {
            var agrcar = new frmAgregarCargosSADM();
            agrcar.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtContraseña.Text != "" && txtNombres.Text != "" && txtApellidos.Text != "" && txtCorreo.Text != "" && cmbSexo.Text != "")
            {
                if (Helper.comprobarEmail(txtCorreo.Text) == true)
                {
                    string usuario = AES.Encriptar(txtUsuario.Text);
                    string contraseña = AES.Encriptar(txtContraseña.Text);
                    if (Helper.Execute("INSERT INTO Administradores (usu_adm, con_adm, nom_adm, ape_adm, sex_adm, correo_adm) VALUES ('" + usuario + "', '" + contraseña + "', '" + txtNombres.Text + "', '" + txtApellidos.Text + "', '" + cmbSexo.Text + "', '" + txtCorreo.Text + "')") > 0)
                    {
                        Helper.MsgBox("Exito", "Operacion ejecutada con exito.", "", "Aceptar");
                        limpiarcampos();
                    }
                }
                else
                {
                    Helper.MsgBox("Error","Correo no valido.","","Aceptar");
                }
            }
            else
            {
                Helper.MsgBox("Error", "Faltan campos por completar.", "", "Aceptar");
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.sololetras(e);
        }
    }
}
