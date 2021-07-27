Imports System.Data.SqlClient
Public Class frmVerRegistrosEmpleados
    Private Sub frmVerRegistrosEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_hotelDataSet4.Empleados' Puede moverla o quitarla según sea necesario.
        'Me.EmpleadosTableAdapter.Fill(Me.Proyecto_hotelDataSet4.Empleados)
        dgvUpdate()
    End Sub
    Private Sub dgvUpdate()
        Try
            Conectar()
            Dim datosClientes As New DataTable
            Using adaptador As New SqlDataAdapter("select * from DiarioEmpleados", coneccion)
                adaptador.Fill(datosClientes)
            End Using

            dgvRegistros.DataSource = datosClientes
            CerrarConeccion()
        Catch ex As Exception
            CerrarConeccion()
            MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim todoCorrecto As Boolean = True


        If (cmbFiltro.Text = "Año") Then
            If IsNumeric(txtParametro.Text) = True Then
                Try
                    Conectar()
                    Dim consulta = "SELECT *FROM DiarioEmpleados WHERE YEAR(Fecha)=" & txtParametro.Text
                    Dim datoscliente As New DataTable

                    Using adaptador As New SqlDataAdapter(consulta, coneccion)
                        adaptador.Fill(datoscliente)
                    End Using

                    dgvRegistros.DataSource = datoscliente
                    CerrarConeccion()
                Catch ex As Exception
                    CerrarConeccion()
                    MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else
                MessageBox.Show("El año debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        ElseIf (cmbFiltro.Text = "Mes") Then
            If IsNumeric(txtParametro.Text) = True And IsNumeric(txtMes.Text) = True Then
                Try
                    Conectar()
                    Dim consulta = "SELECT *FROM DiarioEmpleados WHERE MONTH(Fecha)=" & txtMes.Text & " AND YEAR(Fecha)=" & txtParametro.Text
                    Dim datoscliente As New DataTable

                    Using adaptador As New SqlDataAdapter(consulta, coneccion)
                        adaptador.Fill(datoscliente)
                    End Using

                    dgvRegistros.DataSource = datoscliente
                    CerrarConeccion()
                Catch ex As Exception
                    CerrarConeccion()
                    MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else
                MessageBox.Show("El año y mes deben ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf (cmbFiltro.Text = "Día") Then
            If IsDate(txtParametro.Text) = True Then
                Try
                    Conectar()
                    Dim consulta = "SELECT *FROM DiarioEmpleados WHERE Fecha='" & txtParametro.Text & "'"
                    Dim datoscliente As New DataTable

                    Using adaptador As New SqlDataAdapter(consulta, coneccion)
                        adaptador.Fill(datoscliente)
                    End Using

                    dgvRegistros.DataSource = datoscliente
                    CerrarConeccion()
                Catch ex As Exception
                    CerrarConeccion()
                    MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else
                MessageBox.Show("El formato de fecha es año-mes-dia (ej 2021-02-28)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf (cmbFiltro.Text = "Nombre Empleado") Then
            If cmbEmpleados.Text.Length = 0 Then
                MessageBox.Show("Seleccione un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    Conectar()
                    Dim consulta = "SELECT de.DiarioEmpleadoId,e.Nombre,e.Nombre,e.Cargo, de.Fecha, de.HoraEntrada, de.HoraSalida, de.Observacion
                    from DiarioEmpleados as de INNER JOIN Empleados AS e on de.FkEmpleadoId = e.EmpleadoId and e.EmpleadoId='" & cmbEmpleados.SelectedValue & "'"
                    Dim datoscliente As New DataTable

                    Using adaptador As New SqlDataAdapter(consulta, coneccion)
                        adaptador.Fill(datoscliente)
                    End Using

                    dgvRegistros.DataSource = datoscliente
                    CerrarConeccion()
                Catch ex As Exception
                    CerrarConeccion()
                    MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Filtro no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged
        If (cmbFiltro.SelectedItem.ToString = "Mes") Then
            lbParametro.Text = "Año"
            lbMes.Text = "Mes"
            txtMes.Enabled = True
            cmbEmpleados.Enabled = False
            txtParametro.Enabled = True
        ElseIf cmbFiltro.SelectedItem.ToString = "Día" Then
            lbParametro.Text = ""
            lbMes.Text = ""
            txtMes.Enabled = False
            cmbEmpleados.Enabled = False
            txtParametro.Enabled = True
        ElseIf cmbFiltro.SelectedItem.ToString = "Año" Then
            lbParametro.Text = ""
            lbMes.Text = ""
            txtMes.Enabled = False
            cmbEmpleados.Enabled = False
            txtParametro.Enabled = True
        ElseIf cmbFiltro.SelectedItem.ToString = "Nombre Empleado" Then
            lbParametro.Text = ""
            lbMes.Text = ""
            txtMes.Enabled = False
            cmbEmpleados.Enabled = True
            txtParametro.Enabled = False
        Else
            lbParametro.Text = ""
            lbMes.Text = ""
            txtMes.Enabled = False

            cmbEmpleados.Enabled = False
        End If
    End Sub
End Class