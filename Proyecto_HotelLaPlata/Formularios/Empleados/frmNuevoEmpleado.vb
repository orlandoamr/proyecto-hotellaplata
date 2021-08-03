'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Empleados
'   Formulario: frmNuevoEmpleado
'   Función: realizar registros de nuevos empleados y actualizar existentes
'-----------------------------------------------------------------------------------------------------------------
Public Class frmNuevoEmpleado
    'Variables globales
    Public cargoId As Integer 'Almacena el id del cargo
    Private editar As Boolean = False 'Variable para identificar si el usuario está editando un registro

    'Instancias de la clases de empleados, cargos y las funciones generales
    Private empleados As New clsEmpleados()
    Private funciones As New clsFuncionesGenerales()
    Public cargos As New clsCargos()

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmNuevoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se llena el grid y se ocultan los id para que no sean visibles por el usuario
        funciones.llenarDataGrid(dgvEmpleados, queriesEmpleados("obtener"))
        dgvEmpleados.Columns("FKCargoId").Visible = False

        'Se cargan los registros de cargos as combobox
        cargos.obtenerCargos(cmbCargos)
        cmbCargos.SelectedIndex = 0

    End Sub

    'Evento que se ejecuta al guardar un registro
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Se valida que no existan campos vacíos
        Dim textBoxes As New List(Of TextBox) From {txtNombre, txtApellido, txtIdentidad, txtCorreo, txtNumero}
        Dim val = validarTextBoxVacios(textBoxes)

        'En caso de existir un campo vacío se muestra el campo
        If Not val(0) Then
            MsgCampoVacio(val(1))

            'Se valida el numéro de identidad
        ElseIf Not validarIdentidad(txtIdentidad.Text) Then
            MsgIdentidadInvalida()

            'Se valida el numéro de teléfono
        ElseIf Not validarTelefono(txtNumero.Text) Or Not txtNumero.Text.Length = 8 Then
            MsgNumeroInvalido()

            'Se valida el correo
        ElseIf Not ValidEmail(txtCorreo.Text) Then
            MsgCorreoInvalido()

        Else
            'Se asignan las propiedades de la clase
            empleados._empleadoId = txtIdentidad.Text
            empleados._nombre = txtNombre.Text
            empleados._apellido = txtApellido.Text
            empleados._numeroTelefono = txtNumero.Text
            empleados._correoElectronico = txtCorreo.Text
            empleados._cargoId = cmbCargos.SelectedValue

            'Si editar es true se realizará un actualización
            'La variable res almacena los resultados que le retornó el método guardar
            If editar = True Then
                Dim res = empleados.guardar(queriesEmpleados("actualizar"))

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgRegistroExitoso()
                    limpiarCampos()

                End If

                'Si editar es false se realizará una nueva inserción
            Else
                Dim res = empleados.guardar(queriesEmpleados("insertar"))

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgActualizacionExitosa()
                    limpiarCampos()
                End If

            End If
        End If
    End Sub

    'Método para limpiar todos los campos de la pantalla 
    Private Sub limpiarCampos()
        txtIdentidad.Clear()
        txtNombre.Clear()
        txtNumero.Clear()
        txtCorreo.Clear()
        txtApellido.Clear()
        funciones.llenarDataGrid(dgvEmpleados, queriesEmpleados("obtener"))

        'Se desactiva el modo edición
        editar = False
    End Sub

    'Evento que se ejecuta al hacer doble click en una fila del datagrid
    Private Sub dgvEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles dgvEmpleados.DoubleClick
        'Se copian todos los elementos de la fila a los textbox
        txtNombre.Text = dgvEmpleados.CurrentRow.Cells(0).Value
        txtApellido.Text = dgvEmpleados.CurrentRow.Cells(1).Value
        txtIdentidad.Text = dgvEmpleados.CurrentRow.Cells(2).Value
        txtNumero.Text = dgvEmpleados.CurrentRow.Cells(3).Value
        txtCorreo.Text = dgvEmpleados.CurrentRow.Cells(4).Value

        'Se activa el modo de edición
        editar = True
    End Sub

    'Evento que se ejecuta al presionar el botón de limpiar
    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
    End Sub

    'Evento que se ejecuta al presionar el botón de agregar cargo
    Private Sub btnBuscarCargo_Click(sender As Object, e As EventArgs) Handles btnBuscarCargo.Click
        frmCargos.Show()
    End Sub

    'Evento que se ejecuta al presionar el botón de cerrar ventana
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub
End Class