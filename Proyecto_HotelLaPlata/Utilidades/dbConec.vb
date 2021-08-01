Imports System.Data.SqlClient
Module dbConec
    Public coneccion As New SqlConnection

    Private nivelAcceso As Integer
    Public Sub Conectar()

        If coneccion.State = 0 Then
            Try
                coneccion.ConnectionString = "Data Source=LAPTOP-MAHQ548A;Initial Catalog=proyecto_hotel;Integrated Security=True"
                coneccion.Open()
            Catch ex As Exception
                MsgErrorConexion(ex.Message)
            End Try
        End If

    End Sub
    Public Sub CerrarConeccion()
        If coneccion.State = 1 Then
            Try
                coneccion.Close()
            Catch ex As Exception
                MsgErrorRegistro(ex.Message)
            End Try

        End If

    End Sub
    Public Sub asignarAcceso(acceso As Integer)
        nivelAcceso = acceso
    End Sub
    Public Function obtenerAcceso() As Integer
        Return nivelAcceso
    End Function

End Module
