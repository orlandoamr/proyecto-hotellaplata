Imports System.Data.SqlClient
Public Class frmBuscarCliente
    Private clientes As New clsClientes()
    Private funciones As New clsFuncionesGenerales()
    Private Sub frmVerClientesFiltros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvClientes, queriesClientes("obtener_todos"))
        dgvClientes.Columns("DepartamentoId").Visible = False
        dgvClientes.Columns("PaisId").Visible = False
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        clientes._parametroBusqueda = txtParametro.Text
        clientes.BuscarCliente(dgvClientes, queriesClientes("buscar_parametro"))
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        funciones.llenarDataGrid(dgvClientes, queriesClientes("obtener_todos"))
    End Sub

    Private Sub dgvClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgvClientes.DoubleClick
        frmNuevaVenta.txtCodigoCliente.Text = dgvClientes.CurrentRow.Cells(2).Value
        Me.Close()
    End Sub
End Class