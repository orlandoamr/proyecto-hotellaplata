Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class frmNuevoEmpleado
    Private empleados As New clsEmpleados()
    Private funciones As New clsFuncionesGenerales()
    Public cargos As New clsCargos()

    Public cargoId As Integer
    Private editar As Boolean = False

    Private Sub frmNuevoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvEmpleados, queriesEmpleados("obtener"))
        dgvEmpleados.Columns("FKCargoId").Visible = False

        cargos.obtenerCargos(cmbCargos)
        cmbCargos.SelectedIndex = 0

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Se valida que no existan campos vacíos
        Dim textBoxes As New List(Of TextBox) From {txtNombre, txtApellido, txtIdentidad, txtCorreo, txtNumero}
        Dim val = validarTextBoxVacios(textBoxes)

        'En caso de existir un campo vacío se muestra el campo
        If Not val(0) Then
            MsgCampoVacio(val(1))

        ElseIf Not validarIdentidad(txtIdentidad.Text) Then
            MsgIdentidadInvalida()

        ElseIf Not validarTelefono(txtNumero.Text) Or Not txtNumero.Text.Length = 8 Then
            MsgNumeroInvalido()

        ElseIf Not ValidEmail(txtCorreo.Text) Then
            MsgCorreoInvalido()

        Else
            'Se asignan las propiedades de la clase
            empleados._empleadoId = txtIdentidad.Text
            empleados._nombre = txtNombre.Text
            empleados._apellido = txtApellido.Text
            empleados._numeroTelefono = txtNumero.Text
            empleados._correoElectronico = txtCorreo.Text
            empleados._cargoId = cmbCargos.SelectedValue

            'Si editar es true se realizará un actualización
            'La variable res almacena los resultados que le retornó el método guardar
            If editar = True Then
                Dim res = empleados.guardar(queriesEmpleados("actualizar"))

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgRegistroExitoso()
                    limpiarCampos()

                End If

                'Si editar es false se realizará una nueva inserción
            Else
                Dim res = empleados.guardar(queriesEmpleados("insertar"))

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgActualizacionExitosa()
                    LimpiarCampos()
                End If

            End If
        End If
    End Sub

    Private Sub limpiarCampos()
        txtIdentidad.Clear()
        txtNombre.Clear()
        txtNumero.Clear()
        txtCorreo.Clear()
        txtApellido.Clear()
        funciones.llenarDataGrid(dgvEmpleados, queriesEmpleados("obtener"))
        editar = False
    End Sub

    Private Sub dgvEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles dgvEmpleados.DoubleClick
        txtNombre.Text = dgvEmpleados.CurrentRow.Cells(0).Value
        txtApellido.Text = dgvEmpleados.CurrentRow.Cells(1).Value
        txtIdentidad.Text = dgvEmpleados.CurrentRow.Cells(2).Value
        txtNumero.Text = dgvEmpleados.CurrentRow.Cells(3).Value
        txtCorreo.Text = dgvEmpleados.CurrentRow.Cells(4).Value

        editar = True
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
    End Sub

    Private Sub btnBuscarCargo_Click(sender As Object, e As EventArgs) Handles btnBuscarCargo.Click
        frmCargos.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class