Imports System.Data.SqlClient

Public Class frmRegistroDiarioEmpleados
    Private Sub btnGuardarRegistro_Click(sender As Object, e As EventArgs) Handles btnGuardarRegistro.Click
        Dim todoCorrecto As Boolean = True

        If (cmbEmpleados.Text.Length = 0 Or TxtHoraEntrada.Text.Length = 0 Or TxtObservacion.Text.Length = 0) Then
            todoCorrecto = False
            MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (isDate(TxtHoraEntrada.Text) = False) Then
            todoCorrecto = False
            MessageBox.Show("La hora de entrada no tiene el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (TxtHoraSalida.Text.Length > 0) Then
            If (IsDate(TxtHoraSalida.Text)) = False Then
                todoCorrecto = False
                MessageBox.Show("La hora de salida no tiene el formato correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        If (todoCorrecto = True) Then
            Try
                Conectar()

                Dim consultaGuardar As String = "INSERT INTO DiarioEmpleados(FkEmpleadoId,Fecha, HoraEntrada, HoraSalida, Observacion) VALUES(@FkEmpleadoId,@Fecha, @HoraEntrada, @HoraSalida, @Observacion)"
                Dim ejecutar As New SqlCommand(consultaGuardar, coneccion)
                MsgBox(cmbEmpleados.SelectedValue)
                ejecutar.Parameters.AddWithValue("@FkEmpleadoId", (cmbEmpleados.SelectedValue))
                ejecutar.Parameters.AddWithValue("@Fecha", dtpFechaRegistro.Value)
                ejecutar.Parameters.AddWithValue("@HoraEntrada", TxtHoraEntrada.Text)
                ejecutar.Parameters.AddWithValue("@HoraSalida", TxtHoraSalida.Text)
                ejecutar.Parameters.AddWithValue("@Observacion", TxtObservacion.Text)
                ejecutar.ExecuteNonQuery()
                CerrarConeccion()

                dgvUpdate()
            Catch ex As Exception
                CerrarConeccion()
                MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub dgvUpdate()
        Conectar()

        Dim datosVentas As New DataTable
        Using adaptador As New SqlDataAdapter("select * from DiarioEmpleados", coneccion)
            adaptador.Fill(datosVentas)
        End Using

        dgvEmpleados.DataSource = datosVentas
        coneccion.Close()

    End Sub

    Private Sub frmRegistroDiarioEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_hotelDataSet3.Empleados' Puede moverla o quitarla según sea necesario.
        'Me.EmpleadosTableAdapter.Fill(Me.Proyecto_hotelDataSet3.Empleados)
        dgvUpdate()
        If obtenerAcceso() = 2 Then
            btnActualizarRegistro.Enabled = False
            btnEliminarRegistro.Enabled = False
        ElseIf obtenerAcceso() = 3 Then
            btnActualizarRegistro.Enabled = False
            btnEliminarRegistro.Enabled = False
            btnGuardarRegistro.Enabled = False
            btnActualizarSalida.Enabled = False
        End If
    End Sub

    Private Sub btnActualizarRegistro_Click(sender As Object, e As EventArgs) Handles btnActualizarRegistro.Click
        Dim todoCorrecto As Boolean = True

        If (TxtCodigo.Text.Length = 0 Or cmbEmpleados.Text.Length = 0 Or TxtHoraEntrada.Text.Length = 0 Or TxtObservacion.Text.Length = 0) Then
            todoCorrecto = False
            MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsNumeric(TxtCodigo.Text) = False Then
            todoCorrecto = False
            MessageBox.Show("El codigo debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If todoCorrecto = True Then
            Try
                Conectar()
                Dim datos As String = "update  DiarioEmpleados set FkEmpleadoId=@FkEmpleadoId,HoraEntrada=@HoraEntrada,HoraSalida=@HoraSalida,Observacion=@Observacion where DiarioEmpleadoId=@DiarioEmpleadoId"
                Dim actualizar As New SqlCommand(datos, coneccion)

                actualizar.Parameters.AddWithValue("@DiarioEmpleadoId", (TxtCodigo.Text))
                actualizar.Parameters.AddWithValue("@FkEmpleadoId", (cmbEmpleados.SelectedValue))
                'actualizar.Parameters.AddWithValue("@Fecha", dtpFechaRegistro.Value)
                actualizar.Parameters.AddWithValue("@HoraEntrada", TxtHoraEntrada.Text)
                actualizar.Parameters.AddWithValue("@HoraSalida", TxtHoraSalida.Text)
                actualizar.Parameters.AddWithValue("@Observacion", TxtObservacion.Text)

                actualizar.ExecuteNonQuery()
                CerrarConeccion()
                dgvUpdate()
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btnEliminarRegistro_Click(sender As Object, e As EventArgs) Handles btnEliminarRegistro.Click
        If IsNumeric(TxtCodigo.Text) = True Then
            Try
                Conectar()
                Dim eliminar As String = "delete from DiarioEmpleados where DiarioEmpleadoId=@DiarioEmpleadoId"
                Dim procesar As New SqlCommand(eliminar, coneccion)
                procesar.Parameters.AddWithValue("@DiarioEmpleadoId", TxtCodigo.Text)
                procesar.ExecuteNonQuery()
                CerrarConeccion()
                dgvUpdate()
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("El codigo debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click


        Dim consulta As String
        consulta = txtIdRegistro.Text

        If IsNumeric(consulta) = True Then
            Try
                Conectar()
                consulta = "SELECT *FROM DiarioEmpleados WHERE DiarioEmpleadoId=" & consulta
                Dim datosEmpleado As New DataTable

                Using adaptador As New SqlDataAdapter(consulta, coneccion)
                    adaptador.Fill(datosEmpleado)
                End Using

                dgvEmpleados.DataSource = datosEmpleado
                coneccion.Close()
            Catch ex As Exception
                MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("El codigo debe ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnActualizarSalida_Click(sender As Object, e As EventArgs) Handles btnActualizarSalida.Click
        If IsNumeric(TxtCodigo.Text) = True And IsDate(TxtHoraSalida.Text) = True Then
            Try
                Conectar()
                Dim datos As String = "update DiarioEmpleados set HoraSalida=@HoraSalida where DiarioEmpleadoId=@DiarioEmpleadoId"
                Dim actualizar As New SqlCommand(datos, coneccion)
                actualizar.Parameters.AddWithValue("@DiarioEmpleadoId", TxtCodigo.Text)
                actualizar.Parameters.AddWithValue("@HoraSalida", TxtHoraSalida.Text)
                actualizar.ExecuteNonQuery()
                CerrarConeccion()
                dgvUpdate()
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error al realizar el registro, revise los datos e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("El codigo debe ser numerico y la hora en sistema de 24 horas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub dgvEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellContentClick

    End Sub

    Private Sub TxtHoraEntrada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHoraEntrada.KeyPress
        hora(e)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dgvUpdate()

    End Sub
End Class