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
    public partial class frmAgregarCargosADM : Form
    {
        public frmAgregarCargosADM()
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
                Helper.MsgBox("Error",""+ex,"","Aceptar");
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

        private void pctEmpleados_Click(object sender, EventArgs e)
        {
            var emp = new frmAgregarEmpleadosADM();
            emp.Show();
            this.Hide();
        }

        private void frmAgregarCargosADM_Load(object sender, EventArgs e)
        {
            mostrarNuevoCodigo();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            var men = new frmMenuADM();
            men.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtnomcar.Text != "" && txtsalcar.Text != "" && cmbVacante.Text != "")
            {
                if (Helper.Execute("INSERT INTO Cargos (cod_cargo, nom_cargo, sal_cargo, vacantes_cargo) VALUES (" + txtcodcar.Text + ", '" + txtnomcar.Text + "', '" + txtsalcar.Text + "', '" + cmbVacante.Text + "')") > 0)
                {
                    Helper.MsgBox("Exito", "Operacion ejecutada con exito.", "", "Aceptar");
                    limpiarcampos();
                }
            }
            else
            {
                Helper.MsgBox("Error","Faltan campos por completar.","","Aceptar");
            }
        }
    }
}
