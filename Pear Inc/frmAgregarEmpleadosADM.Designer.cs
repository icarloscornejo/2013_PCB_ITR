namespace Pear_Inc
{
    partial class frmAgregarEmpleadosADM
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
            this.pctCargos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // pctCargos
            // 
            this.pctCargos.BackColor = System.Drawing.Color.Transparent;
            this.pctCargos.Location = new System.Drawing.Point(1, 183);
            this.pctCargos.Name = "pctCargos";
            this.pctCargos.Size = new System.Drawing.Size(599, 60);
            this.pctCargos.TabIndex = 28;
            this.pctCargos.TabStop = false;
            this.pctCargos.Click += new System.EventHandler(this.pctCargos_Click);
            // 
            // frmAgregarEmpleadosADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pear_Inc.Properties.Resources.frmAgregarEmpleadosadm;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pctCargos);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAgregarEmpleadosADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pctCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCargos;
    }
}