' Esta clase se encarga de interactuar con la base de datos.
' Realiza las inserciones, obtiene los datos y los envia a la
' entidad que hace la petición
Imports System.Data.SqlClient
Public Class clsEjecutarQuery
    Inherits clsDBConexion ' Hereda de la clase de conexión

    'Esta función ejecuta cualquier query para insertar, actualizar o eliminar un registro
    Public Function ejecutar(query As String, parametros As List(Of SqlParameter))
        Dim estado = True ' Al terminar, la función retornará una lista con estas dos variables
        Dim mensaje As String = "OK" ' Si la operación es exitosa estado será verdadero y mensaje será ok

        abrirConexion()
        Dim ejec As New SqlCommand(query, conexion)

        For Each parametro In parametros
            ejec.Parameters.Add(parametro)
        Next

        Try
            ejec.ExecuteNonQuery()

        Catch ex As SqlException ' En caso de producirse una excepción, estado será false y se enviara el error en el mensaje
            estado = False

            Select Case ex.Number

                Case 2627
                    mensaje = "ya existe un registro con el id ingresado"

                Case 547
                    mensaje = "existen otros registros ligados a este id, no se puede eliminar"

                Case Else
                    mensaje = ex.Message & " " & ex.Number

            End Select
        End Try

        cerrarConexion()

        Dim res As New List(Of Object) From {estado, mensaje}

        Return res

    End Function


    'Función para obtener información de la base de datos, con o sin parámetros
    Public Function obtener(query As String, parametros As List(Of SqlParameter))
        abrirConexion()
        Dim datos As New DataTable

        Using adaptador As New SqlDataAdapter(query, conexion)
            If Not parametros Is Nothing Then
                For Each parametro In parametros
                    adaptador.SelectCommand.Parameters.Add(parametro)
                Next
            End If

            adaptador.Fill(datos)
        End Using

        cerrarConexion()

        Return datos
    End Function

End Class
