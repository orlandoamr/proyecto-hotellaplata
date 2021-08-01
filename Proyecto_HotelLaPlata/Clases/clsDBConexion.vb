'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsDBConexion
'   Función: realizar la conexión al servidor de la base de datos
'----------------------------------------------------------------------------------------------------------------

Imports System.Data.SqlClient
Public Class clsDBConexion

    'Propiedades
    Protected conexion As New SqlConnection

    'Método para abrir una conexión
    Protected Sub abrirConexion()
        conexion.ConnectionString = "Data Source=LAPTOP-MAHQ548A;Initial Catalog=proyecto_hotel;Integrated Security=True"
        conexion.Open()
    End Sub

    'Método para cerrar la conexión
    Protected Sub cerrarConexion()
        conexion.Close()
    End Sub


End Class
