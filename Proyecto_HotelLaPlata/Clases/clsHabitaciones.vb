'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsHabitaciones
'   Función: insertar, actualizar, buscar las habitaciones en la base de datos.
'----------------------------------------------------------------------------------------------------------------

Imports System.Data.SqlClient
Public Class clsHabitaciones
    Inherits clsEjecutarQuery 'Hereda de la clase principal que ejecuta los queries para usar los métodos
    ' ejecutar y obtener

    'Propiedades
    Private numeroHabitacion As Integer
    Private costoHabitacion As Integer
    Private cantCamas As Integer
    Private cantAlmohadas As Integer
    Private cantMesas As Integer
    Private cantSillas As Integer
    Private cantTvs As Integer
    Private tipoAireId As Integer
    Private tipoHabitacionId As Integer
    Private tipoCamaId As Integer
    Private observacion As String

    'Getters y Setters
    Public Property _numeroHabitacion As Integer
        Get
            Return numeroHabitacion
        End Get
        Set(value As Integer)
            numeroHabitacion = value
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
    Public Property _cantCamas As Integer
        Get
            Return cantCamas
        End Get
        Set(value As Integer)
            cantCamas = value
        End Set
    End Property
    Public Property _cantAlmohadas As Integer
        Get
            Return cantAlmohadas
        End Get
        Set(value As Integer)
            cantAlmohadas = value
        End Set
    End Property
    Public Property _cantMesas As Integer
        Get
            Return cantMesas
        End Get
        Set(value As Integer)
            cantMesas = value
        End Set
    End Property
    Public Property _cantSillas As Integer
        Get
            Return cantSillas
        End Get
        Set(value As Integer)
            cantSillas = value
        End Set
    End Property
    Public Property _cantTvs As Integer
        Get
            Return cantTvs
        End Get
        Set(value As Integer)
            cantTvs = value
        End Set
    End Property
    Public Property _tipoAireId As Integer
        Get
            Return tipoAireId
        End Get
        Set(value As Integer)
            tipoAireId = value
        End Set
    End Property
    Public Property _tipoHabitacionId As Integer
        Get
            Return tipoHabitacionId
        End Get
        Set(value As Integer)
            tipoHabitacionId = value
        End Set
    End Property
    Public Property _tipoCamaId As Integer
        Get
            Return tipoCamaId
        End Get
        Set(value As Integer)
            tipoCamaId = value
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


    'Método para insertar una habitación
    Public Function insertar()
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@HabitacionId", numeroHabitacion),
             New SqlParameter("@CostoHabitacion", costoHabitacion),
             New SqlParameter("@CantCamas", cantCamas),
             New SqlParameter("@CantAlmohadas", cantAlmohadas),
             New SqlParameter("@CantMesas", cantMesas),
             New SqlParameter("@CantSillas", cantSillas),
             New SqlParameter("@Observacion", observacion),
             New SqlParameter("@CantTVs", cantTvs),
             New SqlParameter("@FKTipoAireId", tipoAireId),
             New SqlParameter("@FKTipoHabitacionId", tipoHabitacionId),
             New SqlParameter("@FKTipoCamaId", tipoCamaId)
        }

        Return ejecutar(queriesHabitaciones("insertar"), parametros)
    End Function

    'Método para actualizar una habitación
    Public Function actualizar()
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@HabitacionId", numeroHabitacion),
             New SqlParameter("@CostoHabitacion", costoHabitacion),
             New SqlParameter("@CantCamas", cantCamas),
             New SqlParameter("@CantAlmohadas", cantAlmohadas),
             New SqlParameter("@CantMesas", cantMesas),
             New SqlParameter("@CantSillas", cantSillas),
             New SqlParameter("@Observacion", observacion),
             New SqlParameter("@CantTVs", cantTvs),
             New SqlParameter("@FKTipoAireId", tipoAireId),
             New SqlParameter("@FKTipoHabitacionId", tipoHabitacionId),
             New SqlParameter("@FKTipoCamaId", tipoCamaId)
        }

        Return ejecutar(queriesHabitaciones("actualizar"), parametros)
    End Function


End Class
