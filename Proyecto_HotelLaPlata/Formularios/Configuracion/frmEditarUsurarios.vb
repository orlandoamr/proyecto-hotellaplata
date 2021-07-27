Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class frmEditarUsurarios
    Private Sub frmEditarUsurarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUpdate()
        cmbAcceso.SelectedIndex = 1
    End Sub

    Private Sub dgvUpdate()
        Try
            Conectar()
            Dim usuarios As New DataTable
            Using adaptador As New SqlDataAdapter("select * from Usuarios", coneccion)
                adaptador.Fill(usuarios)
            End Using

            dgvUsuarios.DataSource = usuarios
            CerrarConeccion()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim todoCorrecto As Boolean = True

        If (txtContrasenia.Text.Length = 0 Or txtNombre.Text.Length = 0 Or cmbAcceso.SelectedItem.ToString.Length = 0) Then
            todoCorrecto = False
            MessageBox.Show("No puede dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (txtNombre.Text.Length < 6 Or txtNombre.Text.Length > 16) Then
            todoCorrecto = False
            MessageBox.Show("El nombre de usuario debe tener mínimo 6 caracteres y máximo 16 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (txtContrasenia.Text.Length < 6 Or txtContrasenia.Text.Length > 16) Then
            todoCorrecto = False
            MessageBox.Show("La contraseña debe tener mínimo 6 caracteres y máximo 16 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (todoCorrecto = True) Then
            Dim pass = Encriptar(txtContrasenia.Text)
            Try
                Conectar()

                Dim consultaGuardar As String = "INSERT INTO Usuarios(Nombre, Contrasenia, Nivel) VALUES(@Nombre, @Contrasenia, @Nivel)"

                Dim ejecutar As New SqlCommand(consultaGuardar, coneccion)
                ejecutar.Parameters.AddWithValue("@Nombre", (txtNombre.Text))
                ejecutar.Parameters.AddWithValue("@Contrasenia", pass)
                ejecutar.Parameters.AddWithValue("@Nivel", cmbAcceso.SelectedItem.ToString())
                ejecutar.ExecuteNonQuery()
                CerrarConeccion()

                dgvUpdate()
                clear()

            Catch ex As Exception
                MessageBox.Show("Ocurrio un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub
    Public Sub clear()
        txtCodigo.Clear()
        txtContrasenia.Clear()
        txtNombre.Clear()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim todoCorrecto As Boolean = True

        If (txtContrasenia.Text.Length = 0 Or txtNombre.Text.Length = 0 Or cmbAcceso.SelectedItem.ToString.Length = 0) Then
            MessageBox.Show("No puede dejar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (txtNombre.Text.Length < 6 Or txtNombre.Text.Length > 16) Then
            todoCorrecto = False
            MessageBox.Show("El nombre de usuario debe tener mínimo 6 caracteres y máximo 16 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (txtContrasenia.Text.Length < 6 Or txtContrasenia.Text.Length > 16) Then
            todoCorrecto = False
            MessageBox.Show("La contraseña debe tener mínimo 6 caracteres y máximo 16 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If todoCorrecto = True Then
            Try
                Conectar()
                If (Val(txtCodigo.Text) = 1) Then
                    Dim consultaAct As String = "Update Usuarios SET Nombre=@Nombre, Contrasenia=@Contrasenia WHERE UsuarioId=@UsuarioId"
                    Dim pass = Encriptar(txtContrasenia.Text)
                    Dim ejec As New SqlCommand(consultaAct, coneccion)
                    ejec.Parameters.AddWithValue("@UsuarioId", Val(txtCodigo.Text))
                    ejec.Parameters.AddWithValue("@Nombre", (txtNombre.Text))
                    ejec.Parameters.AddWithValue("@Contrasenia", pass)
                    ejec.ExecuteNonQuery()
                Else
                    Dim consultaGuardar As String = "Update Usuarios SET Nombre=@Nombre, Contrasenia=@Contrasenia, Nivel=@Nivel WHERE UsuarioId=@UsuarioId"
                    Dim pass = Encriptar(txtContrasenia.Text)
                    Dim ejecutar As New SqlCommand(consultaGuardar, coneccion)
                    ejecutar.Parameters.AddWithValue("@UsuarioId", Val(txtCodigo.Text))
                    ejecutar.Parameters.AddWithValue("@Nombre", (txtNombre.Text))
                    ejecutar.Parameters.AddWithValue("@Contrasenia", pass)
                    ejecutar.Parameters.AddWithValue("@Nivel", cmbAcceso.SelectedItem.ToString())
                    ejecutar.ExecuteNonQuery()
                End If
                CerrarConeccion()
                dgvUpdate()
                clear()

            Catch ex As Exception
                MessageBox.Show("Ocurrio un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If (Val(txtCodigo.Text) = 8) Then
            btnEliminar.Enabled = False
            'cmbAcceso.Enabled = False
        Else
            btnEliminar.Enabled = True
            cmbAcceso.Enabled = True
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtCodigo.Text.Length = 0 Then
            MessageBox.Show("Seleccione un registro para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Conectar()

                Dim consultaEliminar As String = "DELETE FROM Usuarios WHERE UsuarioId=@UsuarioId"

                Dim ejecutar As New SqlCommand(consultaEliminar, coneccion)
                ejecutar.Parameters.AddWithValue("@UsuarioId", Val(txtCodigo.Text))
                ejecutar.ExecuteNonQuery()
                CerrarConeccion()

                dgvUpdate()
                clear()
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If



    End Sub

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick

    End Sub
    Public Function Encriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV

        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    Public Function Desencriptar(ByVal Input As String) As String

        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi") 'La clave debe ser de 8 caracteres
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5") 'No se puede alterar la cantidad de caracteres pero si la clave
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    Private Sub dgvUsuarios_DoubleClick(sender As Object, e As EventArgs) Handles dgvUsuarios.DoubleClick
        Try
            txtCodigo.Text = dgvUsuarios.CurrentRow.Cells(0).Value
            txtNombre.Text = dgvUsuarios.CurrentRow.Cells(1).Value
        Catch ex As Exception

        End Try

    End Sub
End Class