Module mdlMensajes
    'Exitoos
    Public Sub MsgRegistroExitoso()
        MessageBox.Show("Registro realizado exitosamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub MsgActualizacionExitosa()
        MessageBox.Show("Registro actualizado exitosamente.", "Actualizacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub MsgEliminacionExitosa()
        MessageBox.Show("Se ha eliminado el registro exitosamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Public Sub MsgDepartamento()
        MessageBox.Show("Seleccione un departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub MsgIdentidadNumerico()
        MessageBox.Show("El numero de identidad debe ser unicamente numérico, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Public Sub MsgErrorEliminarCliente()
        MessageBox.Show("No puede eliminar este cliente, debido a que existen otros registros relacionados a él.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Sub MsgIngreseId()
        MessageBox.Show("Ingrese un número de identidad", "Ingrese un Id", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Public Sub MsgIngreseParametro()
        MessageBox.Show("Ingrese un parámetro para realizar la busqueda", "Ingrese parámetro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Public Sub MsgIdDuplicado()
        MessageBox.Show("Ya existe un registro con con el ID ingresado", "ID Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

End Module
