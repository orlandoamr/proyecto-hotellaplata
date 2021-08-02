'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsPaises
'   Función: obtener los paises por nombre
'----------------------------------------------------------------------------------------------------------------

Imports System.Data.SqlClient

Public Class clsPaises
    Inherits clsEjecutarQuery 'Hereda de la clase principal que ejecuta los queries para usar los métodos
    ' ejecutar y obtener

    'Propiedades
    Private nombrePais As String

    'Getter y Setter
    Public Property _nombrePais As String
        Get
            Return nombrePais
        End Get
        Set(value As String)
            nombrePais = value
        End Set
    End Property

    'Método para obtener un país por su nombre
    Public Sub obtenerPais(dgv As DataGridView)
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@NombrePais", nombrePais)
        }

        dgv.DataSource = obtener(queriesPaises("obtener_nombre"), parametros)
    End Sub
End Class
