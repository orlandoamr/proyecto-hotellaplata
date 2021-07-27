Imports System.Data.SqlClient
Public Class frmBuscarDepartamentos
    Private Sub frmBuscarDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUpdate()
    End Sub

    Private Sub dgvUpdate()
        Try
            Conectar()

            Dim deptos As New DataTable
            Using adaptador As New SqlDataAdapter("select * from Departamentos", coneccion)
                adaptador.Fill(deptos)
            End Using

            dgvDeptos.DataSource = deptos
            CerrarConeccion()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvDeptos_DoubleClick(sender As Object, e As EventArgs) Handles dgvDeptos.DoubleClick
        Try
            frmNuevoCliente.txtProcedencia.Text = dgvDeptos.CurrentRow.Cells(1).Value
            frmNuevoCliente.idDepto = dgvDeptos.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try


        Me.Close()
    End Sub

    Private Sub dgvDeptos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDeptos.CellContentClick

    End Sub
End Class