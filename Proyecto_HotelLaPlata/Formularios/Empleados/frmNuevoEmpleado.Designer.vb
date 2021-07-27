<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevoEmpleado
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
        Me.btnEliminarEmpleado = New System.Windows.Forms.Button()
        Me.btnActualizarEmpleado = New System.Windows.Forms.Button()
        Me.DgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.lbCargo = New System.Windows.Forms.Label()
        Me.TxtCargo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNumIdentidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.btnRegistrarCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEliminarEmpleado
        '
        Me.btnEliminarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarEmpleado.Location = New System.Drawing.Point(481, 581)
        Me.btnEliminarEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminarEmpleado.Name = "btnEliminarEmpleado"
        Me.btnEliminarEmpleado.Size = New System.Drawing.Size(115, 55)
        Me.btnEliminarEmpleado.TabIndex = 52
        Me.btnEliminarEmpleado.Text = "Eliminar"
        Me.btnEliminarEmpleado.UseVisualStyleBackColor = True
        '
        'btnActualizarEmpleado
        '
        Me.btnActualizarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizarEmpleado.Location = New System.Drawing.Point(332, 581)
        Me.btnActualizarEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizarEmpleado.Name = "btnActualizarEmpleado"
        Me.btnActualizarEmpleado.Size = New System.Drawing.Size(115, 55)
        Me.btnActualizarEmpleado.TabIndex = 51
        Me.btnActualizarEmpleado.Text = "Actualizar"
        Me.btnActualizarEmpleado.UseVisualStyleBackColor = True
        '
        'DgvEmpleados
        '
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleados.Location = New System.Drawing.Point(417, 98)
        Me.DgvEmpleados.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.ReadOnly = True
        Me.DgvEmpleados.RowHeadersWidth = 51
        Me.DgvEmpleados.RowTemplate.Height = 24
        Me.DgvEmpleados.Size = New System.Drawing.Size(580, 375)
        Me.DgvEmpleados.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 371)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Correo"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.AcceptsTab = True
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(134, 367)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCorreo.MaxLength = 30
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(244, 24)
        Me.TxtCorreo.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 330)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Teléfono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.AcceptsTab = True
        Me.TxtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(249, 327)
        Me.TxtTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTelefono.MaxLength = 8
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(129, 24)
        Me.TxtTelefono.TabIndex = 46
        '
        'lbCargo
        '
        Me.lbCargo.AutoSize = True
        Me.lbCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCargo.Location = New System.Drawing.Point(43, 287)
        Me.lbCargo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCargo.Name = "lbCargo"
        Me.lbCargo.Size = New System.Drawing.Size(52, 20)
        Me.lbCargo.TabIndex = 45
        Me.lbCargo.Text = "Cargo"
        '
        'TxtCargo
        '
        Me.TxtCargo.AcceptsTab = True
        Me.TxtCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCargo.Location = New System.Drawing.Point(223, 284)
        Me.TxtCargo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCargo.MaxLength = 20
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(156, 24)
        Me.TxtCargo.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 241)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Numero de identidad"
        '
        'TxtNumIdentidad
        '
        Me.TxtNumIdentidad.AcceptsTab = True
        Me.TxtNumIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumIdentidad.Location = New System.Drawing.Point(223, 237)
        Me.TxtNumIdentidad.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNumIdentidad.MaxLength = 13
        Me.TxtNumIdentidad.Name = "TxtNumIdentidad"
        Me.TxtNumIdentidad.Size = New System.Drawing.Size(155, 24)
        Me.TxtNumIdentidad.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(43, 157)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.AcceptsTab = True
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(249, 154)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.MaxLength = 16
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(129, 24)
        Me.TxtNombre.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 199)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Apellido"
        '
        'TxtApellido
        '
        Me.TxtApellido.AcceptsTab = True
        Me.TxtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(249, 196)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtApellido.MaxLength = 16
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(129, 24)
        Me.TxtApellido.TabIndex = 38
        '
        'btnRegistrarCliente
        '
        Me.btnRegistrarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarCliente.Location = New System.Drawing.Point(183, 581)
        Me.btnRegistrarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistrarCliente.Name = "btnRegistrarCliente"
        Me.btnRegistrarCliente.Size = New System.Drawing.Size(115, 55)
        Me.btnRegistrarCliente.TabIndex = 36
        Me.btnRegistrarCliente.Text = "Registrar"
        Me.btnRegistrarCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 116)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Código"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(288, 112)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCodigo.MaxLength = 6
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(90, 24)
        Me.TxtCodigo.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(434, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(172, 24)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Nuevo Empleado"
        '
        'frmNuevoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 670)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnEliminarEmpleado)
        Me.Controls.Add(Me.btnActualizarEmpleado)
        Me.Controls.Add(Me.DgvEmpleados)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.lbCargo)
        Me.Controls.Add(Me.TxtCargo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNumIdentidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.btnRegistrarCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmNuevoEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmNuevoEmpleado"
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEliminarEmpleado As Button
    Friend WithEvents btnActualizarEmpleado As Button
    Friend WithEvents DgvEmpleados As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents lbCargo As Label
    Friend WithEvents TxtCargo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNumIdentidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents btnRegistrarCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label10 As Label
End Class
