Public Class frmAgregarServicios
    Private funciones As New clsFuncionesGenerales()

    Dim servicios As New Dictionary(Of String, Integer)
    Dim idServicios As New List(Of Integer)
    Private Sub frmAgregarServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        funciones.llenarDataGrid(dgvServiciosDisponibles, queriesServicios("obtener_disponibles"))
        dgvServiciosAsignados.Columns("ServicioId").Visible = False
        dgvServiciosDisponibles.Columns("ServicioId").Visible = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (dgvServiciosDisponibles.SelectedCells.Count > 0) Then
            Dim indice As Integer = dgvServiciosDisponibles.CurrentCell.RowIndex
            Dim idServicio = dgvServiciosDisponibles.Rows(indice).Cells(0).Value
            Dim servicio = dgvServiciosDisponibles.Rows(indice).Cells(1).Value
            Dim costoServicio = dgvServiciosDisponibles.Rows(indice).Cells(2).Value

            Dim todoBien As Boolean = True
            For Each id In servicios
                If id.Key = servicio Then
                    todoBien = False
                End If
            Next

            If todoBien = True Then
                idServicios.Add(idServicio)
                servicios.Add(servicio, costoServicio)
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
            servicios.Remove(servicio)
            idServicios.Remove(idServicio)

        End If
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If (dgvServiciosAsignados.SelectedCells.Count > 0) Then
            frmNuevaVenta.idServicios = idServicios
            frmNuevaVenta.servicios = servicios
            frmNuevaVenta.actualizarVentaServicios()
            Me.Close()
        Else
            MsgError2("Seleccione al menos un servicio", "Seleccione un servicio")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.Close()
    End Sub
End Class