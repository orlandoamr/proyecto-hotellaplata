'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Empleados
'   Formulario: frmActualizarSalidaEmpleados
'   Función: realizar registros la salida de un empleado en el registro diario
'----------------------------------------------------------------------------------------------------------------
Public Class frmActualizarSalidaEmpleado

    'Instancias de la clases de diarios y las funciones generales
    Private diario As New clsDiarioEmpleados()
    Private funciones As New clsFuncionesGenerales()

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmActualizarSalidaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se llena el grid y se ocultan los id para que no sean visibles por el usuario
        funciones.llenarDataGrid(dgvRegistros, queriesDiario("obtener2"))
        dgvRegistros.Rows("DiarioEmpleadoId").Visible = False
    End Sub

    'Evento que se ejecuta al guardar un registro
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Se valida que no existan campos vacíos
        If txtCodigo.Text = "" Then
            MsgCampoVacio("código del registro")

        Else
            'Se asignan los valores a las propiedades de la clase diario
            diario._diarioId = Val(txtCodigo.Text)
            diario._horaSalida = dtpHoraSalida.Value.ToString()

            'La variable res almacena los resultados que le retornó el método ejecutar
            Dim res = diario.actualizarSalida()
            If res(0) = False Then
                MsgError(res(1))

            Else
                MsgRegistroExitoso()
                limpiarCampos()
            End If
        End If
    End Sub


    'Método para limpiar todos los campos de la pantalla 
    Private Sub limpiarCampos()
        txtCodigo.Clear()
        funciones.llenarDataGrid(dgvRegistros, queriesDiario("obtener2"))
    End Sub

    'Evento que se ejecuta al hacer doble click en una fila del datagrid
    Private Sub dgvRegistros_DoubleClick(sender As Object, e As EventArgs) Handles dgvRegistros.DoubleClick
        txtCodigo.Text = dgvRegistros.CurrentRow.Cells(0).Value
    End Sub
    'Evento que se ejecuta al presionar el botón de limpiar
    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
    End Sub

    'Evento que se ejecuta al presionar el botón de cerrar ventana
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub
End Class