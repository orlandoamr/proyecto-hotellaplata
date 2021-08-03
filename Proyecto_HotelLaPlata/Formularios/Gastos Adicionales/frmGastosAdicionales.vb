'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Gastos Adicionales
'   Formulario: frmGastosAdicionales
'   Función: realizar registros de los gastos adicionales de los clientes
'-----------------------------------------------------------------------------------------------------------------
Public Class frmGastosAdicionales
    'Variables globales
    Public idProducto As Integer ' Almacena el id de los productos

    'Instancias de la clases de gastos y las funciones generales
    Private gastos As New clsGastosAdicionales()
    Private funciones As New clsFuncionesGenerales()

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmGastosAdicionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se llena el grid
        funciones.llenarDataGrid(dgvGastosAdicionales, queriesGastos("obtener_gastos"))
        txtCodigoVenta.Text = ""
    End Sub


    'Evento que se ejecuta al guardar un registro
    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Se valida que no existan campos vacíos
        Dim textBoxes As New List(Of TextBox) From {txtCodigoVenta, TxtProducto, TxtCantidad}

        Dim validar = validarTextBoxVacios(textBoxes)

        'En caso de existir un campo vacío se muestra el campo
        If (Not validar(0)) Then
            MsgCampoVacio(validar(1))

        Else
            'Se asignan los valores a las propiedades de la clase gastos
            gastos._ventaId = Val(txtCodigoVenta.Text)
            gastos._productoId = idProducto
            gastos._cantidadProducto = Val(TxtCantidad.Text)
            gastos._totalGasto = Val(TxtTotal.Text)

            'La variable res almacena los resultados que le retornó el método guardar
            Dim res = gastos.insertar()

            If Not res(0) Then
                MsgError(res(1))

            Else
                MsgRegistroExitoso()
                limpiarCampos()
            End If
        End If
    End Sub


    'Método para limpiar todos los campos de la pantalla 
    Public Sub limpiarCampos()
        txtCodigo.Clear()
        TxtCantidad.Clear()
        txtCodigoVenta.Clear()
        TxtProducto.Clear()
        txtPrecio.Clear()
        TxtTotal.Clear()
        funciones.llenarDataGrid(dgvGastosAdicionales, queriesGastos("obtener_gastos"))
    End Sub
    'Evento que se ejecuta al cambiar el valor del textbox cantidad
    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        TxtTotal.Text = Val(txtPrecio.Text) * Val(TxtCantidad.Text)
    End Sub

    'Evento que se ejecuta al escribir el textbox de Nombre
    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        soloNumeros(e)
    End Sub

    'Evento que se ejecuta al presionar el botón de buscar buscar venta
    Private Sub btnBuscarVent_Click(sender As Object, e As EventArgs) Handles btnBuscarVent.Click
        frmBuscarVenta.Show()
    End Sub

    'Evento que se ejecuta al presionar el botón de limpiar campos
    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
    End Sub

    'Evento que se ejecuta al presionar el botón de buscar productos
    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        frmBuscarProducto.Show()
    End Sub

    'Evento que se ejecuta al presionar el botón de cerrar ventana
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub
End Class