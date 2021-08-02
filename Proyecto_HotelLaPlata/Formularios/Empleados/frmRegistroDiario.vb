Public Class frmRegistroDiario
    Private diario As New clsDiarioEmpleados()
    Private funciones As New clsFuncionesGenerales()

    Private Sub frmRegistroDiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvDiarioEmpleados, queriesDiario("obtener"))
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        frmBuscarEmpleado.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim textBoxes As New List(Of TextBox) From {txtEmpleado, txtObservacion}
        Dim val = validarTextBoxVacios(textBoxes)

        'En caso de existir un campo vacío se muestra el campo
        If Not val(0) Then
            MsgCampoVacio(val(1))

        Else
            diario._fecha = dtpFecha.Value
            diario._horaEntrada = dtpEntrada.Value.ToString()
            diario._observacion = txtObservacion.Text
            diario._empleadoId = txtEmpleado.Text

            Dim res = diario.insertar()

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
        txtEmpleado.Clear()
        txtObservacion.Clear()
        funciones.llenarDataGrid(dgvDiarioEmpleados, queriesDiario("obtener"))
    End Sub
End Class