'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsClientes
'   Función: insertar, actualizar y buscar clientes en la base de datos.
'----------------------------------------------------------------------------------------------------------------

Imports System.Data.SqlClient

Public Class clsServicios
    Inherits clsEjecutarQuery 'Hereda de la clase principal que ejecuta los queries para usar los métodos
    ' ejecutar y obtener

    'Propiedades
    Private servicioId As Integer
    Private descripcion As String
    Private precio As Integer
    Private estado As Boolean

    'Getters y Setters
    Public Property _servicioId As Integer
        Get
            Return servicioId
        End Get
        Set(value As Integer)
            servicioId = value
        End Set
    End Property
    Public Property _descripcion As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property
    Public Property _precio As Integer
        Get
            Return precio
        End Get
        Set(value As Integer)
            precio = value
        End Set
    End Property
    Public Property _estado As Integer
        Get
            Return estado
        End Get
        Set(value As Integer)
            estado = value
        End Set
    End Property


    'Método para insertar una servicio
    Public Function guardar(query As String)
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@Descripcion", descripcion),
             New SqlParameter("@Precio", precio),
             New SqlParameter("@EstadoServicio", estado)
        }

        Return ejecutar(query, parametros)
    End Function


    'Método para actualizar una servicio
    Public Function actualizar(query As String)
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@ServicioId", servicioId),
             New SqlParameter("@Descripcion", descripcion),
             New SqlParameter("@Precio", precio),
             New SqlParameter("@EstadoServicio", estado)
        }

        Return ejecutar(query, parametros)
    End Function

End Class
