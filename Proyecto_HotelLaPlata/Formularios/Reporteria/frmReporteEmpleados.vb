'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Reportes
'   Formulario: frmReporteEmpleados
'   Función: generar un reporte de las salidas y entradas de los empleados al hotel por rango de fechas
'-----------------------------------------------------------------------------------------------------------------
Public Class frmReporteEmpleados
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        frmBuscarEmpleado.Show()
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        If txtCodigo.Text = "" Then
            MsgIngreseParametro()

        Else
            'TODO: This line of code loads data into the 'dataSet.DiarioEmpleados' table. You can move, or remove it, as needed.
            Me.DiarioEmpleadosTableAdapter.Fill(Me.dataSet.DiarioEmpleados, txtCodigo.Text, dtpEntrada.Value, dtpSalida.Value)
            ReportViewer1.RefreshReport()
            txtCodigo.Clear()
        End If
    End Sub

    Private Sub frmReporteEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpEntrada.MaxDate = System.DateTime.Now
        dtpSalida.MaxDate = System.DateTime.Now
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        frmInicio2.cargar()
    End Sub
End Class