namespace Controls.Menu
{
    partial class ConfiguracionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracionControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCourse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSchoolSubject = new System.Windows.Forms.ToolStripButton();
            this.toolStripTeacher = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPeriodo = new System.Windows.Forms.ToolStripButton();
            this.panelConfiguration = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCourse,
            this.toolStripButtonSchoolSubject,
            this.toolStripTeacher,
            this.toolStripButtonPeriodo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(739, 33);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonCourse
            // 
            this.toolStripButtonCourse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCourse.BackgroundImage")));
            this.toolStripButtonCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCourse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCourse.Name = "toolStripButtonCourse";
            this.toolStripButtonCourse.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonCourse.Text = "toolStripButton1";
            this.toolStripButtonCourse.ToolTipText = "Cursos";
            this.toolStripButtonCourse.Click += new System.EventHandler(this.toolStripButtonCourse_Click);
            // 
            // toolStripButtonSchoolSubject
            // 
            this.toolStripButtonSchoolSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSchoolSubject.BackgroundImage")));
            this.toolStripButtonSchoolSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonSchoolSubject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSchoolSubject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSchoolSubject.Name = "toolStripButtonSchoolSubject";
            this.toolStripButtonSchoolSubject.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonSchoolSubject.Text = "toolStripButton1";
            this.toolStripButtonSchoolSubject.ToolTipText = "Asignatura";
            this.toolStripButtonSchoolSubject.Click += new System.EventHandler(this.toolStripButtonSchoolSubject_Click);
            // 
            // toolStripTeacher
            // 
            this.toolStripTeacher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripTeacher.Image = ((System.Drawing.Image)(resources.GetObject("toolStripTeacher.Image")));
            this.toolStripTeacher.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripTeacher.Name = "toolStripTeacher";
            this.toolStripTeacher.Size = new System.Drawing.Size(34, 28);
            this.toolStripTeacher.Text = "toolStripButton1";
            this.toolStripTeacher.ToolTipText = "Profesor";
            this.toolStripTeacher.Click += new System.EventHandler(this.toolStripTeacher_Click);
            // 
            // toolStripButtonPeriodo
            // 
            this.toolStripButtonPeriodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPeriodo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPeriodo.Image")));
            this.toolStripButtonPeriodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPeriodo.Name = "toolStripButtonPeriodo";
            this.toolStripButtonPeriodo.Size = new System.Drawing.Size(34, 28);
            this.toolStripButtonPeriodo.Text = "toolStripButton1";
            this.toolStripButtonPeriodo.ToolTipText = "Periodo";
            this.toolStripButtonPeriodo.Click += new System.EventHandler(this.toolStripButtonPeriodo_Click);
            // 
            // panelConfiguration
            // 
            this.panelConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConfiguration.Location = new System.Drawing.Point(0, 33);
            this.panelConfiguration.Name = "panelConfiguration";
            this.panelConfiguration.Size = new System.Drawing.Size(739, 680);
            this.panelConfiguration.TabIndex = 4;
            // 
            // ConfiguracionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelConfiguration);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ConfiguracionControl";
            this.Size = new System.Drawing.Size(739, 713);
            this.Load += new System.EventHandler(this.ConfiguracionControl_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCourse;
        private System.Windows.Forms.ToolStripButton toolStripButtonSchoolSubject;
        private System.Windows.Forms.ToolStripButton toolStripTeacher;
        private System.Windows.Forms.Panel panelConfiguration;
        private System.Windows.Forms.ToolStripButton toolStripButtonPeriodo;
    }
}
