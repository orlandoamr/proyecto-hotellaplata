Imports System.Data.SqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class Login
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim usuario As String = txtUsuario.Text
        Dim contrasenia As String = txtContraseña.Text
        Dim acceso As Integer

        If (usuario.Length = 0 Or contrasenia.Length = 0) Then
            MessageBox.Show("Ingrese un usuario y una contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Conectar()
                Dim pass = Encriptar(contrasenia)
                Dim recuperar As String = "SELECT *FROM Usuarios WHERE Nombre='" & usuario & "' AND Contrasenia='" & pass & "'"

                Dim mostrar As SqlDataReader
                Dim ejecutar As New SqlCommand

                ejecutar = New SqlCommand(recuperar, coneccion)

                mostrar = ejecutar.ExecuteReader()

                Dim estado As String
                estado = mostrar.Read()

                If (estado = True) Then
                    acceso = mostrar(3)
                    asignarAcceso(acceso)
                    CerrarConeccion()
                    frmInicio.Show()
                    MessageBox.Show("Bienvenido usuario " & usuario, "Inicio existoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No se encontró ningun usuario con esas credenciales, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtContraseña.Clear()
                    txtUsuario.Clear()
                    CerrarConeccion()
                End If

            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error en la conexión a la base de datos, comuníquese con el administrador del servidor." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class