Imports Datos
Public Class FrmBusqueda
    Public Property Id As Integer
    Public Property Tabla As DataTable
    Private Class Columna
        Property Id As Integer
        Property Nombre As String
    End Class
    Private Function ListarColumnas(DgTabla As DataGridView) As List(Of Columna)
        Dim LstColumnas As New List(Of Columna), i As Integer
        i = 1
        For Each col As DataGridViewColumn In DgTabla.Columns
            Dim columna As New Columna
            If Not col.HeaderText.Contains("id") Or Not col.HeaderText.Contains("Id") Then
                columna.Id = i
                columna.Nombre = col.HeaderText
                LstColumnas.Add(columna)
                i = i + 1
            End If
        Next
        Return LstColumnas
    End Function
    Private Sub Txtfiltro_TextChanged(sender As Object, e As EventArgs) Handles txtfiltro.TextChanged
        Try
            If txtfiltro.Text <> "" And cbofiltro.SelectedIndex <> -1 Then
                dgVer.DataSource = Utilidades.Busqueda(cbofiltro.Text, txtfiltro.Text, Tabla)
            Else
                dgVer.DataSource = Tabla
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub cbofiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofiltro.SelectedIndexChanged
        txtfiltro.Focus()
    End Sub
    Private Sub dgVer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgVer.CellContentDoubleClick
        Id = dgVer.Rows(e.RowIndex).Cells(0).Value
        Me.Close()
    End Sub
    Private Sub frmbusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgVer.DataSource = Tabla
        For Each column As DataGridViewColumn In dgVer.Columns
            If column.Name.Contains("id") Or column.Name.Contains("Id") Then
                column.Visible = False
            End If
        Next
        Utilidades.Cmb(cbofiltro, ListarColumnas(dgVer), {"id", "nombre"})
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        If dgVer.Rows.Count <> 0 Then
            If dgVer.CurrentRow IsNot Nothing Then
                Id = dgVer.CurrentRow.Cells(0).Value
                Me.Close()
            End If
        End If
    End Sub


End Class
