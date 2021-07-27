Imports System.Data.SqlClient
Public Class frmDetalleVentas

    Private habId As Integer
    Private detalleVentas As New clsDetalleVentas()
    Private habitaciones As New clsHabitaciones()

    Private Sub frmDetalleVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If obtenerAcceso() = 2 Then
            btnActualizarVenta.Enabled = False
            btnEliminarVenta.Enabled = False
        ElseIf obtenerAcceso() = 3 Then
            btnActualizarVenta.Enabled = False
            btnEliminarVenta.Enabled = False
            btnActualizarVenta.Enabled = False
            btnRegistrarVenta.Enabled = False
            btnActualizarSalida.Enabled = False
        End If

        dtpHoraEntrada.MaxDate = System.DateTime.Now
        dtpHoraSalida.MinDate = System.DateTime.Now

        Conectar()
        dgvRefresh(dgvVentas, queriesVentas("obtener_ventas"), coneccion)
        cmbFill(cmbhabitacion, queriesHabitaciones("obtener_disponibles"), coneccion, "HabitacionId", "HabitacionId")
        cmbFill(cmbatn, queriesEmpleados("obtener_recepcionistas"), coneccion, "Nombre", "EmpleadoId")
        CerrarConeccion()
    End Sub
    Private Sub btnRegistrarVenta_Click_1(sender As Object, e As EventArgs) Handles btnRegistrarVenta.Click
        Dim textBoxes As New List(Of TextBox) From {txtCodigoCliente, txtCostoTotalHab}

        If (Not validarTextBoxVacios(textBoxes)) Then
            MsgCamposVacios()
        Else
            Conectar()
            detalleVentas._clienteId = Val(txtCodigoCliente.Text)
            detalleVentas._habitacionAsignada = Val(cmbhabitacion.SelectedValue.ToString())
            detalleVentas._costoHabitacion = Val(txtCostoTotalHab.Text)
            detalleVentas._fechaEntrada = dtpHoraEntrada.Value
            detalleVentas._observacion = txtobservacion.Text
            detalleVentas._empleadoId = Val(cmbatn.SelectedValue.ToString())

            detalleVentas.insertarVenta(queriesVentas("insertar_venta"), coneccion)

            habitaciones._numeroHabitacion = Val(cmbhabitacion.SelectedValue.ToString())
            habitaciones._estadoHabitacion = False

            habitaciones.actualizarEstado(queriesHabitaciones("actualizar_estado"), coneccion)
            cmbFill(cmbhabitacion, queriesHabitaciones("obtener_disponibles"), coneccion, "HabitacionId", "HabitacionId")
            dgvRefresh(dgvVentas, queriesVentas("obtener_ventas"), coneccion)
            CerrarConeccion()
        End If
    End Sub
    Private Sub btnActualizarVenta_Click(sender As Object, e As EventArgs) Handles btnActualizarVenta.Click
        Dim textBoxes As New List(Of TextBox) From {txtcodigoventa, txtCodigoCliente, txtCostoTotalHab}
        Dim todoCorrecto As Boolean = True
        If (Not validarTextBoxVacios(textBoxes)) Then
            MsgCamposVacios()
        Else
            detalleVentas._ventaId = Val(txtcodigoventa.Text)
            detalleVentas._clienteId = Val(txtCodigoCliente.Text)
            detalleVentas._habitacionAsignada = Val(cmbhabitacion.SelectedValue.ToString())
            detalleVentas._costoHabitacion = txtCostoTotalHab.Text
            detalleVentas._fechaEntrada = dtpHoraEntrada.Value
            detalleVentas._observacion = txtobservacion.Text
            detalleVentas._empleadoId = Val(cmbatn.SelectedValue.ToString())
            Conectar()
            detalleVentas.insertarVenta(queriesVentas("actualizar_venta"), coneccion)
            cmbFill(cmbhabitacion, queriesHabitaciones("obtener_disponibles"), coneccion, "HabitacionId", "HabitacionId")
            dgvRefresh(dgvVentas, queriesVentas("obtener_ventas"), coneccion)
            CerrarConeccion()
        End If
    End Sub

    Private Sub btnEliminarVenta_Click(sender As Object, e As EventArgs) Handles btnEliminarVenta.Click
        If txtcodigoventa.Text = "" Then
            MsgCodigoVacio()
        Else
            detalleVentas._ventaId = Val(txtcodigoventa.Text)

            Conectar()
            detalleVentas.eliminarVenta(queriesVentas("eliminar_venta"), coneccion)
            cmbFill(cmbhabitacion, queriesHabitaciones("obtener_disponibles"), coneccion, "HabitacionId", "HabitacionId")
            dgvRefresh(dgvVentas, queriesVentas("obtener_ventas"), coneccion)
            CerrarConeccion()
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim idCliente As String = txtBuscarCliente.Text

        If (idCliente = "") Then
            MsgIngreseId()
        Else
            Conectar()
            detalleVentas.BuscarIdCliente(dgvVentas, queriesVentas("obtener_venta_cliente"), coneccion, idCliente)
            CerrarConeccion()
        End If

    End Sub
    Public Sub limpiarCampos()
        txtBuscarCliente.Clear()
        txtCodigoCliente.Clear()
        txtobservacion.Clear()
        txtcodigoventa.Clear()
        txtCostoTotalHab.Clear()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        frmBuscarCliente.Show()
    End Sub

    Private Sub btnActualizarSalida_Click(sender As Object, e As EventArgs) Handles btnActualizarSalida.Click
        If (txtcodigoventa.Text = "") Then
            MsgCodigoVacio()
        Else
            Conectar()
            detalleVentas._ventaId = Val(txtcodigoventa.Text)
            detalleVentas._fechaSalida = dtpHoraSalida.Value

            detalleVentas.actualizarSalida(queriesVentas("actualizar_salida"), coneccion)

            habitaciones._numeroHabitacion = habId
            habitaciones._estadoHabitacion = True
            habitaciones.actualizarEstado(queriesHabitaciones("actualizar_estado"), coneccion)
            cmbFill(cmbhabitacion, queriesHabitaciones("obtener_disponibles"), coneccion, "HabitacionId", "HabitacionId")
            CerrarConeccion()

        End If
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs)
        Conectar()
        dgvRefresh(dgvVentas, queriesVentas("obtener_ventas"), coneccion)
        CerrarConeccion()
    End Sub

    Private Sub txtBuscarCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarCliente.KeyPress
        soloLetras(e)
    End Sub

    Private Sub dgvVentas_DoubleClick(sender As Object, e As EventArgs) Handles dgvVentas.DoubleClick
        Try
            txtcodigoventa.Text = dgvVentas.CurrentRow.Cells(0).Value
            habId = dgvVentas.CurrentRow.Cells(3).Value
            txtCodigoCliente.Text = dgvVentas.CurrentRow.Cells(1).Value
            txtCostoTotalHab.Text = dgvVentas.CurrentRow.Cells(4).Value
            txtobservacion.Text = dgvVentas.CurrentRow.Cells(8).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmbhabitacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbhabitacion.KeyPress
        soloNumeros(e)

    End Sub

    Private Sub txtCostoTotalHab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoTotalHab.KeyPress
        soloNumeros(e)

    End Sub

    Private Sub cmbatn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbatn.KeyPress
        soloLetras(e)

    End Sub
    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            'Me.HabitacionesTableAdapter.FillBy(Me.Proyecto_hotelDataSet.Habitaciones)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            'Me.HabitacionesTableAdapter.FillBy(Me.Proyecto_hotelDataSet.Habitaciones)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarCampos()
    End Sub

    Private Sub btnRefrescar_Click_1(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        Conectar()
        dgvRefresh(dgvVentas, queriesVentas("obtener_ventas"), coneccion)
        CerrarConeccion()
    End Sub
End Class