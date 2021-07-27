<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistroDiarioEmpleados
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
        Me.btnEliminarRegistro = New System.Windows.Forms.Button()
        Me.btnActualizarRegistro = New System.Windows.Forms.Button()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnGuardarRegistro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtHoraSalida = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtHoraEntrada = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbEmpleados = New System.Windows.Forms.ComboBox()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'e.Proyecto_hotelDataSet3 = New Proyecto_HotelLaPlata.proyecto_hotelDataSet3()
        'e.EmpleadosTableAdapter = New Proyecto_HotelLaPlata.proyecto_hotelDataSet3TableAdapters.EmpleadosTableAdapter()
        Me.btnActualizarSalida = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdRegistro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        'Type(Me.Proyecto_hotelDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminarRegistro
        '
        Me.btnEliminarRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRegistro.Location = New System.Drawing.Point(396, 585)
        Me.btnEliminarRegistro.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarRegistro.Name = "btnEliminarRegistro"
        Me.btnEliminarRegistro.Size = New System.Drawing.Size(115, 55)
        Me.btnEliminarRegistro.TabIndex = 95
        Me.btnEliminarRegistro.Text = "Eliminar"
        Me.btnEliminarRegistro.UseVisualStyleBackColor = True
        '
        'btnActualizarRegistro
        '
        Me.btnActualizarRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarRegistro.Location = New System.Drawing.Point(265, 585)
        Me.btnActualizarRegistro.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizarRegistro.Name = "btnActualizarRegistro"
        Me.btnActualizarRegistro.Size = New System.Drawing.Size(115, 55)
        Me.btnActualizarRegistro.TabIndex = 94
        Me.btnActualizarRegistro.Text = "Actualizar"
        Me.btnActualizarRegistro.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Location = New System.Drawing.Point(363, 98)
        Me.dgvEmpleados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.RowHeadersWidth = 51
        Me.dgvEmpleados.RowTemplate.Height = 24
        Me.dgvEmpleados.Size = New System.Drawing.Size(638, 386)
        Me.dgvEmpleados.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Código Empleado"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(725, 56)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(81, 38)
        Me.btnBuscar.TabIndex = 90
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnGuardarRegistro
        '
        Me.btnGuardarRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarRegistro.Location = New System.Drawing.Point(132, 585)
        Me.btnGuardarRegistro.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardarRegistro.Name = "btnGuardarRegistro"
        Me.btnGuardarRegistro.Size = New System.Drawing.Size(115, 55)
        Me.btnGuardarRegistro.TabIndex = 89
        Me.btnGuardarRegistro.Text = "Registrar"
        Me.btnGuardarRegistro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 101)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Código"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(246, 98)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCodigo.MaxLength = 6
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(98, 24)
        Me.TxtCodigo.TabIndex = 87
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 358)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 20)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Observación"
        '
        'TxtObservacion
        '
        Me.TxtObservacion.AcceptsTab = True
        Me.TxtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.Location = New System.Drawing.Point(132, 354)
        Me.TxtObservacion.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtObservacion.MaxLength = 90
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(214, 24)
        Me.TxtObservacion.TabIndex = 85
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 300)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 20)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Hora de salida"
        '
        'TxtHoraSalida
        '
        Me.TxtHoraSalida.AcceptsTab = True
        Me.TxtHoraSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHoraSalida.Location = New System.Drawing.Point(246, 296)
        Me.TxtHoraSalida.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtHoraSalida.Name = "TxtHoraSalida"
        Me.TxtHoraSalida.Size = New System.Drawing.Size(99, 24)
        Me.TxtHoraSalida.TabIndex = 83
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 258)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 20)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "Hora de entrada"
        '
        'TxtHoraEntrada
        '
        Me.TxtHoraEntrada.AcceptsTab = True
        Me.TxtHoraEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHoraEntrada.Location = New System.Drawing.Point(246, 255)
        Me.TxtHoraEntrada.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtHoraEntrada.Name = "TxtHoraEntrada"
        Me.TxtHoraEntrada.Size = New System.Drawing.Size(98, 24)
        Me.TxtHoraEntrada.TabIndex = 81
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 189)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 20)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Fecha"
        '
        'cmbEmpleados
        '
        Me.cmbEmpleados.DataSource = Me.EmpleadosBindingSource
        Me.cmbEmpleados.DisplayMember = "Nombre"
        Me.cmbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpleados.FormattingEnabled = True
        Me.cmbEmpleados.Location = New System.Drawing.Point(207, 137)
        Me.cmbEmpleados.Name = "cmbEmpleados"
        Me.cmbEmpleados.Size = New System.Drawing.Size(139, 26)
        Me.cmbEmpleados.TabIndex = 97
        Me.cmbEmpleados.ValueMember = "EmpleadoId"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        'e.EmpleadosBindingSource.DataSource = Me.Proyecto_hotelDataSet3
        '
        'Proyecto_hotelDataSet3
        '
        'Me.Proyecto_hotelDataSet3.DataSetName = "proyecto_hotelDataSet3"
        'e.Proyecto_hotelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosTableAdapter
        '
        'e.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'btnActualizarSalida
        '
        Me.btnActualizarSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarSalida.Location = New System.Drawing.Point(752, 585)
        Me.btnActualizarSalida.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizarSalida.Name = "btnActualizarSalida"
        Me.btnActualizarSalida.Size = New System.Drawing.Size(115, 55)
        Me.btnActualizarSalida.TabIndex = 98
        Me.btnActualizarSalida.Text = "Actualizar Salida"
        Me.btnActualizarSalida.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(374, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 24)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Registro diario de empleados"
        '
        'dtpFechaRegistro
        '
        Me.dtpFechaRegistro.Enabled = False
        Me.dtpFechaRegistro.Location = New System.Drawing.Point(148, 189)
        Me.dtpFechaRegistro.Name = "dtpFechaRegistro"
        Me.dtpFechaRegistro.Size = New System.Drawing.Size(198, 20)
        Me.dtpFechaRegistro.TabIndex = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 228)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 16)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Formato de 24 horas(ejemplos: 9:00, 19:00)"
        '
        'txtIdRegistro
        '
        Me.txtIdRegistro.AcceptsTab = True
        Me.txtIdRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdRegistro.Location = New System.Drawing.Point(545, 63)
        Me.txtIdRegistro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdRegistro.MaxLength = 5
        Me.txtIdRegistro.Name = "txtIdRegistro"
        Me.txtIdRegistro.Size = New System.Drawing.Size(176, 24)
        Me.txtIdRegistro.TabIndex = 102
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(576, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 16)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Buscar registro por id"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(616, 488)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 38)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "Refrescar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmRegistroDiarioEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 670)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIdRegistro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFechaRegistro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnActualizarSalida)
        Me.Controls.Add(Me.cmbEmpleados)
        Me.Controls.Add(Me.btnEliminarRegistro)
        Me.Controls.Add(Me.btnActualizarRegistro)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnGuardarRegistro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtObservacion)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtHoraSalida)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtHoraEntrada)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRegistroDiarioEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistroDiarioEmpleados"
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        'Type(Me.Proyecto_hotelDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminarRegistro As Button
    Friend WithEvents btnActualizarRegistro As Button
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnGuardarRegistro As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtObservacion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtHoraSalida As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtHoraEntrada As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbEmpleados As ComboBox
    'riend WithEvents Proyecto_hotelDataSet3 As proyecto_hotelDataSet3
    Friend WithEvents EmpleadosBindingSource As BindingSource
    'Friend WithEvents EmpleadosTableAdapter As proyecto_hotelDataSet3TableAdapters.EmpleadosTableAdapter
    Friend WithEvents btnActualizarSalida As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFechaRegistro As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdRegistro As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
