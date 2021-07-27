'Formulario para visualización de las ventas usando diferentes filtros
Imports System.Data.SqlClient
Public Class frmVerDetallesVentas
    Private Sub frmVerDetallesVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
        dgvRefresh(dgvDetalleVentas, queriesVentas("obtener_ventas"), coneccion)
        CerrarConeccion()

        cmbFiltro.SelectedIndex = 0
        dtpFecha.MaxDate = System.DateTime.Now

    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Conectar()
        Select Case cmbFiltro.SelectedItem.ToString
            Case "Año"
                dgvFill(dgvDetalleVentas, queriesVentas("obtener_ventas_anio"), coneccion, dtpFecha.Value.Year, "@Anio")

            Case "Mes"
                dgvFill2(dgvDetalleVentas, queriesVentas("obtener_ventas_mes"), coneccion, dtpFecha.Value.Year, dtpFecha.Value.Month, "@Anio", "@Mes")

            Case "Día"
                Dim fecha = dtpFecha.Value.ToShortDateString()
                dgvFill(dgvDetalleVentas, queriesVentas("obtener_ventas_dia"), coneccion, fecha, "@FechaEntrada")

            Case "Número de Identidad Cliente"
                If (txtParametro.Text = "") Then
                    MsgIngreseParametro()
                Else
                    dgvFill(dgvDetalleVentas, queriesVentas("obtener_ventas_cliente"), coneccion, txtParametro.Text, "@ClienteId")
                End If
        End Select
        CerrarConeccion()


    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged
        If (cmbFiltro.SelectedItem.ToString = "Año") Then
            dtpFecha.Enabled = True
            dtpFecha.Format = DateTimePickerFormat.Custom
            dtpFecha.CustomFormat = "yyyy"
            dtpFecha.ShowUpDown = True
            txtParametro.Enabled = False
        ElseIf cmbFiltro.SelectedItem.ToString = "Mes" Then
            dtpFecha.Enabled = True
            dtpFecha.Format = DateTimePickerFormat.Custom
            dtpFecha.CustomFormat = "MM"
            dtpFecha.ShowUpDown = True
            txtParametro.Enabled = False
        ElseIf cmbFiltro.SelectedItem.ToString = "Día" Then
            dtpFecha.Enabled = True
            dtpFecha.Format = DateTimePickerFormat.Custom
            dtpFecha.CustomFormat = "dd MM yyyy"
            dtpFecha.ShowUpDown = False
            txtParametro.Enabled = False
        Else
            txtParametro.Enabled = True
            dtpFecha.Enabled = False
        End If

    End Sub

    Private Sub dgvDetalleVentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleVentas.CellDoubleClick
        frmGastosAdicionales.TxtCodigoDetalleVenta.Text = dgvDetalleVentas.CurrentRow.Cells(4).Value
    End Sub
End Class