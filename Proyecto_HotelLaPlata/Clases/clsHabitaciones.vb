'Clase para insertar, actualizar, buscar y eliminar registros relacionados a las habitaciones
Imports System.Data.SqlClient
Public Class clsHabitaciones
    'Propiedades
    Private numeroHabitacion As Byte
    Private estadoHabitacion As Boolean
    Private tipoHabitacion As String

    'Getters y Setters
    Public Property _numeroHabitacion As Byte
        Get
            Return numeroHabitacion
        End Get
        Set(value As Byte)
            numeroHabitacion = value
        End Set
    End Property
    Public Property _estadoHabitacion As Boolean
        Get
            Return estadoHabitacion
        End Get
        Set(value As Boolean)
            estadoHabitacion = value
        End Set
    End Property
    Public Property _tipoHabitacion As String
        Get
            Return tipoHabitacion
        End Get
        Set(value As String)
            tipoHabitacion = value
        End Set
    End Property

    'Método para actualizar el estado de disponibilidad de una habitación
    Public Sub actualizarEstado(query As String, conexion As SqlConnection)
        Dim ejecutar As New SqlClient.SqlCommand(query, conexion)

        ejecutar.Parameters.AddWithValue("@HabitacionId", numeroHabitacion)
        ejecutar.Parameters.AddWithValue("@EstadoDisponibilidad", estadoHabitacion)

        Try
            ejecutar.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
End Class
