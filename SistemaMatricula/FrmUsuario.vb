Imports Datos
Public Class frmUsuario
    Dim hlp As New Helper, codUsua As Integer, image As Byte()
    Sub Limpiar()
        codUsua = 0
        txtNombre.Clear()
        txtApellido.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        txtUsuario.Clear()
        txtPassword.Clear()
        imagen.Image = Nothing
    End Sub
    Sub Bloquear()
        btnGuardar.Enabled = False
        btnEditar.Enabled = True
        txtNombre.Enabled = False
        btnNuevo.Enabled = True
        btnCancelar.Enabled = False

        txtNombre.ReadOnly = True
        txtApellido.ReadOnly = True
        txtDireccion.ReadOnly = True
        txtTelefono.ReadOnly = True
        txtUsuario.ReadOnly = True
        txtPassword.ReadOnly = True
    End Sub
    Sub Desbloquear()
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnCancelar.Enabled = True
        btnNuevo.Enabled = False

        txtNombre.ReadOnly = False
        txtApellido.ReadOnly = False
        txtDireccion.ReadOnly = False
        txtTelefono.ReadOnly = False
        txtUsuario.ReadOnly = False
        txtPassword.ReadOnly = False
    End Sub
    Private Sub frmUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgvUsuario.DataSource = hlp.ListarUsuarios()
        Bloquear()
    End Sub
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If txtDireccion.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtApellido.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtNombre.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtUsuario.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtPassword.Text = "" Then
                MsgBox("FALTAN CAMPOS POR LLENAR", MsgBoxStyle.Exclamation)
                Return
            End If
            If codUsua = 0 Then
                hlp.InsertarUsuario(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text,
                                    txtUsuario.Text, txtPassword.Text, IIf(IsNothing(image), DBNull.Value, image))
            Else
                hlp.ModificarUsuario(CInt(codUsua), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text,
                                    txtUsuario.Text, txtPassword.Text, IIf(IsNothing(image), DBNull.Value, image))
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            dgvUsuario.DataSource = hlp.ListarUsuarios()
            Limpiar()
            Bloquear()
        End Try
    End Sub
    Private Sub btneditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If (codUsua = 0) Then
            MsgBox("SELECCIONA UN REGISTRO", MsgBoxStyle.Exclamation)
        Else
            Desbloquear()
        End If
    End Sub
    Private Sub dgvUsuaruio_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsuario.CellDoubleClick
        codUsua = dgvUsuario.CurrentRow.Cells("idusuario").Value.ToString()
        Dim usuario = hlp.BuscarUsuario(codUsua)
        txtNombre.Text = usuario.Nombre
        txtApellido.Text = usuario.Apellido
        txtDireccion.Text = usuario.Direccion
        txtTelefono.Text = usuario.Telefono
        txtUsuario.Text = usuario.Usuario
        txtPassword.Text = usuario.Password
        image = usuario.Foto
        imagen.Image = Utilidades.CargarImagen(image)
    End Sub
    Private Sub txtUsername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.LostFocus
        txtDireccion.Text = UCase(txtDireccion.Text)
    End Sub
    Private Sub txtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTelefono.LostFocus
        txtTelefono.Text = UCase(txtTelefono.Text)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Limpiar()
        Bloquear()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Desbloquear()
        Limpiar()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        image = Utilidades.CargarImagen(imagen)
    End Sub
End Class