'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Servicios
'   Formulario: frmAgregarServicios
'   Función: Asignarle servicios a los clientes
'-----------------------------------------------------------------------------------------------------------------
Public Class frmAgregarServicios
    Private funciones As New clsFuncionesGenerales()
    Public servicios As New Dictionary(Of Integer, Dictionary(Of String, Integer))
    Private Sub frmAgregarServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvServiciosDisponibles, queriesServicios("obtener_disponibles"))
        dgvServiciosAsignados.Columns("ServicioId").Visible = False
        dgvServiciosDisponibles.Columns("ServicioId").Visible = False

        For Each id In servicios
            For Each ser In id.Value
                dgvServiciosAsignados.Rows.Add(id.Key, ser.Key, ser.Value)
            Next
        Next

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (dgvServiciosDisponibles.SelectedCells.Count > 0) Then
            Dim indice As Integer = dgvServiciosDisponibles.CurrentCell.RowIndex
            Dim idServicio = dgvServiciosDisponibles.Rows(indice).Cells(0).Value
            Dim servicio = dgvServiciosDisponibles.Rows(indice).Cells(1).Value
            Dim costoServicio = dgvServiciosDisponibles.Rows(indice).Cells(2).Value

            Dim todoBien As Boolean = True
            For Each id In servicios
                If id.Key = idServicio Then
                    todoBien = False
                End If
            Next



            If todoBien = True Then
                Dim dict As New Dictionary(Of String, Integer)
                dict.Add(servicio, costoServicio)

                servicios.Add(idServicio, dict)

                dgvServiciosAsignados.Rows.Add(idServicio, servicio, costoServicio)
            Else
                MsgError2("Ya ha agregado este servicio", "")
            End If


        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        If (dgvServiciosAsignados.SelectedCells.Count > 0) Then
            Dim indice As Integer = dgvServiciosAsignados.CurrentCell.RowIndex
            Dim idServicio = dgvServiciosAsignados.Rows(indice).Cells(0).Value

            Dim servicio = dgvServiciosDisponibles.Rows(indice).Cells(1).Value

            dgvServiciosAsignados.Rows.RemoveAt(indice)


            servicios.Remove(idServicio)

        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        frmNuevaVenta.servicios = servicios
        frmNuevaVenta.actualizarVentaServicios()
        frmNuevaVenta.actualizarVentaTotal()
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Close()
    End Sub
End Class