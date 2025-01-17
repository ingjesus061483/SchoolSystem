Imports System.Data.SqlClient
Imports System.Configuration.ConfigurationManager
''' <summary>
''' contiene los metodos que realizan la conexion y ejecucion a un base de datos SQL SERVER
''' </summary>
Public Class DatosSQL
    Private Conexion As SqlConnection, cmd As SqlCommand, da As SqlDataAdapter, lector As IDataReader
    Class Logros
        Property IdLogro As Integer
        Property Codigo As String
        Property Nombre As String
        Property Descripcion As String
        Property IdAsignatura As Integer
    End Class
    Class Asignaturas
        Property IdAsignatura As Integer
        Property Codigo As String
        Property Nombre As String
        Property Descripcion As String
        Property CantidadHoraria As Integer
        Property IdCurso As Integer
        Property IdUsuario As Integer
    End Class
    Class Estudiantes
        Property IdEstudiante As Integer
        Property IdTipoDocumento As Integer
        Property TipoDocumento As String
        Property NumDocumento As String
        Property PrimerNombre As String
        Property SegundoNombre As String
        Property PrimerApellido As String
        Property SegundoApellido As String
        Property FechaNacimiento As Date
        Property Direccion As String
        Property Telefono As String
        Property IdSexo As Integer
        Property Sexo As String
        Property Foto As Byte()
    End Class
    Class Usuarios
        Property IdUsuario As Integer
        Property Nombre As String
        Property Apellido As String
        Property Direccion As String
        Property Telefono As String
        Property Usuario As String
        Property Password As String
        Property Foto As Byte()
    End Class
    ''' <summary>
    ''' Inicializa una nueva instancia de la clase DatosSQL
    ''' </summary>
    Sub New()
        Conexion = New SqlConnection With {.ConnectionString = ConnectionStrings("Colegio").ConnectionString}
    End Sub
    ''' <summary>
    ''' Prepara una consulta para su ejecucion
    ''' </summary>
    ''' <param name="CommandText">
    ''' cadena de texto que representa la la consulta
    ''' </param>
    ''' <param name="CommandType">
    ''' tipo de comando que tiene la consulta
    ''' </param>
    ''' <returns></returns>

    Private Function Comando(CommandText As String, CommandType As CommandType) As SqlCommand
        Dim comand As New SqlCommand With {
        .Connection = Conexion,
        .CommandType = CommandType,
        .CommandText = CommandText
        }
        Return comand
    End Function
    ''' <summary>
    ''' Abre una conexion sql Server
    ''' </summary>
    Private Sub Conectar()
        Conexion.Open()
    End Sub
    ''' <summary>
    ''' Cierra la conexion sql
    ''' </summary>
    Private Sub Desconectar()
        Conexion.Close()
    End Sub
