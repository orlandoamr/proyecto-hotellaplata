'Módulo con todas las funciones que se reutilizan en varios formularios del proyecto
Imports System.Data.SqlClient
Module mdlFuncionesGlobales

    'Función para llenar un Grid o actualizarlo
    Public Sub dgvRefresh(dgv As DataGridView, query As String, conexion As SqlConnection)
        Dim datos As New DataTable

        Using adaptador As New SqlDataAdapter(query, conexion)
            adaptador.Fill(datos)
        End Using
        dgv.DataSource = datos
    End Sub

    'Función para llenar un combobox 
    Public Sub cmbFill(cmb As ComboBox, query As String, conexion As SqlConnection, displayMember As String, valueMember As String)
        Dim datos As New DataTable

        Using adaptador As New SqlDataAdapter(query, conexion)
            adaptador.Fill(datos)
        End Using
        cmb.DataSource = datos
        cmb.DisplayMember = displayMember
        cmb.ValueMember = valueMember
    End Sub

    'Función para llenar un grid con un parámetro de búsqueda
    Public Sub dgvFill(dgv As DataGridView, query As String, con As SqlConnection, par As String, val As String)
        Dim datos As New DataTable
        Try
            Using adaptador As New SqlDataAdapter(query, con)
                adaptador.SelectCommand.Parameters.AddWithValue(val, par)
                adaptador.Fill(datos)

            End Using
            dgv.DataSource = datos
        Catch ex As SqlException
            MsgErrorConexion(ex.Message)
        End Try
    End Sub

    'Función para llenar un grid con dos parámetros de búsqueda
    Public Sub dgvFill2(dgv As DataGridView, query As String, con As SqlConnection, par As String, par2 As String, val As String, val2 As String)
        Dim datos As New DataTable
        Try
            Using adaptador As New SqlDataAdapter(query, con)
                adaptador.SelectCommand.Parameters.AddWithValue(val, par)
                adaptador.SelectCommand.Parameters.AddWithValue(val2, par2)
                adaptador.Fill(datos)
            End Using
            dgv.DataSource = datos
        Catch ex As SqlException
            MsgErrorConexion(ex.Message)
        End Try

    End Sub
End Module
