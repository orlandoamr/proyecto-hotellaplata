Imports System.Data.SqlClient
Public Class clsDiarioEmpleados
    Inherits clsEjecutarQuery

    Private diarioId As Integer
    Private fecha As Date
    Private horaEntrada As String
    Private horaSalida As String
    Private observacion As String
    Private empleadoId As String

    Public Property _diarioId As Integer
        Get
            Return diarioId
        End Get
        Set(value As Integer)
            diarioId = value
        End Set
    End Property
    Public Property _fecha As Date
        Get
            Return fecha
        End Get
        Set(value As Date)
            fecha = value
        End Set
    End Property
    Public Property _horaEntrada As String
        Get
            Return horaEntrada
        End Get
        Set(value As String)
            horaEntrada = value
        End Set
    End Property
    Public Property _horaSalida As String
        Get
            Return horaSalida
        End Get
        Set(value As String)
            horaSalida = value
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

    Public Function insertar()
        Dim parametros As New List(Of SqlParameter) From {
           New SqlParameter("@Fecha", fecha),
           New SqlParameter("@HoraEntrada", horaEntrada),
           New SqlParameter("@Observacion", observacion),
           New SqlParameter("@FkEmpleadoId", empleadoId)
        }

        Return ejecutar(queriesDiario("insertar"), parametros)
    End Function

    Public Function actualizarSalida()
        Dim parametros As New List(Of SqlParameter) From {
           New SqlParameter("@HoraSalida", horaSalida),
           New SqlParameter("@DiarioEmpleadoId", diarioId)
        }

        Return ejecutar(queriesDiario("actualizar_salida"), parametros)
    End Function

End Class
