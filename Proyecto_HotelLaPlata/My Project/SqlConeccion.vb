Imports System.Data.SqlClient
Public Class SqlConeccion
    Dim conec As New SqlClient.SqlConnection
    Private Sub Sql()
        conec.ConnectionString = "Data Source=LAPTOP-HT71Q9AM;Initial Catalog=proyecto_hotel;Integrated Security=True"
        conec.Open()
    End Sub
End Class
