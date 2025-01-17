Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat

Public MustInherit Class Utilidades
    Public Shared Sub AbrirEnPanel(ByVal form As Control, ByVal panel As Panel)
        panel.Controls.Clear()
        panel.Controls.Add(form)
    End Sub
    Shared Sub Cmb(cmb As ComboBox, tabla As DataTable, arr As Array)
        With cmb
            .DataSource = tabla
            .ValueMember = arr(0)
            .DisplayMember = arr(1)
            .SelectedIndex = -1
        End With
    End Sub
    Shared Sub Cmb(cmb As ComboBox, tabla As Object, arr As Array)
        With cmb
            .DataSource = tabla
            .ValueMember = arr(0)
            .DisplayMember = arr(1)
            .SelectedIndex = -1
        End With
    End Sub

    Public Shared Function SoloNumeros(ByVal tecla As Char) As Boolean
        Dim EsSoloNumero As Boolean
        If Char.IsControl(tecla) Or Char.IsDigit(tecla) Then
            EsSoloNumero = False
        Else
            EsSoloNumero = True
        End If
        Return EsSoloNumero
    End Function
    Public Shared Sub TodoMayuscula(ByVal texto As String)
        texto.ToUpper()
    End Sub
    Public Shared Function Busqueda(filtro As String, valor As String, Tabla As DataTable) As DataTable
        Dim TablaDatos As DataTable
        If IsNumeric(valor) Then
            Dim query = (From tab In Tabla.AsEnumerable
                         Where tab.Field(Of Integer)(filtro) = Val(valor)
                         Select tab)
            If query.ToList().Count <> 0 Then
                TablaDatos = query.CopyToDataTable
            Else
                TablaDatos = Tabla
            End If
        Else
            Dim query = (From tab In Tabla.AsEnumerable
                         Where tab.Field(Of String)(filtro).Contains(valor)
                         Select tab)
            If query.ToList.Count <> 0 Then
                TablaDatos = query.CopyToDataTable
            Else
                TablaDatos = Tabla
            End If
        End If
        Return TablaDatos
    End Function
    Public Shared Function CargarImagen(picture As PictureBox) As Byte()
        Try
            Dim bytes As Byte()
            Dim OpenFile As New OpenFileDialog With
            {
                .Filter = "Imagenes (JPG)|*.jpg" 'filtro de archivos del OpenFileDialog 
            }
            If OpenFile.ShowDialog() = DialogResult.OK Then ' en caso de que se aplaste el boton cancelar salga y no haga nada
                picture.SizeMode = PictureBoxSizeMode.StretchImage 'establecemos como se visualiza la imagen
                picture.Load(OpenFile.FileName) 'visualizamos abriendo el archivo seleccionado
                Dim FileStream As New FileStream(OpenFile.FileName, FileMode.Open, FileAccess.Read) 'instanciamos en Stream indicandole la ruta del arvhivo,el modo de acceso y si es de lectura o escritura
                ReDim bytes(FileStream.Length) 'llenamos el arreglo
                FileStream.Read(bytes, 0, CInt(FileStream.Length)) 'llenamos el arreglo
                Return bytes
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Shared Function CargarImagen(file As String) As Byte()
        Try
            Dim bytes As Byte(), FileStream As FileStream
            FileStream = New FileStream(file, FileMode.Open, FileAccess.Read) 'instanciamos en Stream indicandole la ruta del arvhivo,el modo de acceso y si es de lectura o escritura
            ReDim bytes(FileStream.Length) 'llenamos el arreglo
            FileStream.Read(bytes, 0, CInt(FileStream.Length)) 'llenamos el arreglo
            Return bytes
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Public Shared Function CargarImagen(imagenbuffer As Byte()) As Image
        Try
            If imagenbuffer IsNot Nothing Then
                Dim MemoryStream As New MemoryStream(imagenbuffer)
                Return Image.FromStream(MemoryStream)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Shared Sub ExportarDatos(table As DataTable)
        Dim ExcelApp As New Excel.Application, WorkSheet As Excel.Worksheet
        Try
            Dim column As DataColumn
            ExcelApp.Workbooks.Add()
            Dim i As Integer = 1, iRowCnt As Integer = 4,
                hoja As String = "Hoja" & i
            WorkSheet = ExcelApp.Sheets(hoja)
            With WorkSheet
                .Cells(1, 1).value = table.TableName
                .Cells(1, 1).FONT.NAME = "Calibri"
                .Cells(1, 1).Font.Bold = True
                .Cells(1, 1).Font.Size = 20
                .Range("A1:H1").MergeCells = True   ' MERGE CELLS OF THE HEADER.
                Dim col = 1
                For Each column In table.Columns
                    .Cells(iRowCnt - 1, col).value = column.ColumnName
                    col = col + 1
                Next
                For Each row As DataRow In table.Rows
                    col = 1
                    For Each column In table.Columns
                        .Cells(iRowCnt, col) = row(column)
                        col = col + 1
                    Next
                    iRowCnt = iRowCnt + 1
                Next
            End With
            ExcelApp.ActiveCell.Worksheet.Cells(4, 1).AutoFormat(ExcelAutoFormat.xlRangeAutoFormatList3)
            ExcelApp.Sheets.Add()
            hoja = "Hoja" & i
            WorkSheet = ExcelApp.Sheets(hoja)
            WorkSheet.Delete()
            ExcelApp.Visible = True
        Catch ex As Exception
            Throw ex
        Finally
            ExcelApp = Nothing : WorkSheet = Nothing
        End Try
    End Sub

End Class
