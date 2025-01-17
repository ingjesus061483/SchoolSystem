Imports Datos
Public Class frmLogin
    Dim hlp As New Helper, usuario As DatosSQL.Usuarios
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Try
            If txtPassword.Text = "" Then
                MsgBox("El campo password esta vacio", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtUsername.Text = "" Then
                MsgBox("El campo usuario esta vacio", MsgBoxStyle.Exclamation)
                Return
            End If
            usuario = hlp.LoguearUsuario(txtUsername.Text, txtPassword.Text)
            frmPrincipal.usuarios = usuario
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtUsername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.LostFocus
        txtUsername.Text = UCase(txtUsername.Text)
    End Sub
    Private Sub txtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.LostFocus
        txtPassword.Text = UCase(txtPassword.Text)
    End Sub
    Private Sub txtPassword_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnEntrar.PerformClick()
        End If
    End Sub
End Class