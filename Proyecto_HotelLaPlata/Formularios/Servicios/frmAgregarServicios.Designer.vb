<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarServicios
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvServiciosAsignados = New System.Windows.Forms.DataGridView()
        Me.ServicioId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Servicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvServiciosDisponibles = New System.Windows.Forms.DataGridView()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvServiciosAsignados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvServiciosDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(666, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Servicios asignados"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 20)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "Servicios disponibles"
        '
        'dgvServiciosAsignados
        '
        Me.dgvServiciosAsignados.AllowUserToAddRows = False
        Me.dgvServiciosAsignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvServiciosAsignados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvServiciosAsignados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiciosAsignados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvServiciosAsignados.ColumnHeadersHeight = 35
        Me.dgvServiciosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvServiciosAsignados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServicioId, Me.Servicio, Me.Precio})
        Me.dgvServiciosAsignados.EnableHeadersVisualStyles = False
        Me.dgvServiciosAsignados.Location = New System.Drawing.Point(670, 93)
        Me.dgvServiciosAsignados.Name = "dgvServiciosAsignados"
        Me.dgvServiciosAsignados.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiciosAsignados.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvServiciosAsignados.RowHeadersWidth = 51
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvServiciosAsignados.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvServiciosAsignados.RowTemplate.Height = 24
        Me.dgvServiciosAsignados.Size = New System.Drawing.Size(378, 280)
        Me.dgvServiciosAsignados.TabIndex = 137
        '
        'ServicioId
        '
        Me.ServicioId.HeaderText = "ServicioId"
        Me.ServicioId.Name = "ServicioId"
        Me.ServicioId.ReadOnly = True
        Me.ServicioId.Width = 97
        '
        'Servicio
        '
        Me.Servicio.HeaderText = "Nombre del servicio"
        Me.Servicio.Name = "Servicio"
        Me.Servicio.ReadOnly = True
        Me.Servicio.Width = 168
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio del servicio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 156
        '
        'dgvServiciosDisponibles
        '
        Me.dgvServiciosDisponibles.AllowUserToAddRows = False
        Me.dgvServiciosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvServiciosDisponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvServiciosDisponibles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiciosDisponibles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvServiciosDisponibles.ColumnHeadersHeight = 35
        Me.dgvServiciosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvServiciosDisponibles.EnableHeadersVisualStyles = False
        Me.dgvServiciosDisponibles.Location = New System.Drawing.Point(42, 93)
        Me.dgvServiciosDisponibles.Name = "dgvServiciosDisponibles"
        Me.dgvServiciosDisponibles.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiciosDisponibles.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvServiciosDisponibles.RowHeadersWidth = 51
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.dgvServiciosDisponibles.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvServiciosDisponibles.RowTemplate.Height = 24
        Me.dgvServiciosDisponibles.Size = New System.Drawing.Size(401, 455)
        Me.dgvServiciosDisponibles.TabIndex = 136
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnQuitar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Expand_Arrow_icon_3_Copy
        Me.btnQuitar.Location = New System.Drawing.Point(520, 247)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnQuitar.Size = New System.Drawing.Size(62, 48)
        Me.btnQuitar.TabIndex = 141
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnAgregar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Expand_Arrow_icon
        Me.btnAgregar.Location = New System.Drawing.Point(520, 157)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnAgregar.Size = New System.Drawing.Size(62, 48)
        Me.btnAgregar.TabIndex = 140
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnNuevo.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Cancel_icon
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.Location = New System.Drawing.Point(750, 500)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnNuevo.Size = New System.Drawing.Size(298, 48)
        Me.btnNuevo.TabIndex = 139
        Me.btnNuevo.Text = "Cancelar"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnConfirmar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.icons8_ok
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmar.Location = New System.Drawing.Point(750, 446)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnConfirmar.Size = New System.Drawing.Size(298, 48)
        Me.btnConfirmar.TabIndex = 138
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(466, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 23)
        Me.Label10.TabIndex = 151
        Me.Label10.Text = "Incluir servicios"
        '
        'frmAgregarServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1103, 606)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.dgvServiciosAsignados)
        Me.Controls.Add(Me.dgvServiciosDisponibles)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1119, 645)
        Me.MinimumSize = New System.Drawing.Size(1119, 645)
        Me.Name = "frmAgregarServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar servicios"
        CType(Me.dgvServiciosAsignados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvServiciosDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label1 As Label
    Private WithEvents Label9 As Label
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents dgvServiciosAsignados As DataGridView
    Friend WithEvents dgvServiciosDisponibles As DataGridView
    Friend WithEvents ServicioId As DataGridViewTextBoxColumn
    Friend WithEvents Servicio As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
End Class
