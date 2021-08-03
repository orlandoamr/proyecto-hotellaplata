'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Clases
'   Clase: clsSeguridad
'   Función: encriptar y desencriptar las contraseñas
'----------------------------------------------------------------------------------------------------------------
Imports System.Text
Imports System.Security.Cryptography
Public Class clsSeguridad

    'Método para encriptar una contraseña
    Public Function Encriptar(ByVal Input As String) As String
        'La clave debe ser de 8 caracteres
        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi")
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5")
        Dim buffer() As Byte = Encoding.UTF8.GetBytes(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV

        Return Convert.ToBase64String(des.CreateEncryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function

    'Método para desencriptar una contraseña
    Public Function Desencriptar(ByVal Input As String) As String
        'La clave debe ser de 8 caracteres
        Dim IV() As Byte = ASCIIEncoding.ASCII.GetBytes("qualityi")
        Dim EncryptionKey() As Byte = Convert.FromBase64String("rpaSPvIvVLlrcmtzPU9/c67Gkj7yL1S5")
        Dim buffer() As Byte = Convert.FromBase64String(Input)
        Dim des As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
        des.Key = EncryptionKey
        des.IV = IV
        Return Encoding.UTF8.GetString(des.CreateDecryptor().TransformFinalBlock(buffer, 0, buffer.Length()))

    End Function
End Class
