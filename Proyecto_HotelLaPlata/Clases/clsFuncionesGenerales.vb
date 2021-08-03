'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsFuncionesGenerales
'   Función: almacenar funciones que se usan en varias pantallas del sistema.
'-----------------------------------------------------------------------------------------------------------------
Imports System.Data.SqlClient
Public Class clsFuncionesGenerales 'Hereda de la clase principal que ejecuta los queries para usar los métodos
    Inherits clsEjecutarQuery ' ejecutar y obtener

    Private parametro As String

    Public Property _parametro As String
        Get
            Return parametro
        End Get
        Set(value As String)
            parametro = value
        End Set
    End Property

    'Método para llenar un datagridview
    Public Sub llenarDataGrid(dgv As DataGridView, query As String)
        dgv.DataSource = obtener(query, Nothing)
    End Sub

    'Método para llenar un datagridview
    Public Sub llenarDataGridParametro(dgv As DataGridView, query As String)
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@Parametro", parametro)
        }
        dgv.DataSource = obtener(query, parametros)
    End Sub

    'Método para llenar un combobox
    Public Sub llenarCombobox(cmb As ComboBox, query As String)
        cmb.DataSource = obtener(query, Nothing)
    End Sub

    'Método para llenar un combobox
    Public Function obtenerDatos(query As String)
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@Parametro", parametro)
        }
        Return obtener(query, parametros)
    End Function

End Class
