'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Habitaciones
'   Formulario: frmAsignarHabitaciones
'   Función: seleccionar habitaciones para una venta
'-----------------------------------------------------------------------------------------------------------------
Public Class frmAsignarHabitaciones
    Private funciones As New clsFuncionesGenerales()

    Public habitaciones As New Dictionary(Of Integer, Integer)

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmAsignarHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvHabitacionesDisponibles, queriesHabitaciones("obtener_disponibles"))

        For Each habitacion In habitaciones
            dgvHabitacionesAsignadas.Rows.Add(habitacion.Key, habitacion.Value)
        Next
    End Sub

    'Evento que se ejecuta al presionar el botón de agregar
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (dgvHabitacionesDisponibles.SelectedCells.Count > 0) Then
            Dim indice As Integer = dgvHabitacionesDisponibles.CurrentCell.RowIndex
            Dim numHabitacion = dgvHabitacionesDisponibles.Rows(indice).Cells(0).Value
            Dim costoHabitacion = dgvHabitacionesDisponibles.Rows(indice).Cells(1).Value

            Dim todoBien As Boolean = True

            For Each id In habitaciones
                If id.Key = numHabitacion Then
                    todoBien = False
                End If
            Next

            If todoBien = True Then
                habitaciones.Add(numHabitacion, costoHabitacion)
                dgvHabitacionesAsignadas.Rows.Add(numHabitacion, costoHabitacion)
            Else
                MsgError2("Ya ha agregado esta habitación", "")
            End If
        End If
    End Sub

    'Evento que se ejecuta al presionar el botón de quitar
    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If (dgvHabitacionesAsignadas.SelectedCells.Count > 0) Then
            Dim indice As Integer = dgvHabitacionesAsignadas.CurrentCell.RowIndex
            Dim numHabitacion = dgvHabitacionesAsignadas.Rows(indice).Cells(0).Value

            dgvHabitacionesAsignadas.Rows.RemoveAt(indice)
            habitaciones.Remove(numHabitacion)

        End If
    End Sub

    'Evento que se ejecuta al presionar el botón de confirmar
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If (dgvHabitacionesAsignadas.SelectedCells.Count > 0) Then
            frmNuevaVenta.habitaciones = habitaciones
            frmNuevaVenta.actualizarVentaHabitaciones()
            frmNuevaVenta.actualizarVentaTotal()
            Me.Close()
        Else
            MsgError2("Seleccione al menos una habitación", "Seleccione una habitación")
        End If
    End Sub
End Class