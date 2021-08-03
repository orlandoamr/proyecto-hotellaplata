'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Habitaciones
'   Formulario: frmDisponibilidad
'   Función: mostrar la disponibilidad de las habitaciones
'-----------------------------------------------------------------------------------------------------------------

Public Class frmDisponibilidad
    Private funciones As New clsFuncionesGenerales()

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmDisponibilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvHabitacionesOcupadas, queriesHabitaciones("obtener_ocupadas"))
        funciones.llenarDataGrid(dgvHabitacionesaDisponibles, queriesHabitaciones("obtener_disponibles"))
    End Sub

    'Evento que se ejecuta al presionar el botón cerrar
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub

    'Evento que se ejecuta al presionar el botón refrescar
    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        funciones.llenarDataGrid(dgvHabitacionesOcupadas, queriesHabitaciones("obtener_ocupadas"))
        funciones.llenarDataGrid(dgvHabitacionesaDisponibles, queriesHabitaciones("obtener_disponibles"))
    End Sub
End Class