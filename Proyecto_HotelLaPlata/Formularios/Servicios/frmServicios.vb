'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Servicios
'   Formulario: frmServicios
'   Función: Realizar el control de los servicios disponibles 
'-----------------------------------------------------------------------------------------------------------------
Public Class frmServicios

    Private servicios As New clsServicios()
    Private funciones As New clsFuncionesGenerales()

    Private editar As Boolean = False
    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvServicios, queriesServicios("obtener"))
        dgvServicios.Columns("ServicioId").Visible = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim textBoxes As New List(Of TextBox) From {txtDescripcion, txtPrecio}
        Dim validar = validarTextBoxVacios(textBoxes)

        'En caso de existir un campo vacío se muestra el campo
        If Not validar(0) Then
            MsgCampoVacio(validar(1))
        Else
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
        End If


    End Sub

    Private Sub limpiarCampos()
        txtCodigo.Clear()
        txtDescripcion.Clear()
        txtPrecio.Clear()
        chkEstado.Checked = False
        funciones.llenarDataGrid(dgvServicios, queriesServicios("obtener"))
        editar = False
    End Sub

    Private Sub dgvServicios_DoubleClick(sender As Object, e As EventArgs) Handles dgvServicios.DoubleClick
        txtCodigo.Text = dgvServicios.CurrentRow.Cells(0).Value
        txtDescripcion.Text = dgvServicios.CurrentRow.Cells(1).Value
        txtPrecio.Text = dgvServicios.CurrentRow.Cells(2).Value
        chkEstado.Checked = dgvServicios.CurrentRow.Cells(3).Value

        editar = True
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
        funciones.llenarDataGrid(dgvServicios, queriesServicios("obtener"))
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        soloNumeros(e)
    End Sub
End Class