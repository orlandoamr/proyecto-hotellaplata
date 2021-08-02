Public Class frmDisponibilidad
    Private funciones As New clsFuncionesGenerales()
    Private Sub frmDisponibilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvHabitacionesOcupadas, queriesHabitaciones("obtener_ocupadas"))
        funciones.llenarDataGrid(dgvHabitacionesaDisponibles, queriesHabitaciones("obtener_disponibles"))
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class