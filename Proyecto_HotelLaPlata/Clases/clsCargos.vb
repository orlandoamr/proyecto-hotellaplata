'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsCargos
'   Función: insertar, actualizar y buscar cargos de los empleados en la base de datos.
'----------------------------------------------------------------------------------------------------------------
Imports System.Data.SqlClient
Public Class clsCargos
    Inherits clsEjecutarQuery 'Hereda de la clase principal que ejecuta los queries para usar los métodos
    ' ejecutar y obtener

    'Propiedades
    Private cargoId As Integer
    Private cargoDescripcion As String

    'Getters y Setters
    Public Property _cargoId As Integer
        Get
            Return cargoId
        End Get
        Set(value As Integer)
            cargoId = value
        End Set
    End Property
    Public Property _cargoDescripcion As String
        Get
            Return cargoDescripcion
        End Get
        Set(value As String)
            cargoDescripcion = value
        End Set
    End Property

    'Método para insertar un nuevo cargo
    Public Function insertar()

        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@Descripcion", cargoDescripcion)
        }

        Return ejecutar(queriesCargos("insertar"), parametros)
    End Function

    'Método para actualizar un nuevo cargo
    Public Function actualizar()
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@CargoId", cargoId),
             New SqlParameter("@Descripcion", cargoDescripcion)
        }

        Return ejecutar(queriesCargos("actualizar"), parametros)
    End Function

    'Método para llenar un combobox con los cargos
    Public Sub obtenerCargos(cmb As ComboBox)
        cmb.DataSource = obtener(queriesCargos("obtener"), Nothing)
        cmb.DisplayMember = "Descripción del cargo"
        cmb.ValueMember = "CargoId"
    End Sub

End Class