#Region "cursos"
    ''' <summary>
    ''' Lista de los cursos que tiene  una Institucion Educativa 
    ''' </summary>
    ''' <returns></returns>
    Public Function ListarCursos() As DataTable
        Try
            Dim dt As New DataTable
            Conectar()
            cmd = Comando("ListarCurso", CommandType.StoredProcedure)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try

    End Function

    'procedimiento para insertar cursos
    Public Sub InsertarCurso(nombre As String, CapacidadMaxima As Integer, Descripcion As String)
        Try
            Conectar()
            cmd = Comando("InsertarCurso", CommandType.StoredProcedure)
            cmd.Parameters.Add("nombre", SqlDbType.VarChar).Value = nombre
            cmd.Parameters.Add("CapacidadMaxima", SqlDbType.Int).Value = CapacidadMaxima
            cmd.Parameters.Add("descripcion", SqlDbType.VarChar).Value = Descripcion
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub

    'procedimiento para modificar cursos
    Public Sub ModificarCursos(idcurso As Integer, nombre As String, CapacidadMaxima As Integer, Descripcion As String)
        Try
            Conectar()
            cmd = Comando("ModificarCurso", CommandType.StoredProcedure)
            cmd.Parameters.Add("idcurso", SqlDbType.Int).Value = idcurso
            cmd.Parameters.Add("nombre", SqlDbType.VarChar).Value = nombre
            cmd.Parameters.Add("CapacidadMaxima", SqlDbType.Int).Value = CapacidadMaxima
            cmd.Parameters.Add("descripcion", SqlDbType.VarChar).Value = Descripcion
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub
#End Region
#Region "Estudiantes"
    Public Function ListarEstudiantes(idCurso As Object) As DataTable
        Try
            Dim dt As New DataTable
            Conectar()
            cmd = Comando("ListarEstudiantes", CommandType.StoredProcedure)
            cmd.Parameters.Add("idCurso", SqlDbType.Int).Value = idCurso
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try

    End Function

    'procedimiento para insertar estudiantes
    Public Sub InsertarEstudiante(idtipodoc As Integer, ByVal numDoc As String, ByVal PriNom As String, SegNom As String, ByVal PriApe As String,
                                  ByVal SegApe As String, ByVal fecha As Date, ByVal dir As String, ByVal tel As String, sexo As Integer, foto As Object,
                                  idCurso As Integer)
        Try
            Conectar()
            cmd = Comando("InsertarEstudiantes", CommandType.StoredProcedure)
            cmd.Parameters.Add("idTipoDoc", SqlDbType.SmallInt).Value = idtipodoc
            cmd.Parameters.Add("NumDoc", SqlDbType.VarChar).Value = numDoc
            cmd.Parameters.Add("PriNom", SqlDbType.VarChar).Value = PriNom
            cmd.Parameters.Add("SegNom", SqlDbType.VarChar).Value = SegNom
            cmd.Parameters.Add("PriApe", SqlDbType.VarChar).Value = PriApe
            cmd.Parameters.Add("SegApe", SqlDbType.VarChar).Value = SegApe
            cmd.Parameters.Add("fechaN", SqlDbType.Date).Value = fecha
            cmd.Parameters.Add("Dir", SqlDbType.VarChar).Value = dir
            cmd.Parameters.Add("Tel", SqlDbType.VarChar).Value = tel
            cmd.Parameters.Add("sexo", SqlDbType.Int).Value = sexo
            cmd.Parameters.Add("foto", SqlDbType.VarBinary).Value = foto
            cmd.Parameters.Add(" idCurso", SqlDbType.Int).Value = idCurso
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub
    'procedimiento para modificar estudiantes
    Public Sub ModificarEstudiante(ByVal idEst As Integer, idtipodoc As Integer, ByVal numDoc As String, ByVal PriNom As String, SegNom As String, ByVal PriApe As String,
                                   ByVal SegApe As String, ByVal fecha As Date, ByVal dir As String, ByVal tel As String, sexo As Integer, foto As Object)
        Try
            Conectar()
            cmd = Comando("ModificarEstudiantes", CommandType.StoredProcedure)
            cmd.Parameters.Add("idest", SqlDbType.Int).Value = idEst
            cmd.Parameters.Add("idtipodoc", SqlDbType.Int).Value = idtipodoc
            cmd.Parameters.Add("numDoc", SqlDbType.Int).Value = numDoc
            cmd.Parameters.Add("PriNom", SqlDbType.VarChar).Value = PriNom
            cmd.Parameters.Add("SegNom", SqlDbType.VarChar).Value = SegNom
            cmd.Parameters.Add("PriApe", SqlDbType.VarChar).Value = PriApe
            cmd.Parameters.Add("SegApe", SqlDbType.VarChar).Value = SegApe
            cmd.Parameters.Add("fechaN", SqlDbType.Date).Value = fecha
            cmd.Parameters.Add("dir", SqlDbType.VarChar).Value = dir
            cmd.Parameters.Add("tel", SqlDbType.VarChar).Value = tel
            cmd.Parameters.Add("sexo", SqlDbType.Int).Value = sexo
            cmd.Parameters.Add("Foto", SqlDbType.Binary).Value = foto
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub
    'funcion para buscar el nombre del estudiante
    Public Function BuscarEstudiante(ByVal id As Integer) As Estudiantes
        Try
            Dim lector As IDataReader, estudiantes As Estudiantes
            Conectar()
            cmd = Comando("BuscarEstudiantesPorId", CommandType.StoredProcedure)
            cmd.Parameters.Add("id", SqlDbType.Int).Value = id
            lector = cmd.ExecuteReader()
            lector.Read()
            estudiantes = New Estudiantes With {
            .idEstudiante = lector("idEstudiante"),
            .idTipoDocumento = lector("idTipoDocumento"),
            .TipoDocumento = lector("tipoDocumento"),
            .NumDocumento = lector("numdocumento"),
            .PrimerNombre = lector("PrimerNombre"),
            .SegundoNombre = lector("SegundoNombre"),
            .PrimerApellido = lector("PrimerApellido"),
            .SegundoApellido = lector("SegundoApellido"),
            .FechaNacimiento = lector("FechaNacimiento"),
            .direccion = lector("direccion"),
            .telefono = lector("telefono"),
            .idSexo = lector("idSexo"),
            .Sexo = lector("sexo"),
            .Foto = IIf(IsDBNull(lector("Foto")), Nothing, lector("Foto"))
            }
            lector.Close()
            Return estudiantes
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function

    Public Function BuscarEstudiante(ByVal numdocumento As String) As Estudiantes
        Try
            Dim estudiantes As Estudiantes
            Conectar()
            cmd = Comando("BuscarEstudiantesPorNumDoc", CommandType.StoredProcedure)
            cmd.Parameters.Add("NumDoc", SqlDbType.VarChar).Value = numdocumento
            lector = cmd.ExecuteReader()
            lector.Read()
            estudiantes = New Estudiantes With {
            .idEstudiante = lector("idEstudiante"),
            .idTipoDocumento = lector("idTipoDocumento"),
            .TipoDocumento = lector("tipoDocumento"),
            .NumDocumento = lector("numdocumento"),
            .PrimerNombre = lector("PrimerNombre"),
            .SegundoNombre = lector("SegundoNombre"),
            .PrimerApellido = lector("PrimerApellido"),
            .SegundoApellido = lector("SegundoApellido"),
            .FechaNacimiento = lector("FechaNacimiento"),
            .direccion = lector("direccion"),
            .telefono = lector("telefono"),
            .idSexo = lector("idSexo"),
            .Sexo = lector("sexo"),
            .Foto = IIf(IsDBNull(lector("Foto")), Nothing, lector("Foto"))
            }
            lector.Close()
            Return estudiantes
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function
#End Region
#Region "Jornadas, sexo, tipoId"

    'funcion para listar las jornadas
    Public Function ListarJornada() As DataTable
        Try
            Dim dt As New DataTable
            Conectar()
            cmd = Comando("Select idJornada,nombre FROM jornadas", CommandType.Text)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function
    Public Function ListarSexo() As DataTable
        Try
            Dim dt As New DataTable
            Conectar()
            cmd = Comando("Select IdSexo,nombre FROM sexo", CommandType.Text)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function
    Public Function ListarTipoIdentificacion() As DataTable
        Try
            Dim dt As New DataTable
            Conectar()
            cmd = Comando("Select id,nombre FROM tipoidentificacion", CommandType.Text)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function
