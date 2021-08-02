Imports System.Data.SqlClient
Public Class clsCargos
    Inherits clsEjecutarQuery

    Private cargoId As Integer
    Private cargoDescripcion As String

    Public Property _cargoId As Integer
        Get
            Return cargoId
        End Get
        Set(value As Integer)
            cargoId = value
        End Set
    End Property
    Public Property _cargoDescripcion As String
        Get
            Return cargoDescripcion
        End Get
        Set(value As String)
            cargoDescripcion = value
        End Set
    End Property

    Public Function insertar()

        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@Descripcion", cargoDescripcion)
        }

        Return ejecutar(queriesCargos("insertar"), parametros)
    End Function

    Public Function actualizar()
        Dim parametros As New List(Of SqlParameter) From {
             New SqlParameter("@CargoId", cargoId),
             New SqlParameter("@Descripcion", cargoDescripcion)
        }

        Return ejecutar(queriesCargos("actualizar"), parametros)
    End Function

    Public Sub obtenerCargos(cmb As ComboBox)
        cmb.DataSource = obtener(queriesCargos("obtener"), Nothing)
        cmb.DisplayMember = "Descripción del cargo"
        cmb.ValueMember = "CargoId"
    End Sub

End Class
