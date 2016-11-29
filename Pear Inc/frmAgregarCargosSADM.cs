using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pear_Inc
{
    public partial class frmAgregarCargosSADM : Form
    {
        public frmAgregarCargosSADM()
        {
            InitializeComponent();
        }


        void mostrarNuevoCodigo()
        {
            try
            {
                Helper.Conexion.Open();
                string Consulta = "SELECT MAX(cod_cargo) FROM Cargos";
                OleDbCommand sql = new OleDbCommand(Consulta, Helper.Conexion);
                if (sql.ExecuteScalar() != DBNull.Value)
                {
                    txtcodcar.Text = Convert.ToString(Convert.ToInt32(sql.ExecuteScalar()) + 1);
                }
                else
                {
                    txtcodcar.Text = "1";
                }
            }
            catch (Exception ex)
            {
                Helper.MsgBox("Error", "" + ex, "", "Aceptar");
            }
            Helper.Conexion.Close();
        }

        void limpiarcampos()
        {
            txtnomcar.Clear();
            txtsalcar.Clear();
            cmbVacante.SelectedIndex = -1;
            mostrarNuevoCodigo();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            var men = new frmMenuSADM();
            men.Show();
            this.Hide();
        }

        private void pctEmpleados_Click(object sender, EventArgs e)
        {
            var agreadms = new frmAgregarEmpleadosSADM();
            agreadms.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double sal = Convert.ToDouble(txtsalcar.Text);
            if (txtnomcar.Text != "" && txtsalcar.Text != "" && cmbVacante.Text != "")
            {
                if (sal >= 0.01)
                {
                    if (Helper.Execute("INSERT INTO Cargos (cod_cargo, nom_cargo, sal_cargo, vacantes_cargo) VALUES (" + txtcodcar.Text + ", '" + txtnomcar.Text + "', '" + txtsalcar.Text + "', '" + cmbVacante.Text + "')") > 0)
                    {
                        Helper.MsgBox("Exito", "Operacion ejecutada con exito.", "", "Aceptar");
                        limpiarcampos();
                    }
                }
                else
                {
                    Helper.MsgBox("Error","Salario no permitido","","Aceptar");
                }
            }
            else
            {
                Helper.MsgBox("Error", "Faltan campos por completar.", "", "Aceptar");
            }
        }

        private void frmAgregarCargosSADM_Load(object sender, EventArgs e)
        {
            mostrarNuevoCodigo();
        }

        private void pctAdministradores_Click(object sender, EventArgs e)
        {
            var agradm = new frmAgregarAdministradoresSADM();
            agradm.Show();
            this.Hide();
        }

        private void txtnomcar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.sololetras(e);
        }

        private void txtsalcar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.solonumeros(e);
        }
    }
}