#End Region
#Region "Matriculas"

    'funcion para listar las matriculas
    Public Function ListarMatriculas() As DataTable
        Try
            Dim dt As New DataTable
            Conectar()
            cmd = Comando("listarMatriculas", CommandType.StoredProcedure)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function

    'procedimiento para insertar matriculas
    Public Sub InsertarMatricula(idEstudiante As Integer, idjornada As Integer, idCurso As Integer, FechaInicioMatricula As Date, FechaFinMatricula As Date, ValorDeMatricula As Double,
                                 ValorMensualidad As Double)
        Try
            Conectar()
            cmd = Comando("InsertarMatriculas", CommandType.StoredProcedure)
            cmd.Parameters.Add("idEst", SqlDbType.Int).Value = idEstudiante
            cmd.Parameters.Add("idCurso", SqlDbType.Int).Value = idCurso
            cmd.Parameters.Add("idJor", SqlDbType.Int).Value = idjornada
            cmd.Parameters.Add("FechaInicioMatricula", SqlDbType.Date).Value = FechaInicioMatricula
            cmd.Parameters.Add("FechaFinMatricula", SqlDbType.Date).Value = FechaFinMatricula
            cmd.Parameters.Add("ValorDeMatricula", SqlDbType.Decimal).Value = ValorDeMatricula
            cmd.Parameters.Add("ValorMensualidad", SqlDbType.Decimal).Value = ValorMensualidad
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub
#End Region
#Region "Usuario"

    'funcion que verifica si un usuario existe
    Public Function LoguearUsuario(ByVal usua As String, ByVal pass As String) As Usuarios
        Try

            Conectar()

            cmd = Comando("LoguearUsuario", CommandType.StoredProcedure)
            cmd.Parameters.Add("usua", SqlDbType.VarChar).Value = usua
            cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = pass
            lector = cmd.ExecuteReader()
            lector.Read()
            Dim Usuarios As New Usuarios With {
                   .IdUsuario = lector("idUsuario"),
                   .Nombre = lector("nombre"),
                   .Apellido = lector("Apellido"),
                   .Direccion = lector("direccion"),
                   .Telefono = lector("telefono"),
                   .Usuario = lector("usuario"),
                   .Password = lector("password")
                   }
            lector.Close()
            Return Usuarios
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function
    Public Function BuscarUsuario(ByVal id As Integer) As Usuarios
        Try
            Conectar()
            cmd = Comando("BuscarUsuarios", CommandType.StoredProcedure)
            cmd.Parameters.Add("idUsuario", SqlDbType.VarChar).Value = id
            lector = cmd.ExecuteReader
            lector.Read()
            Dim Usuarios As New Usuarios With {
            .IdUsuario = lector("idUsuario"),
            .Nombre = lector("nombre"),
            .Apellido = lector("Apellido"),
            .Direccion = lector("direccion"),
            .Telefono = lector("telefono"),
            .Usuario = lector("usuario"),
            .Password = lector("password"),
            .Foto = IIf(IsDBNull(lector("foto")), Nothing, lector("foto"))
            }
            lector.Close()
            Return Usuarios
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function

    'funcion para listar los usuarios
    Public Function ListarUsuarios() As DataTable
        Try
            Dim dt As New DataTable
            Conectar()
            cmd = Comando("listarUsuarios", CommandType.StoredProcedure)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try

    End Function

    'procedimiento para insertar usuarios
    Public Sub InsertarUsuario(nom As String, ape As String, Dir As String, tel As String, usua As String, pass As String, foto As Object)
        Try
            Conectar()
            cmd = Comando("InsertarUsuarios", CommandType.StoredProcedure)
            cmd.Parameters.Add("nom", SqlDbType.VarChar).Value = nom
            cmd.Parameters.Add("ape", SqlDbType.VarChar).Value = ape
            cmd.Parameters.Add("dir", SqlDbType.VarChar).Value = Dir
            cmd.Parameters.Add("tel", SqlDbType.VarChar).Value = tel
            cmd.Parameters.Add("usua", SqlDbType.VarChar).Value = usua
            cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = pass
            cmd.Parameters.Add("foto", SqlDbType.VarBinary).Value = foto
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub

    'procedimiento para modificar usuarios
    Public Sub ModificarUsuario(ByVal idUsua As Integer, nom As String, ape As String, Dir As String, tel As String,
                                    usua As String, pass As String, foto As Object)
        Try
            Conectar()
            cmd = Comando("ModificarUsuarios", CommandType.StoredProcedure)
            cmd.Parameters.Add("idUsua", SqlDbType.Int).Value = idUsua
            cmd.Parameters.Add("nom", SqlDbType.VarChar).Value = nom
            cmd.Parameters.Add("ape", SqlDbType.VarChar).Value = ape
            cmd.Parameters.Add("dir", SqlDbType.VarChar).Value = Dir
            cmd.Parameters.Add("tel", SqlDbType.VarChar).Value = tel
            cmd.Parameters.Add("usua", SqlDbType.VarChar).Value = usua
            cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = pass
            cmd.Parameters.Add("foto", SqlDbType.VarBinary).Value = foto
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub
#End Region
#Region "Asignatura"
    Public Function ListarAsignaturas(idusuario As Integer) As DataTable
        Try
            Dim dt As New DataTable
            Conectar()
            cmd = Comando("ListarAsignaturas", CommandType.StoredProcedure)
            cmd.Parameters.Add("idusuario", SqlDbType.VarChar).Value = idusuario
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function
    Sub ModificarAsignatura(id As Integer, Codigo As String, Nombre As String, descripcion As String, CantidadHoraria As Integer, idcurso As Integer)
        Try
            Conectar()
            cmd.Parameters.Add("id", SqlDbType.Int).Value = id
            cmd = Comando("ModificarAsignatura", CommandType.StoredProcedure)
            cmd.Parameters.Add("Codigo", SqlDbType.VarChar).Value = Codigo
            cmd.Parameters.Add("Nombre", SqlDbType.VarChar).Value = Nombre
            cmd.Parameters.Add("descripcion", SqlDbType.VarChar).Value = descripcion
            cmd.Parameters.Add("CantidadHoraria", SqlDbType.Int).Value = CantidadHoraria
            cmd.Parameters.Add("idcurso", SqlDbType.Int).Value = idcurso
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub
    Sub InsertarAsignatura(Codigo As String, Nombre As String, descripcion As String, CantidadHoraria As Integer, idUsuario As Integer, idcurso As Integer)
        Try
            Conectar()
            cmd = Comando("InsertarAsignatura", CommandType.StoredProcedure)
            cmd.Parameters.Add("Codigo", SqlDbType.VarChar).Value = Codigo
            cmd.Parameters.Add("Nombre", SqlDbType.VarChar).Value = Nombre
            cmd.Parameters.Add("descripcion", SqlDbType.VarChar).Value = descripcion
            cmd.Parameters.Add("CantidadHoraria", SqlDbType.Int).Value = CantidadHoraria
            cmd.Parameters.Add("idUsuario", SqlDbType.Int).Value = idUsuario
            cmd.Parameters.Add("idcurso", SqlDbType.Int).Value = idcurso
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try

    End Sub
    Function BuscarAsignaturasPorId(idAsignatura As Integer) As Asignaturas
        Try
            Dim Asignaturas As Asignaturas
            Conectar()
            cmd = Comando("BuscarAsignaturasPorId", CommandType.StoredProcedure)
            cmd.Parameters.Add("idAsignatura", SqlDbType.Int).Value = idAsignatura
            lector = cmd.ExecuteReader()
            lector.Read()
            Asignaturas = New Asignaturas With {
            .IdAsignatura = lector("IdAsignatura"),
            .Codigo = lector("codigo"),
            .Nombre = lector("nombre"),
            .Descripcion = IIf(IsDBNull(lector("descripcion")), "", lector("descripcion")),
            .CantidadHoraria = lector("CantidadHoraria"),
            .idCurso = lector("idCurso"),
            .idUsuario = lector("idUsuario")
            }
            lector.Close()
            Return Asignaturas
        Catch ex As sqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function
