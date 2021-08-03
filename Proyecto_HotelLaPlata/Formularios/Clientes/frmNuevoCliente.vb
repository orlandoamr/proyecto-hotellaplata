'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Clientes
'   Formulario: frmNuevoCliente
'   Función: realizar registros de nuevos clientes y actualizar existentes
'-----------------------------------------------------------------------------------------------------------------
Public Class frmNuevoCliente
    'Variables globales
    Public idDeptO As Integer  ' Almacena el id de los departamentos
    Public idPais As Integer = 76 'Almacena el id de los paises, por defecto 76 que es el id de Honduras
    Private editar As Boolean = False 'Variable para identificar si el usuario está editando un registro

    'Instancias de la clases de clientes y las funciones generales
    Private clientes As New clsClientes()
    Private funciones As New clsFuncionesGenerales()

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se llena el grid y se ocultan los id para que no sean visibles por el usuario
        funciones.llenarDataGrid(dgvClientes, queriesClientes("obtener_todos"))
        dgvClientes.Columns("DepartamentoId").Visible = False
        dgvClientes.Columns("PaisId").Visible = False

    End Sub

    'Evento que se ejecuta al guardar un registro
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Se valida que no existan campos vacíos
        Dim textBoxes As New List(Of TextBox) From {txtNombre, txtApellido, txtIdentidad, txtPais}
        Dim val = validarTextBoxVacios(textBoxes)

        'En caso de existir un campo vacío se muestra el campo
        If Not val(0) Then
            MsgCampoVacio(val(1))

            'Se valida si es Hondureño y no ha seleccionado un departamento de procedencia
        ElseIf txtProcedencia.Text = "" And Not chkExtranjero.Checked Then
            MsgDepartamento()

            'Se valida si la identidad cumple el formato básico hondureño
        ElseIf Not chkExtranjero.Checked And Not validarIdentidad(txtIdentidad.Text) Then
            MsgIdentidadInvalida()

        Else
            'Se asignan los valores a las propiedades de la clase clientes
            clientes._clienteId = txtIdentidad.Text
            clientes._nombre = txtNombre.Text
            clientes._apellido = txtApellido.Text
            clientes._esExtranjero = chkExtranjero.Checked
            clientes._departamento = idDeptO
            clientes._pais = idPais

            'Si editar es true se realizará un actualización

            'La variable res almacena los resultados que le retornó el método guardar
            If editar = True Then

                Dim res = clientes.guardar(queriesClientes("actualizar"))

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgRegistroExitoso()
                    LimpiarCampos()

                End If

                'Si editar es false se realizará una nueva inserción
            Else
                Dim res = clientes.guardar(queriesClientes("insertar"))

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgActualizacionExitosa()
                    LimpiarCampos()
                End If

            End If
        End If
    End Sub

    'Evento que se ejecuta al buscar un registro
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Se valida que el campo para el parámetro no está vacío
        If (txtBuscarCliente.Text = "") Then

        Else
            'Se llena el grid con el resultado de la busqueda.
            clientes._parametroBusqueda = txtBuscarCliente.Text
            clientes.BuscarCliente(dgvClientes, queriesClientes("obtener_por_parametro"))
        End If

    End Sub

    'Evento que se ejecuta al cambiar el estado del checkbox de extranjero
    Private Sub chkExtranjero_CheckedChanged(sender As Object, e As EventArgs) Handles chkExtranjero.CheckedChanged
        'Si está marcado preparamos la pantalla para ingresar un extranjero
        If (chkExtranjero.Checked = True) Then
            btnBuscarPais.Enabled = True
            btnBuscarDepto.Enabled = False
            idDeptO = 20 ' id en caso de extranjero
            txtPais.Clear()
            txtProcedencia.Clear()
            'Si se desmarca preparamos la pantalla para ingresar un hondureño
        Else
            txtPais.Clear()
            txtPais.Text = "Honduras"
            idPais = 76
            btnBuscarPais.Enabled = False
            btnBuscarDepto.Enabled = True
        End If

    End Sub

    'Evento que se ejecuta al hacer doble click en una fila del datagrid
    Private Sub dgvClientes_DoubleClick_1(sender As Object, e As EventArgs) Handles dgvClientes.DoubleClick
        'Se copian todos los elementos de la fila a los textbox
        txtIdentidad.Text = dgvClientes.CurrentRow.Cells(2).Value
        txtNombre.Text = dgvClientes.CurrentRow.Cells(0).Value
        txtApellido.Text = dgvClientes.CurrentRow.Cells(1).Value
        chkExtranjero.Checked = dgvClientes.CurrentRow.Cells(3).Value
        txtProcedencia.Text = dgvClientes.CurrentRow.Cells(4).Value
        txtPais.Text = dgvClientes.CurrentRow.Cells(5).Value
        idDeptO = dgvClientes.CurrentRow.Cells(6).Value
        idPais = dgvClientes.CurrentRow.Cells(7).Value

        'Se activa el modo de edición
        editar = True
    End Sub

    'Evento que se ejecuta al presionar el botón de buscar país
    Private Sub btnBuscarPais_Click(sender As Object, e As EventArgs) Handles btnBuscarPais.Click
        frmBuscarPais.Show()
    End Sub

    'Método para limpiar todos los campos de la pantalla 
    Public Sub LimpiarCampos()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtIdentidad.Text = ""
        txtProcedencia.Text = ""
        txtBuscarCliente.Text = ""
        chkExtranjero.Checked = False
        funciones.llenarDataGrid(dgvClientes, queriesClientes("obtener_todos"))

        'Se desactiva el modo edición 
        editar = False
    End Sub

    'Evento que se ejecuta al escribir el textbox de Nombre
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        'Solo admite letras y sin espacios
        soloLetras(e)
    End Sub

    'Evento que se ejecuta al escribir el textbox de Apellido
    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        soloLetras(e)
    End Sub

    'Evento que se ejecuta al escribir el textbox de Identidad
    Private Sub txtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentidad.KeyPress
        'Solo admite números y letras en caso de ser extranjero
        soloNumerosLetras(e)
    End Sub

    'Evento que se ejecuta al presionar el botón de limpiar
    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        LimpiarCampos()
    End Sub

    'Evento que se ejecuta al presionar el botón de buscar departamento
    Private Sub btnBuscarDepto_Click(sender As Object, e As EventArgs) Handles btnBuscarDepto.Click
        frmBuscarDepartamentos.Show()
    End Sub

    'Evento que se ejecuta al presionar el botón de cerrar ventana
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub
End Class