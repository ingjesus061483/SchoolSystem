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
            this.pnlbody = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCourse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSchoolSubject = new System.Windows.Forms.ToolStripButton();
            this.toolStripStudent = new System.Windows.Forms.ToolStripButton();
            this.toolStripMatricula = new System.Windows.Forms.ToolStripButton();
            this.toolStripConcepto = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 450);
            this.panel1.TabIndex = 0;
            // 
            // pnlbody
            // 
            this.pnlbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbody.Location = new System.Drawing.Point(221, 33);
            this.pnlbody.Name = "pnlbody";
            this.pnlbody.Size = new System.Drawing.Size(579, 417);
            this.pnlbody.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCourse,
            this.toolStripButtonSchoolSubject,
            this.toolStripStudent,
            this.toolStripConcepto,
            this.toolStripMatricula});
            this.toolStrip1.Location = new System.Drawing.Point(221, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(579, 33);
            this.toolStrip1.TabIndex = 2;
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
            this.toolStripButtonSchoolSubject.Size = new System.Drawing.Size(34, 33);
            this.toolStripButtonSchoolSubject.Text = "toolStripButton1";
            this.toolStripButtonSchoolSubject.ToolTipText = "Asignatura";
            this.toolStripButtonSchoolSubject.Click += new System.EventHandler(this.toolStripButtonSchoolSubject_Click);
            // 
            // toolStripStudent
            // 
            this.toolStripStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStudent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStudent.Image")));
            this.toolStripStudent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStudent.Name = "toolStripStudent";
            this.toolStripStudent.Size = new System.Drawing.Size(34, 33);
            this.toolStripStudent.Text = "Estudiantes";
            this.toolStripStudent.Click += new System.EventHandler(this.toolStripStudent_Click);
            // 
            // toolStripMatricula
            // 
            this.toolStripMatricula.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMatricula.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMatricula.Image")));
            this.toolStripMatricula.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMatricula.Name = "toolStripMatricula";
            this.toolStripMatricula.Size = new System.Drawing.Size(34, 33);
            this.toolStripMatricula.Text = "Matricula";
            this.toolStripMatricula.Click += new System.EventHandler(this.toolStripMatricula_Click);
            // 
            // toolStripConcepto
            // 
            this.toolStripConcepto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripConcepto.Image = ((System.Drawing.Image)(resources.GetObject("toolStripConcepto.Image")));
            this.toolStripConcepto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripConcepto.Name = "toolStripConcepto";
            this.toolStripConcepto.Size = new System.Drawing.Size(34, 33);
            this.toolStripConcepto.ToolTipText = "Concepto";
            this.toolStripConcepto.Click += new System.EventHandler(this.toolStripConcepto_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlbody);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlbody;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCourse;
        private System.Windows.Forms.ToolStripButton toolStripButtonSchoolSubject;
        private System.Windows.Forms.ToolStripButton toolStripStudent;
        private System.Windows.Forms.ToolStripButton toolStripMatricula;
        private System.Windows.Forms.ToolStripButton toolStripConcepto;
    }
}

