namespace Controls
{
    partial class CalificacionesUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalificacionesUser));
            this.dgvEstudiante = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asignatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnPeriodo = new System.Windows.Forms.Button();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtLogros = new System.Windows.Forms.TextBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEstudiante
            // 
            this.dgvEstudiante.AllowUserToAddRows = false;
            this.dgvEstudiante.AllowUserToDeleteRows = false;
            this.dgvEstudiante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstudiante.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.fecha,
            this.asignatura,
            this.Concepto,
            this.nota,
            this.Observaciones,
            this.Periodo});
            this.dgvEstudiante.Location = new System.Drawing.Point(8, 563);
            this.dgvEstudiante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEstudiante.Name = "dgvEstudiante";
            this.dgvEstudiante.ReadOnly = true;
            this.dgvEstudiante.RowHeadersVisible = false;
            this.dgvEstudiante.RowHeadersWidth = 62;
            this.dgvEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudiante.Size = new System.Drawing.Size(495, 101);
            this.dgvEstudiante.TabIndex = 1116;
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
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "fecha";
            this.fecha.MinimumWidth = 8;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // asignatura
            // 
            this.asignatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.asignatura.DataPropertyName = "logros";
            this.asignatura.HeaderText = " logros";
            this.asignatura.MinimumWidth = 8;
            this.asignatura.Name = "asignatura";
            this.asignatura.ReadOnly = true;
            // 
            // Concepto
            // 
            this.Concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Concepto.DataPropertyName = "Concepto";
            this.Concepto.HeaderText = "Concepto";
            this.Concepto.MinimumWidth = 8;
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            // 
            // nota
            // 
            this.nota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nota.DataPropertyName = "nota";
            this.nota.HeaderText = "nota";
            this.nota.MinimumWidth = 8;
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Observaciones.DataPropertyName = "Observaciones";
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.MinimumWidth = 8;
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // Periodo
            // 
            this.Periodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.MinimumWidth = 8;
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Controls.Add(this.label5);
            this.Panel1.Controls.Add(this.txtCodigo);
            this.Panel1.Controls.Add(this.btnPeriodo);
            this.Panel1.Controls.Add(this.txtPeriodo);
            this.Panel1.Controls.Add(this.label4);
            this.Panel1.Controls.Add(this.TextBox1);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.txtFecha);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Controls.Add(this.txtLogros);
            this.Panel1.Controls.Add(this.Button2);
            this.Panel1.Controls.Add(this.txtEstudiante);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.txtObservacion);
            this.Panel1.Controls.Add(this.Label9);
            this.Panel1.Controls.Add(this.txtNota);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.txtConcepto);
            this.Panel1.Location = new System.Drawing.Point(8, 9);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(495, 482);
            this.Panel1.TabIndex = 1115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(88, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 1151;
            this.label5.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCodigo.Location = new System.Drawing.Point(166, 196);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(314, 28);
            this.txtCodigo.TabIndex = 1150;
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
            this.btnPeriodo.Location = new System.Drawing.Point(111, 76);
            this.btnPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPeriodo.Name = "btnPeriodo";
            this.btnPeriodo.Size = new System.Drawing.Size(52, 31);
            this.btnPeriodo.TabIndex = 1149;
            this.btnPeriodo.UseVisualStyleBackColor = false;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeriodo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeriodo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPeriodo.Location = new System.Drawing.Point(167, 76);
            this.txtPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeriodo.MaxLength = 40;
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.ReadOnly = true;
            this.txtPeriodo.Size = new System.Drawing.Size(313, 30);
            this.txtPeriodo.TabIndex = 1148;
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
            this.label4.Size = new System.Drawing.Size(495, 54);
            this.label4.TabIndex = 1147;
            this.label4.Text = "CALIFICACIONES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TextBox1.Location = new System.Drawing.Point(314, 116);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox1.MaxLength = 40;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(166, 30);
            this.TextBox1.TabIndex = 1144;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(95, 241);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(63, 21);
            this.Label2.TabIndex = 1143;
            this.Label2.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.CustomFormat = "yyyy-MM-dd";
            this.txtFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtFecha.Location = new System.Drawing.Point(167, 236);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(314, 30);
            this.txtFecha.TabIndex = 1142;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.SteelBlue;
            this.Button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button1.BackgroundImage")));
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(118, 116);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(45, 31);
            this.Button1.TabIndex = 1141;
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // txtLogros
            // 
            this.txtLogros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLogros.Location = new System.Drawing.Point(166, 156);
            this.txtLogros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogros.MaxLength = 40;
            this.txtLogros.Name = "txtLogros";
            this.txtLogros.ReadOnly = true;
            this.txtLogros.Size = new System.Drawing.Size(314, 30);
            this.txtLogros.TabIndex = 1140;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.SteelBlue;
            this.Button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button2.BackgroundImage")));
            this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(118, 156);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(45, 31);
            this.Button2.TabIndex = 1139;
            this.Button2.UseVisualStyleBackColor = false;
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstudiante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEstudiante.Location = new System.Drawing.Point(166, 116);
            this.txtEstudiante.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstudiante.MaxLength = 40;
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.ReadOnly = true;
            this.txtEstudiante.Size = new System.Drawing.Size(142, 30);
            this.txtEstudiante.TabIndex = 1138;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(18, 355);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(142, 21);
            this.Label3.TabIndex = 1137;
            this.Label3.Text = "Observaciones";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtObservacion.Location = new System.Drawing.Point(167, 351);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservacion.MaxLength = 40;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(314, 98);
            this.txtObservacion.TabIndex = 1136;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(107, 318);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(50, 21);
            this.Label9.TabIndex = 1135;
            this.Label9.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNota.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNota.Location = new System.Drawing.Point(167, 313);
            this.txtNota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNota.MaxLength = 40;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(314, 28);
            this.txtNota.TabIndex = 1134;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(101, 280);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 21);
            this.Label1.TabIndex = 1133;
            this.Label1.Text = "Titulo";
            // 
            // txtConcepto
            // 
            this.txtConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConcepto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConcepto.Location = new System.Drawing.Point(167, 276);
            this.txtConcepto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConcepto.MaxLength = 20;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(314, 28);
            this.txtConcepto.TabIndex = 1130;
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
            this.Panel3.Location = new System.Drawing.Point(8, 496);
            this.Panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(495, 62);
            this.Panel3.TabIndex = 1134;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(255, 0);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 62);
            this.btnNuevo.TabIndex = 1099;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(315, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(60, 62);
            this.btnGuardar.TabIndex = 1097;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(375, 0);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 62);
            this.btnEliminar.TabIndex = 1098;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(435, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 62);
            this.btnSalir.TabIndex = 1084;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // CalificacionesUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.dgvEstudiante);
            this.Controls.Add(this.Panel1);
            this.Name = "CalificacionesUser";
            this.Size = new System.Drawing.Size(510, 672);
            this.Load += new System.EventHandler(this.CalificacionesUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiante)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvEstudiante;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker txtFecha;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtLogros;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.TextBox txtEstudiante;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtObservacion;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtNota;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtConcepto;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn asignatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Button btnNuevo;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnPeriodo;
        internal System.Windows.Forms.TextBox txtPeriodo;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtCodigo;
    }
}
