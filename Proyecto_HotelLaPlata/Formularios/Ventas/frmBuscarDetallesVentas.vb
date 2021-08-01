'Formulario para visualización de las ventas usando diferentes filtros
Imports System.Data.SqlClient
Public Class frmBuscarDetallesVentas

    Private detalle As New clsDetalleVentas()
    Private Sub frmVerDetallesVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
        dgvRefresh(dgvDetalleVentas, queriesVentas("obtener_ventas"), coneccion)
        CerrarConeccion()
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim todoCorrecto As Boolean = True

        If (txtParametro.Text = "") Then

        End If

        If (todoCorrecto = True) Then
            If (cmbFiltro.Text = "Año") Then
                If IsNumeric(txtParametro.Text) = True Then
                    Try
                        Conectar()
                        Dim consulta = "SELECT *FROM DetalleVenta WHERE YEAR(FechaEntrada)=" & txtParametro.Text
                        Dim datoscliente As New DataTable

                        Using adaptador As New SqlDataAdapter(consulta, coneccion)
                            adaptador.Fill(datoscliente)
                        End Using

                        dgvDetalleVentas.DataSource = datoscliente
                        CerrarConeccion()
                    Catch ex As Exception
                        MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Else
                    MessageBox.Show("El año debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            ElseIf (cmbFiltro.Text = "Mes") Then
                If IsNumeric(txtParametro.Text) = True And IsNumeric(txtMes.Text) = True Then
                    Try
                        Conectar()
                        Dim consulta = "SELECT *FROM DetalleVenta WHERE MONTH(FechaEntrada)=" & txtMes.Text & " AND YEAR(FechaEntrada)=" & txtParametro.Text
                        Dim datoscliente As New DataTable

                        Using adaptador As New SqlDataAdapter(consulta, coneccion)
                            adaptador.Fill(datoscliente)
                        End Using

                        dgvDetalleVentas.DataSource = datoscliente
                        CerrarConeccion()
                    Catch ex As Exception
                        MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Else
                    MessageBox.Show("El año y mes deben ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf (cmbFiltro.Text = "Día") Then
                If IsDate(txtParametro.Text) = True Then
                    Try
                        Conectar()
                        Dim consulta = "SELECT *FROM DetalleVenta WHERE FechaEntrada='" & txtParametro.Text & "'"
                        Dim datoscliente As New DataTable

                        Using adaptador As New SqlDataAdapter(consulta, coneccion)
                            adaptador.Fill(datoscliente)
                        End Using

                        dgvDetalleVentas.DataSource = datoscliente
                        CerrarConeccion()
                    Catch ex As Exception
                        MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("El formato de fecha es año-mes-dia (ej 2021-02-28)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf (cmbFiltro.Text = "Numero de Identidad Cliente") Then
                If IsNumeric(txtParametro.Text) = True Then
                    Try
                        Conectar()
                        Dim consulta = "SELECT DV.DetalleVentaId, DV.FkCodCliente, C.Nombre, C.Apellido, C.NumeroIdentidad, DV.CostoHabitacion,DV.GastoAdicional,
                        DV.FechaEntrada, DV.HoraEntrada, DV.FechaSalida, DV.HoraSalida, E.Nombre as AtendidoPor FROM DetalleVenta AS DV INNER JOIN Clientes AS C 
                        ON c.NumeroIdentidad='" & txtParametro.Text & "' AND DV.FkCodCliente = C.ClienteId INNER JOIN Empleados AS E on E.EmpleadoId = DV.FkEmpleadoId"
                        Dim datoscliente As New DataTable

                        Using adaptador As New SqlDataAdapter(consulta, coneccion)
                            adaptador.Fill(datoscliente)
                        End Using

                        dgvDetalleVentas.DataSource = datoscliente
                        CerrarConeccion()
                    Catch ex As Exception
                        MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try

                Else
                    MessageBox.Show("El formato de fecha es año-mes-dia (ej 2021-02-28)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Filtro no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub dgvDetalleVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleVentas.CellContentClick

    End Sub

    Private Sub cmbFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged
        If (cmbFiltro.SelectedItem.ToString = "Mes") Then
            lbParametro.Text = "Año"
            lbMes.Text = "Mes"
            txtMes.Enabled = True
        Else
            lbParametro.Text = ""
            lbMes.Text = ""
            txtMes.Enabled = False
        End If

    End Sub

    Private Sub dgvDetalleVentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalleVentas.CellDoubleClick
        Try
            frmGastosAdicionales.txtCodigoVenta.Text = dgvDetalleVentas.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try

        Me.Close()

    End Sub
End Class