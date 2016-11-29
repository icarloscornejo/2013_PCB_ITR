namespace Pear_Inc
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOlvideContraseña = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.pctSalir = new System.Windows.Forms.PictureBox();
            this.btnMostrarContraseña = new System.Windows.Forms.Button();
            this.btnAccesar = new System.Windows.Forms.Button();
            this.lblUsuarioActual = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pctCargando = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tmrLogin = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCargando)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOlvideContraseña
            // 
            this.btnOlvideContraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnOlvideContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlvideContraseña.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlvideContraseña.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnOlvideContraseña.Location = new System.Drawing.Point(597, 322);
            this.btnOlvideContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOlvideContraseña.Name = "btnOlvideContraseña";
            this.btnOlvideContraseña.Size = new System.Drawing.Size(309, 52);
            this.btnOlvideContraseña.TabIndex = 3;
            this.btnOlvideContraseña.TabStop = false;
            this.btnOlvideContraseña.Text = "           Olvide mi contraseña";
            this.btnOlvideContraseña.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnOlvideContraseña.UseVisualStyleBackColor = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(606, 196);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(298, 26);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(606, 277);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(241, 26);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // pctSalir
            // 
            this.pctSalir.BackColor = System.Drawing.Color.Transparent;
            this.pctSalir.Location = new System.Drawing.Point(1283, 691);
            this.pctSalir.Name = "pctSalir";
            this.pctSalir.Size = new System.Drawing.Size(53, 51);
            this.pctSalir.TabIndex = 4;
            this.pctSalir.TabStop = false;
            this.pctSalir.Click += new System.EventHandler(this.pctSalir_Click);
            // 
            // btnMostrarContraseña
            // 
            this.btnMostrarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.btnMostrarContraseña.BackgroundImage = global::Pear_Inc.Properties.Resources.MostrarContraseña;
            this.btnMostrarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarContraseña.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarContraseña.ForeColor = System.Drawing.Color.White;
            this.btnMostrarContraseña.Location = new System.Drawing.Point(846, 276);
            this.btnMostrarContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrarContraseña.Name = "btnMostrarContraseña";
            this.btnMostrarContraseña.Size = new System.Drawing.Size(30, 30);
            this.btnMostrarContraseña.TabIndex = 5;
            this.btnMostrarContraseña.TabStop = false;
            this.btnMostrarContraseña.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMostrarContraseña.UseVisualStyleBackColor = false;
            this.btnMostrarContraseña.Visible = false;
            this.btnMostrarContraseña.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMostrarContraseña_MouseDown);
            this.btnMostrarContraseña.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMostrarContraseña_MouseUp);
            // 
            // btnAccesar
            // 
            this.btnAccesar.BackColor = System.Drawing.Color.Transparent;
            this.btnAccesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccesar.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccesar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnAccesar.Location = new System.Drawing.Point(876, 276);
            this.btnAccesar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccesar.Name = "btnAccesar";
            this.btnAccesar.Size = new System.Drawing.Size(28, 28);
            this.btnAccesar.TabIndex = 6;
            this.btnAccesar.TabStop = false;
            this.btnAccesar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAccesar.UseVisualStyleBackColor = false;
            this.btnAccesar.Click += new System.EventHandler(this.btnAccesar_Click);
            // 
            // lblUsuarioActual
            // 
            this.lblUsuarioActual.AutoSize = true;
            this.lblUsuarioActual.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioActual.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioActual.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioActual.Location = new System.Drawing.Point(6, 25);
            this.lblUsuarioActual.Name = "lblUsuarioActual";
            this.lblUsuarioActual.Size = new System.Drawing.Size(154, 32);
            this.lblUsuarioActual.TabIndex = 7;
            this.lblUsuarioActual.Text = "UsuarioActual";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(57, 106);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(165, 32);
            this.lblMenu.TabIndex = 8;
            this.lblMenu.Text = "Menu principal";
            // 
            // pctCargando
            // 
            this.pctCargando.BackColor = System.Drawing.Color.Transparent;
            this.pctCargando.Image = global::Pear_Inc.Properties.Resources.Loading_Boot;
            this.pctCargando.Location = new System.Drawing.Point(11, 96);
            this.pctCargando.Name = "pctCargando";
            this.pctCargando.Size = new System.Drawing.Size(45, 45);
            this.pctCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCargando.TabIndex = 9;
            this.pctCargando.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.groupBox1.Controls.Add(this.lblUsuarioActual);
            this.groupBox1.Controls.Add(this.pctCargando);
            this.groupBox1.Controls.Add(this.lblMenu);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(597, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 230);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // tmrLogin
            // 
            this.tmrLogin.Interval = 10000;
            this.tmrLogin.Tick += new System.EventHandler(this.tmrLogin_Tick);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnAccesar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::Pear_Inc.Properties.Resources.Login;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAccesar);
            this.Controls.Add(this.btnMostrarContraseña);
            this.Controls.Add(this.pctSalir);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnOlvideContraseña);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pctSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCargando)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOlvideContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox pctSalir;
        private System.Windows.Forms.Button btnMostrarContraseña;
        private System.Windows.Forms.Button btnAccesar;
        private System.Windows.Forms.Label lblUsuarioActual;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pctCargando;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer tmrLogin;

    }
}