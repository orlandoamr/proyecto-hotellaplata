Imports System.Data.SqlClient

Public Class frmProductos
    Private Sub frmBuscarPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUpdate()
    End Sub
    Private Sub dgvUpdate()
        Try
            Conectar()
            Dim paises As New DataTable
            Using adaptador As New SqlDataAdapter("select * from Productos", coneccion)
                adaptador.Fill(paises)
            End Using

            dgvProductos.DataSource = paises
            CerrarConeccion()
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error en la coneccion a la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Dim consulta As String
        consulta = txtParametro.Text
        Try
            Conectar()
            consulta = "SELECT *FROM Productos WHERE NombreProducto='" & consulta & "'"
            Dim paises As New DataTable

            Using adaptador As New SqlDataAdapter(consulta, coneccion)
                adaptador.Fill(paises)
            End Using

            dgvProductos.DataSource = paises
            CerrarConeccion()

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error en la coneccion con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtParametro_TextChanged(sender As Object, e As EventArgs) Handles txtParametro.TextChanged

    End Sub

    Private Sub dgvPaises_DoubleClick(sender As Object, e As EventArgs) Handles dgvProductos.DoubleClick
        Try
            frmGastosAdicionales.TxtProducto.Text = dgvProductos.CurrentRow.Cells(1).Value
            frmGastosAdicionales.idProducto = dgvProductos.CurrentRow.Cells(0).Value
            frmGastosAdicionales.precioProducto = dgvProductos.CurrentRow.Cells(2).Value
            frmGastosAdicionales.txtPrecio.Text = dgvProductos.CurrentRow.Cells(2).Value
        Catch ex As Exception

        End Try


        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dgvPaises_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtProducto.Text.Length = 0 Or txtPrecio.Text = 0 Then
            MessageBox.Show("No puede dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Conectar()

                Dim sql = "INSERT INTO Productos(NombreProducto, Precio) VALUES(@NombreProducto, @Precio)"
                Dim actualizar As New SqlCommand(sql, coneccion)

                actualizar.Parameters.AddWithValue("@NombreProducto", txtProducto.Text)
                actualizar.Parameters.AddWithValue("@Precio", Val(txtPrecio.Text))

                actualizar.ExecuteNonQuery()
                CerrarConeccion()

                txtPrecio.Clear()
                txtProducto.Clear()

                dgvUpdate()
                MessageBox.Show("Registro realizado con éxito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Ocurrio un error en la conección a la base de datos" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try


        End If
    End Sub

    Private Sub txtProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProducto.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        soloNumeros(e)
    End Sub
End Class