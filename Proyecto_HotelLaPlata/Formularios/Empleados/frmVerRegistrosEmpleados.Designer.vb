<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVerRegistrosEmpleados
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvRegistros = New System.Windows.Forms.DataGridView()
        Me.lbMes = New System.Windows.Forms.Label()
        Me.lbParametro = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.cmbEmpleados = New System.Windows.Forms.ComboBox()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.Proyecto_hotelDataSet4 = New Proyecto_HotelLaPlata.proyecto_hotelDataSet4()
        'Me.EmpleadosTableAdapter = New Proyecto_HotelLaPlata.proyecto_hotelDataSet4TableAdapters.EmpleadosTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Proyecto_hotelDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRegistros
        '
        Me.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistros.Location = New System.Drawing.Point(134, 298)
        Me.dgvRegistros.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRegistros.Name = "dgvRegistros"
        Me.dgvRegistros.ReadOnly = True
        Me.dgvRegistros.RowHeadersWidth = 51
        Me.dgvRegistros.RowTemplate.Height = 24
        Me.dgvRegistros.Size = New System.Drawing.Size(775, 294)
        Me.dgvRegistros.TabIndex = 43
        '
        'lbMes
        '
        Me.lbMes.AutoSize = True
        Me.lbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMes.Location = New System.Drawing.Point(167, 176)
        Me.lbMes.Name = "lbMes"
        Me.lbMes.Size = New System.Drawing.Size(0, 20)
        Me.lbMes.TabIndex = 61
        '
        'lbParametro
        '
        Me.lbParametro.AutoSize = True
        Me.lbParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbParametro.Location = New System.Drawing.Point(167, 131)
        Me.lbParametro.Name = "lbParametro"
        Me.lbParametro.Size = New System.Drawing.Size(0, 20)
        Me.lbParametro.TabIndex = 60
        '
        'txtMes
        '
        Me.txtMes.Enabled = False
        Me.txtMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMes.Location = New System.Drawing.Point(335, 173)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(137, 24)
        Me.txtMes.TabIndex = 59
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(540, 208)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(92, 39)
        Me.btnBuscar.TabIndex = 58
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtParametro
        '
        Me.txtParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParametro.Location = New System.Drawing.Point(335, 128)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(137, 24)
        Me.txtParametro.TabIndex = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Buscar por"
        '
        'cmbFiltro
        '
        Me.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Items.AddRange(New Object() {"Año", "Mes", "Día", "Nombre Empleado"})
        Me.cmbFiltro.Location = New System.Drawing.Point(264, 68)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(208, 26)
        Me.cmbFiltro.TabIndex = 55
        '
        'cmbEmpleados
        '
        Me.cmbEmpleados.DataSource = Me.EmpleadosBindingSource
        Me.cmbEmpleados.DisplayMember = "Nombre"
        Me.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpleados.Enabled = False
        Me.cmbEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpleados.FormattingEnabled = True
        Me.cmbEmpleados.Location = New System.Drawing.Point(315, 215)
        Me.cmbEmpleados.Name = "cmbEmpleados"
        Me.cmbEmpleados.Size = New System.Drawing.Size(157, 26)
        Me.cmbEmpleados.TabIndex = 62
        Me.cmbEmpleados.ValueMember = "EmpleadoId"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        'Me.EmpleadosBindingSource.DataSource = Me.Proyecto_hotelDataSet4
        '
        'Proyecto_hotelDataSet4
        '
        'Me.Proyecto_hotelDataSet4.DataSetName = "proyecto_hotelDataSet4"
        'e.Proyecto_hotelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosTableAdapter
        '
        'Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(342, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(347, 24)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Ver Registros Diarios de Empleados"
        '
        'frmVerRegistrosEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 670)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbEmpleados)
        Me.Controls.Add(Me.lbMes)
        Me.Controls.Add(Me.lbParametro)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtParametro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.dgvRegistros)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmVerRegistrosEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVerRegistrosEmpleados"
        CType(Me.dgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        'Type(Me.Proyecto_hotelDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRegistros As DataGridView
    Friend WithEvents lbMes As Label
    Friend WithEvents lbParametro As Label
    Friend WithEvents txtMes As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtParametro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFiltro As ComboBox
    Friend WithEvents cmbEmpleados As ComboBox
    'riend WithEvents Proyecto_hotelDataSet4 As proyecto_hotelDataSet4
    Friend WithEvents EmpleadosBindingSource As BindingSource
    'riend WithEvents EmpleadosTableAdapter As proyecto_hotelDataSet4TableAdapters.EmpleadosTableAdapter
    Friend WithEvents Label3 As Label
End Class
