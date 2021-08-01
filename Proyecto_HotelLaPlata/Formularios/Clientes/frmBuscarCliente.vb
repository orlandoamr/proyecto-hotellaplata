'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Clientes
'   Formulario: frmBuscarCliente
'   Función: buscar clientes por  para obtener su id y realizar una venta
'----------------------------------------------------------------------------------------------------------------

Public Class frmBuscarCliente
    'Instancias de la clases de clientes y las funciones generales
    Private clientes As New clsClientes()
    Private funciones As New clsFuncionesGenerales()

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmBuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se llena el grid y se ocultan los id para que no sean visibles por el usuario
        funciones.llenarDataGrid(dgvVentas, queriesClientes("obtener_todos"))
        dgvVentas.Columns("DepartamentoId").Visible = False
        dgvVentas.Columns("PaisId").Visible = False
    End Sub

    'Evento que se ejecuta al presionar el botón de buscar cliente
    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        If txtParametro.Text = "" Then
            MsgError2("Ingrese un parámetro de busqueda", "Campo vacío")
        Else
            clientes._parametroBusqueda = txtParametro.Text
            clientes.BuscarCliente(dgvVentas, queriesClientes("buscar_parametro"))
        End If
    End Sub

    'Evento que se ejecuta al hacer doble click en una fila del datagrid
    Private Sub dgvClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgvVentas.DoubleClick
        'Se copia el id al formulario de ventas
        frmNuevaVenta.txtCodigoCliente.Text = dgvVentas.CurrentRow.Cells(2).Value

        'Se cierra el formulario
        Me.Close()
    End Sub


    'Evento para limpiar todos los campos de la pantalla 
    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        txtParametro.Clear()
        funciones.llenarDataGrid(dgvVentas, queriesClientes("obtener_todos"))
    End Sub
End Class