<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarDetallesVentas
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
        Me.lbMes = New System.Windows.Forms.Label()
        Me.lbParametro = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.dgvDetalleVentas = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDetalleVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbMes
        '
        Me.lbMes.AutoSize = True
        Me.lbMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMes.Location = New System.Drawing.Point(132, 184)
        Me.lbMes.Name = "lbMes"
        Me.lbMes.Size = New System.Drawing.Size(0, 20)
        Me.lbMes.TabIndex = 62
        '
        'lbParametro
        '
        Me.lbParametro.AutoSize = True
        Me.lbParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbParametro.Location = New System.Drawing.Point(132, 139)
        Me.lbParametro.Name = "lbParametro"
        Me.lbParametro.Size = New System.Drawing.Size(0, 20)
        Me.lbParametro.TabIndex = 61
        '
        'txtMes
        '
        Me.txtMes.Enabled = False
        Me.txtMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMes.Location = New System.Drawing.Point(246, 181)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(137, 24)
        Me.txtMes.TabIndex = 60
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(444, 129)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(92, 39)
        Me.btnBuscar.TabIndex = 59
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtParametro
        '
        Me.txtParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParametro.Location = New System.Drawing.Point(246, 135)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(137, 24)
        Me.txtParametro.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Buscar por"
        '
        'cmbFiltro
        '
        Me.cmbFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Items.AddRange(New Object() {"Año", "Mes", "Día", "Numero de Identidad Cliente"})
        Me.cmbFiltro.Location = New System.Drawing.Point(226, 76)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(157, 26)
        Me.cmbFiltro.TabIndex = 56
        '
        'dgvDetalleVentas
        '
        Me.dgvDetalleVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleVentas.Location = New System.Drawing.Point(111, 230)
        Me.dgvDetalleVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvDetalleVentas.Name = "dgvDetalleVentas"
        Me.dgvDetalleVentas.ReadOnly = True
        Me.dgvDetalleVentas.RowHeadersWidth = 51
        Me.dgvDetalleVentas.RowTemplate.Height = 24
        Me.dgvDetalleVentas.Size = New System.Drawing.Size(775, 294)
        Me.dgvDetalleVentas.TabIndex = 55
        '
        'frmBuscarDetallesVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 600)
        Me.Controls.Add(Me.lbMes)
        Me.Controls.Add(Me.lbParametro)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtParametro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.dgvDetalleVentas)
        Me.Name = "frmBuscarDetallesVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmBuscarDetallesVentas"
        CType(Me.dgvDetalleVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbMes As Label
    Friend WithEvents lbParametro As Label
    Friend WithEvents txtMes As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtParametro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbFiltro As ComboBox
    Friend WithEvents dgvDetalleVentas As DataGridView
End Class
