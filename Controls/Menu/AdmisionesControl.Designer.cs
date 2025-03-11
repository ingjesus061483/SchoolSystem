namespace Controls.Menu
{
    partial class AdmisionesControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmisionesControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAcudiente = new System.Windows.Forms.ToolStripButton();
            this.toolStripStudent = new System.Windows.Forms.ToolStripButton();
            this.toolStripConcepto = new System.Windows.Forms.ToolStripButton();
            this.toolStripMatricula = new System.Windows.Forms.ToolStripButton();
            this.panelConfiguration = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAcudiente,
            this.toolStripStudent,
            this.toolStripConcepto,
            this.toolStripMatricula});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(709, 33);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAcudiente
            // 
            this.toolStripButtonAcudiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAcudiente.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAcudiente.Image")));
            this.toolStripButtonAcudiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAcudiente.Name = "toolStripButtonAcudiente";
            this.toolStripButtonAcudiente.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonAcudiente.Text = "toolStripButton1";
            this.toolStripButtonAcudiente.ToolTipText = "Acudiente";
            this.toolStripButtonAcudiente.Click += new System.EventHandler(this.toolStripButtonAcudiente_Click);
            // 
            // toolStripStudent
            // 
            this.toolStripStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStudent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStudent.Image")));
            this.toolStripStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStudent.Name = "toolStripStudent";
            this.toolStripStudent.Size = new System.Drawing.Size(34, 28);
            this.toolStripStudent.Text = "Estudiantes";
            this.toolStripStudent.Click += new System.EventHandler(this.toolStripStudent_Click);
            // 
            // toolStripConcepto
            // 
            this.toolStripConcepto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripConcepto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripConcepto.Image")));
            this.toolStripConcepto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripConcepto.Name = "toolStripConcepto";
            this.toolStripConcepto.Size = new System.Drawing.Size(34, 28);
            this.toolStripConcepto.ToolTipText = "Concepto";
            this.toolStripConcepto.Click += new System.EventHandler(this.toolStripConcepto_Click);
            // 
            // toolStripMatricula
            // 
            this.toolStripMatricula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMatricula.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMatricula.Image")));
            this.toolStripMatricula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMatricula.Name = "toolStripMatricula";
            this.toolStripMatricula.Size = new System.Drawing.Size(34, 28);
            this.toolStripMatricula.Text = "Matricula";
            this.toolStripMatricula.Click += new System.EventHandler(this.toolStripMatricula_Click);
            // 
            // panelConfiguration
            // 
            this.panelConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfiguration.Location = new System.Drawing.Point(0, 33);
            this.panelConfiguration.Name = "panelConfiguration";
            this.panelConfiguration.Size = new System.Drawing.Size(709, 725);
            this.panelConfiguration.TabIndex = 5;
            // 
            // AdmisionesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelConfiguration);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AdmisionesControl";
            this.Size = new System.Drawing.Size(709, 758);
            this.Load += new System.EventHandler(this.AdmisionesControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAcudiente;
        private System.Windows.Forms.ToolStripButton toolStripStudent;
        private System.Windows.Forms.ToolStripButton toolStripConcepto;
        private System.Windows.Forms.ToolStripButton toolStripMatricula;
        private System.Windows.Forms.Panel panelConfiguration;
    }
}
