Public Class frmEmpleados
    Private Sub btnNuevoEmpleado_Click(sender As Object, e As EventArgs) Handles btnNuevoEmpleado.Click
        switchPanel(frmNuevoEmpleado)
    End Sub

    Private Sub btnRegistroDiario_Click(sender As Object, e As EventArgs) Handles btnRegistroDiario.Click
        switchPanel(frmRegistroDiarioEmpleados)
    End Sub

    Private Sub btnVerRegistros_Click(sender As Object, e As EventArgs) Handles btnVerRegistros.Click
        switchPanel(frmVerRegistrosEmpleados)
    End Sub

    Private Sub frmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub switchPanel(ByVal panel As Form)
        SubPanelEmpleados.Controls.Clear()
        panel.TopLevel = False
        SubPanelEmpleados.Controls.Add(panel)
        panel.Show()
    End Sub
End Class