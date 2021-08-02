'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsEmpleados
'   Función: insertar, actualizar y buscar empleados en la base de datos.
'----------------------------------------------------------------------------------------------------------------
'
Imports System.Data.SqlClient
Public Class clsEmpleados
    Inherits clsEjecutarQuery 'Hereda de la clase principal que ejecuta los queries para usar los métodos
    ' ejecutar y obtener

    'Propiedades
    Private empleadoId As String
    Private nombre As String
    Private apellido As String
    Private numeroTelefono As String
    Private correoElectronico As String
    Private cargoId As Integer

    Private parametroBusqueda As String

    'Getters y Setters
    Public Property _empleadoId As String
        Get
            Return empleadoId
        End Get
        Set(value As String)
            empleadoId = value
        End Set
    End Property
    Public Property _nombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property _apellido As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property
    Public Property _numeroTelefono As String
        Get
            Return numeroTelefono
        End Get
        Set(value As String)
            numeroTelefono = value
        End Set
    End Property
    Public Property _correoElectronico As String
        Get
            Return correoElectronico
        End Get
        Set(value As String)
            correoElectronico = value
        End Set
    End Property
    Public Property _cargoId As Integer
        Get
            Return cargoId
        End Get
        Set(value As Integer)
            cargoId = value
        End Set
    End Property

    Public Property _parametroBusqueda As String
        Get
            Return parametroBusqueda
        End Get
        Set(value As String)
            parametroBusqueda = value
        End Set
    End Property


    'Método para insertar y actualizar un empleado
    Public Function guardar(query As String)
        Dim parametros As New List(Of SqlParameter) From {
         New SqlParameter("@EmpleadoId", empleadoId),
         New SqlParameter("@NombreEmpleado", nombre),
         New SqlParameter("@ApellidoEmpleado", apellido),
         New SqlParameter("@Telefono", numeroTelefono),
         New SqlParameter("@Correo", correoElectronico),
         New SqlParameter("@FKCargoId", cargoId)
    }

        Return ejecutar(query, parametros)
    End Function

    'Método para buscar un empleado por su número de identidad.
    Public Sub BuscarIdEmpleado(dgv As DataGridView, query As String)
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@EmpleadoId", empleadoId)
    }

        dgv.DataSource = obtener(queriesEmpleados("actualizar"), parametros)
    End Sub


    'Método para buscar un empleado por parámetro.
    Public Sub BuscarEmpleado(dgv As DataGridView, query As String)
        Dim parametros As New List(Of SqlParameter) From {
        New SqlParameter("@Parametro", parametroBusqueda)
    }

        dgv.DataSource = obtener(query, parametros)
    End Sub
End Class
