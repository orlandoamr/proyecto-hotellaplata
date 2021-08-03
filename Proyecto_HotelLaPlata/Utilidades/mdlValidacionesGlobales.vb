'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Utilidades
'   Clase: mdlValidacionesGlobales
'   Función: Almacenar las validaciones que se usan en varias pantallas del sistema
'-----------------------------------------------------------------------------------------------------------------
Module mdlValidacionesGlobales

    'Función para validar un número de identidad hondureño
    Public Function validarIdentidad(id As String) As Boolean
        Dim valido As Boolean = True
        If (id.Length = 13 And IsNumeric(Val(id))) Then
            Try
                Dim depto As Integer = Convert.ToInt32(Mid(id, 1, 2))
                Dim municipio As Integer = Convert.ToInt32(Mid(id, 3, 2))
                Dim anio As Integer = Convert.ToInt32(Mid(id, 5, 4))
                Dim numReg As Integer = Convert.ToInt32(Mid(id, 9))

                If (depto < 1 Or depto > 18) Then
                    valido = False
                ElseIf (municipio < 1 Or municipio > 28) Then
                    valido = False
                ElseIf (anio < 1900 Or anio > System.DateTime.Now.Year) Then
                    valido = False
                ElseIf (numReg < 1 Or numReg > 99999) Then
                    valido = False
                End If

            Catch ex As Exception
                valido = False
            End Try
        Else
            valido = False
        End If


        Return valido
    End Function

    'Función para validar los textbox vacíos
    Public Function validarTextBoxVacios(lista As List(Of TextBox))
        Dim campoVacio As String = ""
        Dim estado As Boolean = True

        For Each textBox In lista
            If (textBox.Text = "") Then
                campoVacio = textBox.AccessibleName
                estado = False
                Exit For
            End If
        Next

        Dim res As New List(Of Object) From {estado, campoVacio}
        Return res
    End Function
End Module
