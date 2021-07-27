Imports System.Data.SqlClient

Public Class frmBuscarPais
    Private Sub frmBuscarPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUpdate()
    End Sub
    Private Sub dgvUpdate()
        Try
            Conectar()
            Dim paises As New DataTable
            Using adaptador As New SqlDataAdapter("select * from Paises", coneccion)
                adaptador.Fill(paises)
            End Using

            dgvPaises.DataSource = paises
            CerrarConeccion()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim consulta As String
        consulta = txtParametro.Text
        Try
            Conectar()
            consulta = "SELECT *FROM Paises WHERE NombrePais='" & consulta & "'"
            Dim paises As New DataTable

            Using adaptador As New SqlDataAdapter(consulta, coneccion)
                adaptador.Fill(paises)
            End Using

            dgvPaises.DataSource = paises
            CerrarConeccion()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtParametro_TextChanged(sender As Object, e As EventArgs) Handles txtParametro.TextChanged

    End Sub

    Private Sub dgvPaises_DoubleClick(sender As Object, e As EventArgs) Handles dgvPaises.DoubleClick
        Try
            frmNuevoCliente.txtPais.Text = dgvPaises.CurrentRow.Cells(1).Value
            frmNuevoCliente.idPais = dgvPaises.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try

        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dgvPaises_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPaises.CellContentClick

    End Sub
End Class