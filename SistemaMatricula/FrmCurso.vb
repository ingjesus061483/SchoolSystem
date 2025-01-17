Imports Datos
Public Class Curso
    Dim hlp As New Helper
    Dim CodCurso As Integer
    Sub limpiar()
        CodCurso = 0
        txtNombre.Clear()
        txtCapacidadMax.Clear()
        txtDescripcion.Clear()

    End Sub

    Sub ActualizarDgv()
        dgvCurso.DataSource = hlp.ListarCursos()
    End Sub

    Sub bloquear()
        btnGuardar.Enabled = False
        btnEditar.Enabled = True
        btnNuevo.Enabled = True
        btnCancelar.Enabled = False

        txtNombre.ReadOnly = True
        txtCapacidadMax.ReadOnly = True
        txtDescripcion.ReadOnly = True

    End Sub

    Sub desbloquear()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnNuevo.Enabled = False
        btnCancelar.Enabled = True


        txtNombre.ReadOnly = False
        txtCapacidadMax.ReadOnly = False
        txtDescripcion.ReadOnly = False
    End Sub

    Private Sub frmcurso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarDgv()
        bloquear()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If txtNombre.Text = "" Then
                MsgBox("Falta el campo curso por llenar", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtNombre.Text = "" Then
                MsgBox("Falta el campo curso por llenar", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtCapacidadMax.Text = "" Then
                MsgBox("Falta el campo curso por llenar", MsgBoxStyle.Exclamation)
                Return
            End If
            If CodCurso = 0 Then
                hlp.InsertarCurso(txtNombre.Text, txtCapacidadMax.Text, txtDescripcion.Text)
            Else
                hlp.ModificarCursos(CodCurso, txtNombre.Text, txtCapacidadMax.Text, txtDescripcion.Text)
            End If
            ActualizarDgv()
            limpiar()
            bloquear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If (CodCurso = 0) Then
            MsgBox("Debes seleccionar un elemento de la grilla ", MsgBoxStyle.Exclamation)
            Return
        End If
        desbloquear()
    End Sub
    Private Sub dgvcurso_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCurso.CellDoubleClick
        CodCurso = dgvCurso.CurrentRow.Cells("idcurso").Value.ToString()
        txtNombre.Text = dgvCurso.CurrentRow.Cells("NombreCurso").Value.ToString()
        txtCapacidadMax.Text = dgvCurso.CurrentRow.Cells("CapacidadMaxima").Value.ToString()
        txtDescripcion.Text = dgvCurso.CurrentRow.Cells("Descripcion").Value.ToString()
    End Sub
    Private Sub txtnombre_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.LostFocus
        txtNombre.Text = UCase(txtNombre.Text)
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        desbloquear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        bloquear()
        limpiar()
    End Sub
End Class