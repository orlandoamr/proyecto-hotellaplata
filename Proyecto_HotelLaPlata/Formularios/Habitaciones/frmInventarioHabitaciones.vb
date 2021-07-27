Imports System.Data.SqlClient
Public Class frmInventarioHabitaciones
    Private Sub frmInventarioHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Proyecto_hotelDataSet2.Habitaciones' Puede moverla o quitarla según sea necesario.

        dgvUpdate()
        cmbTipoCama.SelectedIndex = 1
    End Sub
    Private Sub dgvUpdate()
        Try
            Conectar()
            Dim datosInventario As New DataTable
            Using adaptador As New SqlDataAdapter("select * from Habitaciones  as h inner join InventarioHabitaciones as ia on ia.FkHabitacionId = h.HabitacionId", coneccion)
                adaptador.Fill(datosInventario)
            End Using

            dgvInventario.DataSource = datosInventario
            CerrarConeccion()
        Catch ex As Exception
            CerrarConeccion()
            MessageBox.Show("Ocurrio un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegistrarInventario_Click(sender As Object, e As EventArgs) Handles btnRegistrarInventario.Click
        Dim todoCorrecto As Boolean = True

        If (cmbTipoCama.Text.Length = 0 Or txtcantCamas.Text.Length = 0 Or txtcantAlmohada.Text.Length = 0 Or txtcantTV.Text.Length = 0 Or txtcantMesas.Text.Length = 0 Or txtcantSillas.Text.Length = 0 Or txtTipoAire.Text.Length = 0) Then
            todoCorrecto = False
            MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsNumeric(txtcantCamas.Text) = False Or IsNumeric(txtcantAlmohada.Text) = False Or IsNumeric(txtcantTV.Text) = False Or IsNumeric(txtcantMesas.Text) = False Or IsNumeric(txtcantSillas.Text) = False Then
            todoCorrecto = False
            MessageBox.Show("Estos campos deben ser unicamente numéricos, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (todoCorrecto = True) Then
            Try
                Conectar()
                Dim consultaGuardar As String = "INSERT INTO InventarioHabitaciones(FkHabitacionId, TipoCama, CantCamas, CantAlmohadas, CantTvs, CantMesas, CantSillas, TipoAire) 
                VALUES(@FkHabitacionId, @TipoCama, @CantCamas, @CantAlmohadas, @CantTvs, @CantMesas, @CantSillas, @TipoAire)"
                Dim ejecutar As New SqlCommand(consultaGuardar, coneccion)
                ejecutar.Parameters.AddWithValue("@FKHabitacionId", (cmbCodidoHab.SelectedValue))
                ejecutar.Parameters.AddWithValue("@Tipocama", (cmbTipoCama.SelectedItem.ToString))
                ejecutar.Parameters.AddWithValue("@CantCamas", (txtcantCamas.Text))
                ejecutar.Parameters.AddWithValue("@CantAlmohadas", txtcantAlmohada.Text)
                ejecutar.Parameters.AddWithValue("@CantTvs", txtcantTV.Text)
                ejecutar.Parameters.AddWithValue("@CantMesas", txtcantMesas.Text)
                ejecutar.Parameters.AddWithValue("@CantSillas", txtcantSillas.Text)
                ejecutar.Parameters.AddWithValue("@TipoAire", txtTipoAire.Text)
                ejecutar.ExecuteNonQuery()
                CerrarConeccion()
                dgvUpdate()
            Catch ex As Exception
                CerrarConeccion()
                MessageBox.Show("Ocurrio un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btnActualizarInventario_Click(sender As Object, e As EventArgs) Handles btnActualizarInventario.Click
        Dim todoCorrecto As Boolean = True

        If (cmbTipoCama.Text.Length = 0 Or txtcantCamas.Text.Length = 0 Or txtcantAlmohada.Text.Length = 0 Or txtcantTV.Text.Length = 0 Or txtcantMesas.Text.Length = 0 Or txtcantSillas.Text.Length = 0 Or txtTipoAire.Text.Length = 0) Then
            todoCorrecto = False
            MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf IsNumeric(cmbCodidoHab.Text) = False Or IsNumeric(txtcantCamas.Text) = False Or IsNumeric(txtcantAlmohada.Text) = False Or IsNumeric(txtcantTV.Text) = False Or IsNumeric(txtcantMesas.Text) = False Or IsNumeric(txtcantSillas.Text) = False Then
            todoCorrecto = False
            MessageBox.Show("Estos campos deben ser unicamente numéricos, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If (todoCorrecto = True) Then
            Try
                Conectar()
                Dim datos As String = "update InventarioHabitaciones set TipoCama=@TipoCama,CantCamas=@CantCamas,CantAlmohadas=@CantAlmohadas,CantTvs=@CantTvs,CantMesas=@CantMesas where FkHabitacionId=@FkHabitacionId"
                Dim actualizar As New SqlCommand(datos, coneccion)

                actualizar.Parameters.AddWithValue("@FkHabitacionId", (cmbCodidoHab.SelectedValue))
                actualizar.Parameters.AddWithValue("@Tipocama", (cmbTipoCama.Text))
                actualizar.Parameters.AddWithValue("@CantCamas", (txtcantCamas.Text))
                actualizar.Parameters.AddWithValue("@CantAlmohadas", txtcantAlmohada.Text)
                actualizar.Parameters.AddWithValue("@CantTvs", txtcantTV.Text)
                actualizar.Parameters.AddWithValue("@CantMesas", txtcantMesas.Text)
                actualizar.Parameters.AddWithValue("@CantSillas", txtcantSillas.Text)
                actualizar.Parameters.AddWithValue("@TipoAire", txtTipoAire.Text)

                actualizar.ExecuteNonQuery()
                CerrarConeccion()
                dgvUpdate()
            Catch ex As Exception
                CerrarConeccion()
                MessageBox.Show("Ocurrio un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Conectar()
        Dim consulta As String
        consulta = InputBox("Buscar")

        If IsNumeric(consulta) = False Then
            MessageBox.Show("El codigo debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                consulta = "SELECT *FROM InventarioHabitaciones WHERE FkHabitacionId=" & consulta
                Dim datosinventario As New DataTable

                Using adaptador As New SqlDataAdapter(consulta, coneccion)
                    adaptador.Fill(datosinventario)
                End Using

                dgvInventario.DataSource = datosinventario
            Catch ex As Exception
                CerrarConeccion()
                MessageBox.Show("Ocurrio un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Private Sub txtcantCamas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantCamas.KeyPress
        soloNumeros(e)

    End Sub

    Private Sub txtcantAlmohada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantAlmohada.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtcantTV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantTV.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtcantMesas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantMesas.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtcantSillas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantSillas.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtTipoAire_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipoAire.KeyPress
        soloNumerosLetras(e)
    End Sub
End Class