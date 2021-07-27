'Clase para insertar, actualizar y eliminar una venta de habitación
Imports System.Data.SqlClient
Public Class clsDetalleVentas
    'Propiedades
    Private ventaId As Integer
    Private clienteId As String
    Private habitacionAsignada As Integer
    Private costoHabitacion As Integer
    Private fechaEntrada As String
    Private fechaSalida As String
    Private observacion As String
    Private empleadoId As String


    'Getters y Setters
    Public Property _ventaId As Integer
        Get
            Return ventaId
        End Get
        Set(value As Integer)
            ventaId = value
        End Set
    End Property
    Public Property _clienteId As String
        Get
            Return clienteId
        End Get
        Set(value As String)
            clienteId = value
        End Set
    End Property
    Public Property _habitacionAsignada As Integer
        Get
            Return habitacionAsignada
        End Get
        Set(value As Integer)
            habitacionAsignada = value
        End Set
    End Property
    Public Property _costoHabitacion As Integer
        Get
            Return costoHabitacion
        End Get
        Set(value As Integer)
            costoHabitacion = value
        End Set
    End Property
    Public Property _fechaEntrada As String
        Get
            Return fechaEntrada
        End Get
        Set(value As String)
            fechaEntrada = value
        End Set
    End Property
    Public Property _fechaSalida As String
        Get
            Return fechaSalida
        End Get
        Set(value As String)
            fechaSalida = value
        End Set
    End Property
    Public Property _observacion As String
        Get
            Return observacion
        End Get
        Set(value As String)
            observacion = value
        End Set
    End Property
    Public Property _empleadoId As String
        Get
            Return empleadoId
        End Get
        Set(value As String)
            empleadoId = value
        End Set
    End Property

    'Método para insertar una venta
    Public Sub insertarVenta(query As String, conexion As SqlConnection)
        Dim ejecutar As New SqlClient.SqlCommand(query, conexion)

        ejecutar.Parameters.AddWithValue("@FkCodCliente", clienteId)
        ejecutar.Parameters.AddWithValue("@FkCodHabitacion", habitacionAsignada)
        ejecutar.Parameters.AddWithValue("@CostoHabitacion", costoHabitacion)
        ejecutar.Parameters.AddWithValue("@FechaEntrada", fechaEntrada)
        ejecutar.Parameters.AddWithValue("@Observacion", observacion)
        ejecutar.Parameters.AddWithValue("@FkEmpleadoId", empleadoId)

        Try
            ejecutar.ExecuteNonQuery()
            MsgRegistroExitoso()
            frmDetalleVentas.limpiarCampos()
        Catch ex As SqlException
            MsgErrorRegistro(ex.Message)
        End Try
    End Sub

    'Método para actualizar una venta
    Public Sub actualizarVenta(query As String, conexion As SqlConnection)
        Dim ejecutar As New SqlClient.SqlCommand(query, conexion)

        ejecutar.Parameters.AddWithValue("@DetalleVentaId", ventaId)
        ejecutar.Parameters.AddWithValue("@FkCodCliente", clienteId)
        ejecutar.Parameters.AddWithValue("@FkCodHabitacion", habitacionAsignada)
        ejecutar.Parameters.AddWithValue("@CostoHabitacion", costoHabitacion)
        ejecutar.Parameters.AddWithValue("@FechaEntrada", fechaEntrada)
        ejecutar.Parameters.AddWithValue("@FechaSalida", fechaSalida)
        ejecutar.Parameters.AddWithValue("@Observacion", observacion)
        ejecutar.Parameters.AddWithValue("@FkEmpleadoId", empleadoId)

        Try
            ejecutar.ExecuteNonQuery()
            MsgRegistroExitoso()
            frmDetalleVentas.limpiarCampos()
        Catch ex As SqlException
            MsgErrorRegistro(ex.Message)
        End Try


    End Sub

    'Método para actualizar la salida de una cliente
    Public Sub actualizarSalida(query As String, conexion As SqlConnection)
        Dim ejecutar As New SqlClient.SqlCommand(query, conexion)

        ejecutar.Parameters.AddWithValue("@DetalleVentaId", ventaId)
        ejecutar.Parameters.AddWithValue("@FechaSalida", fechaSalida)

        Try
            ejecutar.ExecuteNonQuery()
            MsgActualizacionExitosa()
            frmDetalleVentas.limpiarCampos()
        Catch ex As Exception
            MsgErrorRegistro(ex.Message)
        End Try
    End Sub

    'Método para para eliminar una venta
    Public Sub eliminarVenta(query As String, conexion As SqlConnection)
        Dim ejecutar As New SqlClient.SqlCommand(query, conexion)

        ejecutar.Parameters.AddWithValue("@DetalleVentaId", ventaId)

        Try
            ejecutar.ExecuteNonQuery()
            MsgEliminacionExitosa()
            frmDetalleVentas.limpiarCampos()
        Catch ex As SqlException
            MsgErrorRegistro(ex.Message)
        End Try
    End Sub


    'Método para buscar una venta por el id de un cliente
    Public Sub BuscarIdCliente(dgv As DataGridView, query As String, conexion As SqlClient.SqlConnection, id As String)
        query = query & "'" & id & "'"
        Dim cliente As New DataTable
        Try
            Using adaptador As New SqlClient.SqlDataAdapter(query, conexion)
                adaptador.Fill(cliente)
            End Using
            dgv.DataSource = cliente
            frmDetalleVentas.limpiarCampos()
        Catch ex As SqlException
            MsgErrorConexion(ex.Message)
        End Try

    End Sub
End Class
