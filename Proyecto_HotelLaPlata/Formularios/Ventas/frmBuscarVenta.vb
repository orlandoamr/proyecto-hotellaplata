'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Ventas
'   Formulario: frmBuscarVentas
'   Función: buscar las ventas
'-----------------------------------------------------------------------------------------------------------------
Public Class frmBuscarVenta
    Private funciones As New clsFuncionesGenerales()
    Private Sub frmBuscarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvVentas, queriesVentas("obtener"))
        dgvVentas.Columns("VentaId").Visible = False
    End Sub

    Private Sub dgvVentas_DoubleClick(sender As Object, e As EventArgs) Handles dgvVentas.DoubleClick
        frmVerDetallesVentas.txtCodigoVenta.Text = dgvVentas.CurrentRow.Cells(0).Value
        frmGastosAdicionales.txtCodigoVenta.Text = dgvVentas.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        funciones.llenarDataGrid(dgvVentas, queriesVentas("obtener"))
        txtParametro.Clear()
    End Sub

    Private Sub btnBuscarVenta_Click(sender As Object, e As EventArgs) Handles btnBuscarVenta.Click
        If txtParametro.Text = "" Then
            MsgIngreseParametro()

        Else
            funciones._parametro = txtParametro.Text
            funciones.llenarDataGridParametro(dgvVentas, queriesVentas("obtener_por_cliente"))
        End If

    End Sub
End Class