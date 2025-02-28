namespace Controls.Menu
{
    partial class NotasControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotasControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonLogro = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCalificaciones = new System.Windows.Forms.ToolStripButton();
            this.pnlNotas = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonLogro,
            this.toolStripButtonCalificaciones});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(737, 33);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonLogro
            // 
            this.toolStripButtonLogro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLogro.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLogro.Image")));
            this.toolStripButtonLogro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLogro.Name = "toolStripButtonLogro";
            this.toolStripButtonLogro.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonLogro.Text = "toolStripButton1";
            this.toolStripButtonLogro.ToolTipText = "Logros";
            this.toolStripButtonLogro.Click += new System.EventHandler(this.toolStripButtonLogro_Click);
            // 
            // toolStripButtonCalificaciones
            // 
            this.toolStripButtonCalificaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCalificaciones.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCalificaciones.Image")));
            this.toolStripButtonCalificaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCalificaciones.Name = "toolStripButtonCalificaciones";
            this.toolStripButtonCalificaciones.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonCalificaciones.Text = "toolStripButton1";
            this.toolStripButtonCalificaciones.ToolTipText = "Calificaciones";
            this.toolStripButtonCalificaciones.Click += new System.EventHandler(this.toolStripButtonCalificaciones_Click);
            // 
            // pnlNotas
            // 
            this.pnlNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotas.Location = new System.Drawing.Point(0, 33);
            this.pnlNotas.Name = "pnlNotas";
            this.pnlNotas.Size = new System.Drawing.Size(737, 717);
            this.pnlNotas.TabIndex = 4;
            // 
            // NotasControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlNotas);
            this.Controls.Add(this.toolStrip1);
            this.Name = "NotasControl";
            this.Size = new System.Drawing.Size(737, 750);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogro;
        private System.Windows.Forms.ToolStripButton toolStripButtonCalificaciones;
        private System.Windows.Forms.Panel pnlNotas;
    }
}
