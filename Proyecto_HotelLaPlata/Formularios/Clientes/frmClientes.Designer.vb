<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClientes
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
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.btnVerClientes = New System.Windows.Forms.Button()
        Me.btnDetalleVentas = New System.Windows.Forms.Button()
        Me.VerRegistrosDetalle = New System.Windows.Forms.Button()
        Me.btnGastos = New System.Windows.Forms.Button()
        Me.SubPanelClientes = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnNuevoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoCliente.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNuevoCliente.Location = New System.Drawing.Point(27, 20)
        Me.btnNuevoCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(239, 47)
        Me.btnNuevoCliente.TabIndex = 0
        Me.btnNuevoCliente.Text = "Nuevo Cliente"
        Me.btnNuevoCliente.UseVisualStyleBackColor = False
        '
        'btnVerClientes
        '
        Me.btnVerClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnVerClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerClientes.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerClientes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVerClientes.Location = New System.Drawing.Point(1091, 20)
        Me.btnVerClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVerClientes.Name = "btnVerClientes"
        Me.btnVerClientes.Size = New System.Drawing.Size(239, 47)
        Me.btnVerClientes.TabIndex = 1
        Me.btnVerClientes.Text = "Ver Clientes"
        Me.btnVerClientes.UseVisualStyleBackColor = False
        '
        'btnDetalleVentas
        '
        Me.btnDetalleVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnDetalleVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDetalleVentas.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetalleVentas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnDetalleVentas.Location = New System.Drawing.Point(300, 20)
        Me.btnDetalleVentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDetalleVentas.Name = "btnDetalleVentas"
        Me.btnDetalleVentas.Size = New System.Drawing.Size(236, 47)
        Me.btnDetalleVentas.TabIndex = 2
        Me.btnDetalleVentas.Text = "Detalle Ventas"
        Me.btnDetalleVentas.UseVisualStyleBackColor = False
        '
        'VerRegistrosDetalle
        '
        Me.VerRegistrosDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.VerRegistrosDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.VerRegistrosDetalle.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VerRegistrosDetalle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.VerRegistrosDetalle.Location = New System.Drawing.Point(828, 20)
        Me.VerRegistrosDetalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VerRegistrosDetalle.Name = "VerRegistrosDetalle"
        Me.VerRegistrosDetalle.Size = New System.Drawing.Size(239, 47)
        Me.VerRegistrosDetalle.TabIndex = 3
        Me.VerRegistrosDetalle.Text = "Ver Detalle Ventas"
        Me.VerRegistrosDetalle.UseVisualStyleBackColor = False
        '
        'btnGastos
        '
        Me.btnGastos.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGastos.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGastos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGastos.Location = New System.Drawing.Point(564, 20)
        Me.btnGastos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGastos.Name = "btnGastos"
        Me.btnGastos.Size = New System.Drawing.Size(239, 47)
        Me.btnGastos.TabIndex = 4
        Me.btnGastos.Text = "Gastos Adicionales"
        Me.btnGastos.UseVisualStyleBackColor = False
        '
        'SubPanelClientes
        '
        Me.SubPanelClientes.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SubPanelClientes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SubPanelClientes.Location = New System.Drawing.Point(0, 86)
        Me.SubPanelClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.SubPanelClientes.Name = "SubPanelClientes"
        Me.SubPanelClientes.Size = New System.Drawing.Size(1364, 825)
        Me.SubPanelClientes.TabIndex = 5
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1364, 911)
        Me.Controls.Add(Me.btnNuevoCliente)
        Me.Controls.Add(Me.btnGastos)
        Me.Controls.Add(Me.SubPanelClientes)
        Me.Controls.Add(Me.VerRegistrosDetalle)
        Me.Controls.Add(Me.btnDetalleVentas)
        Me.Controls.Add(Me.btnVerClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClientes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNuevoCliente As Button
    Friend WithEvents btnVerClientes As Button
    Friend WithEvents btnDetalleVentas As Button
    Friend WithEvents VerRegistrosDetalle As Button
    Friend WithEvents btnGastos As Button
    Friend WithEvents SubPanelClientes As Panel
End Class