#End Region
#Region "Logros"
    Public Function BuscarLogros(idlogros) As Logros
        Try
            Dim logros As Logros
            Conectar()
            cmd = Comando("BuscarLogros", CommandType.StoredProcedure)
            cmd.Parameters.Add("idlogro", SqlDbType.Int).Value = idlogros
            lector = cmd.ExecuteReader()
            lector.Read()
            logros = New Logros With {
                .IdLogro = lector("idlogro"),
            .IdAsignatura = lector("IdAsignatura"),
            .Codigo = lector("codigo"),
            .nombre = lector("nombre"),
            .Descripcion = IIf(IsDBNull(lector("descripcion")), "", lector("descripcion"))
            }
            lector.Close()
            Return logros
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function
    Public Function ListarLogros() As DataTable
        Try
            Dim dt As New DataTable
            Conectar()
            cmd = Comando("ListarLogros", CommandType.StoredProcedure)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As sqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function
    Public Sub InsertarLogros(Codigo As String, nombre As String, Descripcion As String, IdAsignatura As Integer)
        Try
            Conectar()
            cmd = Comando("InsertarLogros", CommandType.StoredProcedure)
            cmd.Parameters.Add("Codigo", SqlDbType.VarChar).Value = Codigo
            cmd.Parameters.Add("Nombre", SqlDbType.VarChar).Value = nombre
            cmd.Parameters.Add("Descripcion", SqlDbType.VarChar).Value = Descripcion
            cmd.Parameters.Add("IdAsignatura", SqlDbType.VarChar).Value = IdAsignatura
            cmd.ExecuteNonQuery()
        Catch ex As sqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub

    Public Sub ModificarLogros(idlogros As Integer, Codigo As String, nombre As String, Descripcion As String)
        Try
            Conectar()
            cmd = Comando("ModificarLogros", CommandType.StoredProcedure)
            cmd.Parameters.Add("idlogro", SqlDbType.Int).Value = idlogros
            cmd.Parameters.Add("Codigo", SqlDbType.VarChar).Value = Codigo
            cmd.Parameters.Add("Nombre", SqlDbType.VarChar).Value = nombre
            cmd.Parameters.Add("Descripcion", SqlDbType.VarChar).Value = Descripcion
            cmd.ExecuteNonQuery()
        Catch ex As sqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub
