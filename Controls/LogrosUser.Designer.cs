namespace Controls 
{
    partial class LogrosUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogrosUser));
            this.dgvLogros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnPeriodo = new System.Windows.Forms.Button();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.BtnCurso = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsignatura = new System.Windows.Forms.Button();
            this.txtAsignatura = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogros)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLogros
            // 
            this.dgvLogros.AllowUserToAddRows = false;
            this.dgvLogros.AllowUserToDeleteRows = false;
            this.dgvLogros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLogros.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLogros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Titulo,
            this.Descripcion,
            this.asignatura,
            this.Curso,
            this.periodo});
            this.dgvLogros.Location = new System.Drawing.Point(16, 467);
            this.dgvLogros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLogros.Name = "dgvLogros";
            this.dgvLogros.ReadOnly = true;
            this.dgvLogros.RowHeadersVisible = false;
            this.dgvLogros.RowHeadersWidth = 62;
            this.dgvLogros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogros.Size = new System.Drawing.Size(419, 116);
            this.dgvLogros.TabIndex = 1112;
            this.dgvLogros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogros_CellContentClick);
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
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.DataPropertyName = "Code";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 8;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.DataPropertyName = "title";
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.MinimumWidth = 8;
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion.DataPropertyName = "Description";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // asignatura
            // 
            this.asignatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asignatura.DataPropertyName = "SchoolSubject";
            this.asignatura.HeaderText = "Asignatura";
            this.asignatura.MinimumWidth = 8;
            this.asignatura.Name = "asignatura";
            this.asignatura.ReadOnly = true;
            // 
            // Curso
            // 
            this.Curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Curso.DataPropertyName = "Course";
            this.Curso.HeaderText = "Curso";
            this.Curso.MinimumWidth = 8;
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // periodo
            // 
            this.periodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.periodo.DataPropertyName = "period";
            this.periodo.HeaderText = "Periodo";
            this.periodo.MinimumWidth = 8;
            this.periodo.Name = "periodo";
            this.periodo.ReadOnly = true;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.btnPeriodo);
            this.Panel1.Controls.Add(this.txtPeriodo);
            this.Panel1.Controls.Add(this.BtnCurso);
            this.Panel1.Controls.Add(this.txtCurso);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.btnAsignatura);
            this.Panel1.Controls.Add(this.txtAsignatura);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.txtDescripcion);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.txtNombre);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.txtCodigo);
            this.Panel1.Location = new System.Drawing.Point(12, 9);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(423, 386);
            this.Panel1.TabIndex = 1110;
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
            this.btnPeriodo.Location = new System.Drawing.Point(93, 158);
            this.btnPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPeriodo.Name = "btnPeriodo";
            this.btnPeriodo.Size = new System.Drawing.Size(52, 31);
            this.btnPeriodo.TabIndex = 1147;
            this.btnPeriodo.UseVisualStyleBackColor = false;
            this.btnPeriodo.Click += new System.EventHandler(this.btnPeriodo_Click);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeriodo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPeriodo.Location = new System.Drawing.Point(149, 158);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeriodo.MaxLength = 40;
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.ReadOnly = true;
            this.txtPeriodo.Size = new System.Drawing.Size(246, 30);
            this.txtPeriodo.TabIndex = 1146;
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
            this.BtnCurso.Location = new System.Drawing.Point(93, 78);
            this.BtnCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCurso.Name = "BtnCurso";
            this.BtnCurso.Size = new System.Drawing.Size(54, 30);
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
            this.txtCurso.Location = new System.Drawing.Point(152, 78);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurso.MaxLength = 40;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(244, 30);
            this.txtCurso.TabIndex = 1144;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 54);
            this.label2.TabIndex = 1140;
            this.label2.Text = "LOGROS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAsignatura
            // 
            this.btnAsignatura.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignatura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAsignatura.BackgroundImage")));
            this.btnAsignatura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAsignatura.FlatAppearance.BorderSize = 0;
            this.btnAsignatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignatura.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignatura.ForeColor = System.Drawing.Color.Black;
            this.btnAsignatura.Location = new System.Drawing.Point(93, 118);
            this.btnAsignatura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsignatura.Name = "btnAsignatura";
            this.btnAsignatura.Size = new System.Drawing.Size(52, 31);
            this.btnAsignatura.TabIndex = 1139;
            this.btnAsignatura.UseVisualStyleBackColor = false;
            this.btnAsignatura.Click += new System.EventHandler(this.btnAsignatura_Click);
            // 
            // txtAsignatura
            // 
            this.txtAsignatura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAsignatura.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsignatura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAsignatura.Location = new System.Drawing.Point(149, 118);
            this.txtAsignatura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAsignatura.MaxLength = 40;
            this.txtAsignatura.Name = "txtAsignatura";
            this.txtAsignatura.ReadOnly = true;
            this.txtAsignatura.Size = new System.Drawing.Size(246, 30);
            this.txtAsignatura.TabIndex = 1138;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(27, 277);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(114, 21);
            this.Label3.TabIndex = 1137;
            this.Label3.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescripcion.Location = new System.Drawing.Point(149, 273);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.MaxLength = 40;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(246, 92);
            this.txtDescripcion.TabIndex = 1136;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(81, 239);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(59, 21);
            this.Label9.TabIndex = 1135;
            this.Label9.Text = "Titulo";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombre.Location = new System.Drawing.Point(149, 236);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(247, 28);
            this.txtNombre.TabIndex = 1134;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(69, 202);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 21);
            this.Label1.TabIndex = 1133;
            this.Label1.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCodigo.Location = new System.Drawing.Point(149, 199);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(247, 28);
            this.txtCodigo.TabIndex = 1130;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.btnNuevo);
            this.Panel3.Controls.Add(this.btnGuardar);
            this.Panel3.Controls.Add(this.btnEliminar);
            this.Panel3.Controls.Add(this.btnSalir);
            this.Panel3.Location = new System.Drawing.Point(14, 400);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(421, 62);
            this.Panel3.TabIndex = 1133;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(181, 0);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 62);
            this.btnNuevo.TabIndex = 1099;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(241, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 62);
            this.btnGuardar.TabIndex = 1097;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(301, 0);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 62);
            this.btnEliminar.TabIndex = 1098;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(361, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 62);
            this.btnSalir.TabIndex = 1084;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // LogrosUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dgvLogros);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel1);
            this.Name = "LogrosUser";
            this.Size = new System.Drawing.Size(444, 590);
            this.Load += new System.EventHandler(this.LogrosUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogros)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogros;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnAsignatura;
        internal System.Windows.Forms.TextBox txtAsignatura;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtDescripcion;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtNombre;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button BtnCurso;
        internal System.Windows.Forms.TextBox txtCurso;
        internal System.Windows.Forms.Button btnPeriodo;
        internal System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
    }
}
