namespace Controls.Menu
{
    partial class FacturacionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturacionControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonProducto = new System.Windows.Forms.ToolStripButton();
            this.toolStripCategorias = new System.Windows.Forms.ToolStripButton();
            this.toolStripMensualidad = new System.Windows.Forms.ToolStripButton();
            this.toolStripMatricula = new System.Windows.Forms.ToolStripButton();
            this.panelFacturacion = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonProducto,
            this.toolStripCategorias,
            this.toolStripMensualidad,
            this.toolStripMatricula});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(594, 33);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonProducto
            // 
            this.toolStripButtonProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonProducto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonProducto.Image")));
            this.toolStripButtonProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProducto.Name = "toolStripButtonProducto";
            this.toolStripButtonProducto.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonProducto.Text = "toolStripButton1";
            this.toolStripButtonProducto.ToolTipText = "Productos";
            // 
            // toolStripCategorias
            // 
            this.toolStripCategorias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCategorias.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCategorias.Image")));
            this.toolStripCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCategorias.Name = "toolStripCategorias";
            this.toolStripCategorias.Size = new System.Drawing.Size(34, 28);
            this.toolStripCategorias.Text = "Estudiantes";
            this.toolStripCategorias.ToolTipText = "Categorias";
            // 
            // toolStripMensualidad
            // 
            this.toolStripMensualidad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMensualidad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMensualidad.Image")));
            this.toolStripMensualidad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMensualidad.Name = "toolStripMensualidad";
            this.toolStripMensualidad.Size = new System.Drawing.Size(34, 28);
            this.toolStripMensualidad.ToolTipText = "Mensualidad";
            this.toolStripMensualidad.Click += new System.EventHandler(this.toolStripMensualidad_Click);
            // 
            // toolStripMatricula
            // 
            this.toolStripMatricula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMatricula.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMatricula.Image")));
            this.toolStripMatricula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMatricula.Name = "toolStripMatricula";
            this.toolStripMatricula.Size = new System.Drawing.Size(34, 28);
            this.toolStripMatricula.Text = "Matricula";
            // 
            // panelFacturacion
            // 
            this.panelFacturacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFacturacion.Location = new System.Drawing.Point(0, 33);
            this.panelFacturacion.Name = "panelFacturacion";
            this.panelFacturacion.Size = new System.Drawing.Size(594, 577);
            this.panelFacturacion.TabIndex = 6;
            // 
            // FacturacionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelFacturacion);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FacturacionControl";
            this.Size = new System.Drawing.Size(594, 610);
            this.Load += new System.EventHandler(this.FacturacionControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonProducto;
        private System.Windows.Forms.ToolStripButton toolStripCategorias;
        private System.Windows.Forms.ToolStripButton toolStripMensualidad;
        private System.Windows.Forms.ToolStripButton toolStripMatricula;
        private System.Windows.Forms.Panel panelFacturacion;
    }
}
