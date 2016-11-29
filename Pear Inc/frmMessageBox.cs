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
    public partial class frmMessageBox : Form
    {
        Helper AES;
        public frmMessageBox()
        {
            InitializeComponent();
            AES = new Helper();
        }

        private void frmMessageBox_Load(object sender, EventArgs e)
        {
            lbltitulo.Text = Helper.MsgBoxTitulo;
            lblsubtitulo.Text = Helper.MsgBoxSubTitulo;
            if (Helper.MsgBoxLoad == "Aceptar")
            {
                btnCancelar.Visible = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(Helper.MsgBoxBoton == "SAdm")
            {
                MessageBox.Show("SADM");
            }
            else if(Helper.MsgBoxBoton == "Adm")
            {
                MessageBox.Show("ADM");
            }
            else if(Helper.MsgBoxBoton == "")
            {
                this.Close();
            }
        }
    }
}
