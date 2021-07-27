<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Me.btnVerRegistros = New System.Windows.Forms.Button()
        Me.btnRegistroDiario = New System.Windows.Forms.Button()
        Me.btnNuevoEmpleado = New System.Windows.Forms.Button()
        Me.SubPanelEmpleados = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnVerRegistros
        '
        Me.btnVerRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerRegistros.Location = New System.Drawing.Point(611, 11)
        Me.btnVerRegistros.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVerRegistros.Name = "btnVerRegistros"
        Me.btnVerRegistros.Size = New System.Drawing.Size(179, 38)
        Me.btnVerRegistros.TabIndex = 7
        Me.btnVerRegistros.Text = "Ver Registros Diarios"
        Me.btnVerRegistros.UseVisualStyleBackColor = True
        '
        'btnRegistroDiario
        '
        Me.btnRegistroDiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroDiario.Location = New System.Drawing.Point(402, 11)
        Me.btnRegistroDiario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRegistroDiario.Name = "btnRegistroDiario"
        Me.btnRegistroDiario.Size = New System.Drawing.Size(179, 38)
        Me.btnRegistroDiario.TabIndex = 6
        Me.btnRegistroDiario.Text = "Registro Diario"
        Me.btnRegistroDiario.UseVisualStyleBackColor = True
        '
        'btnNuevoEmpleado
        '
        Me.btnNuevoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoEmpleado.Location = New System.Drawing.Point(190, 11)
        Me.btnNuevoEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNuevoEmpleado.Name = "btnNuevoEmpleado"
        Me.btnNuevoEmpleado.Size = New System.Drawing.Size(179, 38)
        Me.btnNuevoEmpleado.TabIndex = 4
        Me.btnNuevoEmpleado.Text = "Nuevo Empleado"
        Me.btnNuevoEmpleado.UseVisualStyleBackColor = True
        '
        'SubPanelEmpleados
        '
        Me.SubPanelEmpleados.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SubPanelEmpleados.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SubPanelEmpleados.Location = New System.Drawing.Point(0, 70)
        Me.SubPanelEmpleados.Name = "SubPanelEmpleados"
        Me.SubPanelEmpleados.Size = New System.Drawing.Size(1023, 670)
        Me.SubPanelEmpleados.TabIndex = 8
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1023, 740)
        Me.Controls.Add(Me.SubPanelEmpleados)
        Me.Controls.Add(Me.btnVerRegistros)
        Me.Controls.Add(Me.btnRegistroDiario)
        Me.Controls.Add(Me.btnNuevoEmpleado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmpleados"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVerRegistros As Button
    Friend WithEvents btnRegistroDiario As Button
    Friend WithEvents btnNuevoEmpleado As Button
    Friend WithEvents SubPanelEmpleados As Panel
End Class
