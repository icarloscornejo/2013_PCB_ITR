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
    public partial class frmPlanillaCompleta : Form
    {
        public frmPlanillaCompleta()
        {
            InitializeComponent();
        }

        private void frmPlanillaCompleta_Load(object sender, EventArgs e)
        {
            for (int i = 2; i <= 11; i++)
            {
                object emp = Helper.ObtenerDato("SELECT nom_emp FROM Empleados WHERE id_emp = " + i + "");
                object ape = Helper.ObtenerDato("SELECT ape_emp FROM Empleados WHERE id_emp = " + i + "");
                object cargo_emp = Helper.ObtenerDato("SELECT emp.cod_cargo FROM Empleados AS emp, Cargos AS car WHERE emp.cod_cargo = car.cod_cargo AND id_emp = " + i + "");
                string empleado = Convert.ToString(emp) + " "+Convert.ToString(ape);
                string cargo_empleado = Convert.ToString(cargo_emp);
                object salcar = Helper.ObtenerDato("SELECT sal_cargo FROM Cargos WHERE cod_cargo = '" + cargo_empleado + "'");
                double salario = Convert.ToDouble(salcar);
                Helper.Salario = salario;
                Helper.ISSS = Helper.RetencionISSS(salario);
                Helper.AFP = Helper.RetencionAFP(salario);
                Helper.ISR = Helper.RetencionISR(Helper.AFP, salario);
                Helper.Total = Helper.Totalretenciones(Helper.ISSS, Helper.AFP, Helper.ISR);
                Helper.SalarioNetoFinal = Helper.SalarioNeto();
                dgvCargos.Rows.Add(empleado, cargo_empleado, Helper.Salario, Helper.ISR, Helper.ISSS, Helper.AFP, Helper.Total, Helper.SalarioNetoFinal);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
