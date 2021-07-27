Imports System.Data.SqlClient
Public Class clsDBConexion
    Protected conexion As New SqlConnection
    Protected Sub abrirConexion()
        conexion.ConnectionString = "Data Source=LAPTOP-MAHQ548A;Initial Catalog=proyecto_hotel;Integrated Security=True"
        conexion.Open()
    End Sub

    Protected Sub cerrarConexion()
        conexion.Close()
    End Sub


End Class
