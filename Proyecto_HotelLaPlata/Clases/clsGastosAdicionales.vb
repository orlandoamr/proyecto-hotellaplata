'Clase utilizada para insertar, actualizar, buscar y eliminar gastos adicionales
Imports System.Data.SqlClient
Public Class clsGastosAdicionales
    'Propiedades
    Private idGastoAdicional As Integer
    Private idDetalleVenta As Integer
    Private idProducto As Integer
    Private cantidadProducto As Integer
    Private precioProducto As Integer
    Private totalGasto As Integer

    'Getters y Setters
    Public Property _idGastoAdicional As Integer
        Get
            Return idGastoAdicional
        End Get
        Set(value As Integer)
            idGastoAdicional = value
        End Set
    End Property
    Public Property _idDetalleVenta As Integer
        Get
            Return idDetalleVenta
        End Get
        Set(value As Integer)
            idDetalleVenta = value
        End Set
    End Property
    Public Property _idProducto As Integer
        Get
            Return idProducto
        End Get
        Set(value As Integer)
            idProducto = value
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

    'Método para obtener el gasto adicional por su id
    Public Sub obtenerGasto(dgv As DataGridView, query As String, con As SqlConnection, id As Integer)
        query = query & "'" & id & "'"
        Dim gastos As New DataTable

        Using adaptador As New SqlClient.SqlDataAdapter(query, con)
            adaptador.Fill(gastos)
        End Using

        dgv.DataSource = gastos
    End Sub

    Public Sub insertarGasto(query As String, con As SqlConnection)
        Dim ejecutar As New SqlCommand(query, coneccion)
        ejecutar.Parameters.AddWithValue("@FkDetalleVenta", idDetalleVenta)
        ejecutar.Parameters.AddWithValue("@FkProductoId", idProducto)
        ejecutar.Parameters.AddWithValue("@Cantidad", cantidadProducto)
        ejecutar.Parameters.AddWithValue("@Total", totalGasto)

        Try
            ejecutar.ExecuteNonQuery()
            MsgRegistroExitoso()
        Catch ex As Exception
            MsgErrorRegistro(ex.Message)
        End Try
    End Sub

    Public Sub actualizarGasto(query As String, con As SqlConnection)
        Dim ejecutar As New SqlCommand(query, coneccion)
        ejecutar.Parameters.AddWithValue("@FkGastoAdicionalId", idGastoAdicional)
        ejecutar.Parameters.AddWithValue("@FkDetalleVenta", idDetalleVenta)
        ejecutar.Parameters.AddWithValue("@FkProductoId", idProducto)
        ejecutar.Parameters.AddWithValue("@Cantidad", cantidadProducto)
        ejecutar.Parameters.AddWithValue("@Total", totalGasto)

        Try
            ejecutar.ExecuteNonQuery()
            MsgActualizacionExitosa()
        Catch ex As Exception
            MsgErrorRegistro(ex.Message)
        End Try
    End Sub

    Public Sub eliminarGasto(query As String, con As SqlConnection)
        Dim ejecutar As New SqlCommand(query, coneccion)
        ejecutar.Parameters.AddWithValue("@FkGastoAdicionalId", idGastoAdicional)

        Try
            ejecutar.ExecuteNonQuery()
            MsgEliminacionExitosa()
        Catch ex As Exception
            MsgErrorRegistro(ex.Message)
        End Try
    End Sub

End Class
