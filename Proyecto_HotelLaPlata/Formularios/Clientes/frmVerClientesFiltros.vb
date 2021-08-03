'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Clientes
'   Formulario: frmVerClientesFiltros
'   Función: buscar clientes por diferentes parámetros
'----------------------------------------------------------------------------------------------------------------

Public Class frmVerClientesFiltros
    'Instancias de la clases de clientes y las funciones generales
    Private clientes As New clsClientes()
    Private funciones As New clsFuncionesGenerales()

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmVerClientesFiltros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se llena el grid y se ocultan los id para que no sean visibles por el usuario
        funciones.llenarDataGrid(dgvClientes, queriesClientes("obtener_todos"))
        dgvClientes.Columns("DepartamentoId").Visible = False
        dgvClientes.Columns("PaisId").Visible = False
    End Sub

    'Evento que se ejecuta al presionar el botón de buscar cliente
    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        If txtParametro.Text = "" Then
            MsgIngreseParametro()
        Else
            clientes._parametroBusqueda = txtParametro.Text
            clientes.BuscarCliente(dgvClientes, queriesClientes("buscar_parametro"))
        End If

    End Sub

    'Evento que se ejecuta al presionar el botón de cerrar ventana
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub

    'Evento para limpiar todos los campos de la pantalla 
    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        txtParametro.Clear()
        funciones.llenarDataGrid(dgvClientes, queriesClientes("obtener_todos"))
    End Sub
End Class