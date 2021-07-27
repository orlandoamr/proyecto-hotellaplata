<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleVentas
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
        Me.btnEliminarVenta = New System.Windows.Forms.Button()
        Me.btnActualizarVenta = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoCliente = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnRegistrarVenta = New System.Windows.Forms.Button()
        Me.txtCostoTotalHab = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodigoventa = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.cmbatn = New System.Windows.Forms.ComboBox()
        Me.Empleados1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectohotelDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        'Me.Proyecto_hotelDataSet = New Proyecto_HotelLaPlata.proyecto_hotelDataSet()
        Me.EmpleadosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        'Me.Proyecto_hotelDataSet11 = New Proyecto_HotelLaPlata.proyecto_hotelDataSet1()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbhabitacion = New System.Windows.Forms.ComboBox()
        Me.HabitacionesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        'Me.Proyecto_hotelDataSet5 = New Proyecto_HotelLaPlata.proyecto_hotelDataSet5()
        Me.HabitacionesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyectohotelDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.HabitacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.HabitacionesTableAdapter = New Proyecto_HotelLaPlata.proyecto_hotelDataSetTableAdapters.HabitacionesTableAdapter()
        ' Me.Proyecto_hotelDataSet1 = New Proyecto_HotelLaPlata.proyecto_hotelDataSet()
        Me.ProyectohotelDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        ' Me.EmpleadosTableAdapter = New Proyecto_HotelLaPlata.proyecto_hotelDataSet1TableAdapters.EmpleadosTableAdapter()
        Me.EmpleadosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        ' Me.EmpleadosTableAdapter1 = New Proyecto_HotelLaPlata.proyecto_hotelDataSetTableAdapters.EmpleadosTableAdapter()
        ' Me.Empleados1TableAdapter = New Proyecto_HotelLaPlata.proyecto_hotelDataSetTableAdapters.Empleados1TableAdapter()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnActualizarSalida = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        'Me.HabitacionesTableAdapter1 = New Proyecto_HotelLaPlata.proyecto_hotelDataSet5TableAdapters.HabitacionesTableAdapter()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBuscarDepto = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Empleados1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectohotelDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Proyecto_hotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        ' CType(Me.Proyecto_hotelDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Proyecto_hotelDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectohotelDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Proyecto_hotelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyectohotelDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminarVenta
        '
        Me.btnEliminarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarVenta.Location = New System.Drawing.Point(929, 730)
        Me.btnEliminarVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarVenta.Name = "btnEliminarVenta"
        Me.btnEliminarVenta.Size = New System.Drawing.Size(115, 55)
        Me.btnEliminarVenta.TabIndex = 107
        Me.btnEliminarVenta.Text = "Eliminar"
        Me.btnEliminarVenta.UseVisualStyleBackColor = True
        '
        'btnActualizarVenta
        '
        Me.btnActualizarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarVenta.Location = New System.Drawing.Point(799, 690)
        Me.btnActualizarVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizarVenta.Name = "btnActualizarVenta"
        Me.btnActualizarVenta.Size = New System.Drawing.Size(115, 55)
        Me.btnActualizarVenta.TabIndex = 106
        Me.btnActualizarVenta.Text = "Actualizar"
        Me.btnActualizarVenta.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(380, 99)
        Me.dgvVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.RowHeadersWidth = 51
        Me.dgvVentas.RowTemplate.Height = 24
        Me.dgvVentas.Size = New System.Drawing.Size(686, 528)
        Me.dgvVentas.TabIndex = 105
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Código Cliente"
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.Enabled = False
        Me.txtCodigoCliente.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCliente.Location = New System.Drawing.Point(42, 126)
        Me.txtCodigoCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Size = New System.Drawing.Size(261, 25)
        Me.txtCodigoCliente.TabIndex = 103
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(511, 706)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(73, 39)
        Me.btnBuscar.TabIndex = 102
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnRegistrarVenta
        '
        Me.btnRegistrarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarVenta.Location = New System.Drawing.Point(622, 666)
        Me.btnRegistrarVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistrarVenta.Name = "btnRegistrarVenta"
        Me.btnRegistrarVenta.Size = New System.Drawing.Size(115, 55)
        Me.btnRegistrarVenta.TabIndex = 101
        Me.btnRegistrarVenta.Text = "Registrar"
        Me.btnRegistrarVenta.UseVisualStyleBackColor = True
        '
        'txtCostoTotalHab
        '
        Me.txtCostoTotalHab.AcceptsTab = True
        Me.txtCostoTotalHab.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoTotalHab.Location = New System.Drawing.Point(44, 261)
        Me.txtCostoTotalHab.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCostoTotalHab.MaxLength = 6
        Me.txtCostoTotalHab.Name = "txtCostoTotalHab"
        Me.txtCostoTotalHab.Size = New System.Drawing.Size(299, 25)
        Me.txtCostoTotalHab.TabIndex = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Código Venta"
        '
        'txtcodigoventa
        '
        Me.txtcodigoventa.Enabled = False
        Me.txtcodigoventa.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoventa.Location = New System.Drawing.Point(42, 66)
        Me.txtcodigoventa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoventa.Name = "txtcodigoventa"
        Me.txtcodigoventa.Size = New System.Drawing.Size(261, 25)
        Me.txtcodigoventa.TabIndex = 98
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(39, 437)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 20)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "Observación"
        '
        'txtobservacion
        '
        Me.txtobservacion.AcceptsTab = True
        Me.txtobservacion.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservacion.Location = New System.Drawing.Point(42, 461)
        Me.txtobservacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtobservacion.MaxLength = 50
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.Size = New System.Drawing.Size(299, 80)
        Me.txtobservacion.TabIndex = 96
        '
        'cmbatn
        '
        Me.cmbatn.DataSource = Me.Empleados1BindingSource
        Me.cmbatn.DisplayMember = "Nombre"
        Me.cmbatn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbatn.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbatn.FormattingEnabled = True
        Me.cmbatn.Location = New System.Drawing.Point(482, 528)
        Me.cmbatn.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbatn.Name = "cmbatn"
        Me.cmbatn.Size = New System.Drawing.Size(160, 27)
        Me.cmbatn.TabIndex = 91
        Me.cmbatn.ValueMember = "EmpleadoId"
        '
        'Empleados1BindingSource
        '
        Me.Empleados1BindingSource.DataMember = "Empleados1"
        Me.Empleados1BindingSource.DataSource = Me.ProyectohotelDataSetBindingSource1
        '
        'ProyectohotelDataSetBindingSource1
        '
        'Me.ProyectohotelDataSetBindingSource1.DataSource = Me.Proyecto_hotelDataSet
        Me.ProyectohotelDataSetBindingSource1.Position = 0
        '
        'Proyecto_hotelDataSet
        '
        'Me.Proyecto_hotelDataSet.DataSetName = "proyecto_hotelDataSet"
        'Me.Proyecto_hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource2
        '
        Me.EmpleadosBindingSource2.DataMember = "Empleados"
        'Me.EmpleadosBindingSource2.DataSource = Me.Proyecto_hotelDataSet11
        '
        'Proyecto_hotelDataSet11
        '
        'Me.Proyecto_hotelDataSet11.DataSetName = "proyecto_hotelDataSet1"
        ' Me.Proyecto_hotelDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        'Me.EmpleadosBindingSource.DataSource = Me.Proyecto_hotelDataSet11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(478, 509)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 20)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Atendido por"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(41, 304)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 20)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Fecha Entrada"
        '
        'cmbhabitacion
        '
        Me.cmbhabitacion.DataSource = Me.HabitacionesBindingSource2
        Me.cmbhabitacion.DisplayMember = "NumHabitacion"
        Me.cmbhabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbhabitacion.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbhabitacion.FormattingEnabled = True
        Me.cmbhabitacion.Location = New System.Drawing.Point(42, 193)
        Me.cmbhabitacion.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbhabitacion.Name = "cmbhabitacion"
        Me.cmbhabitacion.Size = New System.Drawing.Size(301, 27)
        Me.cmbhabitacion.TabIndex = 87
        Me.cmbhabitacion.ValueMember = "HabitacionId"
        '
        'HabitacionesBindingSource2
        '
        Me.HabitacionesBindingSource2.DataMember = "Habitaciones"
        ' Me.HabitacionesBindingSource2.DataSource = Me.Proyecto_hotelDataSet5
        '
        'Proyecto_hotelDataSet5
        '
        'Me.Proyecto_hotelDataSet5.DataSetName = "proyecto_hotelDataSet5"
        'Me.Proyecto_hotelDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HabitacionesBindingSource1
        '
        Me.HabitacionesBindingSource1.DataMember = "Habitaciones"
        Me.HabitacionesBindingSource1.DataSource = Me.ProyectohotelDataSetBindingSource
        '
        'ProyectohotelDataSetBindingSource
        '
        'Me.ProyectohotelDataSetBindingSource.DataSource = Me.Proyecto_hotelDataSet
        Me.ProyectohotelDataSetBindingSource.Position = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 242)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 20)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Costo total de la habitación"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 174)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 20)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Habitación asignada"
        '
        'HabitacionesBindingSource
        '
        Me.HabitacionesBindingSource.DataMember = "Habitaciones"
        'Me.HabitacionesBindingSource.DataSource = Me.Proyecto_hotelDataSet
        '
        'HabitacionesTableAdapter
        '
        'Me.HabitacionesTableAdapter.ClearBeforeFill = True
        '
        'Proyecto_hotelDataSet1
        '
        'Me.Proyecto_hotelDataSet1.DataSetName = "proyecto_hotelDataSet"
        'Me.Proyecto_hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyectohotelDataSet1BindingSource
        '
        'Me.ProyectohotelDataSet1BindingSource.DataSource = Me.Proyecto_hotelDataSet1
        Me.ProyectohotelDataSet1BindingSource.Position = 0
        '
        'EmpleadosTableAdapter
        '
        'Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosBindingSource1
        '
        Me.EmpleadosBindingSource1.DataMember = "Empleados"
        Me.EmpleadosBindingSource1.DataSource = Me.ProyectohotelDataSet1BindingSource
        '
        'EmpleadosTableAdapter1
        '
        'Me.EmpleadosTableAdapter1.ClearBeforeFill = True
        '
        'Empleados1TableAdapter
        '
        'Me.Empleados1TableAdapter.ClearBeforeFill = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarCliente.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.icons8_search_24
        Me.btnBuscarCliente.Location = New System.Drawing.Point(638, 728)
        Me.btnBuscarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(47, 34)
        Me.btnBuscarCliente.TabIndex = 109
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 378)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Fecha Salida"
        '
        'btnActualizarSalida
        '
        Me.btnActualizarSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarSalida.Location = New System.Drawing.Point(918, 631)
        Me.btnActualizarSalida.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizarSalida.Name = "btnActualizarSalida"
        Me.btnActualizarSalida.Size = New System.Drawing.Size(115, 55)
        Me.btnActualizarSalida.TabIndex = 112
        Me.btnActualizarSalida.Text = "Actualizar Salida"
        Me.btnActualizarSalida.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 23)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Detalle de Ventas"
        '
        'dtpHoraEntrada
        '
        Me.dtpHoraEntrada.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraEntrada.Location = New System.Drawing.Point(44, 325)
        Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
        Me.dtpHoraEntrada.Size = New System.Drawing.Size(299, 25)
        Me.dtpHoraEntrada.TabIndex = 115
        '
        'dtpHoraSalida
        '
        Me.dtpHoraSalida.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraSalida.Location = New System.Drawing.Point(44, 399)
        Me.dtpHoraSalida.Name = "dtpHoraSalida"
        Me.dtpHoraSalida.Size = New System.Drawing.Size(299, 25)
        Me.dtpHoraSalida.TabIndex = 116
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCliente.Location = New System.Drawing.Point(403, 66)
        Me.txtBuscarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscarCliente.MaxLength = 16
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(266, 25)
        Me.txtBuscarCliente.TabIndex = 117
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(399, 45)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(339, 20)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Buscar una venta por la identidad del cliente"
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrescar.Location = New System.Drawing.Point(938, 690)
        Me.btnRefrescar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(95, 36)
        Me.btnRefrescar.TabIndex = 119
        Me.btnRefrescar.Text = "Recargar"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'HabitacionesTableAdapter1
        '
        'Me.HabitacionesTableAdapter1.ClearBeforeFill = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(799, 631)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(115, 55)
        Me.btnLimpiar.TabIndex = 120
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarCampos.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarCampos.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnLimpiarCampos.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Clear_Symbol_icon_2
        Me.btnLimpiarCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(43, 721)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(298, 48)
        Me.btnLimpiarCampos.TabIndex = 124
        Me.btnLimpiarCampos.Text = "Limpiar"
        Me.btnLimpiarCampos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiarCampos.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.AliceBlue
        Me.btnEliminar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Delete_Bin_icon
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.Location = New System.Drawing.Point(43, 666)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnEliminar.Size = New System.Drawing.Size(298, 48)
        Me.btnEliminar.TabIndex = 123
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnNuevo.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Plus_icon
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.Location = New System.Drawing.Point(43, 612)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnNuevo.Size = New System.Drawing.Size(298, 48)
        Me.btnNuevo.TabIndex = 122
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnGuardar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Save_icon
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.Location = New System.Drawing.Point(43, 557)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnGuardar.Size = New System.Drawing.Size(298, 48)
        Me.btnGuardar.TabIndex = 121
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnBuscarDepto
        '
        Me.btnBuscarDepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnBuscarDepto.FlatAppearance.BorderSize = 0
        Me.btnBuscarDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarDepto.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDepto.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Search_icon1
        Me.btnBuscarDepto.Location = New System.Drawing.Point(307, 58)
        Me.btnBuscarDepto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarDepto.Name = "btnBuscarDepto"
        Me.btnBuscarDepto.Size = New System.Drawing.Size(42, 41)
        Me.btnBuscarDepto.TabIndex = 125
        Me.btnBuscarDepto.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Search_icon1
        Me.Button1.Location = New System.Drawing.Point(307, 118)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 41)
        Me.Button1.TabIndex = 126
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Button2.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Search_icon1
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(742, 45)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.Button2.Size = New System.Drawing.Size(298, 48)
        Me.Button2.TabIndex = 127
        Me.Button2.Text = "Buscar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmDetalleVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 852)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBuscarDepto)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBuscarCliente)
        Me.Controls.Add(Me.dtpHoraSalida)
        Me.Controls.Add(Me.dtpHoraEntrada)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnActualizarSalida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.btnEliminarVenta)
        Me.Controls.Add(Me.btnActualizarVenta)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnRegistrarVenta)
        Me.Controls.Add(Me.txtCostoTotalHab)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcodigoventa)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtobservacion)
        Me.Controls.Add(Me.cmbatn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbhabitacion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmDetalleVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalleVentas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Empleados1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectohotelDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Proyecto_hotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Proyecto_hotelDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Proyecto_hotelDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectohotelDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Proyecto_hotelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyectohotelDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminarVenta As Button
    Friend WithEvents btnActualizarVenta As Button
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoCliente As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnRegistrarVenta As Button
    Friend WithEvents txtCostoTotalHab As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcodigoventa As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents cmbatn As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbhabitacion As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    ' Friend WithEvents Proyecto_hotelDataSet As proyecto_hotelDataSet
    Friend WithEvents HabitacionesBindingSource As BindingSource
    'Friend WithEvents HabitacionesTableAdapter As proyecto_hotelDataSetTableAdapters.HabitacionesTableAdapter
    Friend WithEvents ProyectohotelDataSetBindingSource As BindingSource
    Friend WithEvents HabitacionesBindingSource1 As BindingSource
    Friend WithEvents ProyectohotelDataSet1BindingSource As BindingSource
    'Friend WithEvents Proyecto_hotelDataSet1 As proyecto_hotelDataSet
    'Friend WithEvents Proyecto_hotelDataSet11 As proyecto_hotelDataSet1
    Friend WithEvents EmpleadosBindingSource As BindingSource
    'Friend WithEvents EmpleadosTableAdapter As proyecto_hotelDataSet1TableAdapters.EmpleadosTableAdapter
    Friend WithEvents EmpleadosBindingSource1 As BindingSource
    'Friend WithEvents EmpleadosTableAdapter1 As proyecto_hotelDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents EmpleadosBindingSource2 As BindingSource
    Friend WithEvents ProyectohotelDataSetBindingSource1 As BindingSource
    Friend WithEvents Empleados1BindingSource As BindingSource
    'Friend WithEvents Empleados1TableAdapter As proyecto_hotelDataSetTableAdapters.Empleados1TableAdapter
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnActualizarSalida As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpHoraEntrada As DateTimePicker
    Friend WithEvents dtpHoraSalida As DateTimePicker
    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRefrescar As Button
    'Friend WithEvents Proyecto_hotelDataSet5 As proyecto_hotelDataSet5
    Friend WithEvents HabitacionesBindingSource2 As BindingSource
    'Friend WithEvents HabitacionesTableAdapter1 As proyecto_hotelDataSet5TableAdapters.HabitacionesTableAdapter
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBuscarDepto As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
