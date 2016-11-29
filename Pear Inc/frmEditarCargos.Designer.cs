namespace Pear_Inc
{
    partial class frmEditarCargos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblcodcar = new System.Windows.Forms.Label();
            this.dgvCargos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsalcar = new System.Windows.Forms.Label();
            this.lblvaccar = new System.Windows.Forms.Label();
            this.txtcodcar = new System.Windows.Forms.TextBox();
            this.txtnomcar = new System.Windows.Forms.TextBox();
            this.txtsalcar = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(1201, 615);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 39);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(1055, 615);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(136, 39);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblcodcar
            // 
            this.lblcodcar.AutoSize = true;
            this.lblcodcar.BackColor = System.Drawing.Color.Transparent;
            this.lblcodcar.ForeColor = System.Drawing.Color.White;
            this.lblcodcar.Location = new System.Drawing.Point(115, 280);
            this.lblcodcar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcodcar.Name = "lblcodcar";
            this.lblcodcar.Size = new System.Drawing.Size(160, 25);
            this.lblcodcar.TabIndex = 6;
            this.lblcodcar.Text = "Codigo del Cargo:";
            // 
            // dgvCargos
            // 
            this.dgvCargos.AllowUserToAddRows = false;
            this.dgvCargos.AllowUserToDeleteRows = false;
            this.dgvCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCargos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvCargos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCargos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCargos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCargos.ColumnHeadersHeight = 25;
            this.dgvCargos.EnableHeadersVisualStyles = false;
            this.dgvCargos.Location = new System.Drawing.Point(953, 111);
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.ReadOnly = true;
            this.dgvCargos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCargos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCargos.RowHeadersVisible = false;
            this.dgvCargos.RowHeadersWidth = 40;
            this.dgvCargos.Size = new System.Drawing.Size(401, 472);
            this.dgvCargos.TabIndex = 8;
            this.dgvCargos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargos_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(514, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre del Cargo:";
            // 
            // lblsalcar
            // 
            this.lblsalcar.AutoSize = true;
            this.lblsalcar.BackColor = System.Drawing.Color.Transparent;
            this.lblsalcar.ForeColor = System.Drawing.Color.White;
            this.lblsalcar.Location = new System.Drawing.Point(99, 381);
            this.lblsalcar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblsalcar.Name = "lblsalcar";
            this.lblsalcar.Size = new System.Drawing.Size(187, 25);
            this.lblsalcar.TabIndex = 10;
            this.lblsalcar.Text = "Salario del Cargo:     $";
            // 
            // lblvaccar
            // 
            this.lblvaccar.AutoSize = true;
            this.lblvaccar.BackColor = System.Drawing.Color.Transparent;
            this.lblvaccar.ForeColor = System.Drawing.Color.White;
            this.lblvaccar.Location = new System.Drawing.Point(515, 329);
            this.lblvaccar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblvaccar.Name = "lblvaccar";
            this.lblvaccar.Size = new System.Drawing.Size(168, 25);
            this.lblvaccar.TabIndex = 11;
            this.lblvaccar.Text = "Vacantes del Cargo:";
            // 
            // txtcodcar
            // 
            this.txtcodcar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodcar.Enabled = false;
            this.txtcodcar.Location = new System.Drawing.Point(282, 280);
            this.txtcodcar.Name = "txtcodcar";
            this.txtcodcar.Size = new System.Drawing.Size(170, 26);
            this.txtcodcar.TabIndex = 12;
            // 
            // txtnomcar
            // 
            this.txtnomcar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnomcar.Enabled = false;
            this.txtnomcar.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomcar.Location = new System.Drawing.Point(519, 181);
            this.txtnomcar.Name = "txtnomcar";
            this.txtnomcar.Size = new System.Drawing.Size(378, 64);
            this.txtnomcar.TabIndex = 13;
            this.txtnomcar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomcar_KeyPress);
            // 
            // txtsalcar
            // 
            this.txtsalcar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsalcar.Enabled = false;
            this.txtsalcar.Location = new System.Drawing.Point(283, 380);
            this.txtsalcar.Name = "txtsalcar";
            this.txtsalcar.Size = new System.Drawing.Size(170, 26);
            this.txtsalcar.TabIndex = 14;
            this.txtsalcar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalcar_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(691, 329);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 33);
            this.comboBox1.TabIndex = 15;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(334, 615);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(138, 31);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(529, 615);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(138, 31);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(1210, 695);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(138, 31);
            this.btnAtras.TabIndex = 89;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmEditarCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Pear_Inc.Properties.Resources.frmCargos;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtsalcar);
            this.Controls.Add(this.txtnomcar);
            this.Controls.Add(this.txtcodcar);
            this.Controls.Add(this.lblvaccar);
            this.Controls.Add(this.lblsalcar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCargos);
            this.Controls.Add(this.lblcodcar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmEditarCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblcodcar;
        private System.Windows.Forms.DataGridView dgvCargos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsalcar;
        private System.Windows.Forms.Label lblvaccar;
        private System.Windows.Forms.TextBox txtcodcar;
        private System.Windows.Forms.TextBox txtnomcar;
        private System.Windows.Forms.TextBox txtsalcar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAtras;
    }
}