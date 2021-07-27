'Formulario para insertar, actualizar, buscar y eliminar los gastos relacionados a las ventas
Imports System.Data.SqlClient
Public Class frmGastosAdicionales
    Public idProducto As Integer
    Public precioProducto As Integer
    Public total As Integer

    Private gastos As New clsGastosAdicionales()
    Private Sub frmGastosAdicionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
        dgvRefresh(DgvGastosAdicionales, queriesGastos("obtener_gastos"), coneccion)
        CerrarConeccion()

        If obtenerAcceso() = 2 Then
            BtnActualizar.Enabled = False
            BtnEliminar.Enabled = False
        ElseIf obtenerAcceso() = 3 Then
            BtnActualizar.Enabled = False
            BtnEliminar.Enabled = False
            BtnGuardar.Enabled = False
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim textBoxes As New List(Of TextBox) From {TxtCodigoDetalleVenta, TxtProducto, TxtCantidad}

        If (Not validarTextBoxVacios(textBoxes)) Then
            MsgCamposVacios()
        Else
            gastos._idProducto = idProducto
            gastos._idDetalleVenta = Val(TxtCodigoDetalleVenta.Text)
            gastos._precioProducto = Val(txtPrecio.Text)
            gastos._cantidadProducto = Val(TxtCantidad.Text)
            gastos._totalGasto = Val(TxtTotal.Text)


            Conectar()
            gastos.insertarGasto(queriesGastos("insertar_gasto"), coneccion)
            dgvRefresh(DgvGastosAdicionales, queriesGastos("obtener_gastos"), coneccion)
            CerrarConeccion()
        End If
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Dim textBoxes As New List(Of TextBox) From {TxtCodigoDetalleVenta, TxtProducto, TxtCantidad, TxtCodigo}

        If (Not validarTextBoxVacios(textBoxes)) Then
            MsgCamposVacios()
        Else
            total = Val(TxtCantidad.Text) * Val(txtPrecio.Text)

            gastos._idGastoAdicional = Val(TxtCodigo.Text)
            gastos._idProducto = idProducto
            gastos._idDetalleVenta = Val(TxtCodigoDetalleVenta.Text)
            gastos._precioProducto = Val(txtPrecio.Text)
            gastos._cantidadProducto = Val(TxtCantidad.Text)
            gastos._totalGasto = total

            Conectar()
            gastos.insertarGasto(queriesGastos("actualizar_gasto"), coneccion)
            dgvRefresh(DgvGastosAdicionales, queriesGastos("obtener_gastos"), coneccion)
            CerrarConeccion()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If TxtCodigo.Text = "" Then
            MsgCodigoVacio()
        Else
            total = Val(TxtCantidad.Text) * Val(txtPrecio.Text)

            gastos._idGastoAdicional = Val(TxtCodigo.Text)
            gastos._idProducto = Val(TxtProducto.Text)
            gastos._idDetalleVenta = Val(TxtCodigoDetalleVenta.Text)
            gastos._precioProducto = Val(txtPrecio.Text)
            gastos._cantidadProducto = Val(TxtCantidad.Text)
            gastos._totalGasto = total

            Conectar()
            gastos.eliminarGasto(queriesGastos("eliminar_gasto"), coneccion)
            dgvRefresh(DgvGastosAdicionales, queriesGastos("obtener_gastos"), coneccion)
            CerrarConeccion()
        End If


    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If (txtBuscarCliente.Text = "") Then
            MsgIngreseId()
        Else
            Conectar()
            gastos.obtenerGasto(DgvGastosAdicionales, queriesGastos("obtener_gasto"), coneccion, txtBuscarCliente.Text)
            CerrarConeccion()
        End If

    End Sub
    Public Sub limpiarCampos()
        TxtCodigo.Clear()
        TxtCantidad.Clear()
        TxtCodigoDetalleVenta.Clear()
        TxtProducto.Clear()
        txtPrecio.Clear()
        TxtTotal.Clear()
    End Sub

    Private Sub btnBuscarVenta_Click(sender As Object, e As EventArgs) Handles btnBuscarVenta.Click
        frmBuscarDetallesVentas.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmProductos.Show()

    End Sub

    Private Sub DgvGastosAdicionales_DoubleClick(sender As Object, e As EventArgs) Handles DgvGastosAdicionales.DoubleClick
        Try
            TxtCodigo.Text = DgvGastosAdicionales.CurrentRow.Cells(0).Value
            TxtCodigoDetalleVenta.Text = DgvGastosAdicionales.CurrentRow.Cells(1).Value
            TxtProducto.Text = DgvGastosAdicionales.CurrentRow.Cells(4).Value
            TxtCantidad.Text = DgvGastosAdicionales.CurrentRow.Cells(6).Value
            txtPrecio.Text = DgvGastosAdicionales.CurrentRow.Cells(5).Value
            TxtTotal.Text = DgvGastosAdicionales.CurrentRow.Cells(7).Value
            idProducto = DgvGastosAdicionales.CurrentRow.Cells(3).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        TxtTotal.Text = Val(txtPrecio.Text) * Val(TxtCantidad.Text)
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        Conectar()
        dgvRefresh(DgvGastosAdicionales, queriesGastos("obtener_gastos"), coneccion)
        CerrarConeccion()
    End Sub
End Class