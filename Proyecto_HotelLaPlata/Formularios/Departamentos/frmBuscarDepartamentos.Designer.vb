<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarDepartamentos
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
        Me.lbParametro = New System.Windows.Forms.Label()
        Me.dgvDeptos = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvDeptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbParametro
        '
        Me.lbParametro.AutoSize = True
        Me.lbParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbParametro.Location = New System.Drawing.Point(194, -8)
        Me.lbParametro.Name = "lbParametro"
        Me.lbParametro.Size = New System.Drawing.Size(0, 20)
        Me.lbParametro.TabIndex = 67
        '
        'dgvDeptos
        '
        Me.dgvDeptos.AllowUserToAddRows = False
        Me.dgvDeptos.AllowUserToDeleteRows = False
        Me.dgvDeptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDeptos.Location = New System.Drawing.Point(145, 88)
        Me.dgvDeptos.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDeptos.Name = "dgvDeptos"
        Me.dgvDeptos.ReadOnly = True
        Me.dgvDeptos.RowHeadersWidth = 51
        Me.dgvDeptos.RowTemplate.Height = 24
        Me.dgvDeptos.Size = New System.Drawing.Size(308, 367)
        Me.dgvDeptos.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 16)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Haga doble click en un departamento para seleccionarlo"
        '
        'frmBuscarDepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 528)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbParametro)
        Me.Controls.Add(Me.dgvDeptos)
        Me.Name = "frmBuscarDepartamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBuscarDepartamentos"
        CType(Me.dgvDeptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbParametro As Label
    Friend WithEvents dgvDeptos As DataGridView
    Friend WithEvents Label2 As Label
End Class
