'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsVentas
'   Función: insertar y buscar las ventas en la base de datos.
'-----------------------------------------------------------------------------------------------------------------

Imports System.Data.SqlClient
Public Class clsVentas
    Inherits clsEjecutarQuery 'Hereda de la clase principal que ejecuta los queries para usar los métodos
    ' ejecutar y obtener

    'Propiedades
    Private ventaId As Integer
    Private fechaEntrada As DateTime
    Private fechaSalida As DateTime
    Private diasEstadia As Integer
    Private costoTotal As Integer
    Private clienteId As String
    Private empleadoId As String

    Private habitacionId As Integer
    Private servicioId As Integer

    'Getters y Setters
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
    Public Property _diasEstadia As Integer
        Get
            Return diasEstadia
        End Get
        Set(value As Integer)
            diasEstadia = value
        End Set
    End Property

    Public Property _habitacionId As Integer
        Get
            Return habitacionId
        End Get
        Set(value As Integer)
            habitacionId = value
        End Set
    End Property
    Public Property _servicioId As Integer
        Get
            Return servicioId
        End Get
        Set(value As Integer)
            servicioId = value
        End Set
    End Property

    'Método para insertar una venta
    Public Function insertar()
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@FechaEntrada", fechaEntrada),
             New SqlParameter("@DiasEstadia", diasEstadia),
             New SqlParameter("@TotalVenta", costoTotal),
             New SqlParameter("@FKClienteId", clienteId),
             New SqlParameter("@FKEmpleadoId", empleadoId)
        }

        Return ejecutar(queriesVentas("insertar"), parametros)
    End Function

    'Método para insertar las habitaciones de la venta
    Public Function insertarHabitaciones()
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@VentaId", ventaId),
            New SqlParameter("@HabitacionId", habitacionId)
       }
        Me.actualizarEstadoHabitaciones()
        Return ejecutar(queriesVentas("insertar_habitaciones"), parametros)
    End Function

    'Método para actualizar la disponibilidad de las habitaciones a ocupado
    Public Function actualizarEstadoHabitaciones()
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@HabitacionId", habitacionId)
       }
        Return ejecutar(queriesHabitaciones("actualizar_estado"), parametros)
    End Function

    'Método para actualizar la salida del cliente
    Public Function actualizarSalida()
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@VentaId", ventaId),
            New SqlParameter("@FechaSalida", fechaSalida)
       }
        Dim parametros2 As New List(Of SqlParameter) From {
            New SqlParameter("@VentaId", ventaId)
        }
        ejecutar(queriesHabitaciones("actualizar_detalle"), parametros2)
        Return ejecutar(queriesVentas("actualizar_salida"), parametros)
    End Function

    'Método para actualizar la disponibilidad de las habitaciones a disponible
    Public Function actualizarEstadoHabitaciones2()
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@HabitacionId", habitacionId)
       }
        Return ejecutar(queriesHabitaciones("actualizar_estado2"), parametros)
    End Function

    'Método para insertar los servicios de la venta
    Public Function insertarServicios()
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@VentaId", ventaId),
            New SqlParameter("@ServicioId", servicioId)
       }

        Return ejecutar(queriesVentas("insertar_servicios"), parametros)
    End Function

    'Método para insertar los gastos adicionales de la venta
    Public Function insertarGastosAdicionales()
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@VentaId", ventaId),
            New SqlParameter("@ServicioId", ventaId)
       }
        Return ejecutar(queriesVentas("insertar_gastos"), parametros)
    End Function

    'Método para obtener el id de una venta
    Public Function obtenerUltimaVenta()
        Dim dt As New DataTable
        dt = obtener(queriesVentas("obtener_ultima_venta"), Nothing)
        Dim id As Integer
        For Each row In dt.Rows
            id = row("VentaId")
        Next

        Return id
    End Function


    'Método para obtener el las habitaciones de una venta
    Public Sub obtenerHabitacines(dgv As DataGridView)
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@VentaId", ventaId)
       }
        dgv.DataSource = obtener(queriesVentas("obtener_habitaciones"), parametros)
    End Sub

    'Método para obtener el los servicios de una venta
    Public Sub obtenerServicios(dgv As DataGridView)
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@VentaId", ventaId)
       }
        dgv.DataSource = obtener(queriesVentas("obtener_servicios"), parametros)
    End Sub

    'Método para obtener una venta por id
    Public Sub obtenerVentaId(dgv As DataGridView)
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@VentaId", ventaId)
       }
        dgv.DataSource = obtener(queriesVentas("obtener_id"), parametros)
    End Sub

    'Método para obtener el id de las habitaciones de una venta
    Public Function obtenerIdHabitaciones()
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@VentaId", ventaId)
       }
        Dim dt As New DataTable
        dt = obtener(queriesVentas("obtener_habitaciones"), parametros)
        Dim ids As New List(Of Integer)
        For Each Row In dt.Rows
            ids.Add(Row("Número de habitación"))
        Next

        Return ids
    End Function

End Class
