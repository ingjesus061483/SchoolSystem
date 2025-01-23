namespace Controls
{
    partial class AsignaCursoUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignaCursoUser));
            this.dgAsignaturas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolSubjectId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.BtnCurso = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignaturas)).BeginInit();
            this.Panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAsignaturas
            // 
            this.dgAsignaturas.AllowUserToAddRows = false;
            this.dgAsignaturas.AllowUserToDeleteRows = false;
            this.dgAsignaturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAsignaturas.BackgroundColor = System.Drawing.Color.White;
            this.dgAsignaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsignaturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CourseId,
            this.SchoolSubjectId,
            this.Course,
            this.Subject});
            this.dgAsignaturas.Location = new System.Drawing.Point(9, 199);
            this.dgAsignaturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgAsignaturas.Name = "dgAsignaturas";
            this.dgAsignaturas.ReadOnly = true;
            this.dgAsignaturas.RowHeadersVisible = false;
            this.dgAsignaturas.RowHeadersWidth = 62;
            this.dgAsignaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAsignaturas.Size = new System.Drawing.Size(597, 226);
            this.dgAsignaturas.TabIndex = 1132;
            this.dgAsignaturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAsignaturas_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 150;
            // 
            // CourseId
            // 
            this.CourseId.DataPropertyName = "CourseId";
            this.CourseId.HeaderText = "CourseId";
            this.CourseId.MinimumWidth = 8;
            this.CourseId.Name = "CourseId";
            this.CourseId.ReadOnly = true;
            this.CourseId.Visible = false;
            this.CourseId.Width = 150;
            // 
            // SchoolSubjectId
            // 
            this.SchoolSubjectId.DataPropertyName = "SchoolSubjectId";
            this.SchoolSubjectId.HeaderText = "SchoolSubjectId";
            this.SchoolSubjectId.MinimumWidth = 8;
            this.SchoolSubjectId.Name = "SchoolSubjectId";
            this.SchoolSubjectId.ReadOnly = true;
            this.SchoolSubjectId.Visible = false;
            this.SchoolSubjectId.Width = 150;
            // 
            // Course
            // 
            this.Course.DataPropertyName = "Course";
            this.Course.HeaderText = "Curso";
            this.Course.MinimumWidth = 8;
            this.Course.Name = "Course";
            this.Course.ReadOnly = true;
            this.Course.Width = 150;
            // 
            // Subject
            // 
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Asignatura";
            this.Subject.MinimumWidth = 8;
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Width = 150;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.btnGuardar);
            this.Panel3.Controls.Add(this.btnEliminar);
            this.Panel3.Controls.Add(this.btnSalir);
            this.Panel3.Location = new System.Drawing.Point(9, 430);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(597, 62);
            this.Panel3.TabIndex = 1133;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(417, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 62);
            this.btnGuardar.TabIndex = 1099;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(477, 0);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 62);
            this.btnEliminar.TabIndex = 1100;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(537, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 62);
            this.btnSalir.TabIndex = 1084;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(597, 51);
            this.label4.TabIndex = 1139;
            this.label4.Text = "ASIGNATURA =>CURSOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurso
            // 
            this.txtCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCurso.Location = new System.Drawing.Point(95, 111);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurso.MaxLength = 40;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(478, 30);
            this.txtCurso.TabIndex = 1140;
            // 
            // BtnCurso
            // 
            this.BtnCurso.BackColor = System.Drawing.Color.Transparent;
            this.BtnCurso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCurso.BackgroundImage")));
            this.BtnCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCurso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCurso.ForeColor = System.Drawing.Color.Black;
            this.BtnCurso.Location = new System.Drawing.Point(35, 110);
            this.BtnCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCurso.Name = "BtnCurso";
            this.BtnCurso.Size = new System.Drawing.Size(54, 32);
            this.BtnCurso.TabIndex = 1141;
            this.BtnCurso.UseVisualStyleBackColor = false;
            this.BtnCurso.Click += new System.EventHandler(this.BtnCurso_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtAsignatura);
            this.panel1.Controls.Add(this.BtnCurso);
            this.panel1.Controls.Add(this.txtCurso);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 189);
            this.panel1.TabIndex = 0;
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsignatura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsignatura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAsignatura.Location = new System.Drawing.Point(35, 74);
            this.txtAsignatura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAsignatura.MaxLength = 40;
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.ReadOnly = true;
            this.txtAsignatura.Size = new System.Drawing.Size(538, 30);
            this.txtAsignatura.TabIndex = 1142;
            // 
            // AsignaCursoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.dgAsignaturas);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AsignaCursoUser";
            this.Size = new System.Drawing.Size(610, 497);
            this.Load += new System.EventHandler(this.AsignaCursoUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignaturas)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgAsignaturas;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtCurso;
        internal System.Windows.Forms.Button BtnCurso;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.TextBox txtAsignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolSubjectId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnEliminar;
    }
}
