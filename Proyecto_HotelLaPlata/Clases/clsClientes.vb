'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsClientes
'   Función: insertar, actualizar y buscar clientes en la base de datos.
'----------------------------------------------------------------------------------------------------------------

Imports System.Data.SqlClient

Public Class clsClientes
    Inherits clsEjecutarQuery 'Hereda de la clase principal que ejecuta los queries para usar los métodos
    ' ejecutar y obtener

    'Propiedades
    Private clienteId As String
    Private nombre As String
    Private apellido As String
    Private esExtranjero As Boolean
    Private departamento As Integer
    Private pais As Integer

    Private parametroBusqueda As String

    'Getters y Setters
    Public Property _clienteId As String
        Get
            Return clienteId
        End Get
        Set(value As String)
            clienteId = value
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
    Public Property _esExtranjero As Boolean
        Get
            Return esExtranjero
        End Get
        Set(value As Boolean)
            esExtranjero = value
        End Set
    End Property
    Public Property _departamento As Integer
        Get
            Return departamento
        End Get
        Set(value As Integer)
            departamento = value
        End Set
    End Property
    Public Property _pais As Integer
        Get
            Return pais
        End Get
        Set(value As Integer)
            pais = value
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


    'Método para insertar y actualizar un cliente
    Public Function guardar(query As String)
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@ClienteId", clienteId),
             New SqlParameter("@NombreCliente", nombre),
             New SqlParameter("@ApellidoCliente", apellido),
             New SqlParameter("@Extranjero", esExtranjero),
             New SqlParameter("@FKDepartamentoId", departamento),
             New SqlParameter("@FkPaisId", pais)
        }

        Return ejecutar(query, parametros)
    End Function

    'Método para eliminar un cliente.
    Public Function eliminarCliente(query As String)
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@ClienteId", clienteId)
        }

        Return ejecutar(query, parametros)

    End Function

    'Método para buscar un cliente por su número de identidad.
    Public Sub BuscarIdCliente(dgv As DataGridView, query As String)
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@ClienteId", clienteId)
        }

        dgv.DataSource = obtener(query, parametros)
    End Sub


    'Método para buscar un cliente por parámetro.
    Public Sub BuscarCliente(dgv As DataGridView, query As String)
        Dim parametros As New List(Of SqlParameter) From {
            New SqlParameter("@Parametro", parametroBusqueda)
        }

        dgv.DataSource = obtener(query, parametros)
    End Sub
End Class
