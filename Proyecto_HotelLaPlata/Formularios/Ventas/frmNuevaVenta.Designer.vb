<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaVenta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnRecargar = New System.Windows.Forms.Button()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBuscarDepto = New System.Windows.Forms.Button()
        Me.btnBuscarPais = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProcedencia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigoVenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Delete_icon
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.Location = New System.Drawing.Point(17, 14)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.btnCerrar.Size = New System.Drawing.Size(45, 42)
        Me.btnCerrar.TabIndex = 129
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(534, 735)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 20)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Haga doble click sobre un registro para editarlo"
        '
        'dgvClientes
        '
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvClientes.ColumnHeadersHeight = 35
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvClientes.EnableHeadersVisualStyles = False
        Me.dgvClientes.Location = New System.Drawing.Point(374, 117)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvClientes.RowHeadersWidth = 51
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvClientes.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvClientes.RowTemplate.Height = 24
        Me.dgvClientes.Size = New System.Drawing.Size(686, 615)
        Me.dgvClientes.TabIndex = 127
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
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(32, 790)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(298, 48)
        Me.btnLimpiarCampos.TabIndex = 126
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
        Me.btnEliminar.Location = New System.Drawing.Point(32, 735)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnEliminar.Size = New System.Drawing.Size(298, 48)
        Me.btnEliminar.TabIndex = 125
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
        Me.btnNuevo.Location = New System.Drawing.Point(32, 681)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnNuevo.Size = New System.Drawing.Size(298, 48)
        Me.btnNuevo.TabIndex = 124
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
        Me.btnGuardar.Location = New System.Drawing.Point(32, 626)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnGuardar.Size = New System.Drawing.Size(298, 48)
        Me.btnGuardar.TabIndex = 123
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnRecargar
        '
        Me.btnRecargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecargar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecargar.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnRecargar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Sync_icon
        Me.btnRecargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecargar.Location = New System.Drawing.Point(564, 790)
        Me.btnRecargar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnRecargar.Size = New System.Drawing.Size(298, 48)
        Me.btnRecargar.TabIndex = 122
        Me.btnRecargar.Text = "Recargar"
        Me.btnRecargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecargar.UseVisualStyleBackColor = False
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCliente.Location = New System.Drawing.Point(410, 79)
        Me.txtBuscarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBuscarCliente.MaxLength = 16
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(299, 25)
        Me.txtBuscarCliente.TabIndex = 121
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(451, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(131, 23)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Nueva Venta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(428, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(260, 20)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Busque un cliente por su identidad"
        '
        'btnBuscarDepto
        '
        Me.btnBuscarDepto.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnBuscarDepto.FlatAppearance.BorderSize = 0
        Me.btnBuscarDepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarDepto.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDepto.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Search_icon1
        Me.btnBuscarDepto.Location = New System.Drawing.Point(303, 336)
        Me.btnBuscarDepto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarDepto.Name = "btnBuscarDepto"
        Me.btnBuscarDepto.Size = New System.Drawing.Size(42, 41)
        Me.btnBuscarDepto.TabIndex = 118
        Me.btnBuscarDepto.UseVisualStyleBackColor = False
        '
        'btnBuscarPais
        '
        Me.btnBuscarPais.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnBuscarPais.Enabled = False
        Me.btnBuscarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPais.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPais.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Search_icon1
        Me.btnBuscarPais.Location = New System.Drawing.Point(303, 395)
        Me.btnBuscarPais.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarPais.Name = "btnBuscarPais"
        Me.btnBuscarPais.Size = New System.Drawing.Size(42, 41)
        Me.btnBuscarPais.TabIndex = 117
        Me.btnBuscarPais.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 385)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 20)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "País"
        '
        'txtPais
        '
        Me.txtPais.AccessibleName = "país"
        Me.txtPais.Enabled = False
        Me.txtPais.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.Location = New System.Drawing.Point(32, 405)
        Me.txtPais.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(268, 25)
        Me.txtPais.TabIndex = 115
        Me.txtPais.Text = "Honduras"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 326)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 20)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Departamento"
        '
        'txtProcedencia
        '
        Me.txtProcedencia.AccessibleName = "departamento"
        Me.txtProcedencia.Enabled = False
        Me.txtProcedencia.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcedencia.Location = New System.Drawing.Point(32, 346)
        Me.txtProcedencia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProcedencia.MaxLength = 29
        Me.txtProcedencia.Name = "txtProcedencia"
        Me.txtProcedencia.Size = New System.Drawing.Size(268, 25)
        Me.txtProcedencia.TabIndex = 112
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 197)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Fecha de entrada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 20)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Código de la venta"
        '
        'txtCodigoVenta
        '
        Me.txtCodigoVenta.AcceptsTab = True
        Me.txtCodigoVenta.AccessibleName = "nombre"
        Me.txtCodigoVenta.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoVenta.Location = New System.Drawing.Point(32, 100)
        Me.txtCodigoVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoVenta.MaxLength = 16
        Me.txtCodigoVenta.Name = "txtCodigoVenta"
        Me.txtCodigoVenta.Size = New System.Drawing.Size(268, 25)
        Me.txtCodigoVenta.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Código del cliente "
        '
        'txtApellido
        '
        Me.txtApellido.AcceptsTab = True
        Me.txtApellido.AccessibleName = "apellido"
        Me.txtApellido.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(32, 155)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellido.MaxLength = 16
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(268, 25)
        Me.txtApellido.TabIndex = 105
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnBuscar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Search_icon1
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.Location = New System.Drawing.Point(725, 64)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnBuscar.Size = New System.Drawing.Size(298, 48)
        Me.btnBuscar.TabIndex = 104
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(33, 220)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(267, 20)
        Me.DateTimePicker1.TabIndex = 130
        '
        'frmNuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 852)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnRecargar)
        Me.Controls.Add(Me.txtBuscarCliente)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnBuscarDepto)
        Me.Controls.Add(Me.btnBuscarPais)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtProcedencia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigoVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.btnBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNuevaVenta"
        Me.Text = "frmNuevaVenta"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As Button
    Private WithEvents Label1 As Label
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnRecargar As Button
    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents Label10 As Label
    Private WithEvents Label9 As Label
    Friend WithEvents btnBuscarDepto As Button
    Friend WithEvents btnBuscarPais As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtProcedencia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigoVenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
