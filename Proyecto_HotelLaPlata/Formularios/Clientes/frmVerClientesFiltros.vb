'Formulario para buscar clientes con diferentes parámetros
Public Class frmVerClientesFiltros
    Private clientes As New clsClientes()
    Private funciones As New clsFuncionesGenerales()
    Private Sub frmVerClientesFiltros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvClientes, queriesClientes("obtener_todos"))
        dgvClientes.Columns("DepartamentoId").Visible = False
        dgvClientes.Columns("PaisId").Visible = False
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        If txtParametro.Text = "" Then
            MsgIngreseParametro()
        Else
            clientes._parametroBusqueda = txtParametro.Text
            clientes.BuscarCliente(dgvClientes, queriesClientes("buscar_parametro"))
        End If

    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        funciones.llenarDataGrid(dgvClientes, queriesClientes("obtener_todos"))
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class