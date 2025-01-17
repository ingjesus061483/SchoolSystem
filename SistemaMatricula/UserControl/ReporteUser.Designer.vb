<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteUser
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteUser))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabBoletines = New System.Windows.Forms.TabPage()
        Me.dgVer = New System.Windows.Forms.DataGridView()
        Me.idCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.curso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idEstudiante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTipoIdentificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoidentificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAsignatura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Asignatura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdLogro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.logro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionLogro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotaFinalLogro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabListarEstudiante = New System.Windows.Forms.TabPage()
        Me.dgvEstudiante = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idTipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaFinMatricula = New System.Windows.Forms.DateTimePicker()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEstudiante = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFechaInicioMatricula = New System.Windows.Forms.DateTimePicker()
        Me.txtestudiante = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnPdf = New System.Windows.Forms.Button()
        Me.btnTxt = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabBoletines.SuspendLayout()
        CType(Me.dgVer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabListarEstudiante.SuspendLayout()
        CType(Me.dgvEstudiante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabBoletines)
        Me.TabControl1.Controls.Add(Me.tabListarEstudiante)
        Me.TabControl1.Location = New System.Drawing.Point(23, 344)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(700, 518)
        Me.TabControl1.TabIndex = 1129
        '
        'TabBoletines
        '
        Me.TabBoletines.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TabBoletines.Controls.Add(Me.dgVer)
        Me.TabBoletines.Location = New System.Drawing.Point(4, 29)
        Me.TabBoletines.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabBoletines.Name = "TabBoletines"
        Me.TabBoletines.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabBoletines.Size = New System.Drawing.Size(692, 485)
        Me.TabBoletines.TabIndex = 0
        Me.TabBoletines.Text = "Boletines"
        '
        'dgVer
        '
        Me.dgVer.AllowUserToAddRows = False
        Me.dgVer.AllowUserToDeleteRows = False
        Me.dgVer.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgVer.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCurso, Me.curso, Me.idEstudiante, Me.IdTipoIdentificacion, Me.tipoidentificacion, Me.NumDocumento, Me.NombreCompleto, Me.FechaNacimiento, Me.direccion, Me.telefono, Me.IdSexo, Me.sexo, Me.IdAsignatura, Me.Asignatura, Me.IdLogro, Me.logro, Me.DescripcionLogro, Me.NotaFinalLogro})
        Me.dgVer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVer.GridColor = System.Drawing.Color.White
        Me.dgVer.Location = New System.Drawing.Point(4, 5)
        Me.dgVer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgVer.Name = "dgVer"
        Me.dgVer.ReadOnly = True
        Me.dgVer.RowHeadersVisible = False
        Me.dgVer.RowHeadersWidth = 62
        Me.dgVer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVer.Size = New System.Drawing.Size(684, 475)
        Me.dgVer.TabIndex = 1119
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
        Me.curso.HeaderText = "curso"
        Me.curso.MinimumWidth = 8
        Me.curso.Name = "curso"
        Me.curso.ReadOnly = True
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
        'IdTipoIdentificacion
        '
        Me.IdTipoIdentificacion.DataPropertyName = "IdTipoIdentificacion"
        Me.IdTipoIdentificacion.HeaderText = "IdTipoIdentificacion"
        Me.IdTipoIdentificacion.MinimumWidth = 8
        Me.IdTipoIdentificacion.Name = "IdTipoIdentificacion"
        Me.IdTipoIdentificacion.ReadOnly = True
        Me.IdTipoIdentificacion.Visible = False
        Me.IdTipoIdentificacion.Width = 150
        '
        'tipoidentificacion
        '
        Me.tipoidentificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipoidentificacion.DataPropertyName = "tipoidentificacion"
        Me.tipoidentificacion.HeaderText = "tipoidentificacion"
        Me.tipoidentificacion.MinimumWidth = 8
        Me.tipoidentificacion.Name = "tipoidentificacion"
        Me.tipoidentificacion.ReadOnly = True
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
        'FechaNacimiento
        '
        Me.FechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaNacimiento.DataPropertyName = "FechaNacimiento"
        Me.FechaNacimiento.HeaderText = "FechaNacimiento"
        Me.FechaNacimiento.MinimumWidth = 8
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.ReadOnly = True
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
        'IdSexo
        '
        Me.IdSexo.DataPropertyName = "IdSexo"
        Me.IdSexo.HeaderText = "IdSexo"
        Me.IdSexo.MinimumWidth = 8
        Me.IdSexo.Name = "IdSexo"
        Me.IdSexo.ReadOnly = True
        Me.IdSexo.Visible = False
        Me.IdSexo.Width = 150
        '
        'sexo
        '
        Me.sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.sexo.DataPropertyName = "sexo"
        Me.sexo.HeaderText = "sexo"
        Me.sexo.MinimumWidth = 8
        Me.sexo.Name = "sexo"
        Me.sexo.ReadOnly = True
        '
        'IdAsignatura
        '
        Me.IdAsignatura.DataPropertyName = "IdAsignatura"
        Me.IdAsignatura.HeaderText = "IdAsignatura"
        Me.IdAsignatura.MinimumWidth = 8
        Me.IdAsignatura.Name = "IdAsignatura"
        Me.IdAsignatura.ReadOnly = True
        Me.IdAsignatura.Visible = False
        Me.IdAsignatura.Width = 150
        '
        'Asignatura
        '
        Me.Asignatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Asignatura.DataPropertyName = "Asignatura"
        Me.Asignatura.HeaderText = "Asignatura"
        Me.Asignatura.MinimumWidth = 8
        Me.Asignatura.Name = "Asignatura"
        Me.Asignatura.ReadOnly = True
        '
        'IdLogro
        '
        Me.IdLogro.DataPropertyName = "IdLogro"
        Me.IdLogro.HeaderText = "IdLogro"
        Me.IdLogro.MinimumWidth = 8
        Me.IdLogro.Name = "IdLogro"
        Me.IdLogro.ReadOnly = True
        Me.IdLogro.Visible = False
        Me.IdLogro.Width = 150
        '
        'logro
        '
        Me.logro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.logro.DataPropertyName = "logro"
        Me.logro.HeaderText = "logro"
        Me.logro.MinimumWidth = 8
        Me.logro.Name = "logro"
        Me.logro.ReadOnly = True
        '
        'DescripcionLogro
        '
        Me.DescripcionLogro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionLogro.DataPropertyName = "DescripcionLogro"
        Me.DescripcionLogro.HeaderText = "DescripcionLogro"
        Me.DescripcionLogro.MinimumWidth = 8
        Me.DescripcionLogro.Name = "DescripcionLogro"
        Me.DescripcionLogro.ReadOnly = True
        '
        'NotaFinalLogro
        '
        Me.NotaFinalLogro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NotaFinalLogro.DataPropertyName = "NotaFinalLogro"
        Me.NotaFinalLogro.HeaderText = "NotaFinalLogro"
        Me.NotaFinalLogro.MinimumWidth = 8
        Me.NotaFinalLogro.Name = "NotaFinalLogro"
        Me.NotaFinalLogro.ReadOnly = True
        '
        'tabListarEstudiante
        '
        Me.tabListarEstudiante.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tabListarEstudiante.Controls.Add(Me.dgvEstudiante)
        Me.tabListarEstudiante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabListarEstudiante.Location = New System.Drawing.Point(4, 29)
        Me.tabListarEstudiante.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabListarEstudiante.Name = "tabListarEstudiante"
        Me.tabListarEstudiante.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabListarEstudiante.Size = New System.Drawing.Size(692, 485)
        Me.tabListarEstudiante.TabIndex = 1
        Me.tabListarEstudiante.Text = "listado de Estudiante"
        '
        'dgvEstudiante
        '
        Me.dgvEstudiante.AllowUserToAddRows = False
        Me.dgvEstudiante.AllowUserToDeleteRows = False
        Me.dgvEstudiante.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvEstudiante.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstudiante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.idTipoDocumento, Me.DataGridViewTextBoxColumn3, Me.tipoDocumento, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgvEstudiante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEstudiante.Location = New System.Drawing.Point(4, 5)
        Me.dgvEstudiante.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvEstudiante.Name = "dgvEstudiante"
        Me.dgvEstudiante.ReadOnly = True
        Me.dgvEstudiante.RowHeadersVisible = False
        Me.dgvEstudiante.RowHeadersWidth = 62
        Me.dgvEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEstudiante.Size = New System.Drawing.Size(684, 475)
        Me.dgvEstudiante.TabIndex = 1103
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idCurso"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idCurso"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idEstudiante"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idEstudiante"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'idTipoDocumento
        '
        Me.idTipoDocumento.DataPropertyName = "idTipoDocumento"
        Me.idTipoDocumento.HeaderText = "idTipoDocumento"
        Me.idTipoDocumento.MinimumWidth = 8
        Me.idTipoDocumento.Name = "idTipoDocumento"
        Me.idTipoDocumento.ReadOnly = True
        Me.idTipoDocumento.Visible = False
        Me.idTipoDocumento.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Curso"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Curso"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'tipoDocumento
        '
        Me.tipoDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipoDocumento.DataPropertyName = "tipoDocumento"
        Me.tipoDocumento.HeaderText = "Tipo Documento"
        Me.tipoDocumento.MinimumWidth = 8
        Me.tipoDocumento.Name = "tipoDocumento"
        Me.tipoDocumento.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NumDocumento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Numero Documento"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NombreCompleto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Nombre completo"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FechaNacimiento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha Nacimiento"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "idSexo"
        Me.DataGridViewTextBoxColumn9.HeaderText = "idSexo"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "sexo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Sexo"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtFechaFinMatricula)
        Me.Panel3.Controls.Add(Me.cmbCurso)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btnEstudiante)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtFechaInicioMatricula)
        Me.Panel3.Controls.Add(Me.txtestudiante)
        Me.Panel3.Location = New System.Drawing.Point(23, 18)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(700, 244)
        Me.Panel3.TabIndex = 1127
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(398, 150)
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
        Me.txtFechaFinMatricula.Location = New System.Drawing.Point(509, 146)
        Me.txtFechaFinMatricula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFechaFinMatricula.Name = "txtFechaFinMatricula"
        Me.txtFechaFinMatricula.Size = New System.Drawing.Size(167, 30)
        Me.txtFechaFinMatricula.TabIndex = 1106
        '
        'cmbCurso
        '
        Me.cmbCurso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(144, 112)
        Me.cmbCurso.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(532, 31)
        Me.cmbCurso.TabIndex = 1097
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 24)
        Me.Label2.TabIndex = 1096
        Me.Label2.Text = "Fecha inicio"
        '
        'btnEstudiante
        '
        Me.btnEstudiante.BackColor = System.Drawing.Color.Transparent
        Me.btnEstudiante.BackgroundImage = CType(resources.GetObject("btnEstudiante.BackgroundImage"), System.Drawing.Image)
        Me.btnEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstudiante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstudiante.ForeColor = System.Drawing.Color.White
        Me.btnEstudiante.Location = New System.Drawing.Point(103, 180)
        Me.btnEstudiante.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEstudiante.Name = "btnEstudiante"
        Me.btnEstudiante.Size = New System.Drawing.Size(38, 30)
        Me.btnEstudiante.TabIndex = 1103
        Me.btnEstudiante.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(72, 118)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 24)
        Me.Label5.TabIndex = 1090
        Me.Label5.Text = "Curso"
        '
        'txtFechaInicioMatricula
        '
        Me.txtFechaInicioMatricula.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInicioMatricula.Location = New System.Drawing.Point(144, 146)
        Me.txtFechaInicioMatricula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFechaInicioMatricula.Name = "txtFechaInicioMatricula"
        Me.txtFechaInicioMatricula.Size = New System.Drawing.Size(213, 30)
        Me.txtFechaInicioMatricula.TabIndex = 1095
        '
        'txtestudiante
        '
        Me.txtestudiante.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtestudiante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtestudiante.Location = New System.Drawing.Point(144, 180)
        Me.txtestudiante.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtestudiante.MaxLength = 40
        Me.txtestudiante.Name = "txtestudiante"
        Me.txtestudiante.Size = New System.Drawing.Size(150, 30)
        Me.txtestudiante.TabIndex = 1084
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCargar)
        Me.Panel1.Controls.Add(Me.btnExcel)
        Me.Panel1.Controls.Add(Me.btnPdf)
        Me.Panel1.Controls.Add(Me.btnTxt)
        Me.Panel1.Location = New System.Drawing.Point(23, 271)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(700, 62)
        Me.Panel1.TabIndex = 1130
        '
        'btnExcel
        '
        Me.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcel.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.Location = New System.Drawing.Point(520, 0)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(60, 62)
        Me.btnExcel.TabIndex = 1099
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnPdf
        '
        Me.btnPdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPdf.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPdf.Image = CType(resources.GetObject("btnPdf.Image"), System.Drawing.Image)
        Me.btnPdf.Location = New System.Drawing.Point(580, 0)
        Me.btnPdf.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPdf.Name = "btnPdf"
        Me.btnPdf.Size = New System.Drawing.Size(60, 62)
        Me.btnPdf.TabIndex = 1097
        Me.btnPdf.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPdf.UseVisualStyleBackColor = True
        '
        'btnTxt
        '
        Me.btnTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTxt.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTxt.Image = CType(resources.GetObject("btnTxt.Image"), System.Drawing.Image)
        Me.btnTxt.Location = New System.Drawing.Point(640, 0)
        Me.btnTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTxt.Name = "btnTxt"
        Me.btnTxt.Size = New System.Drawing.Size(60, 62)
        Me.btnTxt.TabIndex = 1098
        Me.btnTxt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTxt.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCargar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargar.Image = CType(resources.GetObject("btnCargar.Image"), System.Drawing.Image)
        Me.btnCargar.Location = New System.Drawing.Point(460, 0)
        Me.btnCargar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(60, 62)
        Me.btnCargar.TabIndex = 1100
        Me.btnCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(299, 180)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.MaxLength = 40
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(377, 30)
        Me.TextBox1.TabIndex = 1108
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(700, 83)
        Me.Panel5.TabIndex = 1115
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(190, 12)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(310, 60)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "REPORTES"
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(743, 872)
        Me.TabControl1.ResumeLayout(False)
        Me.TabBoletines.ResumeLayout(False)
        CType(Me.dgVer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabListarEstudiante.ResumeLayout(False)
        CType(Me.dgvEstudiante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabBoletines As TabPage
    Friend WithEvents dgVer As DataGridView
    Friend WithEvents idCurso As DataGridViewTextBoxColumn
    Friend WithEvents curso As DataGridViewTextBoxColumn
    Friend WithEvents idEstudiante As DataGridViewTextBoxColumn
    Friend WithEvents IdTipoIdentificacion As DataGridViewTextBoxColumn
    Friend WithEvents tipoidentificacion As DataGridViewTextBoxColumn
    Friend WithEvents NumDocumento As DataGridViewTextBoxColumn
    Friend WithEvents NombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents direccion As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents IdSexo As DataGridViewTextBoxColumn
    Friend WithEvents sexo As DataGridViewTextBoxColumn
    Friend WithEvents IdAsignatura As DataGridViewTextBoxColumn
    Friend WithEvents Asignatura As DataGridViewTextBoxColumn
    Friend WithEvents IdLogro As DataGridViewTextBoxColumn
    Friend WithEvents logro As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionLogro As DataGridViewTextBoxColumn
    Friend WithEvents NotaFinalLogro As DataGridViewTextBoxColumn
    Friend WithEvents tabListarEstudiante As TabPage
    Private WithEvents dgvEstudiante As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents idTipoDocumento As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents tipoDocumento As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Private WithEvents txtFechaFinMatricula As DateTimePicker
    Private WithEvents cmbCurso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEstudiante As Button
    Friend WithEvents Label5 As Label
    Private WithEvents txtFechaInicioMatricula As DateTimePicker
    Friend WithEvents txtestudiante As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnPdf As Button
    Friend WithEvents btnTxt As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label12 As Label
End Class
