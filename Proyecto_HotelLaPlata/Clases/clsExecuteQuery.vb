'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsExecuteQuery
'   Función: interactuar con la base de datos realizando inserciones, actualizaciones y obteniendo datos
'----------------------------------------------------------------------------------------------------------------

Imports System.Data.SqlClient
Public Class clsEjecutarQuery
    Inherits clsDBConexion ' Hereda de la clase de clsDBConexion

    'Método que ejecuta cualquier query para insertar, actualizar o eliminar un registro
    'Recibe un query y una lista como parámetros 
    Public Function ejecutar(query As String, parametros As List(Of SqlParameter))

        ' Al terminar, la función retornará una lista con estas dos variables
        Dim estado = True 'estado = True si la operación fue exitosa, False si ocurrió un error
        Dim mensaje As String = "OK" ' mensaje = OK cuando todo haya sido exitoso, en caso de ocurrir un error 
        ' almacenará en mensaje el error

        abrirConexion()
        Dim ejec As New SqlCommand(query, conexion)

        'Se añaden la lista de parámetros al query
        For Each parametro In parametros
            ejec.Parameters.Add(parametro)
        Next


        Try
            ejec.ExecuteNonQuery() 'Se ejecuta el query

        Catch ex As SqlException ' En caso de producirse una excepción, estado será false y se enviara el error en el mensaje
            estado = False

            Select Case ex.Number
                'Se almacena el error el la variable mensaje
                Case 2627
                    mensaje = "ya existe un registro con el id ingresado"

                Case 547
                    mensaje = "existen otros registros ligados a este id"

                Case Else
                    mensaje = ex.Message & " " & ex.Number

            End Select
        End Try

        cerrarConexion()

        Dim res As New List(Of Object) From {estado, mensaje}

        Return res 'Se retorna el resultado de la operación en una lista
        'en la posición 0 va el estado
        'en la posición 1 va el mensaje

    End Function


    'Método para obtener información de la base de datos, con o sin parámetros
    'Recibe un query y una lista como parámetros
    Public Function obtener(query As String, parametros As List(Of SqlParameter))

        abrirConexion()

        Dim datos As New DataTable 'Retornará un datatable con los datos obtenidos

        Using adaptador As New SqlDataAdapter(query, conexion)
            'Se verifica si hay parametros
            If Not parametros Is Nothing Then
                'Si hay, se agregan al comando
                For Each parametro In parametros
                    adaptador.SelectCommand.Parameters.Add(parametro)
                Next
            End If

            'Se llena el datatable con los resultados
            Try
                adaptador.Fill(datos)
            Catch ex As Exception

            End Try

        End Using

        cerrarConexion()

        'Se retorna el datatable
        Return datos
    End Function

End Class
