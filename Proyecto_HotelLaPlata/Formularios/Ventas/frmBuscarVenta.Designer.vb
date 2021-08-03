<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarVenta
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnRecargar = New System.Windows.Forms.Button()
        Me.btnBuscarVenta = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(492, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(463, 20)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Haga doble click en el registro de una venta para copiar su id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 20)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Ingrese un parámetro de búsqueda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(397, 20)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Buscar una venta por nombre o identidad del cliente"
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvVentas.ColumnHeadersHeight = 35
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVentas.EnableHeadersVisualStyles = False
        Me.dgvVentas.Location = New System.Drawing.Point(374, 124)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvVentas.RowHeadersWidth = 51
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvVentas.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvVentas.RowTemplate.Height = 24
        Me.dgvVentas.Size = New System.Drawing.Size(686, 360)
        Me.dgvVentas.TabIndex = 148
        '
        'txtParametro
        '
        Me.txtParametro.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParametro.Location = New System.Drawing.Point(47, 161)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(299, 26)
        Me.txtParametro.TabIndex = 147
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(492, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 23)
        Me.Label10.TabIndex = 154
        Me.Label10.Text = "Buscar venta"
        '
        'btnRecargar
        '
        Me.btnRecargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecargar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecargar.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnRecargar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Clear_Symbol_icon_2
        Me.btnRecargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecargar.Location = New System.Drawing.Point(48, 271)
        Me.btnRecargar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnRecargar.Size = New System.Drawing.Size(298, 48)
        Me.btnRecargar.TabIndex = 150
        Me.btnRecargar.Text = "Limpiar"
        Me.btnRecargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecargar.UseVisualStyleBackColor = False
        '
        'btnBuscarVenta
        '
        Me.btnBuscarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarVenta.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarVenta.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnBuscarVenta.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Search_icon1
        Me.btnBuscarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarVenta.Location = New System.Drawing.Point(47, 219)
        Me.btnBuscarVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarVenta.Name = "btnBuscarVenta"
        Me.btnBuscarVenta.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnBuscarVenta.Size = New System.Drawing.Size(299, 48)
        Me.btnBuscarVenta.TabIndex = 149
        Me.btnBuscarVenta.Text = "Buscar"
        Me.btnBuscarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarVenta.UseVisualStyleBackColor = False
        '
        'frmBuscarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1103, 606)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRecargar)
        Me.Controls.Add(Me.btnBuscarVenta)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.txtParametro)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1119, 645)
        Me.MinimumSize = New System.Drawing.Size(1119, 645)
        Me.Name = "frmBuscarVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar venta"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label3 As Label
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents btnRecargar As Button
    Friend WithEvents btnBuscarVenta As Button
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents txtParametro As TextBox
    Friend WithEvents Label10 As Label
End Class
