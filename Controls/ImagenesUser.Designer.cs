namespace Controls
{
    partial class ImagenesUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagenesUser));
            this.Panel3 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgAsignaturas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PictureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtImagenes = new System.Windows.Forms.TextBox();
            this.btnImagenes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignaturas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.btnGuardar);
            this.Panel3.Controls.Add(this.btnSalir);
            this.Panel3.Location = new System.Drawing.Point(15, 184);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(515, 62);
            this.Panel3.TabIndex = 1136;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(395, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 62);
            this.btnGuardar.TabIndex = 1099;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(455, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 62);
            this.btnSalir.TabIndex = 1084;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.PictureId,
            this.StudentId,
            this.TeacherId,
            this.picture,
            this.Estudiante,
            this.Profesor,
            this.ver,
            this.eliminar});
            this.dgAsignaturas.Location = new System.Drawing.Point(15, 251);
            this.dgAsignaturas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgAsignaturas.Name = "dgAsignaturas";
            this.dgAsignaturas.ReadOnly = true;
            this.dgAsignaturas.RowHeadersVisible = false;
            this.dgAsignaturas.RowHeadersWidth = 62;
            this.dgAsignaturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAsignaturas.Size = new System.Drawing.Size(515, 484);
            this.dgAsignaturas.TabIndex = 1135;
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
            // PictureId
            // 
            this.PictureId.DataPropertyName = "PictureId";
            this.PictureId.HeaderText = "PictureId";
            this.PictureId.MinimumWidth = 8;
            this.PictureId.Name = "PictureId";
            this.PictureId.ReadOnly = true;
            this.PictureId.Visible = false;
            this.PictureId.Width = 150;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "StudentId";
            this.StudentId.MinimumWidth = 8;
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
            this.StudentId.Width = 150;
            // 
            // TeacherId
            // 
            this.TeacherId.DataPropertyName = "TeacherId";
            this.TeacherId.HeaderText = "TeacherId";
            this.TeacherId.MinimumWidth = 8;
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            this.TeacherId.Visible = false;
            this.TeacherId.Width = 150;
            // 
            // picture
            // 
            this.picture.DataPropertyName = "imagen";
            this.picture.HeaderText = "Titulo";
            this.picture.MinimumWidth = 8;
            this.picture.Name = "picture";
            this.picture.ReadOnly = true;
            this.picture.Width = 150;
            // 
            // Estudiante
            // 
            this.Estudiante.DataPropertyName = "estudiante";
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.MinimumWidth = 8;
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.ReadOnly = true;
            this.Estudiante.Width = 150;
            // 
            // Profesor
            // 
            this.Profesor.DataPropertyName = "profesor";
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.MinimumWidth = 8;
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            this.Profesor.Width = 150;
            // 
            // ver
            // 
            this.ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ver.HeaderText = "";
            this.ver.MinimumWidth = 8;
            this.ver.Name = "ver";
            this.ver.ReadOnly = true;
            this.ver.Text = "Ver";
            this.ver.UseColumnTextForButtonValue = true;
            this.ver.Width = 150;
            // 
            // eliminar
            // 
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.HeaderText = "";
            this.eliminar.MinimumWidth = 8;
            this.eliminar.Name = "eliminar";
            this.eliminar.ReadOnly = true;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseColumnTextForButtonValue = true;
            this.eliminar.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtImagenes);
            this.panel1.Controls.Add(this.btnImagenes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtIdentificacion);
            this.panel1.Controls.Add(this.lblCaption);
            this.panel1.Location = new System.Drawing.Point(15, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 161);
            this.panel1.TabIndex = 1134;
            // 
            // txtImagenes
            // 
            this.txtImagenes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImagenes.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagenes.Location = new System.Drawing.Point(130, 109);
            this.txtImagenes.Name = "txtImagenes";
            this.txtImagenes.ReadOnly = true;
            this.txtImagenes.Size = new System.Drawing.Size(360, 30);
            this.txtImagenes.TabIndex = 1102;
            // 
            // btnImagenes
            // 
            this.btnImagenes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImagenes.BackgroundImage")));
            this.btnImagenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImagenes.FlatAppearance.BorderSize = 0;
            this.btnImagenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagenes.Location = new System.Drawing.Point(84, 109);
            this.btnImagenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImagenes.Name = "btnImagenes";
            this.btnImagenes.Size = new System.Drawing.Size(42, 32);
            this.btnImagenes.TabIndex = 1101;
            this.btnImagenes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImagenes.UseVisualStyleBackColor = true;
            this.btnImagenes.Click += new System.EventHandler(this.btnImagenes_Click);
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
            this.label4.Size = new System.Drawing.Size(515, 51);
            this.label4.TabIndex = 1139;
            this.label4.Text = "ESTUDIANTES =>IMAGENES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(232, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(258, 30);
            this.txtNombre.TabIndex = 2;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(130, 70);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(95, 30);
            this.txtIdentificacion.TabIndex = 1;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(13, 73);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(111, 24);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Estudiante";
            // 
            // ImagenesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.dgAsignaturas);
            this.Controls.Add(this.panel1);
            this.Name = "ImagenesUser";
            this.Size = new System.Drawing.Size(543, 744);
            this.Load += new System.EventHandler(this.ImagenesUser_Load);
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignaturas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgAsignaturas;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Button btnImagenes;
        private System.Windows.Forms.TextBox txtImagenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PictureId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewButtonColumn ver;
        private System.Windows.Forms.DataGridViewButtonColumn eliminar;
    }
}
