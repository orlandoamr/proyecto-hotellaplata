Public Class frmInicio2
    Sub switchPanel(ByVal panel As Form)
        PanelContenedor.Controls.Clear()
        panel.TopLevel = False
        PanelContenedor.Controls.Add(panel)
        Try
            panel.Show()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub frmInicio2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNuevoCliente_Click(sender As Object, e As EventArgs) Handles btnNuevoCliente.Click
        switchPanel(frmNuevoCliente)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
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

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
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

    Private Sub btnHabitaciones_Click(sender As Object, e As EventArgs) Handles btnHabitaciones.Click
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

    Private Sub btnVerClientes_Click(sender As Object, e As EventArgs) Handles btnVerClientes.Click
        switchPanel(frmVerClientesFiltros)
    End Sub

    Private Sub btnNuevaVenta_Click(sender As Object, e As EventArgs) Handles btnNuevaVenta.Click
        switchPanel(frmNuevaVenta)
    End Sub

    Private Sub btnVerDetalleVentas_Click(sender As Object, e As EventArgs) Handles btnVerDetalleVentas.Click
        switchPanel(frmVerDetallesVentas)
    End Sub

    Private Sub btnGastosAdicionales_Click(sender As Object, e As EventArgs) Handles btnGastosAdicionales.Click
        switchPanel(frmGastosAdicionales)
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        switchPanel(frmProductos)
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        switchPanel(frmServicios)
    End Sub

    Private Sub btnActualizarSalida_Click(sender As Object, e As EventArgs) Handles btnActualizarSalida.Click
        switchPanel(frmActualizarSalida)
    End Sub

    Private Sub btnNuevoEmpleado_Click(sender As Object, e As EventArgs) Handles btnNuevoEmpleado.Click
        switchPanel(frmNuevoEmpleado)
    End Sub

    Private Sub btnRegistroDiario_Click(sender As Object, e As EventArgs) Handles btnRegistroDiario.Click
        switchPanel(frmRegistroDiario)
    End Sub

    Private Sub btnActSalida_Click(sender As Object, e As EventArgs) Handles btnActSalida.Click
        switchPanel(frmActualizarSalidaEmpleado)
    End Sub

    Private Sub btnControlHabitaciones_Click(sender As Object, e As EventArgs) Handles btnControlHabitaciones.Click
        switchPanel(frmControlHabitaciones)
    End Sub

    Private Sub btnDisponibilidad_Click(sender As Object, e As EventArgs) Handles btnDisponibilidad.Click
        switchPanel(frmDisponibilidad)
    End Sub
End Class