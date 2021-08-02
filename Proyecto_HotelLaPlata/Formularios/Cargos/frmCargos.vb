Public Class frmCargos
    Private cargos As New clsCargos()
    Private funciones As New clsFuncionesGenerales()

    Public cargoId As Integer
    Private editar As Boolean = False

    Private Sub frmCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvCargos, queriesCargos("obtener"))
        dgvCargos.Columns("CargoId").Visible = False
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtCargo.Text = "" Then
            MsgCampoVacio("descripción del cargo")
        Else
            cargos._cargoDescripcion = txtCargo.Text

            If editar = True Then
                cargos._cargoId = cargoId
                Dim res = cargos.actualizar()

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgRegistroExitoso()
                    LimpiarCampos()

                End If

                'Si editar es false se realizará una nueva inserción
            Else
                Dim res = cargos.insertar()

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgActualizacionExitosa()
                    LimpiarCampos()
                End If

            End If
            frmNuevoEmpleado.cargos.obtenerCargos(frmNuevoEmpleado.cmbCargos)
        End If
    End Sub

    Private Sub limpiarCampos()
        txtCargo.Clear()
        editar = False
        funciones.llenarDataGrid(dgvCargos, queriesCargos("obtener"))
    End Sub

    Private Sub dgvCargos_DoubleClick(sender As Object, e As EventArgs) Handles dgvCargos.DoubleClick
        txtCargo.Text = dgvCargos.CurrentRow.Cells(1).Value
        cargoId = dgvCargos.CurrentRow.Cells(0).Value

        editar = True
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
    End Sub

    Private Sub txtCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCargo.KeyPress
        soloLetras(e)
    End Sub
End Class