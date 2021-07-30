Public Class frmNuevaVenta
    Public servicios As New Dictionary(Of String, Integer)
    Public idServicios As New List(Of Integer)

    Public habitaciones As New Dictionary(Of Integer, Integer)

    Private funciones As New clsFuncionesGenerales()
    Private ventas As New clsVentas()
    Private totalVenta As Integer = 0

    Private editar As Boolean = False

    Private Sub frmNuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvVentas, queriesVentas("obtener"))
    End Sub

    Private Sub btnAgregarHabitaciones_Click(sender As Object, e As EventArgs) Handles btnAgregarHabitaciones.Click
        frmAsignarHabitaciones.Show()
    End Sub

    Private Sub btnAgregarServicios_Click(sender As Object, e As EventArgs) Handles btnAgregarServicios.Click
        frmAgregarServicios.Show()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        frmBuscarCliente.Show()
    End Sub

    Public Sub actualizarVentaHabitaciones()


        If habitaciones IsNot Nothing Then
            For Each habitacion In habitaciones
                lbHabitacionesAsignadas.Items.Add("Número de habitación: " & habitacion.Key & ", Costo: L." & habitacion.Value)
                totalVenta = totalVenta + habitacion.Value
            Next
        End If

        txtTotalVenta.Text = totalVenta
    End Sub

    Public Sub actualizarVentaServicios()

        If servicios IsNot Nothing Then
            For Each servicio In servicios
                lbServicios.Items.Add(servicio.Key & ", Costo: L." & servicio.Value)
                totalVenta = totalVenta + servicio.Value
            Next
        End If
        txtTotalVenta.Text = totalVenta
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCodigoCliente.Text = "" Then
            MsgCampoVacio("código del cliente")

        ElseIf habitaciones.Count = 0 Then
            MsgError2("Asigne al menos una habitación", "Seleccione una habitación")

        Else
            ventas._fechaEntrada = dtpFechaEntrada.Value
            ventas._costoTotal = Val(txtTotalVenta.Text)
            ventas._idCliente = txtCodigoCliente.Text
            ventas._idEmpleado = "1615200084558"

            If editar = True Then
                ventas._ventaId = Val(txtCodigoVenta.Text)

                Dim res = ventas.actualizar()

                If res(0) = False Then
                    MsgError(res(1))
                Else
                    MsgActualizacionExitosa()
                    limpiarCampos()
                End If
            Else
                Dim res = ventas.insertar()

                If res(0) = False Then
                    MsgError(res(1))
                Else
                    Dim idVenta = ventas.obtenerUltimaVenta()
                    For Each habitacion In habitaciones
                        ventas.insertarHabitaciones(idVenta, habitacion.Key)
                    Next
                    For Each servicio In idServicios
                        ventas.insertarServicios(idVenta, servicio)
                    Next
                    MsgRegistroExitoso()
                    limpiarCampos()
                End If
            End If
            funciones.llenarDataGrid(dgvVentas, queriesVentas("obtener"))
        End If
    End Sub

    Private Sub limpiarCampos()
        editar = False
        txtTotalVenta.Clear()
        txtCodigoCliente.Clear()
        txtCodigoVenta.Clear()
        txtBuscarCliente.Clear()
        lbHabitacionesAsignadas.Items.Clear()
        lbServicios.Items.Clear()
        idServicios.Clear()
        habitaciones.Clear()
        servicios.Clear()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtCodigoVenta.Text = "" Then
            MsgCampoVacio("código de la venta")
        Else
            ventas._ventaId = Val(txtCodigoVenta.Text)
            Dim res = ventas.eliminar()

            If res(0) = False Then
                MsgError(res(1))
            Else
                MsgEliminacionExitosa()
                limpiarCampos()
            End If
        End If
    End Sub

    Private Sub dgvVentas_DoubleClick(sender As Object, e As EventArgs) Handles dgvVentas.DoubleClick
        txtCodigoVenta.Text = dgvVentas.CurrentRow.Cells(0).Value
        txtTotalVenta.Text = dgvVentas.CurrentRow.Cells(2).Value
        txtCodigoCliente.Text = dgvVentas.CurrentRow.Cells(5).Value
    End Sub
End Class