Imports Datos
Public Class MatriculaUser
    Dim hlp As New Helper
    Dim idest As String = ""
    Dim idUsuario As Integer = frmPrincipal.usuarios.IdUsuario
    Sub Bloquear()
        btnNuevo.Enabled = True
        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        txtMonto.ReadOnly = True
        txtMensualidad.ReadOnly = True

    End Sub

    Sub Desbloquear()
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        txtMonto.ReadOnly = False
        txtMensualidad.ReadOnly = False
    End Sub
    Sub Limpiar()
        txtMonto.Clear()
        txtMensualidad.Clear()
        txtestudiante.Clear()
    End Sub

    Sub actualizarDgv()
        dgvmatricula.DataSource = hlp.ListarMatriculas
    End Sub

    Private Sub frm_matricula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizarDgv()
        Utilidades.Cmb(cmbJornada, hlp.ListarJornada, {"idjornada", "nombre"})
        Utilidades.Cmb(cmbCurso, hlp.ListarCursos, {"idCurso", "nombre"})
        Bloquear()
    End Sub

    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Desbloquear()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If txtestudiante.Text = "" Then
                MessageBox.Show("FALTAN CAMPOS POR LLENAR")
                Return
            End If
            If cmbCurso.SelectedIndex = -1 Then
                MessageBox.Show("FALTAN CAMPOS POR LLENAR")
                Return
            End If
            If cmbJornada.Text = "" Then
                MessageBox.Show("FALTAN CAMPOS POR LLENAR")
                Return
            End If
            If txtMonto.Text = "" Then
                MessageBox.Show("FALTAN CAMPOS POR LLENAR")
                Return
            End If
            If txtMensualidad.Text = "" Then
                MessageBox.Show("FALTAN CAMPOS POR LLENAR")
                Return
            End If
            Dim CodJor As Integer = CInt(cmbJornada.SelectedValue)
            Dim CodCurso As Integer = CInt(cmbCurso.SelectedValue)
            hlp.InsertarMatricula(CInt(idest), cmbCurso.SelectedValue, cmbJornada.SelectedValue, txtFechaInicioMatricula.Value, txtFechaFinMatricula.Value,
                                  txtMonto.Text, txtMensualidad.Text)
            Limpiar()
            actualizarDgv()
            Bloquear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btncancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Bloquear()
        Limpiar()
    End Sub


    Private Sub txt_monto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If Utilidades.SoloNumeros(e.KeyChar) = False Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim frmbusqueda As New FrmBusqueda With {.Tabla = hlp.ListarEstudiantes(DBNull.Value)}
            frmbusqueda.ShowDialog()
            idest = frmbusqueda.Id
            Dim estudiante = hlp.BuscarEstudiante(CInt(idest))
            txtestudiante.Text = estudiante.PrimerNombre + " " + estudiante.PrimerApellido
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
