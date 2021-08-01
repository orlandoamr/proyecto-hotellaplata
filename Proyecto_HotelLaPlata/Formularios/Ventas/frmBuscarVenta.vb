Public Class frmBuscarVenta
    Private funciones As New clsFuncionesGenerales()
    Private Sub frmBuscarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvVentas, queriesVentas("obtener"))
    End Sub

    Private Sub dgvVentas_DoubleClick(sender As Object, e As EventArgs) Handles dgvVentas.DoubleClick
        frmVerDetallesVentas.txtCodigoVenta.Text = dgvVentas.CurrentRow.Cells(0).Value
        frmGastosAdicionales.txtCodigoVenta.Text = dgvVentas.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        funciones.llenarDataGrid(dgvVentas, queriesVentas("obtener"))
    End Sub

    Private Sub btnBuscarVenta_Click(sender As Object, e As EventArgs) Handles btnBuscarVenta.Click

    End Sub
End Class