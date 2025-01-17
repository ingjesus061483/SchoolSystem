Imports Datos
Public Class EstudiantesUser
    Dim hlp As New Helper
    Dim idEst As Integer
    Dim image As Byte()
    Private Sub Bloquear()
        btnCancelar.Enabled = False
        btnGuardar.Enabled = False
        btnEditar.Enabled = True
        btnNuevo.Enabled = True

        txtNumDoc.ReadOnly = True
        txtPriNombre.ReadOnly = True
        txtSegNombre.ReadOnly = True
        txtPriApellido.ReadOnly = True
        txtSegApellido.ReadOnly = True
        txtDireccion.ReadOnly = True
        txtTelefono.ReadOnly = True

    End Sub
    Private Sub Desbloquear()
        btnCancelar.Enabled = True
        btnGuardar.Enabled = True
        btnEditar.Enabled = False
        btnNuevo.Enabled = False

        txtNumDoc.ReadOnly = False
        txtPriNombre.ReadOnly = False
        txtSegNombre.ReadOnly = False
        txtPriApellido.ReadOnly = False
        txtSegApellido.ReadOnly = False
        txtDireccion.ReadOnly = False
        txtTelefono.ReadOnly = False

    End Sub
    Private Sub Limpiar()
        idEst = 0
        txtNumDoc.Clear()
        txtPriNombre.Clear()
        txtSegNombre.Clear()
        txtPriApellido.Clear()
        txtSegApellido.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
        cmbCurso.SelectedIndex = -1
        cboSexo.SelectedIndex = -1
        cboTipoDoc.SelectedIndex = -1
        Imagen.Image = Nothing
    End Sub
    Private Sub ActualizarDgv()
        dgvEstudiante.DataSource = hlp.ListarEstudiantes(DBNull.Value)
    End Sub
    Private Sub FrmEstudiante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarDgv()
        Utilidades.Cmb(cboSexo, hlp.ListarSexo(), {"idsexo", "nombre"})
        Utilidades.Cmb(cboTipoDoc, hlp.ListarTipoIdentificacion, {"id", "nombre"})
        Utilidades.Cmb(cmbCurso, hlp.ListarCursos, {"idcurso", "nombre"})
        bloquear()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Desbloquear()
        Limpiar()
    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If cboSexo.SelectedIndex = -1 Then
                MsgBox("Falta el campo sexo por llenar", MsgBoxStyle.Exclamation)
                Return
            End If
            If cboTipoDoc.SelectedIndex = -1 Then
                MsgBox("Falta el campo Tipo Doc por llenar", MsgBoxStyle.Exclamation)
                Return
            End If
            If cmbCurso.SelectedIndex = -1 Then
                MsgBox("Falta el campo curso por llenar", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtNumDoc.Text = "" Then
                MsgBox("Falta el campo documento por llenar", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtPriNombre.Text = "" Then
                MsgBox("Falta el campo primer nombre por llenar", MsgBoxStyle.Exclamation)
                Return
            End If

            If txtPriApellido.Text = "" Then
                MsgBox("Falta el campo primer apellido por llenar", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtSegApellido.Text = "" Then
                MsgBox("Falta el campo segundo apellido por llenar", MsgBoxStyle.Exclamation)
                Return
            End If
            If txtDireccion.Text = "" Then
                MsgBox("Falta el campo direccion por llenar", MsgBoxStyle.Exclamation)
                Return
            End If

            If idEst = 0 Then
                hlp.InsertarEstudiante(cboTipoDoc.SelectedValue, txtNumDoc.Text, txtPriNombre.Text, txtSegNombre.Text, txtPriApellido.Text, txtSegApellido.Text,
                                           CDate(txtFechaNacim.Text), txtDireccion.Text, txtTelefono.Text, cboSexo.SelectedValue, IIf(IsNothing(image), DBNull.Value, image), cmbCurso.SelectedValue)
                ActualizarDgv()
            Else
                hlp.ModificarEstudiante(CInt(idEst), cboTipoDoc.SelectedValue, txtNumDoc.Text, txtPriNombre.Text, txtSegNombre.Text, txtPriApellido.Text, txtSegApellido.Text,
                                           CDate(txtFechaNacim.Text), txtDireccion.Text, txtTelefono.Text, cboSexo.SelectedValue, IIf(IsNothing(image), DBNull.Value, image))
                ActualizarDgv()
            End If
            Limpiar()
            Bloquear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Bloquear()
        Limpiar()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If idEst = 0 Then
            MsgBox("Debes seleccionar un elemento de la grilla ", MsgBoxStyle.Exclamation)
        Else
            Desbloquear()
        End If
    End Sub

    Private Sub dgvEstudiante_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEstudiante.CellDoubleClick
        idEst = dgvEstudiante.CurrentRow.Cells("idestudiante").Value.ToString()
        Dim estudiante = hlp.BuscarEstudiante(idEst)
        cboTipoDoc.SelectedValue = estudiante.IdTipoDocumento
        txtNumDoc.Text = estudiante.NumDocumento
        txtPriNombre.Text = estudiante.PrimerNombre
        txtSegNombre.Text = estudiante.SegundoNombre
        txtPriApellido.Text = estudiante.PrimerApellido
        txtSegApellido.Text = estudiante.SegundoApellido
        txtFechaNacim.Value = estudiante.FechaNacimiento
        txtDireccion.Text = estudiante.Direccion
        txtTelefono.Text = estudiante.Telefono
        cboSexo.SelectedValue = estudiante.IdSexo
        cmbCurso.SelectedValue = dgvEstudiante.CurrentRow.Cells("idcurso").Value.ToString()
        image = estudiante.Foto
        Imagen.Image = Utilidades.CargarImagen(image)
    End Sub

    Private Sub txtNumDoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumDoc.KeyPress
        If Not Utilidades.SoloNumeros(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txttelefono_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Not Utilidades.SoloNumeros(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_direccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDireccion.LostFocus
        txtDireccion.Text = UCase(txtDireccion.Text)
    End Sub

    Private Sub txtSegApellidoLostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSegApellido.LostFocus
        txtSegApellido.Text = UCase(txtSegApellido.Text)
    End Sub

    Private Sub txtPriApellidoLostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPriApellido.LostFocus
        txtPriApellido.Text = UCase(txtPriApellido.Text)
    End Sub

    Private Sub txtPriNombreLostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPriNombre.LostFocus
        txtPriNombre.Text = UCase(txtPriNombre.Text)
    End Sub
    Private Sub txtsegNombreLostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSegNombre.LostFocus
        txtSegNombre.Text = UCase(txtSegNombre.Text)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        image = Utilidades.CargarImagen(Imagen)
    End Sub


End Class
