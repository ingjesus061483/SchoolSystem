namespace Controls
{
    partial class MatriculaUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatriculaUser));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCurso = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFechaFinMatricula = new System.Windows.Forms.DateTimePicker();
            this.txtValorMensualidad = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.txtFechaInicioMatricula = new System.Windows.Forms.DateTimePicker();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtValorMatricula = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.cmbJornada = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.dgvmatricula = new System.Windows.Forms.DataGridView();
            this.novedad = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicioMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDeMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorMensualidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jornada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esEstudianteNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.btnNuevo);
            this.Panel1.Controls.Add(this.btnGuardar);
            this.Panel1.Controls.Add(this.btnEliminar);
            this.Panel1.Controls.Add(this.btnSalir);
            this.Panel1.Location = new System.Drawing.Point(10, 412);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(614, 62);
            this.Panel1.TabIndex = 1122;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(374, 0);
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
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(434, 0);
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
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(494, 0);
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
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(554, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 62);
            this.btnSalir.TabIndex = 1084;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.txtDuracion);
            this.Panel3.Controls.Add(this.txtCodigo);
            this.Panel3.Controls.Add(this.label5);
            this.Panel3.Controls.Add(this.BtnCurso);
            this.Panel3.Controls.Add(this.txtCurso);
            this.Panel3.Controls.Add(this.label4);
            this.Panel3.Controls.Add(this.txtNombre);
            this.Panel3.Controls.Add(this.txtFechaFinMatricula);
            this.Panel3.Controls.Add(this.txtValorMensualidad);
            this.Panel3.Controls.Add(this.Label1);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.btnEstudiante);
            this.Panel3.Controls.Add(this.txtFechaInicioMatricula);
            this.Panel3.Controls.Add(this.txtIdentificacion);
            this.Panel3.Controls.Add(this.txtValorMatricula);
            this.Panel3.Controls.Add(this.Label10);
            this.Panel3.Controls.Add(this.cmbJornada);
            this.Panel3.Controls.Add(this.Label11);
            this.Panel3.Location = new System.Drawing.Point(10, 11);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(614, 395);
            this.Panel3.TabIndex = 1121;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuracion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDuracion.Location = new System.Drawing.Point(490, 206);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDuracion.MaxLength = 40;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.ReadOnly = true;
            this.txtDuracion.Size = new System.Drawing.Size(82, 30);
            this.txtDuracion.TabIndex = 1146;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCodigo.Location = new System.Drawing.Point(208, 165);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.MaxLength = 40;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(364, 30);
            this.txtCodigo.TabIndex = 1144;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(120, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 1145;
            this.label5.Text = "Codigo";
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
            this.BtnCurso.Location = new System.Drawing.Point(150, 82);
            this.BtnCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCurso.Name = "BtnCurso";
            this.BtnCurso.Size = new System.Drawing.Size(54, 30);
            this.BtnCurso.TabIndex = 1143;
            this.BtnCurso.UseVisualStyleBackColor = false;
            this.BtnCurso.Click += new System.EventHandler(this.BtnCurso_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCurso.Location = new System.Drawing.Point(209, 82);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurso.MaxLength = 40;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.ReadOnly = true;
            this.txtCurso.Size = new System.Drawing.Size(363, 30);
            this.txtCurso.TabIndex = 1142;
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
            this.label4.Size = new System.Drawing.Size(614, 54);
            this.label4.TabIndex = 1120;
            this.label4.Text = "MATRICULAS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombre.Location = new System.Drawing.Point(406, 123);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(166, 30);
            this.txtNombre.TabIndex = 1119;
            // 
            // txtFechaFinMatricula
            // 
            this.txtFechaFinMatricula.CustomFormat = "yyyy-MM-dd";
            this.txtFechaFinMatricula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFinMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaFinMatricula.Location = new System.Drawing.Point(349, 206);
            this.txtFechaFinMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechaFinMatricula.Name = "txtFechaFinMatricula";
            this.txtFechaFinMatricula.Size = new System.Drawing.Size(134, 30);
            this.txtFechaFinMatricula.TabIndex = 1106;
            this.txtFechaFinMatricula.ValueChanged += new System.EventHandler(this.txtFechaFinMatricula_ValueChanged);
            // 
            // txtValorMensualidad
            // 
            this.txtValorMensualidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorMensualidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMensualidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValorMensualidad.Location = new System.Drawing.Point(208, 291);
            this.txtValorMensualidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorMensualidad.MaxLength = 40;
            this.txtValorMensualidad.Name = "txtValorMensualidad";
            this.txtValorMensualidad.Size = new System.Drawing.Size(364, 30);
            this.txtValorMensualidad.TabIndex = 1104;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(14, 295);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(183, 24);
            this.Label1.TabIndex = 1105;
            this.Label1.Text = "Valor Mensualidad";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(130, 209);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(67, 24);
            this.Label2.TabIndex = 1096;
            this.Label2.Text = "Fecha";
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
            this.btnEstudiante.Location = new System.Drawing.Point(150, 123);
            this.btnEstudiante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(54, 31);
            this.btnEstudiante.TabIndex = 1103;
            this.btnEstudiante.UseVisualStyleBackColor = false;
            this.btnEstudiante.Click += new System.EventHandler(this.btnEstudiante_Click);
            // 
            // txtFechaInicioMatricula
            // 
            this.txtFechaInicioMatricula.CustomFormat = "yyyy-MM-dd";
            this.txtFechaInicioMatricula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInicioMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFechaInicioMatricula.Location = new System.Drawing.Point(208, 206);
            this.txtFechaInicioMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechaInicioMatricula.Name = "txtFechaInicioMatricula";
            this.txtFechaInicioMatricula.Size = new System.Drawing.Size(136, 30);
            this.txtFechaInicioMatricula.TabIndex = 1095;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIdentificacion.Location = new System.Drawing.Point(208, 123);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdentificacion.MaxLength = 40;
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.Size = new System.Drawing.Size(192, 30);
            this.txtIdentificacion.TabIndex = 1084;
            // 
            // txtValorMatricula
            // 
            this.txtValorMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorMatricula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorMatricula.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtValorMatricula.Location = new System.Drawing.Point(208, 249);
            this.txtValorMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtValorMatricula.MaxLength = 40;
            this.txtValorMatricula.Name = "txtValorMatricula";
            this.txtValorMatricula.Size = new System.Drawing.Size(364, 30);
            this.txtValorMatricula.TabIndex = 1085;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(46, 252);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(151, 24);
            this.Label10.TabIndex = 1089;
            this.Label10.Text = "Valor Matricula";
            // 
            // cmbJornada
            // 
            this.cmbJornada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJornada.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJornada.FormattingEnabled = true;
            this.cmbJornada.Location = new System.Drawing.Point(208, 331);
            this.cmbJornada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Size = new System.Drawing.Size(364, 31);
            this.cmbJornada.TabIndex = 1101;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(112, 334);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(87, 24);
            this.Label11.TabIndex = 1100;
            this.Label11.Text = "Jornada";
            // 
            // dgvmatricula
            // 
            this.dgvmatricula.AllowUserToAddRows = false;
            this.dgvmatricula.AllowUserToDeleteRows = false;
            this.dgvmatricula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmatricula.BackgroundColor = System.Drawing.Color.White;
            this.dgvmatricula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvmatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmatricula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.novedad,
            this.id,
            this.Codigo,
            this.FechaInicioMatricula,
            this.FechaFinMatricula,
            this.Duracion,
            this.ValorDeMatricula,
            this.ValorMensualidad,
            this.NombreCompleto,
            this.jornada,
            this.curso,
            this.esEstudianteNuevo});
            this.dgvmatricula.Location = new System.Drawing.Point(12, 482);
            this.dgvmatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvmatricula.Name = "dgvmatricula";
            this.dgvmatricula.ReadOnly = true;
            this.dgvmatricula.RowHeadersVisible = false;
            this.dgvmatricula.RowHeadersWidth = 62;
            this.dgvmatricula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvmatricula.Size = new System.Drawing.Size(610, 145);
            this.dgvmatricula.TabIndex = 1120;
            this.dgvmatricula.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmatricula_CellContentClick);
            // 
            // novedad
            // 
            this.novedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.novedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novedad.HeaderText = "";
            this.novedad.MinimumWidth = 8;
            this.novedad.Name = "novedad";
            this.novedad.ReadOnly = true;
            this.novedad.Text = "Novedades";
            this.novedad.UseColumnTextForButtonValue = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // FechaInicioMatricula
            // 
            this.FechaInicioMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaInicioMatricula.DataPropertyName = "FirstDate";
            this.FechaInicioMatricula.HeaderText = "Fecha Inicio";
            this.FechaInicioMatricula.MinimumWidth = 8;
            this.FechaInicioMatricula.Name = "FechaInicioMatricula";
            this.FechaInicioMatricula.ReadOnly = true;
            // 
            // FechaFinMatricula
            // 
            this.FechaFinMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaFinMatricula.DataPropertyName = "LastDate";
            this.FechaFinMatricula.HeaderText = "Fecha Fin";
            this.FechaFinMatricula.MinimumWidth = 8;
            this.FechaFinMatricula.Name = "FechaFinMatricula";
            this.FechaFinMatricula.ReadOnly = true;
            // 
            // Duracion
            // 
            this.Duracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Duracion.DataPropertyName = "Duration";
            this.Duracion.HeaderText = "Duracion";
            this.Duracion.MinimumWidth = 8;
            this.Duracion.Name = "Duracion";
            this.Duracion.ReadOnly = true;
            // 
            // ValorDeMatricula
            // 
            this.ValorDeMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorDeMatricula.DataPropertyName = "TutionValue";
            this.ValorDeMatricula.HeaderText = "Valor matricula";
            this.ValorDeMatricula.MinimumWidth = 8;
            this.ValorDeMatricula.Name = "ValorDeMatricula";
            this.ValorDeMatricula.ReadOnly = true;
            // 
            // ValorMensualidad
            // 
            this.ValorMensualidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorMensualidad.DataPropertyName = "MonthValue";
            this.ValorMensualidad.HeaderText = "Valor mensualidad";
            this.ValorMensualidad.MinimumWidth = 8;
            this.ValorMensualidad.Name = "ValorMensualidad";
            this.ValorMensualidad.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCompleto.DataPropertyName = "Student";
            this.NombreCompleto.HeaderText = "Estudiante";
            this.NombreCompleto.MinimumWidth = 8;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // jornada
            // 
            this.jornada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jornada.DataPropertyName = "WorkingDay";
            this.jornada.HeaderText = "Jornada";
            this.jornada.MinimumWidth = 8;
            this.jornada.Name = "jornada";
            this.jornada.ReadOnly = true;
            // 
            // curso
            // 
            this.curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.curso.DataPropertyName = "Course";
            this.curso.HeaderText = "Curso";
            this.curso.MinimumWidth = 8;
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            // 
            // esEstudianteNuevo
            // 
            this.esEstudianteNuevo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.esEstudianteNuevo.DataPropertyName = "status";
            this.esEstudianteNuevo.HeaderText = "Estado";
            this.esEstudianteNuevo.MinimumWidth = 8;
            this.esEstudianteNuevo.Name = "esEstudianteNuevo";
            this.esEstudianteNuevo.ReadOnly = true;
            // 
            // MatriculaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.dgvmatricula);
            this.Name = "MatriculaUser";
            this.Size = new System.Drawing.Size(633, 637);
            this.Load += new System.EventHandler(this.MatriculaUser_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatricula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker txtFechaFinMatricula;
        internal System.Windows.Forms.TextBox txtValorMensualidad;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.DateTimePicker txtFechaInicioMatricula;
        internal System.Windows.Forms.TextBox txtIdentificacion;
        internal System.Windows.Forms.TextBox txtValorMatricula;
        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.ComboBox cmbJornada;
        internal System.Windows.Forms.Label Label11;
        private System.Windows.Forms.DataGridView dgvmatricula;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button BtnCurso;
        internal System.Windows.Forms.TextBox txtCurso;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.TextBox txtCodigo;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.DataGridViewButtonColumn novedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicioMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorDeMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorMensualidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn jornada;
        private System.Windows.Forms.DataGridViewTextBoxColumn curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn esEstudianteNuevo;
    }
}
