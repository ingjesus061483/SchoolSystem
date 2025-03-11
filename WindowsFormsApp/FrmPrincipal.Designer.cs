namespace WindowsFormsApp
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnAdmisiones = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.pnlbody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnFacturacion);
            this.panel1.Controls.Add(this.btnNotas);
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnAdmisiones);
            this.panel1.Controls.Add(this.btnConfiguracion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 697);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(70, 647);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 69);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.BackgroundImage")));
            this.btnFacturacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Location = new System.Drawing.Point(70, 536);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(75, 69);
            this.btnFacturacion.TabIndex = 4;
            this.btnFacturacion.UseVisualStyleBackColor = true;
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNotas.BackgroundImage")));
            this.btnNotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Location = new System.Drawing.Point(70, 319);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(75, 69);
            this.btnNotas.TabIndex = 3;
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReportes.BackgroundImage")));
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Location = new System.Drawing.Point(70, 427);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 69);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnAdmisiones
            // 
            this.btnAdmisiones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdmisiones.BackgroundImage")));
            this.btnAdmisiones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmisiones.FlatAppearance.BorderSize = 0;
            this.btnAdmisiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmisiones.Location = new System.Drawing.Point(70, 207);
            this.btnAdmisiones.Name = "btnAdmisiones";
            this.btnAdmisiones.Size = new System.Drawing.Size(75, 69);
            this.btnAdmisiones.TabIndex = 1;
            this.btnAdmisiones.UseVisualStyleBackColor = true;
            this.btnAdmisiones.Click += new System.EventHandler(this.btnAdmisiones_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.BackgroundImage")));
            this.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfiguracion.FlatAppearance.BorderSize = 0;
            this.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracion.Location = new System.Drawing.Point(70, 92);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(75, 69);
            this.btnConfiguracion.TabIndex = 0;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // pnlbody
            // 
            this.pnlbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbody.Location = new System.Drawing.Point(221, 0);
            this.pnlbody.Name = "pnlbody";
            this.pnlbody.Size = new System.Drawing.Size(579, 697);
            this.pnlbody.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 697);
            this.Controls.Add(this.pnlbody);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlbody;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnAdmisiones;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnSalir;
    }
}

