'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Utilidades
'   Clase: mdlMensajes
'   Función: Todos los mensajes que se muestran en pantalla
'-----------------------------------------------------------------------------------------------------------------
Module mdlMensajes
    'Exitoos
    Public Sub MsgRegistroExitoso()
        MessageBox.Show("Registro realizado exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub MsgActualizacionExitosa()
        MessageBox.Show("Registro actualizado exitosamente.", "Actualizacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    'Errores
    Public Sub MsgIdentidadDuplicada()
        MessageBox.Show("El número de identidad ingresado ya pertenece a un registro en el sistema.", "Número de identidad duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub MsgIdentidadInvalida()
        MessageBox.Show("El número de identidad(Honduras) no es válido, debe tener 13 dígitos y cumplir con el estándar establecido", "Número de identidad inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    Public Sub MsgCamposVacios()
        MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub MsgIdentidadHonduras()
        MessageBox.Show("Los numeros de identidad de Honduras deben constar de 13 dígitos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Sub MsgErrorRegistro(e As String)
        MessageBox.Show("Ocurrio un error realizando la operación " & e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub MsgErrorConexion(e As String)
        MessageBox.Show("Ha ocurrido un error en la conexión con la base de datos " & e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub MsgCodigoVacio()
        MessageBox.Show("Seleccione un registro para continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Sub MsgIngreseParametro()
        MessageBox.Show("Ingrese un parámetro para realizar la busqueda", "Ingrese parámetro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Sub MsgNumeroInvalido()
        MessageBox.Show("El número de teléfono es inválido, debe tener 8 dígitos y empezar con 2,3,8,9", "Teléfono inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub MsgCorreoInvalido()
        MessageBox.Show("El correo electrónico es inválido, intente de nuevo", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Sub MsgDepartamento()
        MessageBox.Show("Seleccione un departamento, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Sub MsgError(msg As String)
        MessageBox.Show("Ha ocurrido un error: " & msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub MsgCampoVacio(campo As String)
        MessageBox.Show("Ingrese el campo: " & campo, "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub MsgError2(campo As String, campo2 As String)
        MessageBox.Show(campo, campo2, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub MsgErrorConexion()
        MessageBox.Show("Ocurrió un error en la conexión al servidor de la base de datos, comuníquese con el administrador del servidor.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub


End Module
