namespace Controls
{
    partial class ReportesUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportesUser));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.rbtCursos = new System.Windows.Forms.RadioButton();
            this.rbtBoletines = new System.Windows.Forms.RadioButton();
            this.btnPeriodo = new System.Windows.Forms.Button();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.BtnCurso = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.btnExcel);
            this.Panel1.Controls.Add(this.btnPdf);
            this.Panel1.Controls.Add(this.btnSalir);
            this.Panel1.Location = new System.Drawing.Point(10, 260);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(584, 61);
            this.Panel1.TabIndex = 1133;
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Location = new System.Drawing.Point(404, 0);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(60, 61);
            this.btnExcel.TabIndex = 1100;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnPdf
            // 
            this.btnPdf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPdf.BackgroundImage")));
            this.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPdf.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Location = new System.Drawing.Point(464, 0);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(60, 61);
            this.btnPdf.TabIndex = 1099;
            this.btnPdf.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(524, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 61);
            this.btnSalir.TabIndex = 1097;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.txtNombre);
            this.Panel3.Controls.Add(this.btnEstudiante);
            this.Panel3.Controls.Add(this.txtIdentificacion);
            this.Panel3.Controls.Add(this.rbtCursos);
            this.Panel3.Controls.Add(this.rbtBoletines);
            this.Panel3.Controls.Add(this.btnPeriodo);
            this.Panel3.Controls.Add(this.txtPeriodo);
            this.Panel3.Controls.Add(this.BtnCurso);
            this.Panel3.Controls.Add(this.txtCurso);
            this.Panel3.Controls.Add(this.label1);
            this.Panel3.Location = new System.Drawing.Point(10, 8);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(584, 245);
            this.Panel3.TabIndex = 1131;
            // 
            // rbtCursos
            // 
            this.rbtCursos.AutoSize = true;
            this.rbtCursos.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCursos.Location = new System.Drawing.Point(77, 67);
            this.rbtCursos.Name = "rbtCursos";
            this.rbtCursos.Size = new System.Drawing.Size(103, 28);
            this.rbtCursos.TabIndex = 1151;
            this.rbtCursos.TabStop = true;
            this.rbtCursos.Text = "Cursos";
            this.rbtCursos.UseVisualStyleBackColor = true;
            // 
            // rbtBoletines
            // 
            this.rbtBoletines.AutoSize = true;
            this.rbtBoletines.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBoletines.Location = new System.Drawing.Point(202, 67);
            this.rbtBoletines.Name = "rbtBoletines";
            this.rbtBoletines.Size = new System.Drawing.Size(101, 28);
            this.rbtBoletines.TabIndex = 1150;
            this.rbtBoletines.TabStop = true;
            this.rbtBoletines.Text = "Boletin";
            this.rbtBoletines.UseVisualStyleBackColor = true;
            // 
            // btnPeriodo
            // 
            this.btnPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.btnPeriodo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPeriodo.BackgroundImage")));
            this.btnPeriodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPeriodo.FlatAppearance.BorderSize = 0;
            this.btnPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriodo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriodo.ForeColor = System.Drawing.Color.Black;
            this.btnPeriodo.Location = new System.Drawing.Point(80, 143);
            this.btnPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPeriodo.Name = "btnPeriodo";
            this.btnPeriodo.Size = new System.Drawing.Size(52, 31);
            this.btnPeriodo.TabIndex = 1149;
            this.btnPeriodo.UseVisualStyleBackColor = false;
            this.btnPeriodo.Click += new System.EventHandler(this.btnPeriodo_Click);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeriodo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPeriodo.Location = new System.Drawing.Point(136, 143);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeriodo.MaxLength = 40;
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.ReadOnly = true;
            this.txtPeriodo.Size = new System.Drawing.Size(415, 30);
            this.txtPeriodo.TabIndex = 1148;
            // 
            // BtnCurso
            // 
            this.BtnCurso.BackColor = System.Drawing.Color.Transparent;
            this.BtnCurso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCurso.BackgroundImage")));
            this.BtnCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCurso.FlatAppearance.BorderSize = 0;
            this.BtnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCurso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCurso.ForeColor = System.Drawing.Color.Black;
            this.BtnCurso.Location = new System.Drawing.Point(78, 103);
            this.BtnCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCurso.Name = "BtnCurso";
            this.BtnCurso.Size = new System.Drawing.Size(54, 32);
            this.BtnCurso.TabIndex = 1145;
            this.BtnCurso.UseVisualStyleBackColor = false;
            this.BtnCurso.Click += new System.EventHandler(this.BtnCurso_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCurso.Location = new System.Drawing.Point(138, 103);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurso.MaxLength = 40;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(413, 30);
            this.txtCurso.TabIndex = 1144;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 54);
            this.label1.TabIndex = 1109;
            this.label1.Text = "REPORTES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombre.Location = new System.Drawing.Point(334, 184);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(217, 30);
            this.txtNombre.TabIndex = 1154;
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.BackColor = System.Drawing.Color.Transparent;
            this.btnEstudiante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEstudiante.BackgroundImage")));
            this.btnEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstudiante.FlatAppearance.BorderSize = 0;
            this.btnEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstudiante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstudiante.ForeColor = System.Drawing.Color.Black;
            this.btnEstudiante.Location = new System.Drawing.Point(78, 184);
            this.btnEstudiante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(54, 31);
            this.btnEstudiante.TabIndex = 1153;
            this.btnEstudiante.UseVisualStyleBackColor = false;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIdentificacion.Location = new System.Drawing.Point(136, 184);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdentificacion.MaxLength = 40;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(192, 30);
            this.txtIdentificacion.TabIndex = 1152;
            // 
            // ReportesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Name = "ReportesUser";
            this.Size = new System.Drawing.Size(602, 330);
            this.Panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnExcel;
        internal System.Windows.Forms.Button btnPdf;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button BtnCurso;
        internal System.Windows.Forms.TextBox txtCurso;
        internal System.Windows.Forms.Button btnPeriodo;
        internal System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.RadioButton rbtCursos;
        private System.Windows.Forms.RadioButton rbtBoletines;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Button btnEstudiante;
        internal System.Windows.Forms.TextBox txtIdentificacion;
    }
}
