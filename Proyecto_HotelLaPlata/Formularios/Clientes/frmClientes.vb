Public Class frmClientes
    Private Sub btnNuevoRegistro_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        switchPanel(frmNuevoCliente)
        'frmNuevoCliente.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVerClientes.Click
        switchPanel(frmVerClientesFiltros)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles VerRegistrosDetalle.Click
        switchPanel(frmVerDetallesVentas)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDetalleVentas.Click
        switchPanel(frmDetalleVentas)

    End Sub


    Private Sub btnGastos_Click(sender As Object, e As EventArgs) Handles btnGastos.Click
        switchPanel(frmGastosAdicionales)

    End Sub
    Sub switchPanel(ByVal panel As Form)
        SubPanelClientes.Controls.Clear()
        panel.TopLevel = False
        SubPanelClientes.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub SubPanelClientes_Paint(sender As Object, e As PaintEventArgs) Handles SubPanelClientes.Paint

    End Sub
End Class