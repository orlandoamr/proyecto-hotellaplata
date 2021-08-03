'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Usuarios
'   Formulario: frmGastosAdicionales
'   Función: realizar registros de los usuarios
'-----------------------------------------------------------------------------------------------------------------
Public Class frmControlUsuarios
    Private funciones As New clsFuncionesGenerales()
    Private seguridad As New clsSeguridad()
    Private usuarios As New clsUsuarios()

    Private editar = False
    Private Sub frmControlUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvUsuarios, queriesUsuarios("obtener"))
        cmbRoles.SelectedIndex = 0
        txtCodigoEmpleado.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Se valida que no existan campos vacíos
        Dim textBoxes As New List(Of TextBox) From {txtCodigoEmpleado, txtNombreUsuario, txtContrasenia}
        Dim val = validarTextBoxVacios(textBoxes)

        'En caso de existir un campo vacío se muestra el campo
        If Not val(0) Then
            MsgCampoVacio(val(1))
        ElseIf txtNombreUsuario.Text.Length < 5 Then
            MessageBox.Show("El nombre usuario debe tener mínimo 5 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtContrasenia.Text.Length < 8 Then
            MessageBox.Show("La contraseña debe tener mínimo 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim contrasenia As String = seguridad.Encriptar(txtContrasenia.Text)
            usuarios._usuarioId = txtCodigoEmpleado.Text
            usuarios._nombreUsuario = txtNombreUsuario.Text
            usuarios._contrasenia = contrasenia

            If cmbRoles.SelectedItem.ToString = "Administrador" Then
                usuarios._nivelAcceso = 1
            Else
                usuarios._nivelAcceso = 2
            End If

            If editar = True Then


                Dim res = usuarios.actualizar()

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgRegistroExitoso()
                    limpiarCampos()

                End If


            Else
                Dim res = usuarios.insertar()

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgActualizacionExitosa()
                    limpiarCampos()
                End If
            End If
        End If
    End Sub

    Private Sub limpiarCampos()
        txtCodigoEmpleado.Clear()
        txtContrasenia.Clear()
        txtNombreUsuario.Clear()
        funciones.llenarDataGrid(dgvUsuarios, queriesUsuarios("obtener"))

        editar = False
    End Sub

    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        frmBuscarEmpleado.Show()
    End Sub

    Private Sub dgvUsuarios_DoubleClick(sender As Object, e As EventArgs) Handles dgvUsuarios.DoubleClick
        Dim acceso = dgvUsuarios.CurrentRow.Cells(4).Value
        If acceso = 1 Then
            MessageBox.Show("No puede editar a un administrador")
        Else
            txtCodigoEmpleado.Text = dgvUsuarios.CurrentRow.Cells(1).Value
            txtNombreUsuario.Text = dgvUsuarios.CurrentRow.Cells(2).Value
            txtContrasenia.Text = seguridad.Desencriptar(dgvUsuarios.CurrentRow.Cells(3).Value.ToString())

            editar = True
        End If

    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub
End Class