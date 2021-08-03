'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsDBConexion
'   Función: realizar la conexión al servidor de la base de datos
'-----------------------------------------------------------------------------------------------------------------

Imports System.Data.SqlClient
Public Class clsDBConexion

    'Propiedades
    Protected conexion As New SqlConnection

    'Método para abrir una conexión
    Protected Sub abrirConexion()
        Try
            conexion.ConnectionString = "Data Source=(local);Initial Catalog=hotel_la_plata;Integrated Security=True"
            conexion.Open()
        Catch ex As Exception
            MsgErrorConexion()
        End Try

    End Sub

    'Método para cerrar la conexión
    Protected Sub cerrarConexion()
        Try
            conexion.Close()
        Catch ex As Exception

        End Try

    End Sub


End Class
