Imports Datos
Public Class LogrosUser
    Dim hlp As New Helper, idAsig As Integer, codlogro As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim usuario = frmPrincipal.usuarios
            Dim frmbusqueda As New FrmBusqueda With {.Tabla = hlp.ListarAsignaturas(usuario.IdUsuario)}
            frmbusqueda.ShowDialog()
            idAsig = frmbusqueda.Id
            Dim asignatura = hlp.BuscarAsignaturasPorId(CInt(idAsig))
            txtAsignatura.Text = asignatura.Nombre
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub frmLogros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvLogros.DataSource = hlp.ListarLogros
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If codlogro = 0 Then
            MsgBox("SELECCIONA UN REGISTRO", MsgBoxStyle.Exclamation)
        Else

            Desbloquear()
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Desbloquear()
        limpiar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtCodigo.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtNombre.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtAsignatura.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If codlogro = 0 Then
                hlp.InsertarLogros(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text,
                                    idAsig)
            Else
                hlp.ModificarLogros(codlogro, txtCodigo.Text, txtNombre.Text, txtDescripcion.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            dgvLogros.DataSource = hlp.ListarLogros()
            limpiar()
            Bloquear()
        End Try


    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Bloquear()
    End Sub
    Sub Bloquear()
        btnEditar.Enabled = False
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        txtCodigo.ReadOnly = True
        txtNombre.ReadOnly = True
        txtDescripcion.ReadOnly = True
    End Sub
    Sub Desbloquear()
        btnEditar.Enabled = False
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        txtCodigo.ReadOnly = False
        txtNombre.ReadOnly = False
        txtDescripcion.ReadOnly = False
    End Sub
    Sub Limpiar()
        codlogro = 0
        txtCodigo.Clear()
        txtNombre.Clear()
        txtDescripcion.Clear()
        txtAsignatura.Clear()
    End Sub
    Private Sub dgvEstudiante_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogros.CellContentDoubleClick
        With dgvLogros
            codlogro = .CurrentRow.Cells("idlogro").Value.ToString()
            txtCodigo.Text = .CurrentRow.Cells("Codigo").Value.ToString()
            txtNombre.Text = .CurrentRow.Cells("nombre").Value.ToString()
            txtDescripcion.Text = .CurrentRow.Cells("Descripcion").Value.ToString()
            idAsig = .CurrentRow.Cells("idasignatura").Value.ToString()
            txtAsignatura.Text = .CurrentRow.Cells("asignatura").Value
        End With
    End Sub
End Class
