Imports Datos
Public Class AsignaturasUser
    Property IdUsuario As Integer
    Dim hlp As New Helper, CodAsignatura As Integer
    Private Sub frmAsignaturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvEstudiante.DataSource = hlp.ListarAsignaturas(IdUsuario)
        Utilidades.Cmb(cmbCurso, hlp.ListarCursos, {"idCurso", "nombre"})
        Bloquear()
    End Sub
    Sub Bloquear()
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        txtCodigo.ReadOnly = True
        txtNombre.ReadOnly = True
        txtCantidadHoraria.ReadOnly = True
        txtDescripcion.ReadOnly = True
    End Sub

    Sub Desbloquear()
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        txtCodigo.ReadOnly = False
        txtNombre.ReadOnly = False
        txtCantidadHoraria.ReadOnly = False
        txtDescripcion.ReadOnly = False
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Desbloquear()
    End Sub
    Sub limpiar()
        CodAsignatura = 0
        txtCodigo.Clear()
        txtNombre.Clear()
        txtCantidadHoraria.Clear()
        txtDescripcion.Clear()
        cmbCurso.SelectedIndex = -1

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
            If txtCantidadHoraria.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If cmbCurso.SelectedIndex = -1 Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If CodAsignatura = 0 Then
                hlp.InsertarAsignatura(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, txtCantidadHoraria.Text,
                                    IdUsuario, cmbCurso.SelectedValue)
            Else
                hlp.ModificarAsignatura(CodAsignatura, txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, txtCantidadHoraria.Text,
                                     cmbCurso.SelectedValue)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            dgvEstudiante.DataSource = hlp.ListarAsignaturas(IdUsuario)
            limpiar()
            Bloquear()
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
        Bloquear()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If (CodAsignatura = 0) Then
            MsgBox("SELECCIONA UN REGISTRO", MsgBoxStyle.Exclamation)
        Else
            Desbloquear()
        End If

    End Sub

    Private Sub dgvEstudiante_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstudiante.CellContentDoubleClick
        With dgvEstudiante
            CodAsignatura = .CurrentRow.Cells("idAsignatura").Value.ToString()
            txtCodigo.Text = .CurrentRow.Cells("Codigo").Value.ToString()
            txtNombre.Text = .CurrentRow.Cells("nombre").Value.ToString()
            txtCantidadHoraria.Text = .CurrentRow.Cells("CantidadHoraria").Value.ToString()
            txtDescripcion.Text = .CurrentRow.Cells("Descripcion").Value.ToString()
            cmbCurso.SelectedValue = .CurrentRow.Cells("idcurso").Value
        End With
    End Sub
End Class