#End Region
#Region " Calificaciones"
    Sub InsertarCalificaciones(idLogro As Integer, idEstudiante As Integer, fecha As DateTime, Concepto As String, nota As Decimal, Observaciones As String)
        Try
            Conectar()
            cmd = Comando("InsertarCalificaciones", CommandType.StoredProcedure)
            cmd.Parameters.Add("idlogro", SqlDbType.Int).Value = idLogro
            cmd.Parameters.Add("idEstudiante", SqlDbType.Int).Value = idEstudiante
            cmd.Parameters.Add("fecha", SqlDbType.DateTime).Value = fecha
            cmd.Parameters.Add("concepto", SqlDbType.VarChar).Value = Concepto
            cmd.Parameters.Add("nota", SqlDbType.Decimal).Value = nota
            cmd.Parameters.Add("observaciones", SqlDbType.VarChar).Value = Observaciones
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub
    Function ListarCalificacionesPorEstudiante(idEstudiante As Integer) As DataTable
        Try
            Dim dt As New DataTable
            Conectar()
            cmd = Comando("listarCalificacionesPorEstudiante", CommandType.StoredProcedure)
            cmd.Parameters.Add("idEstudiante", SqlDbType.Int).Value = idEstudiante
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try

    End Function

#End Region
    Function ListarCalificacionesPorEstudiantes(idCurso As Integer, idEstudiante As Integer, fechaInicio As DateTime, fechaFin As DateTime)
        Try
            Dim dt As New DataTable
            Conectar()
            cmd = Comando("ListarCalificacionesPorEstudiantes", CommandType.StoredProcedure)
            cmd.Parameters.Add("idCurso", SqlDbType.Int).Value = idCurso
            cmd.Parameters.Add("idEstudiante", SqlDbType.Int).Value = idEstudiante
            cmd.Parameters.Add("fechaInicio", SqlDbType.DateTime).Value = fechaInicio
            cmd.Parameters.Add("fechaFin", SqlDbType.DateTime).Value = fechaFin
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            Return dt
        Catch ex As SqlException
            Throw ex
        Finally
            Desconectar()
        End Try
    End Function

End Class
