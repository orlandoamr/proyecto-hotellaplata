'Formulario para realizar registros de nuevos clientes, actualizarlos y eliminarlos
Imports System.Data.SqlClient
Public Class frmNuevoCliente
    Public idDeptO = 0
    Public idPais = 76
    Private editar As Boolean = False

    Private clientes As New clsClientes()
    Private funciones As New clsFuncionesGenerales()
    Private Sub frmNuevoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvClientes, queriesClientes("obtener_todos"))
        dgvClientes.Columns("DepartamentoId").Visible = False
        dgvClientes.Columns("PaisId").Visible = False

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim textBoxes As New List(Of TextBox) From {txtNombre, txtApellido, txtIdentidad, txtPais}
        Dim val = validarTextBoxVacios(textBoxes)

        If Not val(0) Then
            MsgCampoVacio(val(1))

        ElseIf txtProcedencia.Text = "" And Not chkExtranjero.Checked Then
            MsgDepartamento()

        ElseIf Not chkExtranjero.Checked And Not validarIdentidad(txtIdentidad.Text) Then
            MsgIdentidadInvalida()

        Else
            clientes._clienteId = txtIdentidad.Text
            clientes._nombre = txtNombre.Text
            clientes._apellido = txtApellido.Text
            clientes._esExtranjero = chkExtranjero.Checked
            clientes._departamento = idDeptO
            clientes._pais = idPais

            If editar = True Then
                Dim res = clientes.guardar(queriesClientes("actualizar"))

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgRegistroExitoso()
                    LimpiarCampos()

                End If

            Else
                Dim res = clientes.guardar(queriesClientes("insertar"))

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgActualizacionExitosa()
                    LimpiarCampos()
                End If

            End If

            funciones.llenarDataGrid(dgvClientes, queriesClientes("obtener_todos"))
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If (txtIdentidad.Text = "") Then
            MsgCodigoVacio()
        Else
            clientes._clienteId = txtIdentidad.Text
            Dim res = clientes.eliminarCliente(queriesClientes("eliminar"))

            If Not (res(0) = True) Then
                MsgError(res(1))

            Else
                MsgEliminacionExitosa()
                LimpiarCampos()
                funciones.llenarDataGrid(dgvClientes, queriesClientes("obtener_todos"))
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If (txtBuscarCliente.Text = "") Then
            MsgIngreseId()
        Else
            clientes._parametroBusqueda = txtBuscarCliente.Text
            clientes.BuscarCliente(dgvClientes, queriesClientes("obtener_por_parametro"))
        End If

    End Sub

    Private Sub chkExtranjero_CheckedChanged(sender As Object, e As EventArgs) Handles chkExtranjero.CheckedChanged
        If (chkExtranjero.Checked = True) Then
            btnBuscarPais.Enabled = True
            btnBuscarDepto.Enabled = False
            idDeptO = 20
            txtPais.Clear()
            txtProcedencia.Clear()
        Else
            txtPais.Clear()
            txtPais.Text = "Honduras"
            idPais = 76
            btnBuscarPais.Enabled = False
            btnBuscarDepto.Enabled = True
        End If

    End Sub
    Private Sub dgvClientes_DoubleClick_1(sender As Object, e As EventArgs) Handles dgvClientes.DoubleClick
        txtIdentidad.Text = dgvClientes.CurrentRow.Cells(2).Value
        txtNombre.Text = dgvClientes.CurrentRow.Cells(0).Value
        txtApellido.Text = dgvClientes.CurrentRow.Cells(1).Value
        chkExtranjero.Checked = dgvClientes.CurrentRow.Cells(3).Value
        txtProcedencia.Text = dgvClientes.CurrentRow.Cells(4).Value
        txtPais.Text = dgvClientes.CurrentRow.Cells(5).Value
        idDeptO = dgvClientes.CurrentRow.Cells(6).Value
        idPais = dgvClientes.CurrentRow.Cells(7).Value
        editar = True
    End Sub


    Private Sub btnBuscarPais_Click(sender As Object, e As EventArgs) Handles btnBuscarPais.Click
        frmBuscarPais.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscarDepto.Click
        frmBuscarDepartamentos.Show()
    End Sub

    Public Sub LimpiarCampos()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtIdentidad.Text = ""
        txtProcedencia.Text = ""
        txtBuscarCliente.Text = ""
        chkExtranjero.Checked = False
        editar = False
    End Sub
    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        soloLetras(e)
    End Sub

    Private Sub txtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentidad.KeyPress
        soloNumerosLetras(e)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        LimpiarCampos()
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        editar = False
        LimpiarCampos()
    End Sub


    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        LimpiarCampos()
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        funciones.llenarDataGrid(dgvClientes, queriesClientes("obtener_todos"))
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class