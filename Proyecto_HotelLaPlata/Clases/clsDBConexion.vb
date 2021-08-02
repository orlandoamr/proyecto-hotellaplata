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
            conexion.ConnectionString = "Data Source=LAPTOP-MAHQ548A;Initial Catalog=proyecto_hotel;Integrated Security=True"
            conexion.Open()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error en la conexión al servidor de la base de datos, comuníquese con el administrador del servidor.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
