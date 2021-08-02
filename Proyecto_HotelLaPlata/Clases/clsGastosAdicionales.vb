'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsGastosAdicionales
'   Función: insertar gastos adicionales de los clientes en la base de datos
'----------------------------------------------------------------------------------------------------------------

Imports System.Data.SqlClient
Public Class clsGastosAdicionales
    Inherits clsEjecutarQuery 'Hereda de la clase principal que ejecuta los queries para usar los métodos
    ' ejecutar y obtener

    'Propiedades
    Private gastoId As Integer
    Private ventaId As Integer
    Private productoId As Integer
    Private cantidadProducto As Integer
    Private precioProducto As Integer
    Private totalGasto As Integer

    'Getters y Setters
    Public Property _gastoId As Integer
        Get
            Return gastoId
        End Get
        Set(value As Integer)
            gastoId = value
        End Set
    End Property
    Public Property _ventaId As Integer
        Get
            Return ventaId
        End Get
        Set(value As Integer)
            ventaId = value
        End Set
    End Property
    Public Property _productoId As Integer
        Get
            Return productoId
        End Get
        Set(value As Integer)
            productoId = value
        End Set
    End Property
    Public Property _cantidadProducto As Integer
        Get
            Return cantidadProducto
        End Get
        Set(value As Integer)
            cantidadProducto = value
        End Set
    End Property
    Public Property _precioProducto As Integer
        Get
            Return precioProducto
        End Get
        Set(value As Integer)
            precioProducto = value
        End Set
    End Property
    Public Property _totalGasto As Integer
        Get
            Return totalGasto
        End Get
        Set(value As Integer)
            totalGasto = value
        End Set
    End Property


    'Método para insertar un gasto adicional
    Public Function insertar()
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@FKVentaId", ventaId),
             New SqlParameter("@FKProductoId", productoId),
             New SqlParameter("@Cantidad", cantidadProducto),
             New SqlParameter("@TotalGasto", totalGasto)
        }

        Return ejecutar(queriesGastos("insertar_gasto"), parametros)
    End Function

    'Método para obtener un gasto adicional
    Public Sub obtenerGastos(dgv As DataGridView)
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@VentaId", ventaId)
        }

        dgv.DataSource = obtener(queriesGastos("obtener_gastos_venta"), parametros)
    End Sub

End Class
