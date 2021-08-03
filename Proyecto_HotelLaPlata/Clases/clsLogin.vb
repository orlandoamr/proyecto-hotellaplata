Imports System.Data.SqlClient
Public Class clsLogin
    Inherits clsEjecutarQuery

    Private usuario As String
    Private contrasenia As String

    Public Property _usuario As String
        Get
            Return usuario
        End Get
        Set(value As String)
            usuario = value
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

    Public Function verificarUsuario()
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@NombreUsuario", usuario),
             New SqlParameter("@Contrasenia", contrasenia)
        }

        Dim dt As New DataTable

        'dt = obtener()
    End Function
End Class
