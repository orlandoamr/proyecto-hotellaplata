'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Reportes
'   Formulario: frmReporteEmpleados
'   Función: generar un reporte de las ventas por rango de fechas
'-----------------------------------------------------------------------------------------------------------------
Public Class frmReporteVentas
    Private Sub frmReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEntrada.MaxDate = System.DateTime.Now
        dtpSalida.MaxDate = System.DateTime.Now
    End Sub

    Private Sub btnGenerar_Click_1(sender As Object, e As EventArgs) Handles btnGenerar.Click
        'TODO: This line of code loads data into the 'dataSet.Ventas' table. You can move, or remove it, as needed.
        Me.VentasTableAdapter.Fill(Me.dataSet.Ventas, dtpEntrada.Value, dtpSalida.Value)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub
End Class