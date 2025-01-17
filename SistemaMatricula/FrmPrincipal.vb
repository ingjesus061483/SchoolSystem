Imports Datos
Imports System.ComponentModel
Public Class frmPrincipal
    Public usuarios As DatosSQL.Usuarios
    Private Sub frmPrincipal_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Try
            frmLogin.ShowDialog()
            If usuarios Is Nothing Then
                Throw New Exception("No has iniciado sesion")
            End If
            With usuarios
                lblUsuario.Text = .Usuario
                lblNombre.Text = .Nombre
                lblApellido.Text = .Apellido
                lbldireccion.Text = .Direccion
                lblTelefono.Text = .Telefono
                If .Foto IsNot Nothing Then
                    pictureBox1.Image = Utilidades.CargarImagen(usuarios.Foto)
                End If
            End With
        Catch ex As Exception
            Me.Close()
        End Try
    End Sub
    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim DialogResult As DialogResult = MsgBox("Desea salir de la aplicion?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If DialogResult = vbYes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub btnEstudiante_Click(sender As Object, e As EventArgs) Handles btnEstudiante.Click
        Dim frmEstudiante As New EstudiantesUser
        Utilidades.AbrirEnPanel(frmEstudiante, pnlMain)
    End Sub
    Private Sub btnmatricula_Click(sender As Object, e As EventArgs) Handles btnmatricula.Click
        Dim frmmatricula As New MatriculaUser
        Utilidades.AbrirEnPanel(frmmatricula, pnlMain)
    End Sub
    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        frmUsuario.ShowDialog()
    End Sub
    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click
        Curso.ShowDialog()
    End Sub
    Private Sub bntAsignaturas_Click(sender As Object, e As EventArgs) Handles bntAsignaturas.Click
        Dim frmAsignaturas As New AsignaturasUser
        frmAsignaturas.IdUsuario = usuarios.IdUsuario
        Utilidades.AbrirEnPanel(frmAsignaturas, pnlMain)
    End Sub
    Private Sub btnlogros_Click(sender As Object, e As EventArgs) Handles btnlogros.Click
        Dim frmLogros As New LogrosUser
        Utilidades.AbrirEnPanel(frmLogros, pnlMain)
    End Sub
    Private Sub btnCalificaciones_Click(sender As Object, e As EventArgs) Handles btnCalificaciones.Click
        Dim frmCalificaciones As New CalificacionesUser
        Utilidades.AbrirEnPanel(frmCalificaciones, pnlMain)
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        Dim frmReportes As New frmReportes
        frmReportes.ShowDialog()
    End Sub
End Class
