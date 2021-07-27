<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVerDetallesVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvDetalleVentas = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        'Me.Proyecto_hotelDataSet1 = New Proyecto_HotelLaPlata.proyecto_hotelDataSet()
        Me.lbParametro = New System.Windows.Forms.Label()
        Me.lbMes = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvDetalleVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Proyecto_hotelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDetalleVentas
        '
        Me.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleVentas.Location = New System.Drawing.Point(213, 242)
        Me.dgvDetalleVentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvDetalleVentas.Name = "dgvDetalleVentas"
        Me.dgvDetalleVentas.ReadOnly = True
        Me.dgvDetalleVentas.RowHeadersWidth = 51
        Me.dgvDetalleVentas.RowTemplate.Height = 24
        Me.dgvDetalleVentas.Size = New System.Drawing.Size(1033, 419)
        Me.dgvDetalleVentas.TabIndex = 0
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(769, 160)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(159, 67)
        Me.btnBuscar.TabIndex = 51
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtParametro
        '
        Me.txtParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParametro.Location = New System.Drawing.Point(360, 180)
        Me.txtParametro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(336, 27)
        Me.txtParametro.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(231, 74)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Buscar por"
        '
        'cmbFiltro
        '
        Me.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Items.AddRange(New Object() {"Año", "Mes", "Día", "Número de Identidad Cliente"})
        Me.cmbFiltro.Location = New System.Drawing.Point(360, 74)
        Me.cmbFiltro.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(336, 28)
        Me.cmbFiltro.TabIndex = 48
        '
        'Proyecto_hotelDataSet1
        '
        'Me.Proyecto_hotelDataSet1.DataSetName = "proyecto_hotelDataSet"
        'Me.Proyecto_hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbParametro
        '
        Me.lbParametro.AutoSize = True
        Me.lbParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbParametro.Location = New System.Drawing.Point(241, 187)
        Me.lbParametro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbParametro.Name = "lbParametro"
        Me.lbParametro.Size = New System.Drawing.Size(0, 20)
        Me.lbParametro.TabIndex = 53
        '
        'lbMes
        '
        Me.lbMes.AutoSize = True
        Me.lbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMes.Location = New System.Drawing.Point(241, 242)
        Me.lbMes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMes.Name = "lbMes"
        Me.lbMes.Size = New System.Drawing.Size(0, 20)
        Me.lbMes.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(533, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 25)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Ver Detalle de Ventas"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(637, 666)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 44)
        Me.Button2.TabIndex = 134
        Me.Button2.Text = "Recargar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(360, 130)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(336, 22)
        Me.dtpFecha.TabIndex = 135
        '
        'frmVerDetallesVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1364, 825)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbMes)
        Me.Controls.Add(Me.lbParametro)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtParametro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.dgvDetalleVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmVerDetallesVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVerDetallesVentas"
        CType(Me.dgvDetalleVentas, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Proyecto_hotelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDetalleVentas As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtParametro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFiltro As ComboBox
    'Friend WithEvents Proyecto_hotelDataSet1 As proyecto_hotelDataSet
    Friend WithEvents lbParametro As Label
    Friend WithEvents lbMes As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents dtpFecha As DateTimePicker
End Class
