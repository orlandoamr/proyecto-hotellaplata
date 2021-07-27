Public Class frmInicio
    Sub switchPanel(ByVal panel As Form)
        panelContenedor.Controls.Clear()
        panel.TopLevel = False
        panelContenedor.Controls.Add(panel)
        panel.Show()

    End Sub
    Sub switchPanel2(ByVal panel As Form)
        frmClientes.SubPanelClientes.Controls.Clear()
        panel.TopLevel = False
        frmClientes.SubPanelClientes.Controls.Add(panel)
        panel.Show()
    End Sub
    Sub switchPanel3(ByVal panel As Form)
        frmEmpleados.SubPanelEmpleados.Controls.Clear()
        panel.TopLevel = False
        frmEmpleados.SubPanelEmpleados.Controls.Add(panel)
        panel.Show()
    End Sub

    Sub switchPanel4(ByVal panel As Form)
        frmHabitaciones.SubPanelHabitaciones.Controls.Clear()
        panel.TopLevel = False
        frmHabitaciones.SubPanelHabitaciones.Controls.Add(panel)
        panel.Show()
    End Sub
    Sub switchPanel5(ByVal panel As Form)
        frmConfiguracion.SubPanelConfiguracion.Controls.Clear()
        panel.TopLevel = False
        frmConfiguracion.SubPanelConfiguracion.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub btnClientes_Click(sender As Object, e As EventArgs)
        switchPanel(frmClientes)
        switchPanel2(frmNuevoCliente)
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs)
        switchPanel(frmEmpleados)
        switchPanel3(frmNuevoEmpleado)
    End Sub

    Private Sub btnHabitaciones_Click(sender As Object, e As EventArgs)
        switchPanel(frmHabitaciones)
        switchPanel4(frmInventarioHabitaciones)
    End Sub

    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Hide()
        If (obtenerAcceso() > 1 Or obtenerAcceso() > 1) Then
            'Button1.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        switchPanel(frmConfiguracion)
        switchPanel5(frmEditarUsurarios)
    End Sub

    Private Sub frmInicio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Close()
    End Sub

    Private Sub btnClientes_Click_1(sender As Object, e As EventArgs) Handles btnClientes.Click
        If panelSubClientes.Visible = False Then
            panelSubClientes.Visible = True

            panelSubVentas.Visible = False
            panelSubEmpleados.Visible = False
            panelSubHabitaciones.Visible = False
            panelSubReporteria.Visible = False
        Else
            panelSubClientes.Visible = False
        End If
    End Sub
    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        If panelSubVentas.Visible = False Then
            panelSubVentas.Visible = True

            panelSubClientes.Visible = False
            panelSubEmpleados.Visible = False
            panelSubHabitaciones.Visible = False
            panelSubReporteria.Visible = False
            panelSubConfiguracion.Visible = False
        Else
            panelSubVentas.Visible = False
        End If
    End Sub

    Private Sub btnEmpleados_Click_1(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        If panelSubEmpleados.Visible = False Then
            panelSubEmpleados.Visible = True

            panelSubClientes.Visible = False
            panelSubVentas.Visible = False
            panelSubHabitaciones.Visible = False
            panelSubReporteria.Visible = False
            panelSubConfiguracion.Visible = False
        Else
            panelSubEmpleados.Visible = False
        End If
    End Sub

    Private Sub btnHabitaciones_Click_1(sender As Object, e As EventArgs) Handles btnHabitaciones.Click
        If panelSubHabitaciones.Visible = False Then
            panelSubHabitaciones.Visible = True

            panelSubClientes.Visible = False
            panelSubVentas.Visible = False
            panelSubEmpleados.Visible = False
            panelSubReporteria.Visible = False
            panelSubConfiguracion.Visible = False

        Else
            panelSubHabitaciones.Visible = False
        End If
    End Sub

    Private Sub btnReporteria_Click(sender As Object, e As EventArgs) Handles btnReporteria.Click
        If panelSubReporteria.Visible = False Then
            panelSubReporteria.Visible = True

            panelSubClientes.Visible = False
            panelSubVentas.Visible = False
            panelSubEmpleados.Visible = False
            panelSubHabitaciones.Visible = False
            panelSubConfiguracion.Visible = False

        Else
            panelSubReporteria.Visible = False
        End If
    End Sub

    Private Sub btnConfiguracion_Click(sender As Object, e As EventArgs) Handles btnConfiguracion.Click
        If panelSubConfiguracion.Visible = False Then
            panelSubConfiguracion.Visible = True

            panelSubClientes.Visible = False
            panelSubVentas.Visible = False
            panelSubEmpleados.Visible = False
            panelSubHabitaciones.Visible = False
            panelSubReporteria.Visible = False

        Else
            panelSubConfiguracion.Visible = False
        End If
    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        switchPanel(frmNuevoCliente)
    End Sub
End Class