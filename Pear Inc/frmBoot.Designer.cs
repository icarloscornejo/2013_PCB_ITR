namespace Pear_Inc
{
    partial class frmBoot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoot));
            this.pctCargando = new System.Windows.Forms.PictureBox();
            this.tmrCargando = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctCargando)).BeginInit();
            this.SuspendLayout();
            // 
            // pctCargando
            // 
            this.pctCargando.Image = global::Pear_Inc.Properties.Resources.Loading_Boot;
            this.pctCargando.Location = new System.Drawing.Point(671, 540);
            this.pctCargando.Name = "pctCargando";
            this.pctCargando.Size = new System.Drawing.Size(40, 40);
            this.pctCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCargando.TabIndex = 0;
            this.pctCargando.TabStop = false;
            // 
            // tmrCargando
            // 
            this.tmrCargando.Interval = 10000;
            this.tmrCargando.Tick += new System.EventHandler(this.tmrCargando_Tick);
            // 
            // frmBoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(744, 721);
            this.Controls.Add(this.pctCargando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pctCargando)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctCargando;
        private System.Windows.Forms.Timer tmrCargando;
    }
}

