<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.panelSubClientes = New System.Windows.Forms.Panel()
        Me.btnVerClientes = New System.Windows.Forms.Button()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.panelSubVentas = New System.Windows.Forms.Panel()
        Me.btnActualizarSalida = New System.Windows.Forms.Button()
        Me.btnServicios = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnGastosAdicionales = New System.Windows.Forms.Button()
        Me.btnVerDetalleVentas = New System.Windows.Forms.Button()
        Me.btnNuevaVenta = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.panelSubEmpleados = New System.Windows.Forms.Panel()
        Me.btnActSalida = New System.Windows.Forms.Button()
        Me.btnRegistroDiario = New System.Windows.Forms.Button()
        Me.btnNuevoEmpleado = New System.Windows.Forms.Button()
        Me.btnHabitaciones = New System.Windows.Forms.Button()
        Me.panelSubHabitaciones = New System.Windows.Forms.Panel()
        Me.btnDisponibilidad = New System.Windows.Forms.Button()
        Me.btnControlHabitaciones = New System.Windows.Forms.Button()
        Me.btnReporteria = New System.Windows.Forms.Button()
        Me.panelSubReporteria = New System.Windows.Forms.Panel()
        Me.btnReporteEmpleados = New System.Windows.Forms.Button()
        Me.btnReporteVentas = New System.Windows.Forms.Button()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.panelSubConfiguracion = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.panelSubClientes.SuspendLayout()
        Me.panelSubVentas.SuspendLayout()
        Me.panelSubEmpleados.SuspendLayout()
        Me.panelSubHabitaciones.SuspendLayout()
        Me.panelSubReporteria.SuspendLayout()
        Me.panelSubConfiguracion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbUsuario)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.pbLogo)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 852)
        Me.Panel1.TabIndex = 1
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.ForeColor = System.Drawing.Color.GhostWhite
        Me.lbUsuario.Location = New System.Drawing.Point(179, 198)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(0, 21)
        Me.lbUsuario.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(75, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Usuario:"
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Button2.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Help_icon
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(237, 805)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(109, 38)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Ayuda"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Button1.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Logout_Rounded_Left_icon1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(13, 805)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(93, 38)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Salir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.La_Plata13
        Me.pbLogo.Location = New System.Drawing.Point(79, -11)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(218, 197)
        Me.pbLogo.TabIndex = 1
        Me.pbLogo.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(157, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClientes)
        Me.FlowLayoutPanel1.Controls.Add(Me.panelSubClientes)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnVentas)
        Me.FlowLayoutPanel1.Controls.Add(Me.panelSubVentas)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnEmpleados)
        Me.FlowLayoutPanel1.Controls.Add(Me.panelSubEmpleados)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnHabitaciones)
        Me.FlowLayoutPanel1.Controls.Add(Me.panelSubHabitaciones)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnReporteria)
        Me.FlowLayoutPanel1.Controls.Add(Me.panelSubReporteria)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnConfiguracion)
        Me.FlowLayoutPanel1.Controls.Add(Me.panelSubConfiguracion)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(13, 251)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(361, 550)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnClientes
        '
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnClientes.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.People_icon_2_1
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClientes.Location = New System.Drawing.Point(4, 4)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(60, 0, 60, 0)
        Me.btnClientes.Size = New System.Drawing.Size(329, 81)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'panelSubClientes
        '
        Me.panelSubClientes.Controls.Add(Me.btnVerClientes)
        Me.panelSubClientes.Controls.Add(Me.btnNuevoCliente)
        Me.panelSubClientes.Location = New System.Drawing.Point(4, 93)
        Me.panelSubClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSubClientes.Name = "panelSubClientes"
        Me.panelSubClientes.Size = New System.Drawing.Size(329, 107)
        Me.panelSubClientes.TabIndex = 1
        Me.panelSubClientes.Visible = False
        '
        'btnVerClientes
        '
        Me.btnVerClientes.FlatAppearance.BorderSize = 0
        Me.btnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerClientes.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerClientes.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnVerClientes.Location = New System.Drawing.Point(78, 50)
        Me.btnVerClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVerClientes.Name = "btnVerClientes"
        Me.btnVerClientes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnVerClientes.Size = New System.Drawing.Size(179, 39)
        Me.btnVerClientes.TabIndex = 1
        Me.btnVerClientes.Text = "Ver Clientes"
        Me.btnVerClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerClientes.UseVisualStyleBackColor = True
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.FlatAppearance.BorderSize = 0
        Me.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoCliente.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCliente.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnNuevoCliente.Location = New System.Drawing.Point(78, 4)
        Me.btnNuevoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnNuevoCliente.Size = New System.Drawing.Size(179, 38)
        Me.btnNuevoCliente.TabIndex = 0
        Me.btnNuevoCliente.Text = "Nuevo Cliente"
        Me.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnVentas.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Bill_icon
        Me.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVentas.Location = New System.Drawing.Point(4, 208)
        Me.btnVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Padding = New System.Windows.Forms.Padding(60, 0, 60, 0)
        Me.btnVentas.Size = New System.Drawing.Size(329, 74)
        Me.btnVentas.TabIndex = 2
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'panelSubVentas
        '
        Me.panelSubVentas.Controls.Add(Me.btnActualizarSalida)
        Me.panelSubVentas.Controls.Add(Me.btnServicios)
        Me.panelSubVentas.Controls.Add(Me.btnProductos)
        Me.panelSubVentas.Controls.Add(Me.btnGastosAdicionales)
        Me.panelSubVentas.Controls.Add(Me.btnVerDetalleVentas)
        Me.panelSubVentas.Controls.Add(Me.btnNuevaVenta)
        Me.panelSubVentas.Location = New System.Drawing.Point(4, 290)
        Me.panelSubVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSubVentas.Name = "panelSubVentas"
        Me.panelSubVentas.Size = New System.Drawing.Size(329, 280)
        Me.panelSubVentas.TabIndex = 2
        Me.panelSubVentas.Visible = False
        '
        'btnActualizarSalida
        '
        Me.btnActualizarSalida.FlatAppearance.BorderSize = 0
        Me.btnActualizarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarSalida.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarSalida.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnActualizarSalida.Location = New System.Drawing.Point(78, 50)
        Me.btnActualizarSalida.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActualizarSalida.Name = "btnActualizarSalida"
        Me.btnActualizarSalida.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnActualizarSalida.Size = New System.Drawing.Size(179, 37)
        Me.btnActualizarSalida.TabIndex = 5
        Me.btnActualizarSalida.Text = "Actualizar salida"
        Me.btnActualizarSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarSalida.UseVisualStyleBackColor = True
        '
        'btnServicios
        '
        Me.btnServicios.FlatAppearance.BorderSize = 0
        Me.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServicios.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServicios.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnServicios.Location = New System.Drawing.Point(78, 230)
        Me.btnServicios.Margin = New System.Windows.Forms.Padding(4)
        Me.btnServicios.Name = "btnServicios"
        Me.btnServicios.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnServicios.Size = New System.Drawing.Size(179, 37)
        Me.btnServicios.TabIndex = 4
        Me.btnServicios.Text = "Control de servicios"
        Me.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServicios.UseVisualStyleBackColor = True
        '
        'btnProductos
        '
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnProductos.Location = New System.Drawing.Point(78, 185)
        Me.btnProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnProductos.Size = New System.Drawing.Size(179, 37)
        Me.btnProductos.TabIndex = 3
        Me.btnProductos.Text = "Control de productos"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.UseVisualStyleBackColor = True
        '
        'btnGastosAdicionales
        '
        Me.btnGastosAdicionales.FlatAppearance.BorderSize = 0
        Me.btnGastosAdicionales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGastosAdicionales.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGastosAdicionales.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnGastosAdicionales.Location = New System.Drawing.Point(78, 140)
        Me.btnGastosAdicionales.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGastosAdicionales.Name = "btnGastosAdicionales"
        Me.btnGastosAdicionales.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnGastosAdicionales.Size = New System.Drawing.Size(179, 37)
        Me.btnGastosAdicionales.TabIndex = 2
        Me.btnGastosAdicionales.Text = "Gastos Adicionales"
        Me.btnGastosAdicionales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGastosAdicionales.UseVisualStyleBackColor = True
        '
        'btnVerDetalleVentas
        '
        Me.btnVerDetalleVentas.FlatAppearance.BorderSize = 0
        Me.btnVerDetalleVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerDetalleVentas.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerDetalleVentas.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnVerDetalleVentas.Location = New System.Drawing.Point(78, 95)
        Me.btnVerDetalleVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVerDetalleVentas.Name = "btnVerDetalleVentas"
        Me.btnVerDetalleVentas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnVerDetalleVentas.Size = New System.Drawing.Size(179, 37)
        Me.btnVerDetalleVentas.TabIndex = 1
        Me.btnVerDetalleVentas.Text = "Ver detalle de venta"
        Me.btnVerDetalleVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerDetalleVentas.UseVisualStyleBackColor = True
        '
        'btnNuevaVenta
        '
        Me.btnNuevaVenta.FlatAppearance.BorderSize = 0
        Me.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevaVenta.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaVenta.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnNuevaVenta.Location = New System.Drawing.Point(78, 4)
        Me.btnNuevaVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevaVenta.Name = "btnNuevaVenta"
        Me.btnNuevaVenta.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnNuevaVenta.Size = New System.Drawing.Size(179, 38)
        Me.btnNuevaVenta.TabIndex = 0
        Me.btnNuevaVenta.Text = "Nueva Venta"
        Me.btnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevaVenta.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnEmpleados.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Management_icon_1
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmpleados.Location = New System.Drawing.Point(4, 578)
        Me.btnEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Padding = New System.Windows.Forms.Padding(60, 0, 60, 0)
        Me.btnEmpleados.Size = New System.Drawing.Size(329, 77)
        Me.btnEmpleados.TabIndex = 3
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'panelSubEmpleados
        '
        Me.panelSubEmpleados.Controls.Add(Me.btnActSalida)
        Me.panelSubEmpleados.Controls.Add(Me.btnRegistroDiario)
        Me.panelSubEmpleados.Controls.Add(Me.btnNuevoEmpleado)
        Me.panelSubEmpleados.Location = New System.Drawing.Point(4, 663)
        Me.panelSubEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSubEmpleados.Name = "panelSubEmpleados"
        Me.panelSubEmpleados.Size = New System.Drawing.Size(329, 134)
        Me.panelSubEmpleados.TabIndex = 3
        Me.panelSubEmpleados.Visible = False
        '
        'btnActSalida
        '
        Me.btnActSalida.FlatAppearance.BorderSize = 0
        Me.btnActSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActSalida.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActSalida.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnActSalida.Location = New System.Drawing.Point(78, 92)
        Me.btnActSalida.Margin = New System.Windows.Forms.Padding(4)
        Me.btnActSalida.Name = "btnActSalida"
        Me.btnActSalida.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnActSalida.Size = New System.Drawing.Size(179, 36)
        Me.btnActSalida.TabIndex = 2
        Me.btnActSalida.Text = "Actualizar salida"
        Me.btnActSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActSalida.UseVisualStyleBackColor = True
        '
        'btnRegistroDiario
        '
        Me.btnRegistroDiario.FlatAppearance.BorderSize = 0
        Me.btnRegistroDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistroDiario.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroDiario.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnRegistroDiario.Location = New System.Drawing.Point(78, 48)
        Me.btnRegistroDiario.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRegistroDiario.Name = "btnRegistroDiario"
        Me.btnRegistroDiario.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnRegistroDiario.Size = New System.Drawing.Size(179, 36)
        Me.btnRegistroDiario.TabIndex = 1
        Me.btnRegistroDiario.Text = "Registro Diario"
        Me.btnRegistroDiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistroDiario.UseVisualStyleBackColor = True
        '
        'btnNuevoEmpleado
        '
        Me.btnNuevoEmpleado.FlatAppearance.BorderSize = 0
        Me.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoEmpleado.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoEmpleado.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnNuevoEmpleado.Location = New System.Drawing.Point(78, 4)
        Me.btnNuevoEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNuevoEmpleado.Name = "btnNuevoEmpleado"
        Me.btnNuevoEmpleado.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnNuevoEmpleado.Size = New System.Drawing.Size(179, 36)
        Me.btnNuevoEmpleado.TabIndex = 0
        Me.btnNuevoEmpleado.Text = "Nuevo Empleado"
        Me.btnNuevoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoEmpleado.UseVisualStyleBackColor = True
        '
        'btnHabitaciones
        '
        Me.btnHabitaciones.FlatAppearance.BorderSize = 0
        Me.btnHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHabitaciones.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHabitaciones.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnHabitaciones.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Bedroom_icon_1
        Me.btnHabitaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHabitaciones.Location = New System.Drawing.Point(4, 805)
        Me.btnHabitaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHabitaciones.Name = "btnHabitaciones"
        Me.btnHabitaciones.Padding = New System.Windows.Forms.Padding(60, 0, 60, 0)
        Me.btnHabitaciones.Size = New System.Drawing.Size(329, 80)
        Me.btnHabitaciones.TabIndex = 4
        Me.btnHabitaciones.Text = "Habitaciones"
        Me.btnHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHabitaciones.UseVisualStyleBackColor = True
        '
        'panelSubHabitaciones
        '
        Me.panelSubHabitaciones.Controls.Add(Me.btnDisponibilidad)
        Me.panelSubHabitaciones.Controls.Add(Me.btnControlHabitaciones)
        Me.panelSubHabitaciones.Location = New System.Drawing.Point(4, 893)
        Me.panelSubHabitaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSubHabitaciones.Name = "panelSubHabitaciones"
        Me.panelSubHabitaciones.Size = New System.Drawing.Size(329, 93)
        Me.panelSubHabitaciones.TabIndex = 4
        Me.panelSubHabitaciones.Visible = False
        '
        'btnDisponibilidad
        '
        Me.btnDisponibilidad.FlatAppearance.BorderSize = 0
        Me.btnDisponibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisponibilidad.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisponibilidad.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnDisponibilidad.Location = New System.Drawing.Point(78, 50)
        Me.btnDisponibilidad.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDisponibilidad.Name = "btnDisponibilidad"
        Me.btnDisponibilidad.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnDisponibilidad.Size = New System.Drawing.Size(179, 39)
        Me.btnDisponibilidad.TabIndex = 1
        Me.btnDisponibilidad.Text = "Disponibilidad"
        Me.btnDisponibilidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDisponibilidad.UseVisualStyleBackColor = True
        '
        'btnControlHabitaciones
        '
        Me.btnControlHabitaciones.FlatAppearance.BorderSize = 0
        Me.btnControlHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnControlHabitaciones.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControlHabitaciones.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnControlHabitaciones.Location = New System.Drawing.Point(78, 4)
        Me.btnControlHabitaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.btnControlHabitaciones.Name = "btnControlHabitaciones"
        Me.btnControlHabitaciones.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnControlHabitaciones.Size = New System.Drawing.Size(179, 38)
        Me.btnControlHabitaciones.TabIndex = 0
        Me.btnControlHabitaciones.Text = "Control "
        Me.btnControlHabitaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnControlHabitaciones.UseVisualStyleBackColor = True
        '
        'btnReporteria
        '
        Me.btnReporteria.FlatAppearance.BorderSize = 0
        Me.btnReporteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteria.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteria.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnReporteria.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Report_File_icon
        Me.btnReporteria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReporteria.Location = New System.Drawing.Point(4, 994)
        Me.btnReporteria.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReporteria.Name = "btnReporteria"
        Me.btnReporteria.Padding = New System.Windows.Forms.Padding(60, 0, 60, 0)
        Me.btnReporteria.Size = New System.Drawing.Size(329, 75)
        Me.btnReporteria.TabIndex = 5
        Me.btnReporteria.Text = "Reporteria"
        Me.btnReporteria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteria.UseVisualStyleBackColor = True
        '
        'panelSubReporteria
        '
        Me.panelSubReporteria.Controls.Add(Me.btnReporteEmpleados)
        Me.panelSubReporteria.Controls.Add(Me.btnReporteVentas)
        Me.panelSubReporteria.Location = New System.Drawing.Point(4, 1077)
        Me.panelSubReporteria.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSubReporteria.Name = "panelSubReporteria"
        Me.panelSubReporteria.Size = New System.Drawing.Size(329, 109)
        Me.panelSubReporteria.TabIndex = 5
        Me.panelSubReporteria.Visible = False
        '
        'btnReporteEmpleados
        '
        Me.btnReporteEmpleados.FlatAppearance.BorderSize = 0
        Me.btnReporteEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteEmpleados.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteEmpleados.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnReporteEmpleados.Location = New System.Drawing.Point(78, 57)
        Me.btnReporteEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReporteEmpleados.Name = "btnReporteEmpleados"
        Me.btnReporteEmpleados.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnReporteEmpleados.Size = New System.Drawing.Size(179, 35)
        Me.btnReporteEmpleados.TabIndex = 1
        Me.btnReporteEmpleados.Text = "Reporte empleados"
        Me.btnReporteEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteEmpleados.UseVisualStyleBackColor = True
        '
        'btnReporteVentas
        '
        Me.btnReporteVentas.FlatAppearance.BorderSize = 0
        Me.btnReporteVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporteVentas.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporteVentas.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnReporteVentas.Location = New System.Drawing.Point(78, 14)
        Me.btnReporteVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReporteVentas.Name = "btnReporteVentas"
        Me.btnReporteVentas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnReporteVentas.Size = New System.Drawing.Size(179, 35)
        Me.btnReporteVentas.TabIndex = 0
        Me.btnReporteVentas.Text = "Reporte ventas"
        Me.btnReporteVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporteVentas.UseVisualStyleBackColor = True
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.FlatAppearance.BorderSize = 0
        Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfiguracion.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnConfiguracion.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Administrative_Tools_icon_2_1
        Me.btnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfiguracion.Location = New System.Drawing.Point(4, 1194)
        Me.btnConfiguracion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Padding = New System.Windows.Forms.Padding(60, 0, 60, 0)
        Me.btnConfiguracion.Size = New System.Drawing.Size(329, 79)
        Me.btnConfiguracion.TabIndex = 6
        Me.btnConfiguracion.Text = "Usuarios"
        Me.btnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfiguracion.UseVisualStyleBackColor = True
        '
        'panelSubConfiguracion
        '
        Me.panelSubConfiguracion.Controls.Add(Me.btnUsuarios)
        Me.panelSubConfiguracion.Location = New System.Drawing.Point(4, 1281)
        Me.panelSubConfiguracion.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSubConfiguracion.Name = "panelSubConfiguracion"
        Me.panelSubConfiguracion.Size = New System.Drawing.Size(329, 47)
        Me.panelSubConfiguracion.TabIndex = 6
        Me.panelSubConfiguracion.Visible = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnUsuarios.Location = New System.Drawing.Point(78, 5)
        Me.btnUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnUsuarios.Size = New System.Drawing.Size(179, 36)
        Me.btnUsuarios.TabIndex = 0
        Me.btnUsuarios.Text = "Control "
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(373, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1077, 852)
        Me.PanelContenedor.TabIndex = 2
        '
        'frmInicio2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 852)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1466, 891)
        Me.MinimumSize = New System.Drawing.Size(1466, 891)
        Me.Name = "frmInicio2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de control  Hotel La Plata"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.panelSubClientes.ResumeLayout(False)
        Me.panelSubVentas.ResumeLayout(False)
        Me.panelSubEmpleados.ResumeLayout(False)
        Me.panelSubHabitaciones.ResumeLayout(False)
        Me.panelSubReporteria.ResumeLayout(False)
        Me.panelSubConfiguracion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnClientes As Button
    Friend WithEvents panelSubClientes As Panel
    Friend WithEvents btnVerClientes As Button
    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents panelSubVentas As Panel
    Friend WithEvents btnVerDetalleVentas As Button
    Friend WithEvents btnNuevaVenta As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents panelSubEmpleados As Panel
    Friend WithEvents btnRegistroDiario As Button
    Friend WithEvents btnNuevoEmpleado As Button
    Friend WithEvents btnHabitaciones As Button
    Friend WithEvents panelSubHabitaciones As Panel
    Friend WithEvents btnDisponibilidad As Button
    Friend WithEvents btnControlHabitaciones As Button
    Friend WithEvents btnReporteria As Button
    Friend WithEvents panelSubReporteria As Panel
    Friend WithEvents btnReporteEmpleados As Button
    Friend WithEvents btnReporteVentas As Button
    Friend WithEvents btnConfiguracion As Button
    Friend WithEvents panelSubConfiguracion As Panel
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnGastosAdicionales As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnServicios As Button
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lbUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnActualizarSalida As Button
    Friend WithEvents btnActSalida As Button
End Class
