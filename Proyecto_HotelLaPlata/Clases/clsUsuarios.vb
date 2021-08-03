'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsUsuarios
'   Función: insertar, actualizar y buscar los usuarios de los empleados en la base de datos.
'----------------------------------------------------------------------------------------------------------------

Imports System.Data.SqlClient

Public Class clsUsuarios
    Inherits clsEjecutarQuery 'Hereda de la clase principal que ejecuta los queries para usar los métodos
    ' ejecutar y obtener

    'Propiedades
    Private usuarioId As String
    Private nombreUsuario As String
    Private contrasenia As String
    Private nivelAcceso As Integer

    'Getters y Setters
    Public Property _usuarioId As String
        Get
            Return usuarioId
        End Get
        Set(value As String)
            usuarioId = value
        End Set
    End Property
    Public Property _nombreUsuario As String
        Get
            Return nombreUsuario
        End Get
        Set(value As String)
            nombreUsuario = value
        End Set
    End Property
    Public Property _contrasenia As String
        Get
            Return contrasenia
        End Get
        Set(value As String)
            contrasenia = value
        End Set
    End Property
    Public Property _nivelAcceso As Integer
        Get
            Return nivelAcceso
        End Get
        Set(value As Integer)
            nivelAcceso = value
        End Set
    End Property

    'Método para insertar un nuevo usuario
    Public Function insertar()
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@EmpleadoId", usuarioId),
            New SqlParameter("@NombreUsuario", nombreUsuario),
            New SqlParameter("@Contrasenia", contrasenia),
            New SqlParameter("@Nivel", nivelAcceso)
       }

        Return ejecutar(queriesUsuarios("insertar"), parametros)
    End Function

    'Método para actualizar un usuario
    Public Function actualizar()
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@EmpleadoId", usuarioId),
            New SqlParameter("@NombreUsuario", nombreUsuario),
            New SqlParameter("@Contrasenia", contrasenia),
            New SqlParameter("@Nivel", nivelAcceso)
       }

        Return ejecutar(queriesUsuarios("actualizar"), parametros)
    End Function

    'Método para buscar un usuario
    Public Function verificarUsuario()
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@NombreUsuario", nombreUsuario),
             New SqlParameter("@Contrasenia", contrasenia)
        }

        Dim dt As New DataTable

        Return obtener(queriesUsuarios("obtener_usuario"), parametros)
    End Function

End Class
