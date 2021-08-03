'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Ventas
'   Formulario: frmActualizarSalida
'   Función: actualizar la salida de un cliente 
'-----------------------------------------------------------------------------------------------------------------
Public Class frmActualizarSalida
    Private funciones As New clsFuncionesGenerales()
    Private ventas As New clsVentas()

    Dim idHabitaciones As New List(Of Integer)

    Private Sub frmActualizarSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvVentas, queriesVentas("obtener_ventas_salida"))
        dgvVentas.Columns("VentaId").Visible = False
        txtCodigoVenta.Text = ""
        dtpFechaSalida.MaxDate = System.DateTime.Now
    End Sub

    Private Sub dgvVentas_DoubleClick(sender As Object, e As EventArgs) Handles dgvVentas.DoubleClick

        Dim ventaId = dgvVentas.CurrentRow.Cells(0).Value
        txtCodigoVenta.Text = dgvVentas.CurrentRow.Cells(0).Value
    End Sub

    Private Sub txtCodigoVenta_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoVenta.TextChanged
        ventas._ventaId = Val(txtCodigoVenta.Text)
        idHabitaciones = ventas.obtenerIdHabitaciones()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCodigoVenta.Text = "" Then
            MsgCampoVacio("código de venta")

        Else
            ventas._ventaId = Val(txtCodigoVenta.Text)
            ventas._fechaSalida = dtpFechaSalida.Value
            ventas.actualizarSalida()

            For Each id In idHabitaciones
                ventas._habitacionId = id
                ventas.actualizarEstadoHabitaciones2()
            Next

            funciones.llenarDataGrid(dgvVentas, queriesVentas("obtener_ventas_salida"))
            MsgRegistroExitoso()
            txtCodigoVenta.Clear()
            idHabitaciones.Clear()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        funciones.llenarDataGrid(dgvVentas, queriesVentas("obtener_ventas_salida"))
        txtCodigoVenta.Text = ""
    End Sub
End Class