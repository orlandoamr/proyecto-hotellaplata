Public Class frmServicios

    Private servicios As New clsServicios()
    Private funciones As New clsFuncionesGenerales()

    Private editar As Boolean = False
    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvServicios, queriesServicios("obtener"))
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        servicios._descripcion = txtDescripcion.Text
        servicios._precio = txtPrecio.Text
        servicios._estado = chkEstado.Checked

        If editar = True Then
            servicios._servicioId = txtCodigo.Text

            Dim res = servicios.actualizar(queriesServicios("actualizar"))

            If res(0) = False Then
                MsgError(res(1))
            Else
                MsgActualizacionExitosa()
                limpiarCampos()
            End If

        Else
            Dim res = servicios.guardar(queriesServicios("insertar"))

            If res(0) = False Then
                MsgError(res(1))
            Else
                MsgRegistroExitoso()
                limpiarCampos()
            End If
        End If

        funciones.llenarDataGrid(dgvServicios, queriesServicios("obtener"))

    End Sub

    Private Sub limpiarCampos()
        txtCodigo.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        chkEstado.Checked = False

        editar = False
    End Sub

    Private Sub dgvServicios_DoubleClick(sender As Object, e As EventArgs) Handles dgvServicios.DoubleClick
        txtCodigo.Text = dgvServicios.CurrentRow.Cells(0).Value
        txtDescripcion.Text = dgvServicios.CurrentRow.Cells(1).Value
        txtPrecio.Text = dgvServicios.CurrentRow.Cells(2).Value
        chkEstado.Checked = dgvServicios.CurrentRow.Cells(3).Value

        editar = True
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarCampos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        servicios._servicioId = Val(txtCodigo.Text)

        Dim res = servicios.eliminar(queriesServicios("eliminar"))

        If res(0) = False Then
            MsgError(res(1))

        Else
            MsgEliminacionExitosa()
            limpiarCampos()
            funciones.llenarDataGrid(dgvServicios, queriesServicios("obtener"))
        End If



    End Sub
End Class