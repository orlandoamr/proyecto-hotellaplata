'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Utilidades
'   Clase: Funciones
'   Función: Funciones para validar campos de texto
'-----------------------------------------------------------------------------------------------------------------
Module mdlFunciones
    Public Sub soloLetras(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 64 Or Asc(e.KeyChar) > 93) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub soloLetrasyEspacios(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 64 Or Asc(e.KeyChar) > 93) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122) And ((Asc(e.KeyChar) < 31) Or (Asc(e.KeyChar) > 33)) Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub soloNumerosLetras(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90) And (Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 120) Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub soloNumeros(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub hora(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And (Asc(e.KeyChar) < 58 Or Asc(e.KeyChar) > 58) Then
                e.Handled = True
            End If
        End If
    End Sub

    Function ValidEmail(ByVal strCheck As String) As Boolean
        'Created by Chad M. Kovac
        'Tech Knowledgey, Inc.
        'http://www.TechKnowledgeyInc.com

        Dim bCK As Boolean
        Dim strDomainType As String
        'Dim strDomainName As String
        Const sInvalidChars As String = "!#$%^&*()=+{}[]|\;:'/?>,< "
        Dim i As Integer

        bCK = Not InStr(1, strCheck, Chr(34)) > 0 'Check to see if there is a double quote
        If Not bCK Then GoTo ExitFunction

        bCK = Not InStr(1, strCheck, "..") > 0 'Check to see if there are consecutive dots
        If Not bCK Then GoTo ExitFunction

        ' Check for invalid characters.
        If Len(strCheck) > Len(sInvalidChars) Then
            For i = 1 To Len(sInvalidChars)
                If InStr(strCheck, Mid(sInvalidChars, i, 1)) > 0 Then
                    bCK = False
                    GoTo ExitFunction
                End If
            Next
        Else
            For i = 1 To Len(strCheck)
                If InStr(sInvalidChars, Mid(strCheck, i, 1)) > 0 Then
                    bCK = False
                    GoTo ExitFunction
                End If
            Next
        End If

        If InStr(1, strCheck, "@") > 1 Then 'Check for an @ symbol
            bCK = Len(Left(strCheck, InStr(1, strCheck, "@") - 1)) > 0
        Else
            bCK = False
        End If
        If Not bCK Then GoTo ExitFunction

        strCheck = Right(strCheck, Len(strCheck) - InStr(1, strCheck, "@"))
        bCK = Not InStr(1, strCheck, "@") > 0 'Check to see if there are too many @'s
        If Not bCK Then GoTo ExitFunction

        strDomainType = Right(strCheck, Len(strCheck) - InStr(1, strCheck, "."))
        bCK = Len(strDomainType) > 0 And InStr(1, strCheck, ".") < Len(strCheck)
        If Not bCK Then GoTo ExitFunction

        Try
            strCheck = Left(strCheck, Len(strCheck) - Len(strDomainType) - 1)
            Do Until InStr(1, strCheck, ".") <= 1
                If Len(strCheck) >= InStr(1, strCheck, ".") Then
                    strCheck = Left(strCheck, Len(strCheck) - (InStr(1, strCheck, ".") - 1))
                Else
                    bCK = False
                    GoTo ExitFunction
                End If
            Loop
            If strCheck = "." Or Len(strCheck) = 0 Then bCK = False

        Catch ex As Exception
            bCK = False
            GoTo ExitFunction
        End Try

ExitFunction:
        ValidEmail = bCK
    End Function

    Function validarTelefono(str As String) As Boolean
        Dim valido As Boolean = True
        Try
            Dim pDigito = Convert.ToInt32(Mid(str, 1, 1))
            If pDigito = 8 Or pDigito = 9 Or pDigito = 3 Or pDigito = 2 Then
                valido = True
            Else
                valido = False
            End If

        Catch ex As Exception
            valido = False
        End Try

        validarTelefono = valido
    End Function



End Module
