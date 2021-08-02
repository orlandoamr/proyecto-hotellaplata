Public Class frmActualizarSalidaEmpleado
    Private diario As New clsDiarioEmpleados()
    Private funciones As New clsFuncionesGenerales()
    Private Sub frmActualizarSalidaEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvRegistros, queriesDiario("obtener2"))
        dgvRegistros.Rows("DiarioEmpleadoId").Visible = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCodigo.Text = "" Then
            MsgCampoVacio("código del registro")

        Else
            diario._diarioId = Val(txtCodigo.Text)
            diario._horaSalida = dtpHoraSalida.Value.ToString()

            Dim res = diario.actualizarSalida()
            If res(0) = False Then
                MsgError(res(1))

            Else
                MsgRegistroExitoso()
                limpiarCampos()
            End If
        End If
    End Sub

    Private Sub limpiarCampos()
        txtCodigo.Clear()
        funciones.llenarDataGrid(dgvRegistros, queriesDiario("obtener2"))
    End Sub

    Private Sub dgvRegistros_DoubleClick(sender As Object, e As EventArgs) Handles dgvRegistros.DoubleClick
        txtCodigo.Text = dgvRegistros.CurrentRow.Cells(0).Value
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class