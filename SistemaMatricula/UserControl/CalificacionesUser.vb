Imports Datos
Public Class CalificacionesUser
    Dim hlp As New Helper, idest As Integer, idLogros As Integer, idcal As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim frmbusqueda As New FrmBusqueda With {.Tabla = hlp.ListarLogros}
            frmbusqueda.ShowDialog()
            idLogros = frmbusqueda.Id
            Dim logros = hlp.BuscarLogros(CInt(idLogros))
            txtLogros.Text = logros.Codigo + "-" + logros.Nombre
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim frmbusqueda As New FrmBusqueda With {.Tabla = hlp.ListarEstudiantes(DBNull.Value)}
            frmbusqueda.ShowDialog()
            idest = frmbusqueda.Id
            Dim estudiante = hlp.BuscarEstudiante(CInt(idest))
            txtEstudiante.Text = estudiante.PrimerNombre + " " + estudiante.PrimerApellido
            dgvEstudiante.DataSource = hlp.ListarCalificacionesPorEstudiante(idest)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Limpiar()
        Desbloquear()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If idcal = 0 Then
            MsgBox("SELECCIONA UN REGISTRO", MsgBoxStyle.Exclamation)
        Else
            Desbloquear()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        Bloquear()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If txtLogros.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtEstudiante.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtConcepto.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtNota.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If idcal = 0 Then
                hlp.InsertarCalificaciones(idLogros, idest, dtpFecha.Value, txtConcepto.Text, txtNota.Text, txtObservacion.Text)
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            dgvEstudiante.DataSource = hlp.ListarCalificacionesPorEstudiante(idest)
            Limpiar()
            Bloquear()
        End Try
    End Sub

    Sub Bloquear()
        btnNuevo.Enabled = True
        btnEditar.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False
        txtConcepto.ReadOnly = True
        txtNota.ReadOnly = True
        txtObservacion.ReadOnly = True


    End Sub

    Private Sub frmCalificaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bloquear()
    End Sub


    Sub Desbloquear()
        btnEditar.Enabled = True
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
        txtConcepto.ReadOnly = False
        txtNota.ReadOnly = False
        txtObservacion.ReadOnly = False

    End Sub
    Sub Limpiar()
        idcal = 0
        txtConcepto.Clear()
        txtNota.Clear()
        dtpFecha.Value = Now
        txtObservacion.Clear()
        txtEstudiante.Clear()
        txtLogros.Clear()
    End Sub
    Private Sub dgvEstudiante_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstudiante.CellContentDoubleClick
        With dgvEstudiante
            idcal = .CurrentRow.Cells("IdCalificacion").Value.ToString()
            dtpFecha.Value = .CurrentRow.Cells("fecha").Value.ToString()
            txtConcepto.Text = .CurrentRow.Cells("concepto").Value.ToString()
            txtNota.Text = .CurrentRow.Cells("nota").Value.ToString()
            idLogros = .CurrentRow.Cells("idlogro").Value.ToString
            Dim logros = hlp.BuscarLogros(CInt(idLogros))
            txtLogros.Text = logros.Codigo + "-" + logros.Nombre
            txtObservacion.Text = .CurrentRow.Cells("observaciones").Value.ToString
        End With
    End Sub
End Class
