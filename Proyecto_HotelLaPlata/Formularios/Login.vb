'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios
'   Formulario: frmLogin
'   Función: Formulario de inicio de sesión
'-----------------------------------------------------------------------------------------------------------------
Public Class Login
    Private usuarios As New clsUsuarios()
    Private seguridad As New clsSeguridad()
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs)
        Dim usuario As String = txtUsuario.Text
        Dim contrasenia As String = txtContraseña.Text
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If (txtUsuario.Text = "" Or txtContraseña.Text = "") Then
            MessageBox.Show("Ingrese usuario y contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContraseña.Clear()
            txtUsuario.Clear()
        ElseIf txtUsuario.Text.Length < 4 Then

            MessageBox.Show("El usuario debe tener mínimo 4 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtContraseña.Text.Length < 8 Then

            MessageBox.Show("La contraseña debe tener mínimo 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            usuarios._nombreUsuario = txtUsuario.Text
            usuarios._contrasenia = seguridad.Encriptar(txtContraseña.Text)

            Dim dt As New DataTable

            dt = usuarios.verificarUsuario()

            If dt.Rows.Count = 0 Then
                MessageBox.Show("Usuario/contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtContraseña.Clear()
                txtUsuario.Clear()
            Else
                For Each Row In dt.Rows
                    frmInicio2.acceso = Row("Nivel")
                    frmInicio2.usuarioId = Row("EmpleadoId")
                Next
                frmInicio2.usuario = txtUsuario.Text
                frmInicio2.Show()
                MessageBox.Show("Bienvenido usuario: " & txtUsuario.Text, "Inicio exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtUsuario.Clear()
                txtContraseña.Clear()
            End If

        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class