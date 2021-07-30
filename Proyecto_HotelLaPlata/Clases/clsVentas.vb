Imports System.Data.SqlClient
Public Class clsVentas
    Inherits clsEjecutarQuery

    Private ventaId As Integer
    Private fechaEntrada As DateTime
    Private fechaSalida As DateTime
    Private costoTotal As Integer
    Private clienteId As String
    Private empleadoId As String

    Public Property _ventaId As Integer
        Get
            Return ventaId
        End Get
        Set(value As Integer)
            ventaId = value
        End Set
    End Property
    Public Property _fechaEntrada As Date
        Get
            Return fechaEntrada
        End Get
        Set(value As Date)
            fechaEntrada = value
        End Set
    End Property
    Public Property _fechaSalida As Date
        Get
            Return fechaSalida
        End Get
        Set(value As Date)
            fechaSalida = value
        End Set
    End Property
    Public Property _costoTotal As Integer
        Get
            Return costoTotal
        End Get
        Set(value As Integer)
            costoTotal = value
        End Set
    End Property
    Public Property _idCliente As String
        Get
            Return clienteId
        End Get
        Set(value As String)
            clienteId = value
        End Set
    End Property
    Public Property _idEmpleado As String
        Get
            Return empleadoId
        End Get
        Set(value As String)
            empleadoId = value
        End Set
    End Property

    Public Function insertar()
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@FechaEntrada", fechaEntrada),
             New SqlParameter("@TotalVenta", costoTotal),
             New SqlParameter("@FKClienteId", clienteId),
             New SqlParameter("@FKEmpleadoId", empleadoId)
        }

        Return ejecutar(queriesVentas("insertar"), parametros)
    End Function

    Public Function actualizar()
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@VentaId", ventaId),
             New SqlParameter("@FechaEntrada", fechaEntrada),
             New SqlParameter("@FechaSalida", fechaSalida),
             New SqlParameter("@TotalVenta", fechaSalida),
             New SqlParameter("@FKClienteId", clienteId),
             New SqlParameter("@FKEmpleadoId", empleadoId)
        }

        Return ejecutar(queriesVentas("actualizar"), parametros)
    End Function

    Public Function eliminar()
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@VentaId", ventaId)
        }

        Return ejecutar(queriesVentas("eliminar"), parametros)
    End Function

    Public Function insertarHabitaciones(id As Integer, hab As Integer)
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@VentaId", id),
            New SqlParameter("@HabitacionId", hab)
       }
        Return ejecutar(queriesVentas("insertar_habitaciones"), parametros)
    End Function
    Public Function insertarServicios(id As Integer, ser As Integer)
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@VentaId", id),
            New SqlParameter("@ServicioId", ser)
       }
        Return ejecutar(queriesVentas("insertar_servicios"), parametros)
    End Function
    Public Function insertarGastosAdicionales()
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@VentaId", ventaId),
            New SqlParameter("@ServicioId", ventaId)
       }
        Return ejecutar(queriesVentas("insertar_servicios"), parametros)
    End Function
    Public Function obtenerUltimaVenta()
        Dim dt As New DataTable
        dt = obtener(queriesVentas("obtener_ultima_venta"), Nothing)
        Dim id As Integer
        For Each row In dt.Rows
            id = row("VentaId")
        Next

        Return id
    End Function
End Class
