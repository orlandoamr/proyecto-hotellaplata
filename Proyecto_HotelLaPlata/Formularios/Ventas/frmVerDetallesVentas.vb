'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Ventas
'   Formulario: frmNuevaVenta
'   Función: visualizar el detalle de una venta
'-----------------------------------------------------------------------------------------------------------------
Imports System.Data.SqlClient
Public Class frmVerDetallesVentas
    Private funciones As New clsFuncionesGenerales()
    Private ventas As New clsVentas()
    Private gastos As New clsGastosAdicionales()

    Private Sub txtCodigoVenta_TextChanged(sender As Object, e As EventArgs) Handles txtCodigoVenta.TextChanged

        If txtCodigoVenta.Text IsNot "" Then
            ventas._ventaId = Val(txtCodigoVenta.Text)
            ventas.obtenerHabitacines(dgvHabitaciones)
            ventas.obtenerServicios(dgvServicios)
            ventas.obtenerVentaId(dgvVenta)
            gastos._ventaId = Val(txtCodigoVenta.Text)
            gastos.obtenerGastos(dgvGastosAdicionales)
        End If

    End Sub

    Private Sub btnBuscarVenta_Click(sender As Object, e As EventArgs) Handles btnBuscarVenta.Click
        frmBuscarVenta.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        txtCodigoVenta.Clear()
        dgvServicios.DataSource = Nothing
        dgvHabitaciones.DataSource = Nothing
        dgvVenta.DataSource = Nothing
        dgvGastosAdicionales.DataSource = Nothing
    End Sub

End Class