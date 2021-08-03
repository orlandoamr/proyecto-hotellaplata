<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsignarHabitaciones
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
        Me.dgvHabitacionesDisponibles = New System.Windows.Forms.DataGridView()
        Me.dgvHabitacionesAsignadas = New System.Windows.Forms.DataGridView()
        Me.NumeroHabitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoHabitación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvHabitacionesDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHabitacionesAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHabitacionesDisponibles
        '
        Me.dgvHabitacionesDisponibles.AllowUserToAddRows = False
        Me.dgvHabitacionesDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvHabitacionesDisponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvHabitacionesDisponibles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHabitacionesDisponibles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvHabitacionesDisponibles.ColumnHeadersHeight = 35
        Me.dgvHabitacionesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHabitacionesDisponibles.EnableHeadersVisualStyles = False
        Me.dgvHabitacionesDisponibles.Location = New System.Drawing.Point(40, 94)
        Me.dgvHabitacionesDisponibles.Name = "dgvHabitacionesDisponibles"
        Me.dgvHabitacionesDisponibles.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHabitacionesDisponibles.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvHabitacionesDisponibles.RowHeadersWidth = 51
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.dgvHabitacionesDisponibles.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvHabitacionesDisponibles.RowTemplate.Height = 24
        Me.dgvHabitacionesDisponibles.Size = New System.Drawing.Size(530, 455)
        Me.dgvHabitacionesDisponibles.TabIndex = 128
        '
        'dgvHabitacionesAsignadas
        '
        Me.dgvHabitacionesAsignadas.AllowUserToAddRows = False
        Me.dgvHabitacionesAsignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvHabitacionesAsignadas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvHabitacionesAsignadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(151, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHabitacionesAsignadas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvHabitacionesAsignadas.ColumnHeadersHeight = 35
        Me.dgvHabitacionesAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHabitacionesAsignadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumeroHabitacion, Me.CostoHabitación})
        Me.dgvHabitacionesAsignadas.EnableHeadersVisualStyles = False
        Me.dgvHabitacionesAsignadas.Location = New System.Drawing.Point(668, 94)
        Me.dgvHabitacionesAsignadas.Name = "dgvHabitacionesAsignadas"
        Me.dgvHabitacionesAsignadas.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHabitacionesAsignadas.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvHabitacionesAsignadas.RowHeadersWidth = 51
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        Me.dgvHabitacionesAsignadas.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvHabitacionesAsignadas.RowTemplate.Height = 24
        Me.dgvHabitacionesAsignadas.Size = New System.Drawing.Size(394, 280)
        Me.dgvHabitacionesAsignadas.TabIndex = 129
        '
        'NumeroHabitacion
        '
        Me.NumeroHabitacion.HeaderText = "Número de Habitación"
        Me.NumeroHabitacion.Name = "NumeroHabitacion"
        Me.NumeroHabitacion.ReadOnly = True
        Me.NumeroHabitacion.Width = 186
        '
        'CostoHabitación
        '
        Me.CostoHabitación.HeaderText = "Costo de la Habitación"
        Me.CostoHabitación.Name = "CostoHabitación"
        Me.CostoHabitación.ReadOnly = True
        Me.CostoHabitación.Width = 188
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(189, 20)
        Me.Label9.TabIndex = 134
        Me.Label9.Text = "Habitaciones disponibles"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(664, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 20)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Habitaciones asignadas"
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnQuitar.Image = Global.Proyecto_HotelLaPlata.My.Resources.Resources.Expand_Arrow_icon_3_Copy
        Me.btnQuitar.Location = New System.Drawing.Point(585, 243)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnQuitar.Size = New System.Drawing.Size(62, 48)
        Me.btnQuitar.TabIndex = 133
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
        Me.btnAgregar.Location = New System.Drawing.Point(585, 158)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnAgregar.Size = New System.Drawing.Size(62, 48)
        Me.btnAgregar.TabIndex = 132
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
        Me.btnNuevo.Location = New System.Drawing.Point(764, 501)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnNuevo.Size = New System.Drawing.Size(298, 48)
        Me.btnNuevo.TabIndex = 131
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
        Me.btnConfirmar.Location = New System.Drawing.Point(764, 445)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Padding = New System.Windows.Forms.Padding(68, 0, 68, 0)
        Me.btnConfirmar.Size = New System.Drawing.Size(298, 48)
        Me.btnConfirmar.TabIndex = 130
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.22642!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(446, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 20)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Asignar habitaciones"
        '
        'frmAsignarHabitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1103, 606)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.dgvHabitacionesAsignadas)
        Me.Controls.Add(Me.dgvHabitacionesDisponibles)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1119, 645)
        Me.MinimumSize = New System.Drawing.Size(1119, 645)
        Me.Name = "frmAsignarHabitaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignar habitaciones"
        CType(Me.dgvHabitacionesDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHabitacionesAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvHabitacionesDisponibles As DataGridView
    Friend WithEvents dgvHabitacionesAsignadas As DataGridView
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnQuitar As Button
    Private WithEvents Label9 As Label
    Private WithEvents Label1 As Label
    Friend WithEvents NumeroHabitacion As DataGridViewTextBoxColumn
    Friend WithEvents CostoHabitación As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
End Class
