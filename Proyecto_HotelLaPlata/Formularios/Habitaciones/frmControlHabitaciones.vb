'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Habitaciones
'   Formulario: frmControlHabitaciones
'   Función: realizar registros de las habitaciones
'-----------------------------------------------------------------------------------------------------------------
Public Class frmControlHabitaciones
    Private habitaciones As New clsHabitaciones()
    Private funciones As New clsFuncionesGenerales()

    Private editar As Boolean = False


    'Evento que se ejecuta al cargar el formulario
    Private Sub clsControlHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvHabitaciones, queriesHabitaciones("obtener"))

        funciones.llenarCombobox(cmbTipoAire, queriesHabitaciones("obtener_tipo_aires"))
        cmbTipoAire.DisplayMember = "DescripcionAire"
        cmbTipoAire.ValueMember = "TipoAireId"

        funciones.llenarCombobox(cmbTipoCama, queriesHabitaciones("obtener_tipo_camas"))
        cmbTipoCama.DisplayMember = "Descripcion"
        cmbTipoCama.ValueMember = "TipoCamaId"

        funciones.llenarCombobox(cmbTipoHabitacion, queriesHabitaciones("obtener_tipo_habitaciones"))
        cmbTipoHabitacion.DisplayMember = "Descripcion"
        cmbTipoHabitacion.ValueMember = "TipoHabitacionId"
    End Sub


    'Evento que se ejecuta al guardar un registro
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Se valida que no existan campos vacíos
        Dim textBoxes As New List(Of TextBox) From {txtNumeroHabitacion, txtCosto, txtCantCamas, txtCantAlmohadas, txtCantMesas,
                                                    txtCantSillas, txtCantTvs, txtObservacion}
        Dim validar = validarTextBoxVacios(textBoxes)

        'En caso de existir un campo vacío se muestra el campo
        If Not validar(0) Then
            MsgCampoVacio(validar(1))
        Else
            habitaciones._numeroHabitacion = Val(txtNumeroHabitacion.Text)
            habitaciones._costoHabitacion = Val(txtCosto.Text)
            habitaciones._cantCamas = Val(txtCantCamas.Text)
            habitaciones._cantMesas = Val(txtCantMesas.Text)
            habitaciones._cantSillas = Val(txtCantSillas.Text)
            habitaciones._cantAlmohadas = Val(txtCantAlmohadas.Text)
            habitaciones._cantTvs = Val(txtCantTvs.Text)
            habitaciones._observacion = txtObservacion.Text
            habitaciones._tipoHabitacionId = Val(cmbTipoHabitacion.SelectedValue)
            habitaciones._tipoAireId = Val(cmbTipoAire.SelectedValue)
            habitaciones._tipoCamaId = Val(cmbTipoCama.SelectedValue)

            If editar = True Then
                Dim res = habitaciones.actualizar()

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgActualizacionExitosa()
                    limpiarCampos()
                End If

                'Si editar es false se realizará una nueva inserción
            Else
                Dim res = habitaciones.insertar()

                If res(0) = False Then
                    MsgError(res(1))

                Else
                    MsgActualizacionExitosa()
                    limpiarCampos()
                End If

            End If
        End If

    End Sub

    'Método para limpiar todos los campos de la pantalla 
    Private Sub limpiarCampos()
        txtCantAlmohadas.Clear()
        txtCantCamas.Clear()
        txtCantMesas.Clear()
        txtCantSillas.Clear()
        txtCantTvs.Clear()
        txtCosto.Clear()
        txtNumeroHabitacion.Clear()
        txtObservacion.Clear()
        funciones.llenarDataGrid(dgvHabitaciones, queriesHabitaciones("obtener"))
        editar = False
    End Sub


    Private Sub dgvHabitaciones_DoubleClick(sender As Object, e As EventArgs) Handles dgvHabitaciones.DoubleClick
        txtNumeroHabitacion.Text = dgvHabitaciones.CurrentRow.Cells(0).Value
        txtCosto.Text = dgvHabitaciones.CurrentRow.Cells(1).Value
        txtCantCamas.Text = dgvHabitaciones.CurrentRow.Cells(2).Value
        txtCantAlmohadas.Text = dgvHabitaciones.CurrentRow.Cells(3).Value
        txtCantMesas.Text = dgvHabitaciones.CurrentRow.Cells(4).Value
        txtCantSillas.Text = dgvHabitaciones.CurrentRow.Cells(5).Value
        txtCantTvs.Text = dgvHabitaciones.CurrentRow.Cells(6).Value
        txtObservacion.Text = dgvHabitaciones.CurrentRow.Cells(10).Value

        editar = True
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        limpiarCampos()
    End Sub

    Private Sub txtNumeroHabitacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeroHabitacion.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtCantCamas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantCamas.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtCantAlmohadas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantAlmohadas.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtCantMesas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantMesas.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtCantSillas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantSillas.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtCantTvs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantTvs.KeyPress
        soloNumeros(e)
    End Sub
End Class