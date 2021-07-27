<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventarioHabitaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmbTipoCama = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcantMesas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcantSillas = New System.Windows.Forms.TextBox()
        Me.txtTipoAire = New System.Windows.Forms.TextBox()
        Me.btnActualizarInventario = New System.Windows.Forms.Button()
        Me.dgvInventario = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcantTV = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcantAlmohada = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcantCamas = New System.Windows.Forms.TextBox()
        Me.btnRegistrarInventario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCodidoHab = New System.Windows.Forms.ComboBox()
        Me.HabitacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.Proyecto_hotelDataSet2 = New Proyecto_HotelLaPlata.proyecto_hotelDataSet2()
        'Me.HabitacionesTableAdapter = New Proyecto_HotelLaPlata.proyecto_hotelDataSet2TableAdapters.HabitacionesTableAdapter()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Proyecto_hotelDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbTipoCama
        '
        Me.cmbTipoCama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoCama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoCama.FormattingEnabled = True
        Me.cmbTipoCama.Items.AddRange(New Object() {"Matrimonial", "Personal"})
        Me.cmbTipoCama.Location = New System.Drawing.Point(231, 160)
        Me.cmbTipoCama.Name = "cmbTipoCama"
        Me.cmbTipoCama.Size = New System.Drawing.Size(129, 26)
        Me.cmbTipoCama.TabIndex = 127
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(50, 405)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Tipo Aire"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(50, 321)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 20)
        Me.Label8.TabIndex = 125
        Me.Label8.Text = "Cantidad Mesas"
        '
        'txtcantMesas
        '
        Me.txtcantMesas.AcceptsTab = True
        Me.txtcantMesas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantMesas.Location = New System.Drawing.Point(231, 322)
        Me.txtcantMesas.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcantMesas.MaxLength = 1
        Me.txtcantMesas.Name = "txtcantMesas"
        Me.txtcantMesas.Size = New System.Drawing.Size(129, 24)
        Me.txtcantMesas.TabIndex = 124
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 361)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "Cantidad Sillas"
        '
        'txtcantSillas
        '
        Me.txtcantSillas.AcceptsTab = True
        Me.txtcantSillas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantSillas.Location = New System.Drawing.Point(231, 364)
        Me.txtcantSillas.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcantSillas.MaxLength = 1
        Me.txtcantSillas.Name = "txtcantSillas"
        Me.txtcantSillas.Size = New System.Drawing.Size(129, 24)
        Me.txtcantSillas.TabIndex = 122
        '
        'txtTipoAire
        '
        Me.txtTipoAire.AcceptsTab = True
        Me.txtTipoAire.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAire.Location = New System.Drawing.Point(231, 405)
        Me.txtTipoAire.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTipoAire.MaxLength = 15
        Me.txtTipoAire.Name = "txtTipoAire"
        Me.txtTipoAire.Size = New System.Drawing.Size(129, 24)
        Me.txtTipoAire.TabIndex = 121
        '
        'btnActualizarInventario
        '
        Me.btnActualizarInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarInventario.Location = New System.Drawing.Point(301, 581)
        Me.btnActualizarInventario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizarInventario.Name = "btnActualizarInventario"
        Me.btnActualizarInventario.Size = New System.Drawing.Size(115, 55)
        Me.btnActualizarInventario.TabIndex = 119
        Me.btnActualizarInventario.Text = "Actualizar"
        Me.btnActualizarInventario.UseVisualStyleBackColor = True
        '
        'dgvInventario
        '
        Me.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInventario.Location = New System.Drawing.Point(404, 115)
        Me.dgvInventario.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvInventario.Name = "dgvInventario"
        Me.dgvInventario.ReadOnly = True
        Me.dgvInventario.RowHeadersWidth = 51
        Me.dgvInventario.RowTemplate.Height = 24
        Me.dgvInventario.Size = New System.Drawing.Size(594, 330)
        Me.dgvInventario.TabIndex = 118
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 280)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 20)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Cantidad TVs"
        '
        'txtcantTV
        '
        Me.txtcantTV.AcceptsTab = True
        Me.txtcantTV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantTV.Location = New System.Drawing.Point(231, 281)
        Me.txtcantTV.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcantTV.MaxLength = 1
        Me.txtcantTV.Name = "txtcantTV"
        Me.txtcantTV.Size = New System.Drawing.Size(129, 24)
        Me.txtcantTV.TabIndex = 116
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 241)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 20)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Cantidad Almohadas"
        '
        'txtcantAlmohada
        '
        Me.txtcantAlmohada.AcceptsTab = True
        Me.txtcantAlmohada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantAlmohada.Location = New System.Drawing.Point(231, 241)
        Me.txtcantAlmohada.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcantAlmohada.MaxLength = 1
        Me.txtcantAlmohada.Name = "txtcantAlmohada"
        Me.txtcantAlmohada.Size = New System.Drawing.Size(129, 24)
        Me.txtcantAlmohada.TabIndex = 114
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 157)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Tipo Cama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 199)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Cantidad Camas"
        '
        'txtcantCamas
        '
        Me.txtcantCamas.AcceptsTab = True
        Me.txtcantCamas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantCamas.Location = New System.Drawing.Point(231, 200)
        Me.txtcantCamas.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcantCamas.MaxLength = 1
        Me.txtcantCamas.Name = "txtcantCamas"
        Me.txtcantCamas.Size = New System.Drawing.Size(129, 24)
        Me.txtcantCamas.TabIndex = 111
        '
        'btnRegistrarInventario
        '
        Me.btnRegistrarInventario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarInventario.Location = New System.Drawing.Point(159, 581)
        Me.btnRegistrarInventario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistrarInventario.Name = "btnRegistrarInventario"
        Me.btnRegistrarInventario.Size = New System.Drawing.Size(115, 55)
        Me.btnRegistrarInventario.TabIndex = 109
        Me.btnRegistrarInventario.Text = "Registrar"
        Me.btnRegistrarInventario.UseVisualStyleBackColor = True
        Me.btnRegistrarInventario.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Numero de Habitación"
        '
        'cmbCodidoHab
        '
        Me.cmbCodidoHab.DataSource = Me.HabitacionesBindingSource
        Me.cmbCodidoHab.DisplayMember = "NumHabitacion"
        Me.cmbCodidoHab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodidoHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCodidoHab.FormattingEnabled = True
        Me.cmbCodidoHab.Location = New System.Drawing.Point(231, 115)
        Me.cmbCodidoHab.Name = "cmbCodidoHab"
        Me.cmbCodidoHab.Size = New System.Drawing.Size(129, 26)
        Me.cmbCodidoHab.TabIndex = 128
        Me.cmbCodidoHab.ValueMember = "HabitacionId"
        '
        'HabitacionesBindingSource
        '
        Me.HabitacionesBindingSource.DataMember = "Habitaciones"
        'Me.HabitacionesBindingSource.DataSource = Me.Proyecto_hotelDataSet2
        '
        'Proyecto_hotelDataSet2
        '
        'Me.Proyecto_hotelDataSet2.DataSetName = "proyecto_hotelDataSet2"
        'Me.Proyecto_hotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HabitacionesTableAdapter
        '
        'Me.HabitacionesTableAdapter.ClearBeforeFill = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(388, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(258, 24)
        Me.Label10.TabIndex = 129
        Me.Label10.Text = "Inventario de Habitaciones"
        '
        'frmInventarioHabitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 670)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbCodidoHab)
        Me.Controls.Add(Me.cmbTipoCama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtcantMesas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcantSillas)
        Me.Controls.Add(Me.txtTipoAire)
        Me.Controls.Add(Me.btnActualizarInventario)
        Me.Controls.Add(Me.dgvInventario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtcantTV)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcantAlmohada)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcantCamas)
        Me.Controls.Add(Me.btnRegistrarInventario)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInventarioHabitaciones"
        Me.Text = "frmInventarioHabitaciones"
        CType(Me.dgvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Proyecto_hotelDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbTipoCama As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtcantMesas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtcantSillas As TextBox
    Friend WithEvents txtTipoAire As TextBox
    Friend WithEvents btnActualizarInventario As Button
    Friend WithEvents dgvInventario As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcantTV As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcantAlmohada As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcantCamas As TextBox
    Friend WithEvents btnRegistrarInventario As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCodidoHab As ComboBox
    'Friend WithEvents Proyecto_hotelDataSet2 As proyecto_hotelDataSet2
    Friend WithEvents HabitacionesBindingSource As BindingSource
    'Friend WithEvents HabitacionesTableAdapter As proyecto_hotelDataSet2TableAdapters.HabitacionesTableAdapter
    Friend WithEvents Label10 As Label
End Class
