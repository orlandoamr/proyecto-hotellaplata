Imports System.Data.SqlClient
Public Class clsFuncionesGenerales
    Inherits clsEjecutarQuery
    Public Sub llenarDataGrid(dgv As DataGridView, query As String)
        dgv.DataSource = obtener(query, Nothing)
    End Sub

End Class
