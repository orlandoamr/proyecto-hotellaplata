<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHabitaciones
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
        Me.SubPanelHabitaciones = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'SubPanelHabitaciones
        '
        Me.SubPanelHabitaciones.BackColor = System.Drawing.SystemColors.ControlLight
        Me.SubPanelHabitaciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SubPanelHabitaciones.Location = New System.Drawing.Point(0, 70)
        Me.SubPanelHabitaciones.Name = "SubPanelHabitaciones"
        Me.SubPanelHabitaciones.Size = New System.Drawing.Size(1023, 670)
        Me.SubPanelHabitaciones.TabIndex = 0
        '
        'frmHabitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1023, 740)
        Me.Controls.Add(Me.SubPanelHabitaciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmHabitaciones"
        Me.Text = "frmHabitaciones"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SubPanelHabitaciones As Panel
End Class
