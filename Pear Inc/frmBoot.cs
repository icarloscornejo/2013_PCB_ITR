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
    public partial class frmBoot : Form
    {
        public frmBoot()
        {
            InitializeComponent();
            tmrCargando.Start();
        }

        private void tmrCargando_Tick(object sender, EventArgs e)
        {
            tmrCargando.Stop();
            var login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
