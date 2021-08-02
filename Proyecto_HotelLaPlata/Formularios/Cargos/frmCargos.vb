'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Cargos
'   Formulario: frmCargos
'   Función: realizar registros de nuevos cargos de los empleados
'----------------------------------------------------------------------------------------------------------------
Public Class frmCargos
    'Variables globales
    Public cargoId As Integer ' Almacena el id de los departamentos
    Private editar As Boolean = False 'Variable para identificar si el usuario está editando un registro

    'Instancias de la clases de cargos y las funciones generales
    Private cargos As New clsCargos()
    Private funciones As New clsFuncionesGenerales()

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se llena el grid y se ocultan los id para que no sean visibles por el usuario
        funciones.llenarDataGrid(dgvCargos, queriesCargos("obtener"))
        dgvCargos.Columns("CargoId").Visible = False
    End Sub

    'Evento que se ejecuta al guardar un registro
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Se valida que no existan campos vacíos
        If txtCargo.Text = "" Then
            MsgCampoVacio("descripción del cargo")
        Else

            'Si editar es true se realizará un actualización
            'La variable res almacena los resultados que le retornó el método ejecutar

            cargos._cargoDescripcion = txtCargo.Text

            If editar = True Then
                cargos._cargoId = cargoId
                Dim res = cargos.actualizar()

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgRegistroExitoso()
                    limpiarCampos()

                End If

                'Si editar es false se realizará una nueva inserción
            Else
                Dim res = cargos.insertar()

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgActualizacionExitosa()
                    limpiarCampos()
                End If

            End If
            frmNuevoEmpleado.cargos.obtenerCargos(frmNuevoEmpleado.cmbCargos)
        End If
    End Sub


    'Método para limpiar todos los campos de la pantalla 
    Private Sub limpiarCampos()
        funciones.llenarDataGrid(dgvCargos, queriesCargos("obtener"))
        txtCargo.Clear()
        'Se desactiva el modo edición
        editar = False

    End Sub

    'Evento que se ejecuta al hacer doble click en una fila del datagrid
    Private Sub dgvCargos_DoubleClick(sender As Object, e As EventArgs) Handles dgvCargos.DoubleClick
        'Se copian todos los elemntos de la fila a los textbox
        txtCargo.Text = dgvCargos.CurrentRow.Cells(1).Value
        cargoId = dgvCargos.CurrentRow.Cells(0).Value

        'Se activa el modo de edición
        editar = True
    End Sub

    'Evento que se ejecuta al presionar el botón de limpiar
    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
    End Sub

    'Evento que se ejecuta al escribir el textbox de Cargo
    Private Sub txtCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCargo.KeyPress
        soloLetrasyEspacios(e)
    End Sub
End Class