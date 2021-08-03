'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Ventas
'   Formulario: frmNuevaVenta
'   Función: realizar los registros de nuevas ventas
'-----------------------------------------------------------------------------------------------------------------
Public Class frmNuevaVenta
    Public habitaciones As New Dictionary(Of Integer, Integer)
    Public servicios As New Dictionary(Of Integer, Dictionary(Of String, Integer))

    Private funciones As New clsFuncionesGenerales()
    Private ventas As New clsVentas()

    Private totalVenta As Integer = 0

    Private Sub frmNuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvVentas, queriesVentas("obtener"))
        dgvVentas.Columns("VentaId").Visible = False
        txtCodigoVenta.Text = ""
    End Sub

    Private Sub btnAgregarHabitaciones_Click(sender As Object, e As EventArgs) Handles btnAgregarHabitaciones.Click
        frmAsignarHabitaciones.habitaciones = habitaciones
        frmAsignarHabitaciones.Show()

    End Sub

    Private Sub btnAgregarServicios_Click(sender As Object, e As EventArgs) Handles btnAgregarServicios.Click
        frmAgregarServicios.servicios = servicios
        frmAgregarServicios.Show()

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        frmBuscarCliente.Show()
    End Sub

    Public Sub actualizarVentaHabitaciones()
        lbHabitacionesAsignadas.Items.Clear()

        For Each habitacion In habitaciones
            lbHabitacionesAsignadas.Items.Add("Número de habitación: " & habitacion.Key & ", Costo por día: L." & habitacion.Value)
        Next

    End Sub

    Public Sub actualizarVentaServicios()
        lbServicios.Items.Clear()

        For Each id In servicios
            For Each servicio In id.Value
                lbServicios.Items.Add(servicio.Key & ", Costo por día: L." & servicio.Value)
            Next
        Next

    End Sub
    Public Sub actualizarVentaTotal()
        Dim totalVenta As Integer = 0

        For Each id In servicios
            For Each ser In id.Value
                totalVenta += ser.Value
            Next
        Next

        For Each habitacion In habitaciones
            totalVenta += habitacion.Value
        Next

        Dim dias As Integer
        If (txtEstadia.Text = "") Then
            dias = 0
        Else
            dias = Val(txtEstadia.Text)
        End If

        txtTotalVenta.Text = totalVenta * dias
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCodigoCliente.Text = "" Then
            MsgCampoVacio("código del cliente")
        ElseIf txtEstadia.Text = "" Then
            MsgCampoVacio("días de estadia")

        ElseIf habitaciones.Count = 0 Then
            MsgError2("Asigne al menos una habitación", "Seleccione una habitación")

        Else
            ventas._fechaEntrada = dtpFechaEntrada.Value
            ventas._diasEstadia = txtEstadia.Text
            ventas._costoTotal = Val(txtTotalVenta.Text)
            ventas._idCliente = txtCodigoCliente.Text
            ventas._idEmpleado = frmInicio2.usuarioId

            Dim res = ventas.insertar()

            If res(0) = False Then
                MsgError(res(1))

            Else
                Dim idVenta = ventas.obtenerUltimaVenta()
                For Each habitacion In habitaciones
                    ventas._ventaId = idVenta
                    ventas._habitacionId = habitacion.Key
                    ventas.insertarHabitaciones()
                Next
                For Each id In servicios
                    ventas._ventaId = idVenta
                    ventas._servicioId = id.Key
                    ventas.insertarServicios()
                Next

                MsgRegistroExitoso()
                limpiarCampos()
            End If
            funciones.llenarDataGrid(dgvVentas, queriesVentas("obtener"))
        End If
    End Sub

    Private Sub limpiarCampos()
        txtTotalVenta.Clear()
        txtCodigoCliente.Clear()
        txtCodigoVenta.Clear()
        txtEstadia.Clear()
        lbHabitacionesAsignadas.Items.Clear()
        lbServicios.Items.Clear()
        habitaciones.Clear()
        servicios.Clear()
    End Sub
    Private Sub dgvVentas_DoubleClick(sender As Object, e As EventArgs) Handles dgvVentas.DoubleClick
        'Dim idVenta = dgvVentas.CurrentRow.Cells(0).Value

        'ventas._ventaId = idVenta
        'ventas.obtenerHabitacines(habitaciones)
        'ventas.obtenerServicios(servicios)
        'actualizarVentaHabitaciones()
        'actualizarVentaServicios()

        'txtCodigoVenta.Text = dgvVentas.CurrentRow.Cells(0).Value
        'txtTotalVenta.Text = dgvVentas.CurrentRow.Cells(2).Value
        'txtCodigoCliente.Text = dgvVentas.CurrentRow.Cells(5).Value
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
    End Sub

    Private Sub txtEstadia_TextChanged(sender As Object, e As EventArgs) Handles txtEstadia.TextChanged
        actualizarVentaTotal()
    End Sub

    Private Sub txtEstadia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstadia.KeyPress
        soloNumeros(e)
    End Sub

End Class