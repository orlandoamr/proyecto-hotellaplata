'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsProductos
'   Función: insertar, actualizar y  buscar los productos en la base de datos.
'----------------------------------------------------------------------------------------------------------------

Imports System.Data.SqlClient
Public Class clsProductos
    Inherits clsEjecutarQuery 'Hereda de la clase principal que ejecuta los queries para usar los métodos
    ' ejecutar y obtener

    'Propiedades
    Private productoId As Integer
    Private nombreProducto As String
    Private precio As Integer
    Private estado As Boolean

    'Getters y Setters
    Public Property _productoId As Integer
        Get
            Return productoId
        End Get
        Set(value As Integer)
            productoId = value
        End Set
    End Property
    Public Property _nombreProducto As String
        Get
            Return nombreProducto
        End Get
        Set(value As String)
            nombreProducto = value
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
    Public Property _estado As Boolean
        Get
            Return estado
        End Get
        Set(value As Boolean)
            estado = value
        End Set
    End Property

    'Método para insertar un producto
    Public Function insertar()
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@NombreProducto", nombreProducto),
            New SqlParameter("@Precio", precio),
            New SqlParameter("@EstadoProducto", estado)
       }

        Return ejecutar(queriesProductos("insertar"), parametros)
    End Function

    'Método para actualizar un producto
    Public Function actualizar()
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@ProductoId", productoId),
            New SqlParameter("@NombreProducto", nombreProducto),
            New SqlParameter("@Precio", precio),
            New SqlParameter("@EstadoProducto", estado)
       }

        Return ejecutar(queriesProductos("actualizar"), parametros)
    End Function

    'Método para obtener un producto
    Public Sub obtenerProducto(dgv As DataGridView, query As String)
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@NombreProducto", nombreProducto)
       }

        dgv.DataSource = obtener(query, parametros)
    End Sub
End Class
