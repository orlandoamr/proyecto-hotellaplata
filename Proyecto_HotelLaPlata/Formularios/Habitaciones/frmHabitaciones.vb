Public Class frmHabitaciones
    Private Sub btnNuevoInventario_Click(sender As Object, e As EventArgs)
        switchPanel(frmInventarioHabitaciones)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SubPanelHabitaciones.Paint

    End Sub

    Private Sub frmHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub switchPanel(ByVal panel As Form)
        SubPanelHabitaciones.Controls.Clear()
        panel.TopLevel = False
        SubPanelHabitaciones.Controls.Add(panel)
        panel.Show()
    End Sub
End Class