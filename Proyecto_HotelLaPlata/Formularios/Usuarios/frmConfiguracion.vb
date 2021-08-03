Public Class frmConfiguracion
    Private Sub frmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs)
        switchPanel(frmEditarUsurarios)
    End Sub
    Sub switchPanel(ByVal panel As Form)
        SubPanelConfiguracion.Controls.Clear()
        panel.TopLevel = False
        SubPanelConfiguracion.Controls.Add(panel)
        panel.Show()
    End Sub
End Class