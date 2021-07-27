Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class frmNuevoEmpleado

    Private Sub btnRegistrarCliente_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub dgvUpdate()
        Try
            Conectar()

            Dim datosEmpleados As New DataTable
            Using adaptador As New SqlDataAdapter("select * from Empleados", coneccion)
                adaptador.Fill(datosEmpleados)
            End Using

            DgvEmpleados.DataSource = datosEmpleados
            CerrarConeccion()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnActualizarEmpleado_Click(sender As Object, e As EventArgs) Handles btnActualizarEmpleado.Click
        Dim todoCorrecto As Boolean = True

        If (TxtCodigo.Text.Length = 0 Or TxtNombre.Text.Length = 0 Or TxtApellido.Text.Length = 0 Or TxtNumIdentidad.Text.Length = 0 Or TxtCargo.Text.Length = 0 Or TxtTelefono.Text.Length = 0 Or TxtCorreo.Text.Length = 0) Then
            todoCorrecto = False
            MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf IsNumeric(TxtNumIdentidad.Text) = False Then
            todoCorrecto = False
            MessageBox.Show("El numero de identidad debe ser unicamente numérico, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf (TxtNumIdentidad.Text.Length < 13 Or TxtNumIdentidad.Text.Length > 13) Then
            todoCorrecto = False
            MessageBox.Show("Los numeros de identidad de deben constar de 13 dígitos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf (TxtTelefono.Text.Length > 8 Or TxtTelefono.Text < 8) Then
            MessageBox.Show("El número de teléfono debe constar de 8 dígitos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            todoCorrecto = False
        ElseIf (TxtTelefono.Text.Length = 8 And validarTelefono(TxtTelefono.Text) = False) Then
            todoCorrecto = False
            MessageBox.Show("El número de teléfono no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf (ValidEmail(TxtCorreo.Text) = False) Then
            todoCorrecto = False
            MessageBox.Show("Correo electrónico no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf validarIdentidad(TxtNumIdentidad.Text) = False Then
            todoCorrecto = False
            MessageBox.Show("Numero de Identidad no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (todoCorrecto = True) Then
            Try
                Conectar()
                Dim datos As String = "update Empleados set Nombre=@Nombre,Apellido=@Apellido,Identidad=@Identidad,Cargo=@Cargo,Telefono=@Telefono,Correo=@Correo where EmpleadoId=@EmpleadoId"
                Dim actualizar As New SqlCommand(datos, coneccion)

                actualizar.Parameters.AddWithValue("@EmpleadoId", TxtCodigo.Text)
                actualizar.Parameters.AddWithValue("@Nombre", TxtNombre.Text)
                actualizar.Parameters.AddWithValue("@Apellido", TxtApellido.Text)
                actualizar.Parameters.AddWithValue("@Identidad", TxtNumIdentidad.Text)
                actualizar.Parameters.AddWithValue("@Cargo", (TxtCargo.Text))
                actualizar.Parameters.AddWithValue("@Telefono", (TxtTelefono.Text))
                actualizar.Parameters.AddWithValue("@Correo", (TxtCorreo.Text))

                actualizar.ExecuteNonQuery()
                CerrarConeccion()

                dgvUpdate()
                clear()
                MessageBox.Show("Se ha actaulizado el registro exitosamente", "Registro Actualuzado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub
    Public Sub clear()
        TxtApellido.Clear()
        TxtCargo.Clear()
        TxtCodigo.Clear()
        TxtCorreo.Clear()
        TxtNombre.Clear()
        TxtNumIdentidad.Clear()
        TxtTelefono.Clear()
    End Sub

    Private Sub btnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btnEliminarEmpleado.Click
        Dim todoCorrecto As Boolean = True

        If TxtCodigo.Text.Length = 0 Then
            todoCorrecto = False
            MessageBox.Show("Seleccione un registro para poder eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If (todoCorrecto = True) Then
            Try
                Conectar()

                Dim eliminar As String = "delete from Empleados where EmpleadoId=@EmpleadoId"
                Dim procesar As New SqlCommand(eliminar, coneccion)
                procesar.Parameters.AddWithValue("@EmpleadoId", TxtCodigo.Text)
                procesar.ExecuteNonQuery()
                CerrarConeccion()

                dgvUpdate()
                clear()
                MessageBox.Show("Se ha eliminado el registro exitosamente", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Este empleado está relacionado a otros registros, no se puede eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Dim consulta As String

        consulta = InputBox("Buscar")
        If IsNumeric(TxtCodigo.Text) = True Then
            Try
                Conectar()
                consulta = "SELECT *FROM Empleados WHERE EmpleadoId=" & consulta
                Dim datosEmpleado As New DataTable

                Using adaptador As New SqlDataAdapter(consulta, coneccion)
                    adaptador.Fill(datosEmpleado)
                End Using

                DgvEmpleados.DataSource = datosEmpleado
                CerrarConeccion()

            Catch ex As Exception
                CerrarConeccion()
                MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("El codigo debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub frmNuevoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUpdate()
        If obtenerAcceso() = 2 Then
            btnActualizarEmpleado.Enabled = False
            btnEliminarEmpleado.Enabled = False
        ElseIf obtenerAcceso() = 3 Then
            btnActualizarEmpleado.Enabled = False
            btnEliminarEmpleado.Enabled = False
            btnRegistrarCliente.Enabled = False
        End If
    End Sub

    Private Sub btnRegistrarCliente_Click_1(sender As Object, e As EventArgs) Handles btnRegistrarCliente.Click
        Dim todoCorrecto As Boolean = True

        If (TxtNombre.Text.Length = 0 Or TxtApellido.Text.Length = 0 Or TxtNumIdentidad.Text.Length = 0 Or TxtCargo.Text.Length = 0 Or TxtTelefono.Text.Length = 0 Or TxtCorreo.Text.Length = 0) Then
            todoCorrecto = False
            MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf IsNumeric(TxtNumIdentidad.Text) = False Then
            todoCorrecto = False
            MessageBox.Show("El numero de identidad debe ser unicamente numérico, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf (TxtNumIdentidad.Text.Length < 13 Or TxtNumIdentidad.Text.Length > 13) Then
            todoCorrecto = False
            MessageBox.Show("Los numeros de identidad de deben constar de 13 dígitos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf (TxtTelefono.Text.Length > 8 Or TxtTelefono.Text < 8) Then
            MessageBox.Show("El número de teléfono debe constar de 8 dígitos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            todoCorrecto = False
        ElseIf (TxtTelefono.Text.Length = 8 And validarTelefono(TxtTelefono.Text) = False) Then
            todoCorrecto = False
            MessageBox.Show("El número de teléfono no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf (ValidEmail(TxtCorreo.Text) = False) Then
            todoCorrecto = False
            MessageBox.Show("Correo electrónico no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf validarIdentidad(TxtNumIdentidad.Text) = False Then
            todoCorrecto = False
            MessageBox.Show("Numero de Identidad no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (todoCorrecto = True) Then
            Try
                Conectar()
                Dim consultaGuardar As String = "INSERT INTO Empleados(Nombre,Apellido,Identidad,Cargo,Telefono,Correo) VALUES(@Nombre, @Apellido, @Identidad, @Cargo, @Telefono,@Correo)"
                Dim ejecutar As New SqlCommand(consultaGuardar, coneccion)
                ejecutar.Parameters.AddWithValue("@Nombre", (TxtNombre.Text))
                ejecutar.Parameters.AddWithValue("@Apellido", (TxtApellido.Text))
                ejecutar.Parameters.AddWithValue("@Identidad", (TxtNumIdentidad.Text))
                ejecutar.Parameters.AddWithValue("@Cargo", (TxtCargo.Text))
                ejecutar.Parameters.AddWithValue("@Telefono", (TxtTelefono.Text))
                ejecutar.Parameters.AddWithValue("@Correo", (TxtCorreo.Text))
                ejecutar.ExecuteNonQuery()

                coneccion.Close()

                dgvUpdate()
                clear()

            Catch ex As Exception
                MessageBox.Show("Ocurrio un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            MessageBox.Show("Se ha realizado el registro correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        coneccion.Close()
    End Sub

    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombre.KeyPress
        soloLetras(e)
    End Sub

    Private Sub TxtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtApellido.KeyPress
        soloLetras(e)
    End Sub

    Private Sub TxtNumIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumIdentidad.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTelefono.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub DgvEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles DgvEmpleados.DoubleClick
        Try
            TxtCodigo.Text = DgvEmpleados.CurrentRow.Cells(0).Value
            TxtNombre.Text = DgvEmpleados.CurrentRow.Cells(1).Value
            TxtApellido.Text = DgvEmpleados.CurrentRow.Cells(2).Value
            TxtNumIdentidad.Text = DgvEmpleados.CurrentRow.Cells(3).Value
            TxtCargo.Text = DgvEmpleados.CurrentRow.Cells(4).Value
            TxtTelefono.Text = DgvEmpleados.CurrentRow.Cells(5).Value
            TxtCorreo.Text = DgvEmpleados.CurrentRow.Cells(6).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DgvEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmpleados.CellContentClick

    End Sub

    Private Sub TxtCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCargo.KeyPress
        soloLetras(e)
    End Sub
End Class