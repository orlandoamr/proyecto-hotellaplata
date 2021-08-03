'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Empleados
'   Formulario: frmRegistroDiario
'   Función: realizar registros de nuevos empleados y actualizar existentes
'-----------------------------------------------------------------------------------------------------------------
Public Class frmRegistroDiario

    'Instancias de la clases de diario y las funciones generales
    Private diario As New clsDiarioEmpleados()
    Private funciones As New clsFuncionesGenerales()

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmRegistroDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se llena el grid
        funciones.llenarDataGrid(dgvDiarioEmpleados, queriesDiario("obtener"))
        dtpFecha.MaxDate = System.DateTime.Now
    End Sub

    'Evento que se ejecuta al guardar un registro
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Se valida que no existan campos vacíos
        Dim textBoxes As New List(Of TextBox) From {txtEmpleado, txtObservacion}
        Dim val = validarTextBoxVacios(textBoxes)

        'En caso de existir un campo vacío se muestra el campo
        If Not val(0) Then
            MsgCampoVacio(val(1))

        Else
            'Se asignan los valores a las propiedades de la clase diario
            diario._fecha = dtpFecha.Value
            diario._horaEntrada = dtpEntrada.Value.ToString()
            diario._observacion = txtObservacion.Text
            diario._empleadoId = txtEmpleado.Text

            Dim res = diario.insertar()

            'La variable res almacena los resultados que le retornó el método insertar
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
        txtEmpleado.Clear()
        txtObservacion.Clear()
        funciones.llenarDataGrid(dgvDiarioEmpleados, queriesDiario("obtener"))
    End Sub

    'Evento que se ejecuta al presionar el botón de buscar empleado
    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        frmBuscarEmpleado.Show()
    End Sub

    'Evento que se ejecuta al presionar el botón de cerrar ventana
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub
End Class