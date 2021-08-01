'Formulario para insertar, actualizar, buscar y eliminar los gastos relacionados a las ventas
Imports System.Data.SqlClient
Public Class frmGastosAdicionales
    Public idProducto As Integer
    'Public precioProducto As Integer
    Public total As Integer

    Private gastos As New clsGastosAdicionales()
    Private funciones As New clsFuncionesGenerales()
    Private Sub frmGastosAdicionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvGastosAdicionales, queriesGastos("obtener_gastos"))
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim textBoxes As New List(Of TextBox) From {txtCodigoVenta, TxtProducto, TxtCantidad}

        If (Not validarTextBoxVacios(textBoxes)) Then
            MsgCamposVacios()
        Else

        End If
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click

        Dim textBoxes As New List(Of TextBox) From {txtCodigoVenta, TxtProducto, TxtCantidad, txtCodigo}

        If (Not validarTextBoxVacios(textBoxes)) Then
            MsgCamposVacios()
        Else
            total = Val(TxtCantidad.Text) * Val(txtPrecio.Text)

            gastos._idGastoAdicional = Val(txtCodigo.Text)
            gastos._idProducto = idProducto
            gastos._idDetalleVenta = Val(txtCodigoVenta.Text)
            gastos._precioProducto = Val(txtPrecio.Text)
            gastos._cantidadProducto = Val(TxtCantidad.Text)
            gastos._totalGasto = total

        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        If txtCodigo.Text = "" Then
            MsgCodigoVacio()
        Else
            total = Val(TxtCantidad.Text) * Val(txtPrecio.Text)

            gastos._idGastoAdicional = Val(txtCodigo.Text)
            gastos._idProducto = Val(TxtProducto.Text)
            gastos._idDetalleVenta = Val(txtCodigoVenta.Text)
            gastos._precioProducto = Val(txtPrecio.Text)
            gastos._cantidadProducto = Val(TxtCantidad.Text)
            gastos._totalGasto = total

            Conectar()
            gastos.eliminarGasto(queriesGastos("eliminar_gasto"), coneccion)
            dgvRefresh(DgvGastosAdicionales, queriesGastos("obtener_gastos"), coneccion)
            CerrarConeccion()
        End If


    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs)
        'If (txtBuscarCliente.Text = "") Then
        '    MsgIngreseId()
        'Else
        '    Conectar()
        '    gastos.obtenerGasto(DgvGastosAdicionales, queriesGastos("obtener_gasto"), coneccion, txtBuscarCliente.Text)
        '    CerrarConeccion()
        'End If

    End Sub
    Public Sub limpiarCampos()
        txtCodigo.Clear()
        TxtCantidad.Clear()
        txtCodigoVenta.Clear()
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

    Private Sub DgvGastosAdicionales_DoubleClick(sender As Object, e As EventArgs)
        Try
            txtCodigo.Text = DgvGastosAdicionales.CurrentRow.Cells(0).Value
            txtCodigoVenta.Text = DgvGastosAdicionales.CurrentRow.Cells(1).Value
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

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs)
        Conectar()
        dgvRefresh(DgvGastosAdicionales, queriesGastos("obtener_gastos"), coneccion)
        CerrarConeccion()
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        frmBuscarProducto.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarVent_Click(sender As Object, e As EventArgs) Handles btnBuscarVent.Click
        frmBuscarVenta.Show()
    End Sub
End Class