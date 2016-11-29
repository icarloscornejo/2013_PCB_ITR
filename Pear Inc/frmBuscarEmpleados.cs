using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace Pear_Inc
{
    public partial class frmBuscarEmpleados : Form
    {
        public frmBuscarEmpleados()
        {
            InitializeComponent();
            cargar();
        }

        void buscarpordui()
        {

            string dui_emp;
            string consulta = "SELECT dui_emp FROM Empleados WHERE dui_emp = '" + txtBuscador.Text + "'";
            OleDbCommand sql = new OleDbCommand(consulta, Helper.Conexion);
            Helper.Conexion.Open();
            if (sql.ExecuteScalar() != null)
            {

                try
                {
                    dui_emp = Convert.ToString(sql.ExecuteScalar());

                    string consulta2 = "SELECT nom_emp, ape_emp, correo_emp, fecnac_emp, dir_emp, profesion_emp, tel_emp, dui_emp, nit_emp, fot_emp, car.nom_cargo FROM Empleados AS emp, Cargos AS car WHERE emp.cod_cargo = car.cod_cargo AND dui_emp LIKE '%" + dui_emp + "%'";
                    OleDbCommand sql2 = new OleDbCommand(consulta2, Helper.Conexion);
                    OleDbDataReader lector;
                    lector = sql2.ExecuteReader();
                    if (lector.Read())
                    {
                        txtNombres.Text = lector["nom_emp"].ToString();
                        txtApellidos.Text = lector["ape_emp"].ToString();
                        txtCorreo.Text = lector["correo_emp"].ToString();
                        dtpFecNac.Text = lector["fecnac_emp"].ToString();
                        txtDireccion.Text = lector["dir_emp"].ToString();
                        txtProfesion.Text = lector["profesion_emp"].ToString();
                        txtTelefono.Text = lector["tel_emp"].ToString();
                        txtDUI.Text = lector["dui_emp"].ToString();
                        txtNIT.Text = lector["nit_emp"].ToString();
                        pctFotoEmp.ImageLocation = lector["fot_emp"].ToString();
                        cmbCargo.Text = lector.GetValue(10).ToString();
                    }

                }

                catch (Exception ex)
                {
                    Helper.MsgBox("Error", "" + ex, "", "Aceptar");
                }
            }
            else
            {
            }
            Helper.Conexion.Close();
        }
        void buscarpornombre()
        {
            string dui_emp;
            string consulta = "SELECT dui_emp FROM Empleados WHERE (nom_emp +' ' +ape_emp) = '" + txtBuscador.Text + "'";
            OleDbCommand sql = new OleDbCommand(consulta, Helper.Conexion);
            Helper.Conexion.Open();
            if (sql.ExecuteScalar() != null)
            {

                try
                {
                    dui_emp = Convert.ToString(sql.ExecuteScalar());

                    string consulta2 = "SELECT nom_emp, ape_emp, correo_emp, fecnac_emp, dir_emp, profesion_emp, tel_emp, dui_emp, nit_emp, fot_emp, car.nom_cargo FROM Empleados AS emp, Cargos AS car WHERE emp.cod_cargo = car.cod_cargo AND dui_emp LIKE '%" + dui_emp + "%'";
                    OleDbCommand sql2 = new OleDbCommand(consulta2, Helper.Conexion);
                    OleDbDataReader lector;
                    lector = sql2.ExecuteReader();
                    if (lector.Read())
                    {
                        txtNombres.Text = lector["nom_emp"].ToString();
                        txtApellidos.Text = lector["ape_emp"].ToString();
                        txtCorreo.Text = lector["correo_emp"].ToString();
                        dtpFecNac.Text = lector["fecnac_emp"].ToString();
                        txtDireccion.Text = lector["dir_emp"].ToString();
                        txtProfesion.Text = lector["profesion_emp"].ToString();
                        txtTelefono.Text = lector["tel_emp"].ToString();
                        txtDUI.Text = lector["dui_emp"].ToString();
                        txtNIT.Text = lector["nit_emp"].ToString();
                        pctFotoEmp.ImageLocation = lector["fot_emp"].ToString();
                        cmbCargo.Text = lector.GetValue(10).ToString();
                    }

                }

                catch (Exception ex)
                {
                    Helper.MsgBox("Error",""+ex,"","Aceptar");
                }
            }
            Helper.Conexion.Close();
        }
        void buscarporapellido()
        {

            string dui_emp;
            string consulta = "SELECT dui_emp FROM Empleados WHERE (ape_emp +', ' +nom_emp) = '" + txtBuscador.Text + "'";
            OleDbCommand sql = new OleDbCommand(consulta, Helper.Conexion);
            Helper.Conexion.Open();
            if (sql.ExecuteScalar() != null)
            {

                try
                {
                    dui_emp = Convert.ToString(sql.ExecuteScalar());

                    string consulta2 = "SELECT nom_emp, ape_emp, correo_emp, fecnac_emp, dir_emp, profesion_emp, tel_emp, dui_emp, nit_emp, fot_emp, car.nom_cargo FROM Empleados AS emp, Cargos AS car WHERE emp.cod_cargo = car.cod_cargo AND dui_emp LIKE '%" + dui_emp + "%'";
                    OleDbCommand sql2 = new OleDbCommand(consulta2, Helper.Conexion);
                    OleDbDataReader lector;
                    lector = sql2.ExecuteReader();
                    if (lector.Read())
                    {
                        txtNombres.Text = lector["nom_emp"].ToString();
                        txtApellidos.Text = lector["ape_emp"].ToString();
                        txtCorreo.Text = lector["correo_emp"].ToString();
                        dtpFecNac.Text = lector["fecnac_emp"].ToString();
                        txtDireccion.Text = lector["dir_emp"].ToString();
                        txtProfesion.Text = lector["profesion_emp"].ToString();
                        txtTelefono.Text = lector["tel_emp"].ToString();
                        txtDUI.Text = lector["dui_emp"].ToString();
                        txtNIT.Text = lector["nit_emp"].ToString();
                        pctFotoEmp.ImageLocation = lector["fot_emp"].ToString();
                        cmbCargo.Text = lector.GetValue(10).ToString();
                    }

                }

                catch (Exception ex)
                {
                    Helper.MsgBox("Error", "" + ex, "", "Aceptar");
                }
            }
            else
            {
            }
            Helper.Conexion.Close();
        }
        private void cargar()
        {
            try
            {
                AutoCompleteStringCollection buscador = new AutoCompleteStringCollection();

                string consulta = "SELECT dui_emp, nom_emp, ape_emp FROM Empleados";
                OleDbCommand sql = new OleDbCommand(consulta, Helper.Conexion);
                OleDbDataReader reader;
                Helper.Conexion.Open();
                reader = sql.ExecuteReader();
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        buscador.Add(reader["dui_emp"].ToString());
                        buscador.Add((reader["nom_emp"].ToString()) + " " + (reader["ape_emp"].ToString()));
                        buscador.Add((reader["ape_emp"].ToString()) + ", " + (reader["nom_emp"].ToString()));
                    }
                }

                txtBuscador.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBuscador.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtBuscador.AutoCompleteCustomSource = buscador;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            Helper.Conexion.Close();
        }
        void reiniciar()
        {
            var busemp = new frmBuscarEmpleados();
            busemp.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarpordui();
            buscarpornombre();
            buscarporapellido();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Focus();
            btnPlanilla.Enabled = true;
            txtBuscador.Text = "Buscar por DUI, nombre, apellido..";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtCorreo.Enabled = true;
            pctFotoEmp.Enabled = true;
            txtDireccion.Enabled = true;
            txtProfesion.Enabled = true;
            txtNIT.Enabled = true;
            txtTelefono.Enabled = true;
            cmbCargo.Enabled = true;
            cmbCargo.Enabled = true;
            dtpFecNac.Enabled = true;
            btnMod.Visible = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            var men = new frmMenuSADM();
            men.Show();
            this.Hide();
        }

        void limpiarcampos()
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            dtpFecNac.Value = DateTime.Today;
            txtProfesion.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtNIT.Clear();
            txtDUI.Clear();
            pctFotoEmp.Image = null;
            cmbCargo.SelectedIndex = -1;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {

            string fotoempleado = null;
            if (pctFotoEmp.Image != null)
            {
                fotoempleado = "Empleados/" + txtDUI.Text + ".png";
                pctFotoEmp.Image.Save(fotoempleado, System.Drawing.Imaging.ImageFormat.Png);
            }
            else
            {
                fotoempleado = "Empleados/Nodisponible.png";
                Helper.MsgBox("Faltan datos", "Falta la foto de identificacion.", "", "Aceptar");
            }
            if (txtNombres.Text != "" && txtApellidos.Text != "" && txtCorreo.Text != "" && dtpFecNac.Text != "" && txtDireccion.Text != "" && txtProfesion.Text != "" && txtTelefono.Text != "" && txtDUI.Text != "" && txtNIT.Text != "" && cmbCargo.Text != "" && pctFotoEmp.Image != null)
            {
                if (Helper.Execute("UPDATE Empleados SET nom_emp = '"+ txtNombres.Text+"', ape_emp = '"+ txtApellidos.Text+"', correo_emp = '"+ txtCorreo.Text+"', fecnac_emp = '"+ dtpFecNac.Text+"', dir_emp = '"+ txtDireccion.Text+"', profesion_emp = '"+ txtProfesion.Text+"', tel_emp = '"+ txtTelefono.Text+"', nit_emp = '"+ txtNIT.Text+"', cod_cargo = '"+ cmbCargo.SelectedValue+"', fot_emp = '"+ fotoempleado+"' WHERE dui_emp = '" + txtDUI.Text + "'") > 0)
                {
                    Helper.MsgBox("Exito", "Operacion ejecutada con exito.", "", "Aceptar");
                    reiniciar();
                }
            }
            else
            {
                Helper.MsgBox("Error", "Faltan campos por completar.", "", "Aceptar");
            }
        }

        private void frmBuscarEmpleados_Load(object sender, EventArgs e)
        {
            cmbCargo.DataSource = Helper.Cargar("SELECT * FROM Cargos WHERE vacantes_cargo >= 0 ORDER BY nom_cargo");
            cmbCargo.DisplayMember = "nom_cargo";
            cmbCargo.ValueMember = "cod_cargo";
            cmbCargo.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Helper.Execute("DELETE * FROM Empleados WHERE dui_emp = '" + txtDUI.Text + "'") > 0)
            {
                Helper.MsgBox("Exito", "Operacion ejecutada con exito.", "", "Aceptar");
                limpiarcampos();
                reiniciar();
            }
        }

        private void txtBuscador_MouseClick(object sender, MouseEventArgs e)
        {
            txtBuscador.Text = "";
        }

        void calculartodo()
        {
            object salcar = Helper.ObtenerDato("SELECT sal_cargo FROM Cargos WHERE nom_cargo = '" + cmbCargo.Text + "'");
            double salario = Convert.ToDouble(salcar);
            Helper.Salario = salario;
            Helper.ISSS = Helper.RetencionISSS(salario);
            Helper.AFP = Helper.RetencionAFP(salario);
            Helper.ISR = Helper.RetencionISR(Helper.AFP, salario);
            Helper.Total = Helper.Totalretenciones(Helper.ISSS, Helper.AFP, Helper.ISR);
            Helper.SalarioNetoFinal = Helper.SalarioNeto();
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {

            try
            {
                calculartodo();
                Random esa = new Random();
                int esas = esa.Next(1,16);
                string pdf = "Recibo_Salarial.pdf";
                Document documento = new Document(PageSize.LETTER, 50, 50, 50, 100);
                PdfWriter.GetInstance(documento, new FileStream(pdf, FileMode.Create));
                documento.Open(); //Se abre el documento.
                //ENCABEZADO DEL DOCUMENTO.
                PdfPTable encabezado = new PdfPTable(3); //Se crea una tabla con tres columnas.
                encabezado.SetWidthPercentage(new float[] { 100, 350, 150 }, PageSize.LETTER); //Se asignan tamaños para las columnas en la pagina.
                //Se crean las celdas para la tabla.
                encabezado.AddCell(iTextSharp.text.Image.GetInstance("Pear.png"));
                encabezado.AddCell(new Paragraph("Pear Inc", FontFactory.GetFont("Calibri", 9, iTextSharp.text.Font.BOLD)));
                encabezado.AddCell(new Paragraph("Recibo Salarial No. " + esas + "\nRecibo salarial del mes de: "+DateTime.Today.Month, FontFactory.GetFont("Calibri", 9, iTextSharp.text.Font.BOLD)));
                //Se da formato a las celdas.
                foreach (PdfPCell celda in encabezado.Rows[0].GetCells())
                {
                    celda.BackgroundColor = BaseColor.LIGHT_GRAY; //Se establece el color de fondo para las celdas.
                    celda.HorizontalAlignment = 1; //Se define la alineación horizontal al centro.
                    celda.VerticalAlignment = 5; //Se define la alineación vertical al centro.
                    celda.Border = 0; //Se elimina el borde de las celdas.
                }
                documento.Add(encabezado); //Se agrega la tabla al documento.
                //CUERPO DEL DOCUMENTO.


                documento.Add(new Paragraph(" "));
                documento.Add(new Paragraph("Nombre: " + txtNombres.Text, FontFactory.GetFont("Calibri", 9)));
                documento.Add(new Paragraph("Apellido: " + txtApellidos.Text, FontFactory.GetFont("Calibri", 9)));
                documento.Add(new Paragraph("Profesion: " + txtProfesion.Text, FontFactory.GetFont("Calibri", 9)));
                documento.Add(new Paragraph("DUI: " + txtDUI.Text, FontFactory.GetFont("Calibri", 9)));
                documento.Add(new Paragraph(" ")); //Se agrega un parrafo en blanco.
                documento.Add(new Paragraph(" "));
                PdfPTable cuerpo = new PdfPTable(7); //Se crea una tabla con seis columnas para mostrar la información del juego.
                cuerpo.SetWidthPercentage(new float[] { 200, 60, 60, 60, 60, 70, 70 }, PageSize.LETTER); //Se asignan tamaños para las columnas en la pagina.
                //Se crean los encabezados para la tabla.


                Paragraph cargo = new Paragraph("Cargo: "+cmbCargo.Text, FontFactory.GetFont("Calibri", 10));
                cargo.Alignment = Element.ALIGN_RIGHT;
                documento.Add(cargo); 
                Paragraph salario = new Paragraph("Salario: "+Helper.Salario, FontFactory.GetFont("Calibri", 10));
                salario.Alignment = Element.ALIGN_RIGHT;
                documento.Add(salario);
                Paragraph ISR = new Paragraph("ISR: "+Helper.ISR, FontFactory.GetFont("Calibri", 10));
                ISR.Alignment = Element.ALIGN_RIGHT;
                documento.Add(ISR);
                Paragraph AFP = new Paragraph("AFP: "+Helper.AFP, FontFactory.GetFont("Calibri", 10));
                AFP.Alignment = Element.ALIGN_RIGHT;
                documento.Add(AFP);
                Paragraph ISSS = new Paragraph("ISSS: "+Helper.ISSS, FontFactory.GetFont("Calibri", 10));
                ISSS.Alignment = Element.ALIGN_RIGHT;
                documento.Add(ISSS);
                Paragraph linea = new Paragraph("________________");
                linea.Alignment = Element.ALIGN_RIGHT;
                documento.Add(linea);
                Paragraph Totalret = new Paragraph("Total Retenciones: "+Helper.Total, FontFactory.GetFont("Calibri", 10));
                Totalret.Alignment = Element.ALIGN_RIGHT;
                documento.Add(Totalret);
                Paragraph Salnet = new Paragraph("Salario Neto: "+Helper.SalarioNetoFinal, FontFactory.GetFont("Calibri", 16));
                Salnet.Alignment = Element.ALIGN_RIGHT;
                documento.Add(Salnet);
                //PIE DEL DOCUMENTO.
                documento.Add(new Paragraph(" "));
                documento.Add(new Paragraph(" "));
                documento.Add(new Paragraph(" "));
                documento.Add(new Paragraph(" "));
                documento.Add(new Paragraph(" "));
                Paragraph pie = new Paragraph("Recibo realizado por: " + Helper.UsuActual + "\n", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD));
                pie = new Paragraph("F.__________________Encargado                                                                           F.__________________Empleado", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.BOLD));
                pie.Alignment = Element.ALIGN_CENTER; //Se alinea al centro el parrafo.
                documento.Add(pie); //Se agrega el parrafo al documento.
                documento.Close(); //Se cierra el documento.
                //MOSTRAR EL ARCHIVO DEL DOCUMENTO.
                Process archivo = new Process(); //Se crea el archivo para el documento.
                archivo.StartInfo.FileName = pdf; //Se coloca el nombre al archivo.
                archivo.Start(); //Se abre el archivo.
                limpiarcampos();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = new frmPlanillaCompleta();
            n.Show();
        }

    }
}
