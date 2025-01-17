<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatriculaUser
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MatriculaUser))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaFinMatricula = New System.Windows.Forms.DateTimePicker()
        Me.txtMensualidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaInicioMatricula = New System.Windows.Forms.DateTimePicker()
        Me.txtestudiante = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbJornada = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvmatricula = New System.Windows.Forms.DataGridView()
        Me.idMatricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicioMatricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinMatricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDeMatricula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorMensualidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEstudiante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idjornada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jornada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.esEstudianteNuevo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvmatricula, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.txtFechaFinMatricula)
        Me.Panel3.Controls.Add(Me.txtMensualidad)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.cmbCurso)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtFechaInicioMatricula)
        Me.Panel3.Controls.Add(Me.txtestudiante)
        Me.Panel3.Controls.Add(Me.txtMonto)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.cmbJornada)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Location = New System.Drawing.Point(12, 11)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1008, 377)
        Me.Panel3.TabIndex = 1116
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(135, 210)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 24)
        Me.Label3.TabIndex = 1107
        Me.Label3.Text = "Fecha Fin"
        '
        'txtFechaFinMatricula
        '
        Me.txtFechaFinMatricula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFechaFinMatricula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaFinMatricula.Location = New System.Drawing.Point(248, 205)
        Me.txtFechaFinMatricula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFechaFinMatricula.Name = "txtFechaFinMatricula"
        Me.txtFechaFinMatricula.Size = New System.Drawing.Size(733, 30)
        Me.txtFechaFinMatricula.TabIndex = 1106
        '
        'txtMensualidad
        '
        Me.txtMensualidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensualidad.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensualidad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMensualidad.Location = New System.Drawing.Point(248, 273)
        Me.txtMensualidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMensualidad.MaxLength = 40
        Me.txtMensualidad.Name = "txtMensualidad"
        Me.txtMensualidad.Size = New System.Drawing.Size(733, 30)
        Me.txtMensualidad.TabIndex = 1104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 277)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 24)
        Me.Label1.TabIndex = 1105
        Me.Label1.Text = "Valor Mensualidad"
        '
        'cmbCurso
        '
        Me.cmbCurso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(248, 307)
        Me.cmbCurso.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(733, 31)
        Me.cmbCurso.TabIndex = 1097
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(114, 175)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 24)
        Me.Label2.TabIndex = 1096
        Me.Label2.Text = "Fecha inicio"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(194, 102)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 30)
        Me.Button2.TabIndex = 1103
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(176, 313)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 24)
        Me.Label5.TabIndex = 1090
        Me.Label5.Text = "Curso"
        '
        'txtFechaInicioMatricula
        '
        Me.txtFechaInicioMatricula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFechaInicioMatricula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicioMatricula.Location = New System.Drawing.Point(248, 171)
        Me.txtFechaInicioMatricula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFechaInicioMatricula.Name = "txtFechaInicioMatricula"
        Me.txtFechaInicioMatricula.Size = New System.Drawing.Size(733, 30)
        Me.txtFechaInicioMatricula.TabIndex = 1095
        '
        'txtestudiante
        '
        Me.txtestudiante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtestudiante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtestudiante.Location = New System.Drawing.Point(248, 102)
        Me.txtestudiante.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtestudiante.MaxLength = 40
        Me.txtestudiante.Name = "txtestudiante"
        Me.txtestudiante.Size = New System.Drawing.Size(197, 30)
        Me.txtestudiante.TabIndex = 1084
        '
        'txtMonto
        '
        Me.txtMonto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMonto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMonto.Location = New System.Drawing.Point(248, 239)
        Me.txtMonto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMonto.MaxLength = 40
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(733, 30)
        Me.txtMonto.TabIndex = 1085
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(86, 244)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 24)
        Me.Label10.TabIndex = 1089
        Me.Label10.Text = "Valor Matricula"
        '
        'cmbJornada
        '
        Me.cmbJornada.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbJornada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJornada.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJornada.FormattingEnabled = True
        Me.cmbJornada.Location = New System.Drawing.Point(248, 136)
        Me.cmbJornada.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbJornada.Name = "cmbJornada"
        Me.cmbJornada.Size = New System.Drawing.Size(733, 31)
        Me.cmbJornada.TabIndex = 1101
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(153, 142)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 24)
        Me.Label11.TabIndex = 1100
        Me.Label11.Text = "Jornada"
        '
        'dgvmatricula
        '
        Me.dgvmatricula.AllowUserToAddRows = False
        Me.dgvmatricula.AllowUserToDeleteRows = False
        Me.dgvmatricula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvmatricula.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvmatricula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvmatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmatricula.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idMatricula, Me.FechaInicioMatricula, Me.FechaFinMatricula, Me.ValorDeMatricula, Me.ValorMensualidad, Me.idEstudiante, Me.NumDocumento, Me.NombreCompleto, Me.direccion, Me.telefono, Me.idjornada, Me.jornada, Me.idCurso, Me.curso, Me.esEstudianteNuevo})
        Me.dgvmatricula.Location = New System.Drawing.Point(15, 463)
        Me.dgvmatricula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvmatricula.Name = "dgvmatricula"
        Me.dgvmatricula.ReadOnly = True
        Me.dgvmatricula.RowHeadersVisible = False
        Me.dgvmatricula.RowHeadersWidth = 62
        Me.dgvmatricula.Size = New System.Drawing.Size(1005, 244)
        Me.dgvmatricula.TabIndex = 1115
        '
        'idMatricula
        '
        Me.idMatricula.DataPropertyName = "idMatricula"
        Me.idMatricula.HeaderText = "idMatricula"
        Me.idMatricula.MinimumWidth = 8
        Me.idMatricula.Name = "idMatricula"
        Me.idMatricula.ReadOnly = True
        Me.idMatricula.Visible = False
        Me.idMatricula.Width = 150
        '
        'FechaInicioMatricula
        '
        Me.FechaInicioMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaInicioMatricula.DataPropertyName = "FechaInicioMatricula"
        Me.FechaInicioMatricula.HeaderText = "FechaInicioMatricula"
        Me.FechaInicioMatricula.MinimumWidth = 8
        Me.FechaInicioMatricula.Name = "FechaInicioMatricula"
        Me.FechaInicioMatricula.ReadOnly = True
        '
        'FechaFinMatricula
        '
        Me.FechaFinMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaFinMatricula.DataPropertyName = "FechaFinMatricula"
        Me.FechaFinMatricula.HeaderText = "FechaFinMatricula"
        Me.FechaFinMatricula.MinimumWidth = 8
        Me.FechaFinMatricula.Name = "FechaFinMatricula"
        Me.FechaFinMatricula.ReadOnly = True
        '
        'ValorDeMatricula
        '
        Me.ValorDeMatricula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ValorDeMatricula.DataPropertyName = "ValorDeMatricula"
        Me.ValorDeMatricula.HeaderText = "ValorDeMatricula"
        Me.ValorDeMatricula.MinimumWidth = 8
        Me.ValorDeMatricula.Name = "ValorDeMatricula"
        Me.ValorDeMatricula.ReadOnly = True
        '
        'ValorMensualidad
        '
        Me.ValorMensualidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ValorMensualidad.DataPropertyName = "ValorMensualidad"
        Me.ValorMensualidad.HeaderText = "ValorMensualidad"
        Me.ValorMensualidad.MinimumWidth = 8
        Me.ValorMensualidad.Name = "ValorMensualidad"
        Me.ValorMensualidad.ReadOnly = True
        '
        'idEstudiante
        '
        Me.idEstudiante.DataPropertyName = "idEstudiante"
        Me.idEstudiante.HeaderText = "idEstudiante"
        Me.idEstudiante.MinimumWidth = 8
        Me.idEstudiante.Name = "idEstudiante"
        Me.idEstudiante.ReadOnly = True
        Me.idEstudiante.Visible = False
        Me.idEstudiante.Width = 150
        '
        'NumDocumento
        '
        Me.NumDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NumDocumento.DataPropertyName = "NumDocumento"
        Me.NumDocumento.HeaderText = "NumDocumento"
        Me.NumDocumento.MinimumWidth = 8
        Me.NumDocumento.Name = "NumDocumento"
        Me.NumDocumento.ReadOnly = True
        '
        'NombreCompleto
        '
        Me.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreCompleto.DataPropertyName = "NombreCompleto"
        Me.NombreCompleto.HeaderText = "NombreCompleto"
        Me.NombreCompleto.MinimumWidth = 8
        Me.NombreCompleto.Name = "NombreCompleto"
        Me.NombreCompleto.ReadOnly = True
        '
        'direccion
        '
        Me.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.direccion.DataPropertyName = "direccion"
        Me.direccion.HeaderText = "direccion"
        Me.direccion.MinimumWidth = 8
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        '
        'telefono
        '
        Me.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.telefono.DataPropertyName = "telefono"
        Me.telefono.HeaderText = "telefono"
        Me.telefono.MinimumWidth = 8
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'idjornada
        '
        Me.idjornada.DataPropertyName = "idjornada"
        Me.idjornada.HeaderText = "idjornada"
        Me.idjornada.MinimumWidth = 8
        Me.idjornada.Name = "idjornada"
        Me.idjornada.ReadOnly = True
        Me.idjornada.Visible = False
        Me.idjornada.Width = 150
        '
        'jornada
        '
        Me.jornada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.jornada.DataPropertyName = "jornada"
        Me.jornada.HeaderText = "jornada"
        Me.jornada.MinimumWidth = 8
        Me.jornada.Name = "jornada"
        Me.jornada.ReadOnly = True
        '
        'idCurso
        '
        Me.idCurso.DataPropertyName = "idCurso"
        Me.idCurso.HeaderText = "idCurso"
        Me.idCurso.MinimumWidth = 8
        Me.idCurso.Name = "idCurso"
        Me.idCurso.ReadOnly = True
        Me.idCurso.Visible = False
        Me.idCurso.Width = 150
        '
        'curso
        '
        Me.curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.curso.DataPropertyName = "curso"
        Me.curso.HeaderText = "Curso"
        Me.curso.MinimumWidth = 8
        Me.curso.Name = "curso"
        Me.curso.ReadOnly = True
        '
        'esEstudianteNuevo
        '
        Me.esEstudianteNuevo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.esEstudianteNuevo.DataPropertyName = "esEstudianteNuevo"
        Me.esEstudianteNuevo.HeaderText = "EstudianteNuevo"
        Me.esEstudianteNuevo.MinimumWidth = 8
        Me.esEstudianteNuevo.Name = "esEstudianteNuevo"
        Me.esEstudianteNuevo.ReadOnly = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1008, 83)
        Me.Panel5.TabIndex = 1118
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(304, 12)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(385, 60)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "MATRICULAS"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(12, 394)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1008, 62)
        Me.Panel1.TabIndex = 1119
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(828, 0)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 62)
        Me.btnCancelar.TabIndex = 1097
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.Location = New System.Drawing.Point(888, 0)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(60, 62)
        Me.btnNuevo.TabIndex = 1098
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(948, 0)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(60, 62)
        Me.btnGuardar.TabIndex = 1084
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(448, 102)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.MaxLength = 40
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(533, 30)
        Me.TextBox1.TabIndex = 1119
        '
        'frmMatricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgvmatricula)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMatricula"
        Me.Size = New System.Drawing.Size(1032, 716)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvmatricula, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Private WithEvents cmbCurso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Private WithEvents txtFechaInicioMatricula As DateTimePicker
    Friend WithEvents txtestudiante As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label10 As Label
    Private WithEvents cmbJornada As ComboBox
    Friend WithEvents Label11 As Label
    Private WithEvents dgvmatricula As DataGridView
    Friend WithEvents txtMensualidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents txtFechaFinMatricula As DateTimePicker
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents idMatricula As DataGridViewTextBoxColumn
    Friend WithEvents FechaInicioMatricula As DataGridViewTextBoxColumn
    Friend WithEvents FechaFinMatricula As DataGridViewTextBoxColumn
    Friend WithEvents ValorDeMatricula As DataGridViewTextBoxColumn
    Friend WithEvents ValorMensualidad As DataGridViewTextBoxColumn
    Friend WithEvents idEstudiante As DataGridViewTextBoxColumn
    Friend WithEvents NumDocumento As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents idjornada As DataGridViewTextBoxColumn
    Friend WithEvents jornada As DataGridViewTextBoxColumn
    Friend WithEvents idCurso As DataGridViewTextBoxColumn
    Friend WithEvents curso As DataGridViewTextBoxColumn
    Friend WithEvents esEstudianteNuevo As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents TextBox1 As TextBox
End Class
