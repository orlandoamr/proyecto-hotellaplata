'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Productos
'   Formulario: frmProductos
'   Función: realizar registros de los productos para la venta
'-----------------------------------------------------------------------------------------------------------------
Public Class frmProductos
    Private funciones As New clsFuncionesGenerales()
    Private productos As New clsProductos()

    Private editar As Boolean = False
    Private Sub frmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvProductos, queriesProductos("obtener_todos"))
        dgvProductos.Columns("ProductoId").Visible = False
    End Sub
    Private Sub txtProducto_KeyPress(sender As Object, e As KeyPressEventArgs)
        soloLetras(e)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
        soloNumeros(e)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim textBoxes As New List(Of TextBox) From {txtNombre, txtPrecio}

        Dim validar = validarTextBoxVacios(textBoxes)

        If (Not validar(0)) Then
            MsgCampoVacio(validar(1))
        Else
            productos._nombreProducto = txtNombre.Text
            productos._precio = val(txtPrecio.Text)
            productos._estado = chkEstado.Checked

            If editar = True Then
                productos._productoId = txtCodigo.Text

                Dim res = productos.actualizar()

                If Not res(0) Then
                    MsgError(res(1))
                Else
                    MsgActualizacionExitosa()
                    limpiarCampos()
                End If

            Else
                Dim res = productos.insertar()

                If Not res(0) Then
                    MsgError(res(1))
                Else
                    MsgRegistroExitoso()
                    limpiarCampos()
                End If
            End If
            funciones.llenarDataGrid(dgvProductos, queriesProductos("obtener_todos"))
        End If

    End Sub

    Private Sub limpiarCampos()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
        chkEstado.Checked = False
        editar = False
    End Sub

    Private Sub dgvProductos_DoubleClick(sender As Object, e As EventArgs) Handles dgvProductos.DoubleClick
        txtCodigo.Text = dgvProductos.CurrentRow.Cells(0).Value
        txtNombre.Text = dgvProductos.CurrentRow.Cells(1).Value
        txtPrecio.Text = dgvProductos.CurrentRow.Cells(2).Value
        chkEstado.Checked = dgvProductos.CurrentRow.Cells(3).Value
        editar = True
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
        funciones.llenarDataGrid(dgvProductos, queriesProductos("obtener_todos"))
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub
    Private Sub txtPrecio_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        soloNumeros(e)
    End Sub
End Class