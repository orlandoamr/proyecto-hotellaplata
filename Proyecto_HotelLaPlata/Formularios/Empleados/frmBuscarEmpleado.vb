Public Class frmBuscarEmpleado
    Private funciones As New clsFuncionesGenerales()
    Private Sub frmBuscarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvEmpleados, queriesEmpleados("obtener"))
    End Sub

    Private Sub dgvEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles dgvEmpleados.DoubleClick
        frmRegistroDiario.txtEmpleado.Text = dgvEmpleados.CurrentRow.Cells(2).Value
        Me.Close()
    End Sub
End Class