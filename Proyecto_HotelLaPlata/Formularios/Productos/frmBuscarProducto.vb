Public Class frmBuscarProducto
    Private funciones As New clsFuncionesGenerales()
    Private productos As New clsProductos()
    Private Sub frmBuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvProducto, queriesProductos("obtener_activos"))
    End Sub
    Private Sub dgvProducto_DoubleClick(sender As Object, e As EventArgs) Handles dgvProducto.DoubleClick
        frmGastosAdicionales.idProducto = dgvProducto.CurrentRow.Cells(0).Value

        frmGastosAdicionales.TxtProducto.Text = dgvProducto.CurrentRow.Cells(1).Value
        frmGastosAdicionales.txtPrecio.Text = dgvProducto.CurrentRow.Cells(2).Value
        Me.Close()
    End Sub
End Class