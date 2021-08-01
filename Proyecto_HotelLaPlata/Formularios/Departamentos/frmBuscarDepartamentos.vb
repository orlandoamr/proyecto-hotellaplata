'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Departamentos
'   Formulario: frmBuscarDepartamentos
'   Función: mostrar los departamentos de Honduras para que el usuario seleccione uno
'----------------------------------------------------------------------------------------------------------------
Public Class frmBuscarDepartamentos

    'Instancia de la clase funciones generales
    Private funciones As New clsFuncionesGenerales()

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmBuscarDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se llena el grid y se ocultan los id para que no sean visibles por el usuario
        funciones.llenarDataGrid(dgvDeptos, queriesDeptos("obtener"))
        dgvDeptos.Columns("DepartamentoId").Visible = False
    End Sub

    'Evento que se ejecuta al hacer doble click en una fila del datagrid
    Private Sub dgvDeptos_DoubleClick(sender As Object, e As EventArgs) Handles dgvDeptos.DoubleClick
        'Se copian todos el elemento al formulario de nuevo cliente
        frmNuevoCliente.txtProcedencia.Text = dgvDeptos.CurrentRow.Cells(1).Value
        frmNuevoCliente.idDeptO = dgvDeptos.CurrentRow.Cells(0).Value

        'Se cierra este formulario
        Me.Close()
    End Sub
End Class