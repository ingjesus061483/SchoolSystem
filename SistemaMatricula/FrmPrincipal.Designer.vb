<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnEstudiante = New System.Windows.Forms.ToolStripButton()
        Me.btnCursos = New System.Windows.Forms.ToolStripButton()
        Me.btnmatricula = New System.Windows.Forms.ToolStripButton()
        Me.bntAsignaturas = New System.Windows.Forms.ToolStripButton()
        Me.btnlogros = New System.Windows.Forms.ToolStripButton()
        Me.btnCalificaciones = New System.Windows.Forms.ToolStripButton()
        Me.btnReportes = New System.Windows.Forms.ToolStripButton()
        Me.btnUsuarios = New System.Windows.Forms.ToolStripButton()
        Me.btnCerrar = New System.Windows.Forms.ToolStripButton()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.panel1.Controls.Add(Me.Panel6)
        Me.panel1.Controls.Add(Me.Panel5)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1582, 148)
        Me.panel1.TabIndex = 11
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel6.Controls.Add(Me.label2)
        Me.Panel6.Controls.Add(Me.label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(141, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1441, 148)
        Me.Panel6.TabIndex = 4
        '
        'label2
        '
        Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!)
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(0, 63)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(1441, 85)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Versión: 1.0.0 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Autor: Ing. Jesus Mora"
        '
        'label1
        '
        Me.label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(1441, 63)
        Me.label1.TabIndex = 1
        Me.label1.Text = "SISTEMA DE MATRÍCULAS Y CALIFICACIONES"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.pictureBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(141, 148)
        Me.Panel5.TabIndex = 3
        '
        'pictureBox1
        '
        Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.pictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(141, 148)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlMain.Controls.Add(Me.pnlBody)
        Me.pnlMain.Controls.Add(Me.ToolStrip1)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(431, 0)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1151, 889)
        Me.pnlMain.TabIndex = 6
        '
        'lblUsuario
        '
        Me.lblUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(118, 20)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(184, 25)
        Me.lblUsuario.TabIndex = 1113
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(27, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 24)
        Me.Label6.TabIndex = 1112
        Me.Label6.Text = "Usuario"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pnlMain)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 148)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1582, 889)
        Me.Panel2.TabIndex = 1114
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(431, 889)
        Me.Panel4.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.lblTelefono)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.lbldireccion)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblApellido)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.lblNombre)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.lblUsuario)
        Me.Panel3.Location = New System.Drawing.Point(12, 34)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(411, 682)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(12, 198)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(317, 394)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 148)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 24)
        Me.Label7.TabIndex = 1120
        Me.Label7.Text = "Telefono"
        '
        'lblTelefono
        '
        Me.lblTelefono.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.White
        Me.lblTelefono.Location = New System.Drawing.Point(116, 148)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(188, 25)
        Me.lblTelefono.TabIndex = 1121
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(8, 115)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 24)
        Me.Label5.TabIndex = 1118
        Me.Label5.Text = "Direccion"
        '
        'lbldireccion
        '
        Me.lbldireccion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldireccion.ForeColor = System.Drawing.Color.White
        Me.lbldireccion.Location = New System.Drawing.Point(116, 115)
        Me.lbldireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(216, 25)
        Me.lbldireccion.TabIndex = 1119
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 83)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 24)
        Me.Label4.TabIndex = 1116
        Me.Label4.Text = "Aplellido"
        '
        'lblApellido
        '
        Me.lblApellido.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.Color.White
        Me.lblApellido.Location = New System.Drawing.Point(116, 83)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(188, 25)
        Me.lblApellido.TabIndex = 1117
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 24)
        Me.Label3.TabIndex = 1114
        Me.Label3.Text = "Nombre"
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(118, 51)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(184, 25)
        Me.lblNombre.TabIndex = 1115
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEstudiante, Me.btnCursos, Me.btnmatricula, Me.bntAsignaturas, Me.btnlogros, Me.btnCalificaciones, Me.btnReportes, Me.btnUsuarios, Me.btnCerrar})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1151, 57)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnEstudiante
        '
        Me.btnEstudiante.BackColor = System.Drawing.Color.Transparent
        Me.btnEstudiante.BackgroundImage = CType(resources.GetObject("btnEstudiante.BackgroundImage"), System.Drawing.Image)
        Me.btnEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEstudiante.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEstudiante.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEstudiante.Name = "btnEstudiante"
        Me.btnEstudiante.Size = New System.Drawing.Size(34, 52)
        Me.btnEstudiante.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEstudiante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnEstudiante.ToolTipText = "Estudiantes"
        '
        'btnCursos
        '
        Me.btnCursos.BackColor = System.Drawing.Color.Transparent
        Me.btnCursos.BackgroundImage = CType(resources.GetObject("btnCursos.BackgroundImage"), System.Drawing.Image)
        Me.btnCursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCursos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCursos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCursos.Name = "btnCursos"
        Me.btnCursos.Size = New System.Drawing.Size(34, 52)
        Me.btnCursos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCursos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCursos.ToolTipText = "Cursos"
        '
        'btnmatricula
        '
        Me.btnmatricula.BackColor = System.Drawing.Color.Transparent
        Me.btnmatricula.BackgroundImage = CType(resources.GetObject("btnmatricula.BackgroundImage"), System.Drawing.Image)
        Me.btnmatricula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmatricula.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnmatricula.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnmatricula.Name = "btnmatricula"
        Me.btnmatricula.Size = New System.Drawing.Size(34, 64)
        Me.btnmatricula.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmatricula.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnmatricula.ToolTipText = "Matricula"
        '
        'bntAsignaturas
        '
        Me.bntAsignaturas.BackColor = System.Drawing.Color.Transparent
        Me.bntAsignaturas.BackgroundImage = CType(resources.GetObject("bntAsignaturas.BackgroundImage"), System.Drawing.Image)
        Me.bntAsignaturas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bntAsignaturas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bntAsignaturas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bntAsignaturas.Name = "bntAsignaturas"
        Me.bntAsignaturas.Size = New System.Drawing.Size(34, 64)
        Me.bntAsignaturas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bntAsignaturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.bntAsignaturas.ToolTipText = "Asignaturas"
        '
        'btnlogros
        '
        Me.btnlogros.BackColor = System.Drawing.Color.Transparent
        Me.btnlogros.BackgroundImage = CType(resources.GetObject("btnlogros.BackgroundImage"), System.Drawing.Image)
        Me.btnlogros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnlogros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnlogros.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnlogros.Name = "btnlogros"
        Me.btnlogros.Size = New System.Drawing.Size(34, 64)
        Me.btnlogros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnlogros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnlogros.ToolTipText = "Logros"
        '
        'btnCalificaciones
        '
        Me.btnCalificaciones.BackColor = System.Drawing.Color.Transparent
        Me.btnCalificaciones.BackgroundImage = CType(resources.GetObject("btnCalificaciones.BackgroundImage"), System.Drawing.Image)
        Me.btnCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalificaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCalificaciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCalificaciones.Name = "btnCalificaciones"
        Me.btnCalificaciones.Size = New System.Drawing.Size(34, 64)
        Me.btnCalificaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCalificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCalificaciones.ToolTipText = "Calificaciones"
        '
        'btnReportes
        '
        Me.btnReportes.BackColor = System.Drawing.Color.Transparent
        Me.btnReportes.BackgroundImage = CType(resources.GetObject("btnReportes.BackgroundImage"), System.Drawing.Image)
        Me.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(34, 64)
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnReportes.ToolTipText = "Usuarios"
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuarios.BackgroundImage = CType(resources.GetObject("btnUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(34, 64)
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnUsuarios.ToolTipText = "Usuarios"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(34, 52)
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'pnlBody
        '
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 57)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1151, 832)
        Me.pnlBody.TabIndex = 8
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1582, 1037)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Matrículas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnCerrar As ToolStripButton
    Friend WithEvents btnEstudiante As ToolStripButton
    Friend WithEvents btnmatricula As ToolStripButton
    Friend WithEvents btnlogros As ToolStripButton
    Friend WithEvents btnUsuarios As ToolStripButton
    Friend WithEvents bntAsignaturas As ToolStripButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCursos As ToolStripButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbldireccion As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCalificaciones As ToolStripButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnReportes As ToolStripButton
    Friend WithEvents pnlBody As Panel
End Class
