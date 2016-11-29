using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Data.OleDb;

namespace Pear_Inc
{
    public partial class frmAgregarEmpleadosSADM : Form
    {
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;

        public frmAgregarEmpleadosSADM()
        {
            InitializeComponent();
            BuscarDispositivos();
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
            pctWebcam.Image = null;
            cmbCargo.SelectedIndex = -1;
        }
        public static string dispositivo;

        public void DispositivodeVideoDisponible(FilterInfoCollection Dispositivos)
        {
            dispositivo = Dispositivos[0].Name.ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }

            else
            {
                ExisteDispositivo = true;
                DispositivodeVideoDisponible(DispositivoDeVideo);

            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }

        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pctWebcam.Image = Imagen;

        }

        private void pctCargos_Click(object sender, EventArgs e)
        {
            var agrcar = new frmAgregarCargosSADM();
            agrcar.Show();
            this.Hide();
        }

        private void btnWebcam_Click(object sender, EventArgs e)
        {

            if (btnWebcam.Text == "Webcam")
            {
                if (ExisteDispositivo)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[0].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    btnWebcam.Text = "Capturar";
                }
                else
                {
                    Helper.MsgBox("Error", "No se encuentra el dispositivo.", "", "Aceptar");
                }
            }

            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    btnWebcam.Text = "Webcam";
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fotoempleado = null;
            if (pctWebcam.Image != null)
            {
                fotoempleado = "Empleados/" + txtDUI.Text + ".png";
                pctWebcam.Image.Save(fotoempleado, System.Drawing.Imaging.ImageFormat.Png);
            }
            else
            {
                    fotoempleado = "Empleados/Nodisponible.png";
                    Helper.MsgBox("Faltan datos","Falta la foto de identificacion.","","Aceptar");
            }
            if (txtNombres.Text != "" && txtApellidos.Text != "" && txtCorreo.Text != "" && dtpFecNac.Text != "" && txtDireccion.Text != "" && txtProfesion.Text != "" && txtTelefono.Text != "" && txtDUI.Text != "" && txtNIT.Text != "" && cmbCargo.Text != "" && pctWebcam.Image != null)
            {
                string esa = dtpFecNac.Text.Replace("/", "");
                string fec = esa.Remove(4, 2);
                MessageBox.Show(fec);
                bool contiene = txtNIT.Text.Contains(fec);
                string tel = txtTelefono.Text.Replace("-", "");
                string telefono = tel.Replace("_", "");
                string nit = txtNIT.Text.Replace("-","");
                string dui = txtDUI.Text.Replace("-","");
                if (contiene == true && telefono.Length == 8 && telefono.StartsWith("2") && nit.Length == 14 && dui.Length == 8)
                {
                    if (Helper.comprobarEmail(txtCorreo.Text) == true)
                    {
                        if (Helper.Execute("INSERT INTO Empleados (nom_emp, ape_emp, correo_emp, fecnac_emp, dir_emp, profesion_emp, tel_emp, dui_emp, nit_emp, fot_emp, cod_cargo) VALUES ('" + txtNombres.Text + "', '" + txtApellidos.Text + "', '" + txtCorreo.Text + "', '" + dtpFecNac.Text + "', '" + txtDireccion.Text + "', '" + txtProfesion.Text + "', '" + txtTelefono.Text + "', '" + txtDUI.Text + "', '" + txtNIT.Text + "', '" + fotoempleado + "', '" + cmbCargo.SelectedValue + "')") > 0)
                        {
                            Helper.Execute("UPDATE Cargos SET vacantes_cargo = (vacantes_cargo - 1) WHERE nom_cargo = '" + cmbCargo.Text + "'");
                            Helper.MsgBox("Exito", "Operacion ejecutada con exito.", "", "Aceptar");
                            limpiarcampos();
                            cargos();
                        }
                    }
                    else
                    {
                        Helper.MsgBox("Error","Correo no valido","","Aceptar");
                    }
                }
                else
                {
                    Helper.MsgBox("Error", "La fecha de nacimiento no coincide con el nit.","","Aceptar");
                }
            }
            else
            {
                Helper.MsgBox("Error", "Faltan campos por completar.", "", "Aceptar");
            }
        }

        private void frmAgregarEmpleadosSADM_Load(object sender, EventArgs e)
        {
            cmbCargo.DataSource = Helper.Cargar("SELECT * FROM Cargos WHERE vacantes_cargo > 0 ORDER BY nom_cargo");
            cmbCargo.DisplayMember = "nom_cargo";
            cmbCargo.ValueMember = "cod_cargo";
            cmbCargo.SelectedIndex = -1;
        }

        void cargos()
        {
            cmbCargo.DataSource = Helper.Cargar("SELECT * FROM Cargos WHERE vacantes_cargo > 0 ORDER BY nom_cargo");
            cmbCargo.DisplayMember = "nom_cargo";
            cmbCargo.ValueMember = "cod_cargo";
            cmbCargo.SelectedIndex = -1;
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            var men = new frmMenuSADM();
            men.Show();
            this.Hide();
        }

        private void pctAdministradores_Click(object sender, EventArgs e)
        {
            var agradm = new frmAgregarAdministradoresSADM();
            agradm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.sololetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.sololetras(e);
        }

        private void txtProfesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.sololetras(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.sololetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helper.solonumeros(e);
        }

    }
}
