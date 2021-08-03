Public Class frmEntrada
    Private funciones As New clsFuncionesGenerales()
    Private Sub frmEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones._parametro = System.DateTime.Now.ToString()
        crtHabitaciones.DataSource = funciones.obtenerDatos(queriesHabitaciones("top_vendidas"))
        crtHabitaciones.Series("Series1").XValueMember = "Número de habitación"
        crtHabitaciones.Series("Series1").YValueMembers = "Total ventas"
        crtHabitaciones.Series("Series1").LegendText = "Habitaciones más vendidas"

        crtVentasAnio.DataSource = funciones.obtenerDatos(queriesVentas("obtener_ventas_anio"))
        Dim res = funciones.obtenerDatos(queriesVentas("obtener_ventas_anio"))
        crtVentasAnio.Series("Series1").XValueMember = "Mes"
        crtVentasAnio.Series("Series1").YValueMembers = "TotalVenta"
        crtVentasAnio.Series("Series1").IsValueShownAsLabel = True
    End Sub

End Class