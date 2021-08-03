<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPais
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
        Me.lbParametro = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRecargar = New System.Windows.Forms.Button()
        Me.btnBuscarPais = New System.Windows.Forms.Button()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvPaises = New System.Windows.Forms.DataGridView()
        CType(Me.dgvPaises, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbParametro
        '
        Me.lbParametro.AutoSize = True
        Me.lbParametro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbParametro.Location = New System.Drawing.Point(111, 4)
        Me.lbParametro.Name = "lbParametro"
        Me.lbParametro.Size = New System.Drawing.Size(0, 17)
        Me.lbParametro.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(160, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(436, 20)
        Me.Label3.TabIndex = 160
        Me.Label3.Text = "Haga doble click en el registro de un cliente para copiarlo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 20)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Ingrese un nombre de un país"
        '
        'btnRecargar
        '
        Me.btnRecargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecargar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecargar.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnRecargar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Clear_Symbol_icon_2
        Me.btnRecargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecargar.Location = New System.Drawing.Point(26, 236)
        Me.btnRecargar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnRecargar.Size = New System.Drawing.Size(298, 48)
        Me.btnRecargar.TabIndex = 157
        Me.btnRecargar.Text = "Limpiar"
        Me.btnRecargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecargar.UseVisualStyleBackColor = False
        '
        'btnBuscarPais
        '
        Me.btnBuscarPais.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnBuscarPais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPais.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPais.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnBuscarPais.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Search_icon1
        Me.btnBuscarPais.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarPais.Location = New System.Drawing.Point(25, 184)
        Me.btnBuscarPais.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscarPais.Name = "btnBuscarPais"
        Me.btnBuscarPais.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnBuscarPais.Size = New System.Drawing.Size(299, 48)
        Me.btnBuscarPais.TabIndex = 156
        Me.btnBuscarPais.Text = "Buscar"
        Me.btnBuscarPais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarPais.UseVisualStyleBackColor = False
        '
        'txtParametro
        '
        Me.txtParametro.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParametro.Location = New System.Drawing.Point(25, 126)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(299, 26)
        Me.txtParametro.TabIndex = 154
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(314, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 23)
        Me.Label10.TabIndex = 161
        Me.Label10.Text = "Buscar país"
        '
        'dgvPaises
        '
        Me.dgvPaises.AllowUserToAddRows = False
        Me.dgvPaises.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPaises.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPaises.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPaises.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPaises.ColumnHeadersHeight = 35
        Me.dgvPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPaises.EnableHeadersVisualStyles = False
        Me.dgvPaises.Location = New System.Drawing.Point(369, 83)
        Me.dgvPaises.Name = "dgvPaises"
        Me.dgvPaises.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPaises.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPaises.RowHeadersWidth = 51
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPaises.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPaises.RowTemplate.Height = 24
        Me.dgvPaises.Size = New System.Drawing.Size(362, 360)
        Me.dgvPaises.TabIndex = 162
        '
        'frmBuscarPais
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(769, 528)
        Me.Controls.Add(Me.dgvPaises)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRecargar)
        Me.Controls.Add(Me.btnBuscarPais)
        Me.Controls.Add(Me.txtParametro)
        Me.Controls.Add(Me.lbParametro)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(785, 567)
        Me.MinimumSize = New System.Drawing.Size(785, 567)
        Me.Name = "frmBuscarPais"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar país"
        CType(Me.dgvPaises, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbParametro As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label1 As Label
    Friend WithEvents btnRecargar As Button
    Friend WithEvents btnBuscarPais As Button
    Friend WithEvents txtParametro As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvPaises As DataGridView
End Class
