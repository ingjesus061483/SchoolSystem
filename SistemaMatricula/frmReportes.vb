Imports Datos
Public Class frmReportes
    Dim hlp As New Helper, idest As Integer, Calificaciones As DataTable, Estudiantes As DataTable
    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Utilidades.Cmb(cmbCurso, hlp.ListarCursos, {"idCurso", "nombre"})
    End Sub

    Private Sub btnTxt_Click(sender As Object, e As EventArgs) Handles btnTxt.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Estudiantes = hlp.ListarEstudiantes(cmbCurso.SelectedValue)
        dgvEstudiante.DataSource = Estudiantes
        Calificaciones = hlp.ListarCalificacionesPorEstudiantes(cmbCurso.SelectedValue, idest, txtFechaInicioMatricula.Value, txtFechaFinMatricula.Value)
        Calificaciones.TableName = "Boletines DEl periodo " & txtFechaInicioMatricula.Value & " - " & txtFechaFinMatricula.Value
        dgVer.DataSource = Calificaciones
    End Sub
    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        If TabControl1.SelectedTab Is TabBoletines Then
            Utilidades.ExportarDatos(Calificaciones)
        ElseIf TabControl1.SelectedTab Is tabListarEstudiante Then
            Utilidades.ExportarDatos(Estudiantes)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEstudiante.Click
        Try
            Dim frmbusqueda As New FrmBusqueda With {.Tabla = hlp.ListarEstudiantes(DBNull.Value)}
            frmbusqueda.ShowDialog()
            idest = frmbusqueda.Id
            Dim estudiante = hlp.BuscarEstudiante(idest)
            txtestudiante.Text = estudiante.PrimerNombre + " " + estudiante.PrimerApellido
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
End Class