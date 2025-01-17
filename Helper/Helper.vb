Public Class Helper
    Dim ODatos As New DatosSQL
    Function ListarCalificacionesPorEstudiantes(idCurso As Integer, idEstudiante As Integer, fechaInicio As DateTime, fechaFin As DateTime)
        Try
            Return ODatos.ListarCalificacionesPorEstudiantes(idCurso, idEstudiante, fechaInicio, fechaFin)
        Catch ex As Exception

        End Try
    End Function

    Public Function ListarLogros() As DataTable
        Try
            Return ODatos.ListarLogros
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub InsertarLogros(Codigo As String, nombre As String, Descripcion As String, IdAsignatura As Integer)
        Try
            ODatos.InsertarLogros(Codigo, nombre, Descripcion, IdAsignatura)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub ModificarLogros(idlogros As Integer, Codigo As String, nombre As String, Descripcion As String)
        Try
            ODatos.ModificarLogros(idlogros, Codigo, nombre, Descripcion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub InsertarCalificaciones(idLogro As Integer, idEstudiante As Integer, fecha As DateTime, Concepto As String, nota As Decimal, Observaciones As String)
        Try
            ODatos.InsertarCalificaciones(idLogro, idEstudiante, fecha, Concepto, nota, Observaciones)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function BuscarLogros(idlogros) As DatosSQL.Logros
        Try
            Return ODatos.BuscarLogros(idlogros)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function ListarCalificacionesPorEstudiante(idEstudiante As Integer) As DataTable
        Try
            Return ODatos.ListarCalificacionesPorEstudiante(idEstudiante)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarAsignaturasPorId(idAsignatura As Integer) As DatosSQL.Asignaturas
        Try
            Return ODatos.BuscarAsignaturasPorId(idAsignatura)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'funcion para listar los cursos
    Public Function ListarSexo() As DataTable
        Try
            Return ODatos.ListarSexo()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ListarTipoIdentificacion() As DataTable
        Try
            Return ODatos.ListarTipoIdentificacion
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function ListarCursos() As DataTable
        Try
            Return ODatos.ListarCursos
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarUsuario(ByVal usuario As String) As DatosSQL.Usuarios
        Try
            Return ODatos.BuscarUsuario(usuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'procedimiento para insertar cursos
    Public Sub InsertarCurso(ByVal nom As String, max As Integer, descripcion As String)
        Try
            ODatos.InsertarCurso(nom, max, descripcion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub InsertarAsignatura(Codigo As String, Nombre As String, descripcion As String, cantidadhoras As Integer, idUsuario As Integer, idcurso As Integer)
        Try
            ODatos.InsertarAsignatura(Codigo, Nombre, descripcion, cantidadhoras, idUsuario, idcurso)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'procedimiento para modificar cursos
    Public Sub ModificarCursos(ByVal idCur As Integer, ByVal nom As String, max As Integer, descripcion As String)
        Try
            ODatos.ModificarCursos(idCur, nom, max, descripcion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function ListarEstudiantes(idCurso As Object) As DataTable
        Try
            Return ODatos.ListarEstudiantes(idCurso)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'procedimiento para insertar estudiantes
    Public Sub InsertarEstudiante(idtipodoc As Integer, ByVal numDoc As String, ByVal PriNom As String, SegNom As String, ByVal PriApe As String,
                                  ByVal SegApe As String, ByVal fecha As Date, ByVal dir As String, ByVal tel As String, sexo As Integer, foto As Object, idcurso As Integer)
        Try
            ODatos.InsertarEstudiante(idtipodoc, numDoc, PriNom, SegNom, PriApe, SegApe, fecha, dir, tel, sexo, foto, idcurso)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'procedimiento para modificar estudiantes
    Public Sub ModificarEstudiante(ByVal idEst As Integer, idtipodoc As Integer, ByVal numDoc As String, ByVal PriNom As String, SegNom As String, ByVal PriApe As String,
                                  ByVal SegApe As String, ByVal fecha As Date, ByVal dir As String, ByVal tel As String, sexo As Integer, foto As Object)

        Try
            ODatos.ModificarEstudiante(idEst, idtipodoc, numDoc, PriNom, SegNom, PriApe, SegApe,
                fecha, dir, tel, sexo, foto)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'funcion para buscar el nombre del estudiante
    Public Function BuscarEstudiante(ByVal id As Integer) As DatosSQL.Estudiantes
        Try
            Return ODatos.BuscarEstudiante(id)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function BuscarEstudiante(ByVal numDoc As String) As DatosSQL.Estudiantes
        Try
            Return ODatos.BuscarEstudiante(numDoc)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'funcion para listar las jornadas
    Public Function ListarJornada() As DataTable
        Try
            Return ODatos.ListarJornada()
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'funcion para listar las matriculas
    Public Function ListarMatriculas() As DataTable
        Try
            Return ODatos.ListarMatriculas
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'procedimiento para insertar matriculas
    Public Sub InsertarMatricula(idEstudiante As Integer, idjornada As Integer, idCurso As Integer, FechaInicioMatricula As Date, FechaFinMatricula As Date, ValorDeMatricula As Double,
                                 ValorMensualidad As Double)
        Try
            ODatos.InsertarMatricula(idEstudiante, idjornada, idCurso, FechaInicioMatricula, FechaFinMatricula, ValorDeMatricula, ValorMensualidad)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'funcion para listar los usuarios
    Public Function ListarUsuarios() As DataTable
        Try
            Return ODatos.ListarUsuarios()
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    'procedimiento para insertar usuarios
    Public Sub InsertarUsuario(nom As String, ape As String, Dir As String, tel As String, usua As String, pass As String, foto As Object)
        Try
            ODatos.InsertarUsuario(nom, ape, Dir, tel, usua, pass, foto)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub ModificarAsignatura(id As Integer, Codigo As String, Nombre As String, descripcion As String, CantidadHoraria As Integer, idCurso As Integer)
        Try
            ODatos.ModificarAsignatura(id, Codigo, Nombre, descripcion, CantidadHoraria, idCurso)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'procedimiento para modificar usuarios
    Public Sub ModificarUsuario(ByVal idUsua As Integer, nom As String, ape As String, Dir As String, tel As String,
                                    usua As String, pass As String, foto As Object)
        Try
            ODatos.ModificarUsuario(idUsua, nom, ape, Dir, tel, usua, pass, foto)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function ListarAsignaturas(idusuario As Integer) As DataTable
        Try
            Return ODatos.ListarAsignaturas(idusuario)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'funcion  que verifica si un usuario existe
    Public Function LoguearUsuario(ByVal user As String, ByVal pass As String) As DatosSQL.Usuarios
        Try
            Return ODatos.LoguearUsuario(user, pass)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
