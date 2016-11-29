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
    public partial class frmLogin : Form
    {
        Helper AES;
        public frmLogin()
        {
            InitializeComponent();
            AES = new Helper();
        }

        void limpiarcampos()
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }
        private void pctSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMostrarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;
        }

        private void btnMostrarContraseña_MouseUp(object sender, MouseEventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "")
            {
                btnMostrarContraseña.Visible = true;
            }
            else
            {
                btnMostrarContraseña.Visible = false;
            }
        }


        private void btnAccesar_Click(object sender, EventArgs e)
        {
            try
            {
                string Usuario = AES.Encriptar(txtUsuario.Text.ToLower());
                string Contraseña = AES.Encriptar(txtContraseña.Text);
                object dato = Helper.ObtenerDato("SELECT usu_sadm FROM SuperAdministradores WHERE usu_sadm = '" + Usuario + "' AND con_sadm = '" + Contraseña + "'");
                if (dato != null)
                {
                    Helper.UsuActual = AES.Desencriptar(dato.ToString());
                    lblUsuarioActual.Text = Helper.UsuActual;
                    groupBox1.Visible = true;
                    Helper.TipoUsuActual = "SAdm";
                    tmrLogin.Start();
                }
                else
                {
                    object dato2 = Helper.ObtenerDato("SELECT usu_adm FROM Administradores WHERE usu_adm = '" + Usuario + "' AND con_adm = '" + Contraseña + "'");
                    if (dato2 != null)
                    {
                        Helper.UsuActual = AES.Desencriptar(dato2.ToString());
                        lblUsuarioActual.Text = Helper.UsuActual;
                        groupBox1.Visible = true;
                        Helper.TipoUsuActual = "Adm";
                        tmrLogin.Start();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectas.", "Error");
                        limpiarcampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void tmrLogin_Tick(object sender, EventArgs e)
        {
            tmrLogin.Stop();
            if (Helper.TipoUsuActual == "SAdm")
            {
                var menusadm = new frmMenuSADM();
                menusadm.Show();
                this.Hide();
            }
            else if(Helper.TipoUsuActual == "Adm")
            {
                var menuadm = new frmMenuADM();
                menuadm.Show();
                this.Hide();
            }
        }
        
    }
}
