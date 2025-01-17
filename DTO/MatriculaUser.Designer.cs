namespace UserControls
{
    partial class MatriculaControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatriculaControl));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtFechaFinMatricula = new System.Windows.Forms.DateTimePicker();
            this.txtMensualidad = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtFechaInicioMatricula = new System.Windows.Forms.DateTimePicker();
            this.txtestudiante = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.cmbJornada = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.dgvmatricula = new System.Windows.Forms.DataGridView();
            this.idMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicioMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorDeMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorMensualidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idjornada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jornada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esEstudianteNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.btnCancelar);
            this.Panel1.Controls.Add(this.btnNuevo);
            this.Panel1.Controls.Add(this.btnGuardar);
            this.Panel1.Location = new System.Drawing.Point(10, 350);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(613, 62);
            this.Panel1.TabIndex = 1122;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(433, 0);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 62);
            this.btnCancelar.TabIndex = 1097;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(493, 0);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 62);
            this.btnNuevo.TabIndex = 1098;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(553, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 62);
            this.btnGuardar.TabIndex = 1084;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Controls.Add(this.label4);
            this.Panel3.Controls.Add(this.TextBox1);
            this.Panel3.Controls.Add(this.Label3);
            this.Panel3.Controls.Add(this.txtFechaFinMatricula);
            this.Panel3.Controls.Add(this.txtMensualidad);
            this.Panel3.Controls.Add(this.Label1);
            this.Panel3.Controls.Add(this.cmbCurso);
            this.Panel3.Controls.Add(this.Label2);
            this.Panel3.Controls.Add(this.Button2);
            this.Panel3.Controls.Add(this.Label5);
            this.Panel3.Controls.Add(this.txtFechaInicioMatricula);
            this.Panel3.Controls.Add(this.txtestudiante);
            this.Panel3.Controls.Add(this.txtMonto);
            this.Panel3.Controls.Add(this.Label10);
            this.Panel3.Controls.Add(this.cmbJornada);
            this.Panel3.Controls.Add(this.Label11);
            this.Panel3.Location = new System.Drawing.Point(10, 11);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(613, 335);
            this.Panel3.TabIndex = 1121;
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox1.Location = new System.Drawing.Point(448, 75);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox1.MaxLength = 40;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(138, 30);
            this.TextBox1.TabIndex = 1119;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(135, 183);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(102, 24);
            this.Label3.TabIndex = 1107;
            this.Label3.Text = "Fecha Fin";
            // 
            // txtFechaFinMatricula
            // 
            this.txtFechaFinMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaFinMatricula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFinMatricula.Location = new System.Drawing.Point(248, 178);
            this.txtFechaFinMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechaFinMatricula.Name = "txtFechaFinMatricula";
            this.txtFechaFinMatricula.Size = new System.Drawing.Size(338, 30);
            this.txtFechaFinMatricula.TabIndex = 1106;
            // 
            // txtMensualidad
            // 
            this.txtMensualidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensualidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensualidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMensualidad.Location = new System.Drawing.Point(248, 246);
            this.txtMensualidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMensualidad.MaxLength = 40;
            this.txtMensualidad.Name = "txtMensualidad";
            this.txtMensualidad.Size = new System.Drawing.Size(338, 30);
            this.txtMensualidad.TabIndex = 1104;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(54, 250);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(183, 24);
            this.Label1.TabIndex = 1105;
            this.Label1.Text = "Valor Mensualidad";
            // 
            // cmbCurso
            // 
            this.cmbCurso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(248, 280);
            this.cmbCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(338, 31);
            this.cmbCurso.TabIndex = 1097;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(114, 148);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(123, 24);
            this.Label2.TabIndex = 1096;
            this.Label2.Text = "Fecha inicio";
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.Transparent;
            this.Button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2.BackgroundImage")));
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(194, 75);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(50, 30);
            this.Button2.TabIndex = 1103;
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(176, 286);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(67, 24);
            this.Label5.TabIndex = 1090;
            this.Label5.Text = "Curso";
            // 
            // txtFechaInicioMatricula
            // 
            this.txtFechaInicioMatricula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaInicioMatricula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInicioMatricula.Location = new System.Drawing.Point(248, 144);
            this.txtFechaInicioMatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFechaInicioMatricula.Name = "txtFechaInicioMatricula";
            this.txtFechaInicioMatricula.Size = new System.Drawing.Size(338, 30);
            this.txtFechaInicioMatricula.TabIndex = 1095;
            // 
            // txtestudiante
            // 
            this.txtestudiante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtestudiante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtestudiante.Location = new System.Drawing.Point(248, 75);
            this.txtestudiante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtestudiante.MaxLength = 40;
            this.txtestudiante.Name = "txtestudiante";
            this.txtestudiante.Size = new System.Drawing.Size(197, 30);
            this.txtestudiante.TabIndex = 1084;
            // 
            // txtMonto
            // 
            this.txtMonto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMonto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMonto.Location = new System.Drawing.Point(248, 212);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonto.MaxLength = 40;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(338, 30);
            this.txtMonto.TabIndex = 1085;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(86, 217);
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
            this.cmbJornada.Location = new System.Drawing.Point(248, 109);
            this.cmbJornada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbJornada.Name = "cmbJornada";
            this.cmbJornada.Size = new System.Drawing.Size(338, 31);
            this.cmbJornada.TabIndex = 1101;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(153, 115);
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
            this.idMatricula,
            this.FechaInicioMatricula,
            this.FechaFinMatricula,
            this.ValorDeMatricula,
            this.ValorMensualidad,
            this.idEstudiante,
            this.NumDocumento,
            this.NombreCompleto,
            this.direccion,
            this.telefono,
            this.idjornada,
            this.jornada,
            this.idCurso,
            this.curso,
            this.esEstudianteNuevo});
            this.dgvmatricula.Location = new System.Drawing.Point(12, 417);
            this.dgvmatricula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvmatricula.Name = "dgvmatricula";
            this.dgvmatricula.ReadOnly = true;
            this.dgvmatricula.RowHeadersVisible = false;
            this.dgvmatricula.RowHeadersWidth = 62;
            this.dgvmatricula.Size = new System.Drawing.Size(611, 244);
            this.dgvmatricula.TabIndex = 1120;
            // 
            // idMatricula
            // 
            this.idMatricula.DataPropertyName = "idMatricula";
            this.idMatricula.HeaderText = "idMatricula";
            this.idMatricula.MinimumWidth = 8;
            this.idMatricula.Name = "idMatricula";
            this.idMatricula.ReadOnly = true;
            this.idMatricula.Visible = false;
            this.idMatricula.Width = 150;
            // 
            // FechaInicioMatricula
            // 
            this.FechaInicioMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaInicioMatricula.DataPropertyName = "FechaInicioMatricula";
            this.FechaInicioMatricula.HeaderText = "FechaInicioMatricula";
            this.FechaInicioMatricula.MinimumWidth = 8;
            this.FechaInicioMatricula.Name = "FechaInicioMatricula";
            this.FechaInicioMatricula.ReadOnly = true;
            // 
            // FechaFinMatricula
            // 
            this.FechaFinMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaFinMatricula.DataPropertyName = "FechaFinMatricula";
            this.FechaFinMatricula.HeaderText = "FechaFinMatricula";
            this.FechaFinMatricula.MinimumWidth = 8;
            this.FechaFinMatricula.Name = "FechaFinMatricula";
            this.FechaFinMatricula.ReadOnly = true;
            // 
            // ValorDeMatricula
            // 
            this.ValorDeMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorDeMatricula.DataPropertyName = "ValorDeMatricula";
            this.ValorDeMatricula.HeaderText = "ValorDeMatricula";
            this.ValorDeMatricula.MinimumWidth = 8;
            this.ValorDeMatricula.Name = "ValorDeMatricula";
            this.ValorDeMatricula.ReadOnly = true;
            // 
            // ValorMensualidad
            // 
            this.ValorMensualidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorMensualidad.DataPropertyName = "ValorMensualidad";
            this.ValorMensualidad.HeaderText = "ValorMensualidad";
            this.ValorMensualidad.MinimumWidth = 8;
            this.ValorMensualidad.Name = "ValorMensualidad";
            this.ValorMensualidad.ReadOnly = true;
            // 
            // idEstudiante
            // 
            this.idEstudiante.DataPropertyName = "idEstudiante";
            this.idEstudiante.HeaderText = "idEstudiante";
            this.idEstudiante.MinimumWidth = 8;
            this.idEstudiante.Name = "idEstudiante";
            this.idEstudiante.ReadOnly = true;
            this.idEstudiante.Visible = false;
            this.idEstudiante.Width = 150;
            // 
            // NumDocumento
            // 
            this.NumDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumDocumento.DataPropertyName = "NumDocumento";
            this.NumDocumento.HeaderText = "NumDocumento";
            this.NumDocumento.MinimumWidth = 8;
            this.NumDocumento.Name = "NumDocumento";
            this.NumDocumento.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "NombreCompleto";
            this.NombreCompleto.MinimumWidth = 8;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "direccion";
            this.direccion.MinimumWidth = 8;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "telefono";
            this.telefono.MinimumWidth = 8;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // idjornada
            // 
            this.idjornada.DataPropertyName = "idjornada";
            this.idjornada.HeaderText = "idjornada";
            this.idjornada.MinimumWidth = 8;
            this.idjornada.Name = "idjornada";
            this.idjornada.ReadOnly = true;
            this.idjornada.Visible = false;
            this.idjornada.Width = 150;
            // 
            // jornada
            // 
            this.jornada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jornada.DataPropertyName = "jornada";
            this.jornada.HeaderText = "jornada";
            this.jornada.MinimumWidth = 8;
            this.jornada.Name = "jornada";
            this.jornada.ReadOnly = true;
            // 
            // idCurso
            // 
            this.idCurso.DataPropertyName = "idCurso";
            this.idCurso.HeaderText = "idCurso";
            this.idCurso.MinimumWidth = 8;
            this.idCurso.Name = "idCurso";
            this.idCurso.ReadOnly = true;
            this.idCurso.Visible = false;
            this.idCurso.Width = 150;
            // 
            // curso
            // 
            this.curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.curso.DataPropertyName = "curso";
            this.curso.HeaderText = "Curso";
            this.curso.MinimumWidth = 8;
            this.curso.Name = "curso";
            this.curso.ReadOnly = true;
            // 
            // esEstudianteNuevo
            // 
            this.esEstudianteNuevo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.esEstudianteNuevo.DataPropertyName = "esEstudianteNuevo";
            this.esEstudianteNuevo.HeaderText = "EstudianteNuevo";
            this.esEstudianteNuevo.MinimumWidth = 8;
            this.esEstudianteNuevo.Name = "esEstudianteNuevo";
            this.esEstudianteNuevo.ReadOnly = true;
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
            this.label4.Size = new System.Drawing.Size(613, 54);
            this.label4.TabIndex = 1120;
            this.label4.Text = "MATRICULAS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MatriculaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.dgvmatricula);
            this.Name = "MatriculaControl";
            this.Size = new System.Drawing.Size(633, 592);
            this.Panel1.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmatricula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.DateTimePicker txtFechaFinMatricula;
        internal System.Windows.Forms.TextBox txtMensualidad;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox cmbCurso;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.DateTimePicker txtFechaInicioMatricula;
        internal System.Windows.Forms.TextBox txtestudiante;
        internal System.Windows.Forms.TextBox txtMonto;
        internal System.Windows.Forms.Label Label10;
        private System.Windows.Forms.ComboBox cmbJornada;
        internal System.Windows.Forms.Label Label11;
        private System.Windows.Forms.DataGridView dgvmatricula;
        internal System.Windows.Forms.DataGridViewTextBoxColumn idMatricula;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FechaInicioMatricula;
        internal System.Windows.Forms.DataGridViewTextBoxColumn FechaFinMatricula;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ValorDeMatricula;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ValorMensualidad;
        internal System.Windows.Forms.DataGridViewTextBoxColumn idEstudiante;
        internal System.Windows.Forms.DataGridViewTextBoxColumn NumDocumento;
        internal System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        internal System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        internal System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        internal System.Windows.Forms.DataGridViewTextBoxColumn idjornada;
        internal System.Windows.Forms.DataGridViewTextBoxColumn jornada;
        internal System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
        internal System.Windows.Forms.DataGridViewTextBoxColumn curso;
        internal System.Windows.Forms.DataGridViewTextBoxColumn esEstudianteNuevo;
        internal System.Windows.Forms.Label label4;
    }
}
