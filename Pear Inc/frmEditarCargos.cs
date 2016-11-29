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
    public partial class frmEditarCargos : Form
    {
        public frmEditarCargos()
        {
            InitializeComponent();
        }

        void cargardgv()
        {
            dgvCargos.DataSource = Helper.Cargar("SELECT cod_cargo, nom_cargo, sal_cargo, vacantes_cargo FROM Cargos");
            dgvCargos.Columns[0].HeaderText = "Codigo";
            dgvCargos.Columns[1].HeaderText = "Nombre";
            dgvCargos.Columns[2].HeaderText = "Salario";
            dgvCargos.Columns[3].HeaderText = "Vacantes";
            txtnomcar.Enabled = true;
            txtsalcar.Enabled = true;
            comboBox1.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            cargardgv();
        }

        private void dgvCargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodcar.Text = dgvCargos.CurrentRow.Cells[0].Value.ToString();
            txtnomcar.Text = dgvCargos.CurrentRow.Cells[1].Value.ToString();
            txtsalcar.Text = dgvCargos.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dgvCargos.CurrentRow.Cells[3].Value.ToString();
        }

        void limpiarcampos()
        {
            dgvCargos.DataSource = null;
            txtcodcar.Clear();
            txtnomcar.Clear();
            txtsalcar.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            if (txtnomcar.Text != "" && txtsalcar.Text != "" && comboBox1.Text != "")
            {
                if (Helper.Execute("UPDATE Cargos SET nom_cargo = '" + txtnomcar.Text + "', sal_cargo = '" + txtsalcar.Text + "', vacantes_cargo = '"+ comboBox1.Text+"' WHERE cod_cargo = '"+ txtcodcar.Text+"'" ) > 0)
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
            if (Helper.Execute("DELETE * FROM Cargos WHERE cod_cargo = '" + txtcodcar.Text + "'") > 0)
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
