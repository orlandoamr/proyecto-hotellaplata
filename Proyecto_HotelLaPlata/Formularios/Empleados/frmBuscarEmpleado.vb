'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Empleados
'   Formulario: frmBuscarEmpleado
'   Función: buscar los empleados registrados en la base de datos
'-----------------------------------------------------------------------------------------------------------------
Public Class frmBuscarEmpleado
    'Instancias de la clases de clientes y las funciones generales
    Private funciones As New clsFuncionesGenerales()

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmBuscarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvEmpleados, queriesEmpleados("obtener"))
    End Sub

    'Evento que se ejecuta al hacer doble click en una fila del datagrid
    Private Sub dgvEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles dgvEmpleados.DoubleClick
        frmRegistroDiario.txtEmpleado.Text = dgvEmpleados.CurrentRow.Cells(2).Value
        frmControlUsuarios.txtCodigoEmpleado.Text = dgvEmpleados.CurrentRow.Cells(2).Value
        frmReporteEmpleados.txtCodigo.Text = dgvEmpleados.CurrentRow.Cells(2).Value
        Me.Close()
    End Sub
End Class