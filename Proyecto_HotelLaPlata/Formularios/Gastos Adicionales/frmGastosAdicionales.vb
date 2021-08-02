'Formulario para insertar, actualizar, buscar y eliminar los gastos relacionados a las ventas
Imports System.Data.SqlClient
Public Class frmGastosAdicionales
    Public idProducto As Integer
    Public total As Integer

    Private gastos As New clsGastosAdicionales()
    Private funciones As New clsFuncionesGenerales()
    Private Sub frmGastosAdicionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvGastosAdicionales, queriesGastos("obtener_gastos"))
        txtCodigoVenta.Text = ""
    End Sub
    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim textBoxes As New List(Of TextBox) From {txtCodigoVenta, TxtProducto, TxtCantidad}

        Dim validar = validarTextBoxVacios(textBoxes)

        If (Not validar(0)) Then
            MsgCampoVacio(validar(1))

        Else
            gastos._ventaId = Val(txtCodigoVenta.Text)
            gastos._productoId = idProducto
            gastos._cantidadProducto = Val(TxtCantidad.Text)
            gastos._totalGasto = Val(TxtTotal.Text)

            Dim res = gastos.insertar()

            If Not res(0) Then
                MsgError(res(1))

            Else
                MsgRegistroExitoso()
                limpiarCampos()
            End If
        End If
    End Sub

    Public Sub limpiarCampos()
        txtCodigo.Clear()
        TxtCantidad.Clear()
        txtCodigoVenta.Clear()
        TxtProducto.Clear()
        txtPrecio.Clear()
        TxtTotal.Clear()
        funciones.llenarDataGrid(dgvGastosAdicionales, queriesGastos("obtener_gastos"))
    End Sub

    Private Sub btnBuscarVenta_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub DgvGastosAdicionales_DoubleClick(sender As Object, e As EventArgs)
        Try
            txtCodigo.Text = dgvGastosAdicionales.CurrentRow.Cells(0).Value
            txtCodigoVenta.Text = dgvGastosAdicionales.CurrentRow.Cells(1).Value
            TxtProducto.Text = dgvGastosAdicionales.CurrentRow.Cells(4).Value
            TxtCantidad.Text = dgvGastosAdicionales.CurrentRow.Cells(6).Value
            txtPrecio.Text = dgvGastosAdicionales.CurrentRow.Cells(5).Value
            TxtTotal.Text = dgvGastosAdicionales.CurrentRow.Cells(7).Value
            idProducto = dgvGastosAdicionales.CurrentRow.Cells(3).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        TxtTotal.Text = Val(txtPrecio.Text) * Val(TxtCantidad.Text)
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        soloNumeros(e)
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

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
    End Sub
End Class