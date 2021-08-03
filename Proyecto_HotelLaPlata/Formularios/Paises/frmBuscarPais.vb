'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Formularios/Paises
'   Formulario: frmBuscarPais
'   Función: mostrar los paises para que el usuario seleccione uno
'----------------------------------------------------------------------------------------------------------------

Public Class frmBuscarPais

    'Instancias de la clases de clientes y las funciones generales
    Private funciones As New clsFuncionesGenerales()
    Private paises As New clsPaises()

    'Evento que se ejecuta al cargar el formulario
    Private Sub frmBuscarPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se llena el grid y se ocultan los id para que no sean visibles por el usuario
        funciones.llenarDataGrid(dgvPaises, queriesPaises("obtener"))
        dgvPaises.Columns("PaisId").Visible = False
    End Sub

    'Evento que se ejecuta al presionar el botón de buscar
    Private Sub btnBuscarPais_Click(sender As Object, e As EventArgs) Handles btnBuscarPais.Click
        If txtParametro.Text = "" Then
            MsgError2("Ingrese un país", "Campo vacío")
        Else
            paises._nombrePais = txtParametro.Text
            paises.obtenerPais(dgvPaises)
        End If
    End Sub

    'Evento que se ejecuta al hacer doble click en una fila del datagrid
    Private Sub dgvPaises_DoubleClick(sender As Object, e As EventArgs) Handles dgvPaises.DoubleClick
        'Se copian todos el elemento al formulario de nuevo cliente
        frmNuevoCliente.idPais = dgvPaises.CurrentRow.Cells(0).Value
        frmNuevoCliente.txtPais.Text = dgvPaises.CurrentRow.Cells(1).Value

        'Se cierra este formulario
        Me.Close()
    End Sub

    Private Sub txtParametro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtParametro.KeyPress
        soloLetrasyEspacios(e)
    End Sub

    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        txtParametro.Clear()
        funciones.llenarDataGrid(dgvPaises, queriesPaises("obtener"))
    End Sub
End Class